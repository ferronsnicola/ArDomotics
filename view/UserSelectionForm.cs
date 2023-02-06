using progetto_ingegneria_del_software.model;
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
	public partial class UserSelectionForm : RadForm {

		public UserSelectionForm ( ) {
			InitializeComponent ( );
		}

		public Button DeleteButton {
			get { return _deleteButton; }
		}

		public Button ModifyButton {
			get { return _modifyButton; }
		}

		public ComboBox UsersComboBox {
			get { return _usersComboBox; }
		}

	}
}
