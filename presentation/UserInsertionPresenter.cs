using progetto_ingegneria_del_software.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using progetto_ingegneria_del_software.view;

namespace progetto_ingegneria_del_software.presentation {

	public delegate void UserInsertion ( );

	class UserInsertionPresenter {

		private UserManagementForm _userManagementForm;

		public event UserInsertion userInsertionEvent;

		public UserInsertionPresenter ( UserManagementForm userManagementForm ) {
			if ( userManagementForm == null )
				throw new ArgumentException ( "Argument userManagementForm is not valid" );

			_userManagementForm = userManagementForm;
			_userManagementForm.AddUserButton.Click += AddUserButtonClick;
			_userManagementForm.ModifyUserButton.Hide ( );
		}

		private void AddUserButtonClick ( object sender , EventArgs e ) {
			string name, username, password;
			List<IRoom> rooms = new List<IRoom> ( );
			name = _userManagementForm.NameTextBox.Text;
			username = _userManagementForm.UsernameTextBox.Text;
			password = _userManagementForm.PasswordTextBox.Text;

			foreach ( RadListDataItem camera in _userManagementForm.RoomsCheckList.CheckedItems )
				rooms.Add ( (IRoom) camera.Value );

			User user = null;
			try {
				user = new User ( name , username , password , rooms );
			} catch ( ArgumentException ) {
				MessageBox.Show ( "ERRORE: campi non validi" );
				return;
			}

			if ( !Home.GetInstance ( ).Users.Contains ( user ) ) {
				Home.GetInstance ( ).Users.Add ( user );
				userInsertionEvent ( );
				MessageBox.Show ( "Inserimento effettuato con successo" );
				_userManagementForm.Close ( );
			} else {
				MessageBox.Show ( "Impossibile inserire utente" );
				return;
			}
		}
	}
}
