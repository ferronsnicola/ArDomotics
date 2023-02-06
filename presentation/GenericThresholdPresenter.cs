using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.presentation {
	class GenericThresholdPresenter {
		private string _command;
		private GenericThresholdForm _gtf;
		private IComunicator _comunicator;

		public GenericThresholdPresenter ( GenericThresholdForm gtf , IComunicator comunicator , string mode ) {
			if ( gtf == null )
				throw new ArgumentException ( "Argument Form is not valid" );
			if ( comunicator == null )
				throw new ArgumentException ( "Argument comunicator is not valid" );

			_gtf = gtf;
			_comunicator = comunicator;
			_gtf.OkButton.Click += OkButtonClick;
			_command = mode + "_thresh";
			_gtf.ThresholdName.Text = "Soglia " + mode + ":";
		}

		private void OkButtonClick ( object sender , EventArgs e ) {
			int newThresh = -1;
			try {
				newThresh = Int32.Parse ( _gtf.ThreshText.Text );
			} catch ( Exception ) {
				MessageBox.Show ( "Inserire un numero nell'apposito campo" , "Parsing error" , MessageBoxButtons.OK );
				return;
			}

			if ( newThresh >= 0 && newThresh <= 100 ) {
				_comunicator.WriteCommand ( _command + " " + newThresh );
				MessageBox.Show ( "Soglia impostata correttamente" );
				_gtf.Close ( );
			} else
				MessageBox.Show ( "Il numero deve essere compreso tra 0 e 100" , "Logic error" , MessageBoxButtons.OK );
		}
	}
}
