using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.presentation {
	class NightModeThresholdPresenter {
		private readonly string NIGHT_MODE_THRESHOLD_COMMAND = "NIGHTMODE_RANGE";
		private NightModeThresholdForm _nmtf;
		private IComunicator _comunicator;

		public NightModeThresholdPresenter ( NightModeThresholdForm nmtf , IComunicator comunicator ) {
			if ( nmtf == null )
				throw new ArgumentException ( "Argument Form is not valid" );
			if ( comunicator == null )
				throw new ArgumentException ( "Argument comunicator is not valid" );

			_nmtf = nmtf;
			_comunicator = comunicator;
			_nmtf.OkButton.Click += OkButtonClick;
		}

		private void OkButtonClick ( object sender , EventArgs e ) {
			string from = _nmtf.From.Value.Value.Hour + ":" + _nmtf.From.Value.Value.Minute;
			string to = _nmtf.To.Value.Value.Hour + ":" + _nmtf.To.Value.Value.Minute;
			_comunicator.WriteCommand ( NIGHT_MODE_THRESHOLD_COMMAND + " " + from + " " + to );
			MessageBox.Show ( "Soglia impostata correttamente" );
			_nmtf.Close ( );
		}
	}
}
