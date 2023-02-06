using System;
using System.Linq;
using System.Windows.Forms;
using progetto_ingegneria_del_software.view;
using progetto_ingegneria_del_software.presentation;

namespace progetto_ingegneria_del_software.program {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main ( ) {
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault ( false );
			try {
				LoginForm lf = new LoginForm ( );
				LoginPresenter pl = new LoginPresenter ( lf );
				Application.Run ( lf );
			} catch ( Exception e ) {
				MessageBox.Show ( "E' stata generata un'eccezione fatale:\n" + e.Message + "\nl'applicazione verrà chiusa!" );
				Application.Exit ( );
			}
		}
	}
}