using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace progetto_ingegneria_del_software.view {
	public partial class GenericThresholdForm : Telerik.WinControls.UI.RadForm {
		public GenericThresholdForm ( ) {
			InitializeComponent ( );
		}

		public Button OkButton {
			get { return _okButton; }
		}

		public TextBox ThreshText {
			get { return _threshText; }
		}

		public Label ThresholdName {
			get { return _thresholdName; }
		}
	}
}
