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
	public partial class NightModeThresholdForm : RadForm {
		public NightModeThresholdForm ( ) {
			InitializeComponent ( );
		}

		public Button OkButton {
			get { return _okButton; }
		}

		public RadTimePicker From {
			get { return _from; }
		}

		public RadTimePicker To {
			get { return _to; }
		}
	}
}
