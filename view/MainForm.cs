using progetto_ingegneria_del_software.presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace progetto_ingegneria_del_software.view {
	public partial class MainForm : RadForm {

		#region components presenter properties
		public TableLayoutPanel BinaryComponentsPanel {
			get { return _binaryComponentsPanel; }
		}

		public TableLayoutPanel MultivaluedComponentsPanel {
			get { return _multivaluedComponentsPanel; }
		}
		#endregion

		#region room presenter properties
		public RadDropDownList RoomList {
			get { return _roomList; }
		}

		public PictureBox RoomPicture {
			get { return _roomPicture; }
		}

		public CheckBox VisibilityCheckBox {
			get { return _visibilityCheckBox; }
		}
		#endregion

		#region history presenter properties
		public RadGridView HistoryGrid {
			get { return _historyGrid; }
		}

		public CheckBox TimeFromCheck {
			get { return _timeFromCheck; }
		}

		public CheckBox TimeToCheck {
			get { return _timeToCheck; }
		}

		public CheckBox DateFromCheck {
			get { return _dateFromCheck; }
		}

		public CheckBox DateToCheck {
			get { return _dateToCheck; }
		}

		public RadDateTimePicker DateFromPicker {
			get { return _dateFromPicker; }
		}

		public RadDateTimePicker DateToPicker {
			get { return _dateToPicker; }
		}

		public RadTimePicker TimeFromPicker {
			get { return _timeFromPicker; }
		}

		public RadTimePicker TimeToPicker {
			get { return _timeToPicker; }
		}

		public Button HistoryButton {
			get { return _historyButton; }
		}

		public RadCheckedDropDownList CategoriesCheckList {
			get { return _categoriesCheckList; }
		}

		public RadCheckedDropDownList ComponentsCheckList {
			get { return _componentsCheckList; }
		}

		public RadCheckedDropDownList UsersCheckList {
			get { return _userCheckList; }
		}

		public Label HistoryLabel {
			get { return _historyLabel; }
		}
		#endregion

		#region admin management properties
		public RadMenu AdminMenu {
			get { return _adminMenu; }
		}

		public RadMenuItem InsertUserMenuItem {
			get { return _insertUserMenuItem; }
		}

		public RadMenuItem SelectUserMenuItem {
			get { return _selectUserMenuItem; }
		}

		public RadMenuItem NightModeThresholdMenuItem {
			get { return _nightModeThresholdMenuItem; }
		}

		public RadMenuItem TemperatureThresholdMenuItem {
			get { return _temperatureThresholdMenuItem; }
		}

		public RadMenuItem BrightnessThresholdMenuItem {
			get { return _brightnessThresholdMenuItem; }
		}
		#endregion

		public MainForm ( ) {
			InitializeComponent ( );
		}

	}
}