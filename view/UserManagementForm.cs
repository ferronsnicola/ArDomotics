using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace progetto_ingegneria_del_software.view {
	public partial class UserManagementForm : RadForm {

		public UserManagementForm ( ) {
			InitializeComponent ( );
			_roomsCheckList.DataSource = RoomFactory.GetPrivateRooms ( );
		}

		public TextBox NameTextBox {
			get { return _nameTextBox; }
		}

		public TextBox UsernameTextBox {
			get { return _usernameTextBox; }
		}
		public TextBox PasswordTextBox {
			get { return _passwordTextBox; }
		}

		public RadCheckedDropDownList RoomsCheckList {
			get { return _roomsCheckList; }
		}

		public Button AddUserButton {
			get { return _addUserButton; }
		}

		public Button ModifyUserButton {
			get { return _modifyUserButton; }
		}
	}
}
