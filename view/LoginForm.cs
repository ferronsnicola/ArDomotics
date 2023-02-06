using progetto_ingegneria_del_software.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace progetto_ingegneria_del_software.view {
	public partial class LoginForm : Telerik.WinControls.UI.RadForm {
		public LoginForm ( ) {
			InitializeComponent ( );
		}

		public string Password {
			get { return _password_tbx.Text; }
		}

		public string Username {
			get { return _username_tbx.Text; }

		}

		public void ResetForm ( ) {
			_username_tbx.Clear ( );
			_password_tbx.Clear ( );
		}

		public Button LoginButton {
			get { return _loginButton; }
		}
		
	}
}
