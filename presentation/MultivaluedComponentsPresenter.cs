using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;


namespace progetto_ingegneria_del_software.presentation {
	class MultivaluedComponentsPresenter {

		private MainForm _mainForm;
		private IComunicator _comunicator;
		private TableLayoutPanel _panel;
		private List<MultivaluedComponent> _components;
		private Dictionary<MultivaluedComponent,TrackBar> _trackBars;

		private User _user;

		public MultivaluedComponentsPresenter ( MainForm mainForm , List<MultivaluedComponent> components , User user , IComunicator comunicator ) {
			if ( mainForm == null )
				throw new ArgumentException ( "Argument mainForm is not valid" );
			if ( components == null || components.Count == 0 )
				throw new ArgumentException ( "Argument components is not valid" );
			if ( user == null )
				throw new ArgumentException ( "Argument user is not valid" );
			if ( comunicator == null )
				throw new ArgumentException ( "Argument comunicator is not valid" );

			_mainForm = mainForm;
			_panel = _mainForm.MultivaluedComponentsPanel;
			_panel.Controls.Clear ( );
			_components = components;
			_user = user;
			_comunicator = comunicator;
			_trackBars = new Dictionary<MultivaluedComponent , TrackBar> ( );
			_comunicator.ChangeMultivaluedStatusFromSerial += ComponentStatusChangeFromSerial;

			Init ( );
			Form.CheckForIllegalCrossThreadCalls = false;
		}

		private void ComponentStatusChangeFromSerial ( string componentID , int newStatus ) {
			if ( componentID == null || componentID.Length == 0 || RoomFactory.GetComponentbyComponentID ( componentID ) == null )
				throw new ArgumentException ( "Argument componentID is not valid" );
			if ( newStatus > 100 || newStatus < 0 )
				throw new ArgumentException ( "Argument newStatus is not valid" );

			MultivaluedComponent component = (MultivaluedComponent) RoomFactory.GetComponentbyComponentID ( componentID );
			HandlerStatusChanging ( componentID , newStatus , Home.GetInstance ( ).AnonymousUser , component );
		}

		private void TrackBarValueChange ( object sender , MouseEventArgs e ) {
			TrackBar tb = (TrackBar) sender;

			foreach ( MultivaluedComponent c in _components ) {
				if ( _trackBars [ c ].Equals ( tb ) ) {
					MultivaluedComponent component = (MultivaluedComponent) RoomFactory.GetComponentbyComponentID ( c.Id );
					HandlerStatusChanging ( c.Id , tb.Value , _user , component );
					_comunicator.WriteCommand ( component.ToSerial ( ) );
					break;
				}
			}
		}

		private void HandlerStatusChanging ( string componentID , int status , User user , MultivaluedComponent component ) {
			RoomFactory.ChangeComponentStatus ( componentID , status );
			History.GetInstance ( ).Signals.Add ( new Signal ( component , component.Status , DateTime.Now , user ) );
			ComponentValueChange ( component );
		}

		public List<MultivaluedComponent> Components {
			get { return _components; }
			set { _components = value; }
		}

		public void Init ( ) {
			_panel.Controls.Clear ( );
			_trackBars.Clear ( );
			foreach ( MultivaluedComponent c in _components ) {

				#region init trackbar
				TrackBar tb = new TrackBar ( );
				tb.Maximum = 100;
				tb.TickFrequency = 25;
				tb.TickStyle = TickStyle.None;
				tb.AutoSize = true;
				tb.Dock = DockStyle.Fill;
				tb.Cursor = Cursors.Hand;
				tb.Value = c.Status;
				_trackBars.Add ( c , tb );

				#endregion
				#region init layout
				TableLayoutPanel t = new TableLayoutPanel ( );
				t.RowCount = 2;
				t.ColumnCount = 1;
				t.Dock = DockStyle.Fill;
				#endregion
				#region lable
				Label l = new Label ( );
				l.Text = c.Id;
				l.Dock = DockStyle.Fill;
				t.ForeColor = System.Drawing.Color.CornflowerBlue;
				#endregion
				#region add
				t.Controls.Add ( l );
				//t.Controls.Add ( rtb );
				t.Controls.Add ( tb );
				_panel.Controls.Add ( t );
				#endregion

				if ( c.EditableByUser )
					_trackBars [ c ].MouseUp += TrackBarValueChange;
				else
					_trackBars [ c ].Enabled = false;
			}
		}

		private void ComponentValueChange ( MultivaluedComponent multivaluedComponent ) {
			if ( multivaluedComponent == null )
				throw new ArgumentException ( "Argument multivaluedComponent is not valid" );

			if ( _trackBars.Keys.Contains ( multivaluedComponent ) )
				_trackBars [ multivaluedComponent ].Value = multivaluedComponent.Status;
		}
	}
}
