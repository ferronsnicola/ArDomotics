using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.presentation {
	class RoomPresenter {

		private MainForm _mainForm;
		private IRoom _room;
		private User _user;

		public RoomPresenter ( MainForm mainForm , User user ) {
			if ( mainForm == null )
				throw new ArgumentException ( "Argument mainForm is not valid" );
			if ( user == null )
				throw new ArgumentException ( "Argument user is not valid" );

			_mainForm = mainForm;
			_user = user;
			_mainForm.RoomList.DataSource = RoomFactory.GetRoomsByUser ( _user );
            _room = (IRoom) _mainForm.RoomList.SelectedValue;

			ConfigureCheckBoxVisibility ( );

			_mainForm.RoomList.SelectedValueChanged += RoomChange;
			_mainForm.VisibilityCheckBox.Click += VisibilityChange;

			_mainForm.RoomPicture.Image = _room.Image;
		}

		private void ConfigureCheckBoxVisibility () {
			if ( _user.Rooms.Contains ( _room ) && RoomFactory.IsRoomPrivate(_room.Id)) {
				bool visibility = RoomFactory.PrivateRoomVisibility ( _room.Id );
				_mainForm.VisibilityCheckBox.Show ( );
				SetVisibility ( visibility );
			} else
				_mainForm.VisibilityCheckBox.Hide ( );
		}

		private void SetVisibility (bool visibility) {
			_mainForm.VisibilityCheckBox.Checked = visibility;
			_mainForm.VisibilityCheckBox.ForeColor = visibility ? Color.Green : Color.Red;
			_mainForm.VisibilityCheckBox.BackColor = Color.Transparent;
		}

		private void VisibilityChange ( object sender , EventArgs e ) {
			RoomFactory.ChangePrivateRoomVisibility ( _room.Id );
			bool visibility = RoomFactory.PrivateRoomVisibility ( _room.Id );
			SetVisibility ( visibility );
		}

		private void RoomChange ( object sender , EventArgs e ) {
            if (!(_mainForm.RoomList.SelectedValue is IRoom)) {
                MessageBox.Show("ERRORE: non è stata selezionata una camera valida.");
                return;
            }

            _room = (IRoom) _mainForm.RoomList.SelectedValue;
			_mainForm.RoomPicture.Image = _room.Image;
			ConfigureCheckBoxVisibility ( );
		}
	}
}
