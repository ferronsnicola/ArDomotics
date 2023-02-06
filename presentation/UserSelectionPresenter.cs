using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.presentation {

	public delegate void UserDelete ( );

	class UserSelectionPresenter {

		UserSelectionForm _userSelectionForm;
		public event UserDelete userDeleteEvent;
		List <User> _users;

		public UserSelectionPresenter ( UserSelectionForm userSelectionForm ) {
			if ( userSelectionForm == null )
				throw new ArgumentException ( "Argument userSelectionForm is not valid" );

			_userSelectionForm = userSelectionForm;
			_users = new List<User> ( );
			_users.AddRange ( Home.GetInstance ( ).Users );
			_users.Remove ( Home.GetInstance ( ).Admin );
			_userSelectionForm.UsersComboBox.DataSource = _users;
			_userSelectionForm.DeleteButton.Click += DeleteClick;
			_userSelectionForm.ModifyButton.Click += ModifyClick;
			userDeleteEvent += RefreshUsersComboBox;
		}

		private void ModifyClick ( object sender , EventArgs e ) {
			UserManagementForm umf = new UserManagementForm ( );

			User user = (User) _userSelectionForm.UsersComboBox.SelectedItem;
			if ( !Home.GetInstance ( ).Users.Contains ( user ) ) {
				MessageBox.Show ( "ERRORE: utente non valido" );
				return;
			}
			UserModifyPresenter ump = new UserModifyPresenter ( umf , user );
			ump.userModifyEvent += RefreshUsersComboBox;
			umf.ShowDialog ( );
		}

		private void DeleteClick ( object sender , EventArgs e ) {
			User selectedUser = (User) _userSelectionForm.UsersComboBox.SelectedItem;
			if ( selectedUser is Admin ) {
				System.Windows.Forms.MessageBox.Show ( "Impossibile eliminare amministratore" );
			} else {
				Home.GetInstance ( ).Users.Remove ( selectedUser );
				userDeleteEvent ( );
				System.Windows.Forms.MessageBox.Show ( "Eliminazione effettuata con successo" );
			}
		}

		private void RefreshUsersComboBox ( ) {
			_userSelectionForm.UsersComboBox.DataSource = null;
			_users = new List<User> ( );
			_users.AddRange ( Home.GetInstance ( ).Users );
			_users.Remove ( Home.GetInstance ( ).Admin );
			_userSelectionForm.UsersComboBox.DataSource = _users;
		}
	}
}
