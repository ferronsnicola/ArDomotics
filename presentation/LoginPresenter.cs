using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.presentation {
	class LoginPresenter {
		private readonly LoginForm _loginForm;

		public LoginPresenter ( LoginForm loginForm ) {
			if ( loginForm == null )
				throw new ArgumentException ( "Login Form not found" );
			_loginForm = loginForm;
			_loginForm.LoginButton.Click += LoginCheck;
		}

		private void LoginCheck ( object sender , EventArgs e ) {
			bool logged = false;
			foreach ( User u in Home.GetInstance ( ).Users ) {
				Console.WriteLine ( "login _users2 : " + u.Name + " " + u.Password );
				if ( u.Password == _loginForm.Password && u.Username == _loginForm.Username ) {
					logged = true;
					MainForm mf = new MainForm ( );
					mf.Owner = _loginForm;
					Home.GetInstance ( );
					History.GetInstance ( );
					MainFormPresenter pmf = new MainFormPresenter ( u , mf );
					_loginForm.Hide ( );
					mf.Show ( );
					_loginForm.ResetForm ( );
					break;
				}
			}
			if ( !logged )
				MessageBox.Show ( "ERRORE: Account inesistente" );
		}

	}
}
