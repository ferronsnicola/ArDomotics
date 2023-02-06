using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;


namespace progetto_ingegneria_del_software.presentation {
	class HistoryPresenter {

		MainForm _mainForm;

		private IFilter[] _filters;
		private RadGridView _historyGrid;

		List<Component> _components = new List<Component>();
		List<Category> _categories = new List<Category>();
		List<User> _users = new List<User>();

		IRoom _room;

		#region constants
		private readonly int COMPONENT = 0;
		private readonly int CATEGORY = 1;
		private readonly int USER = 2;
		private readonly int DATE_FROM = 3;
		private readonly int DATE_TO = 4;
		private readonly int TIME_FROM = 5;
		private readonly int TIME_TO = 6;
		private readonly int ROOM = 7;
		private readonly int MAX_FILTERS = 8;
		#endregion

		public HistoryPresenter ( MainForm mainForm , IRoom room ) {
			if ( mainForm == null )
				throw new ArgumentException ( "Argument mainForm is not valid" );
			if ( room == null )
				throw new ArgumentException ( "Argument room is not valid" );

			_mainForm = mainForm;
			#region EVENTS
			mainForm.CategoriesCheckList.ItemCheckedChanged += CategoriesCheckListChange;
			mainForm.ComponentsCheckList.ItemCheckedChanged += ComponentsCheckListChange;
			mainForm.UsersCheckList.ItemCheckedChanged += UsersCheckListChange;

			mainForm.TimeFromCheck.CheckedChanged += TimeFromChange;
			mainForm.TimeToCheck.CheckedChanged += TimeToChange;
			mainForm.DateFromCheck.CheckedChanged += DateFromChange;
			mainForm.DateToCheck.CheckedChanged += DateToChange;

			mainForm.TimeFromPicker.ValueChanged += TimeFromChange;
			mainForm.TimeToPicker.ValueChanged += TimeToChange;
			mainForm.DateFromPicker.ValueChanged += DateFromChange;
			mainForm.DateToPicker.ValueChanged += DateToChange;

			mainForm.HistoryButton.Click += HistoryButtonClick;
			#endregion
			#region INIT GRID
			_historyGrid = mainForm.HistoryGrid;
			_historyGrid.Hide ( );
			_mainForm.HistoryLabel.Hide ( );
			_historyGrid.Rows.Clear ( );
			#endregion

			_filters = new IFilter [ MAX_FILTERS ];
			_room = room;

			Init ( );
		}

		#region date/time filters (sarebbe bello trovare un modo più carino per questa gestione....)
		private void TimeToChange ( object sender , EventArgs e ) {
			if ( _mainForm.TimeToCheck.Checked )
				_filters [ TIME_TO ] = FilterManager.CreateToTimeFilter ( new TimeSpan ( _mainForm.TimeToPicker.Value.Value.Hour , _mainForm.TimeToPicker.Value.Value.Minute , 0 ) );
			else
				_filters [ TIME_TO ] = null;
		}

		private void TimeFromChange ( object sender , EventArgs e ) {
			if ( _mainForm.TimeFromCheck.Checked )
				_filters [ TIME_FROM ] = FilterManager.CreateFromTimeFilter ( new TimeSpan ( _mainForm.TimeFromPicker.Value.Value.Hour , _mainForm.TimeFromPicker.Value.Value.Minute , 0 ) );
			else
				_filters [ TIME_FROM ] = null;
		}

		private void DateToChange ( object sender , EventArgs e ) {
			if ( _mainForm.DateToCheck.Checked )
				_filters [ DATE_TO ] = FilterManager.CreateToDateFilter ( _mainForm.DateToPicker.Value );
			else
				_filters [ DATE_TO ] = null;
		}

		private void DateFromChange ( object sender , EventArgs e ) {
			if ( _mainForm.DateFromCheck.Checked )
				_filters [ DATE_FROM ] = FilterManager.CreateFromDateFilter ( _mainForm.DateFromPicker.Value );
			else
				_filters [ DATE_FROM ] = null;
		}
		#endregion

		#region combobox filters (anche questi molto simili)
		private void CategoriesCheckListChange ( object sender , EventArgs e ) {
			_categories.Clear ( );
			_mainForm.ComponentsCheckList.Enabled = false;

			foreach ( RadListDataItem item in _mainForm.CategoriesCheckList.CheckedItems )
				_categories.Add ( (Category) item.Value );

			_filters [ CATEGORY ] = FilterManager.CreateCategoriesFilter ( _categories );

			if ( _mainForm.CategoriesCheckList.CheckedItems.Count == 0 ) {
				_mainForm.ComponentsCheckList.Enabled = true;
				_filters [ CATEGORY ] = null;
			}
		}

		private void ComponentsCheckListChange ( object sender , EventArgs e ) {
			_components.Clear ( );
			_mainForm.CategoriesCheckList.Enabled = false;

			foreach ( RadListDataItem item in _mainForm.ComponentsCheckList.CheckedItems ) {
				_components.Add ( (Component) item.Value );
			}

			_filters [ COMPONENT ] = FilterManager.CreateComponentsFilter ( _components );
			if ( _mainForm.ComponentsCheckList.CheckedItems.Count == 0 ) {
				_mainForm.CategoriesCheckList.Enabled = true;
				_filters [ COMPONENT ] = null;
			}
		}

		private void UsersCheckListChange ( object sender , EventArgs e ) {
			_users.Clear ( );
			foreach ( RadListDataItem item in _mainForm.UsersCheckList.CheckedItems ) {
				_users.Add ( (User) item.Value );
			}

			_filters [ USER ] = FilterManager.CreateUsersFilter ( _users );
			if ( _mainForm.UsersCheckList.CheckedItems.Count == 0 )
				_filters [ USER ] = null;
		}
		#endregion

		private void HistoryButtonClick ( object sender , EventArgs e ) {
			List<Signal> result;
			List<IFilter> filters = new List<IFilter> ( );

			_filters [ ROOM ] = FilterManager.CreateRoomFilter ( _room );

			foreach ( IFilter f in _filters ) {
				if ( f != null )
					filters.Add ( f );
			}
			result = History.GetInstance ( ).Filter ( filters );
			_historyGrid.Rows.Clear ( );
			foreach ( Signal s in result ) {
				string newStatus;
				string unity;
				if ( s.Component is BinaryComponent )
					newStatus = s.NewStatus == 0 ? "Off" : "On";
				else {
					unity = s.Component.Name == "temperatura" ? "°" : "%";
					newStatus = s.NewStatus.ToString ( ) + unity;
				}
				_historyGrid.Rows.Add ( s.Component.Id , newStatus , s.User , s.Instant );
			}
			_historyGrid.Show ( );
			_mainForm.HistoryLabel.Show ( );
			_historyGrid.BestFitColumns ( );
		}

		public void Init ( ) {
			_mainForm.ComponentsCheckList.DataSource = _room.Components;
			List<User> users = new List<User> ( );
			users.AddRange ( Home.GetInstance ( ).Users );
			users.Add ( Home.GetInstance ( ).AnonymousUser );
			_mainForm.UsersCheckList.DataSource = users;
			_mainForm.CategoriesCheckList.DataSource = Enum.GetValues ( typeof ( Category ) );
		}

	}
}
