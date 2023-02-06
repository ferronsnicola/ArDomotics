using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.presentation {
	class AdminServicesPresenter {
		private MainForm _mainForm;
		private IComunicator _comunicator;
		public AdminServicesPresenter ( MainForm mainForm , IComunicator comunicator ) {
			if ( mainForm == null )
				throw new ArgumentException ( "Argument MainForm is not valid" );
			if ( comunicator == null )
				throw new ArgumentException ( "Argument comunicator is not valid" );

			_mainForm = mainForm;
			_comunicator = comunicator;

			_mainForm.SelectUserMenuItem.Click += SelectUserClick;
			_mainForm.InsertUserMenuItem.Click += InsertUserClick;
			_mainForm.BrightnessThresholdMenuItem.Click += BrightnessThresholdClick;
			_mainForm.NightModeThresholdMenuItem.Click += NightModeThresholdClick;
			_mainForm.TemperatureThresholdMenuItem.Click += TemperatureThresholdClick;
		}


		private void NightModeThresholdClick ( object sender , EventArgs e ) {
			NightModeThresholdForm nmtf = new NightModeThresholdForm ( );
			NightModeThresholdPresenter nmtp = new NightModeThresholdPresenter ( nmtf , _comunicator );
			nmtf.ShowDialog ( );
		}

		private void TemperatureThresholdClick ( object sender , EventArgs e ) {
			GenericThresholdForm ttf = new GenericThresholdForm ( );
			GenericThresholdPresenter ttp = new GenericThresholdPresenter ( ttf , _comunicator , "temperatura" );
			ttf.ShowDialog ( );
		}

		private void BrightnessThresholdClick ( object sender , EventArgs e ) {
			GenericThresholdForm btf = new GenericThresholdForm ( );
			GenericThresholdPresenter btp = new GenericThresholdPresenter ( btf , _comunicator , "luminosità" );
			btf.ShowDialog ( );
		}


		private void InsertUserClick ( object sender , EventArgs e ) {
			UserManagementForm insertForm = new UserManagementForm ( );
			UserInsertionPresenter uip = new UserInsertionPresenter ( insertForm );
			uip.userInsertionEvent += RefreshUsersCheckList;
			insertForm.ShowDialog ( );
		}

		private void SelectUserClick ( object sender , EventArgs e ) {
			UserSelectionForm usf = new UserSelectionForm ( );
			UserSelectionPresenter usp = new UserSelectionPresenter ( usf );
			usp.userDeleteEvent += RefreshUsersCheckList;
			usf.ShowDialog ( );
		}

		public void RefreshUsersCheckList ( ) {
			List<User> users = new List<User> ( );
			users.AddRange ( Home.GetInstance ( ).Users );
			users.Add ( Home.GetInstance ( ).AnonymousUser );
			_mainForm.UsersCheckList.DataSource = users;
			_mainForm.UsersCheckList.Refresh ( );
		}

	}
}
