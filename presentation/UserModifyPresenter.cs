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

	public delegate void UserModify ( );

	class UserModifyPresenter {

		private UserManagementForm _userManagementForm;
		private User _user;

		public event UserModify userModifyEvent;

		public UserModifyPresenter ( UserManagementForm userManagementForm , User user ) {
			if ( userManagementForm == null )
				throw new ArgumentException ( "Argument userManagementForm is not valid" );
			if ( user == null )
				throw new ArgumentException ( "Argument user is not valid" );

			_userManagementForm = userManagementForm;
			_userManagementForm.ModifyUserButton.Click += ModifyUserButtonClick;
			_userManagementForm.AddUserButton.Hide ( );
			_user = user;
		}

		private void ModifyUserButtonClick ( object sender , EventArgs e ) {
			List<IRoom> rooms = new List<IRoom> ( );
			string name = _userManagementForm.NameTextBox.Text;
			string username = _userManagementForm.UsernameTextBox.Text;
			string password = _userManagementForm.PasswordTextBox.Text;

			foreach ( RadListDataItem camera in _userManagementForm.RoomsCheckList.CheckedItems )
				rooms.Add ( (IRoom) camera.Value );

			if ( !CheckNewUserFields ( name , username , password , rooms ) ) {
				MessageBox.Show ( "ERRORE: Campi di modifica utente non compilati correttamente" );
				return;
			}

			User user = Home.GetInstance ( ).GetUserByUsername ( _user.Username );
			if ( user == null ) {
				MessageBox.Show ( "ERRORE: utente non valido" );
				return;
			}

			user.Username = username;
			user.Name = name;
			user.Password = password;
			user.Rooms = rooms;

			userModifyEvent ( );
			MessageBox.Show ( "Modifica effettuata con successo" );
			_userManagementForm.Close ( );
		}

		private bool CheckNewUserFields ( string name , string username , string password , List<IRoom> rooms ) {
			bool result = true;

			if ( name == null || name.Length == 0 )
				result = false;

			if ( !result || username == null || username.Length == 0 ||
				(username != _user.Username && Home.GetInstance ( ).GetUserByUsername ( username ) != null) )
				result = false;

			if ( !result || password == null || password.Length == 0 )
				result = false;

			if ( !result || rooms == null || rooms.Count == 0 )
				result = false;

			return result;
		}

	}
}
