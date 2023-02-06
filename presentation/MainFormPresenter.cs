using progetto_ingegneria_del_software.model;
using progetto_ingegneria_del_software.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.presentation {
	class MainFormPresenter {

		private IComunicator _comunicator;

		private User _user;
		private MainForm _mainForm;
		private BinaryComponentsPresenter _bcp;
		private MultivaluedComponentsPresenter _mcp;
		private HistoryPresenter _hp;
		private RoomPresenter _rp;
		private AdminServicesPresenter _asp;

		public MainFormPresenter ( User user , MainForm mainForm ) {
			if ( user == null )
				throw new ArgumentException ( "Argument user is not valid" );
			if ( mainForm == null )
				throw new ArgumentException ( "Argument mainForm is not valid" );

			_user = user;
			_mainForm = mainForm;

			_comunicator = ComunicatorFactory.GetArduinoComunicator ( );


			_mainForm.RoomList.SelectedValueChanged += RoomChange;
			_mainForm.FormClosing += MainFormClosing;

			#region unique historygrid init
			_mainForm.HistoryGrid.Columns.Add ( "Componente" );
			_mainForm.HistoryGrid.Columns.Add ( "Stato" );
			_mainForm.HistoryGrid.Columns.Add ( "Utente" );
			_mainForm.HistoryGrid.Columns.Add ( "Data e Ora" );
			#endregion
			InitPresenters ( );
			#region admin check
			if ( _user is Admin )
				_mainForm.AdminMenu.Visible = true;
			else
				_mainForm.AdminMenu.Visible = false;
			#endregion
		}

		private void MainFormClosing ( object sender , FormClosingEventArgs e ) {
			_mainForm.Owner.Show ( );
		}


		#region gestione cambio camera che si propaga a molti presenter

		private void RoomChange ( object sender , EventArgs e ) {
            if (!(_mainForm.RoomList.SelectedValue is IRoom)) {
                return;
            }

            List<BinaryComponent>  binaryComponents = ((IRoom)_mainForm.RoomList.SelectedValue).GetBinaryComponents();
            List<MultivaluedComponent> multivaluedComponents = ((IRoom)_mainForm.RoomList.SelectedValue).GetMultivaluedComponents();
     
			if ( _bcp != null && _mcp != null && _hp != null ) {
				_bcp.Components = binaryComponents;
				_bcp.Init ( );

				_mcp.Components = multivaluedComponents;
				_mcp.Init ( );

				_hp = new HistoryPresenter ( _mainForm , (IRoom) _mainForm.RoomList.SelectedValue );
			}
		}
		#endregion

		private void InitPresenters ( ) {
			_rp = new RoomPresenter ( _mainForm , _user );

			IRoom selectedRoom = (IRoom) _mainForm.RoomList.SelectedValue;

			_bcp = new BinaryComponentsPresenter ( _mainForm , selectedRoom.GetBinaryComponents ( ) , _user , _comunicator );
			_mcp = new MultivaluedComponentsPresenter ( _mainForm , selectedRoom.GetMultivaluedComponents ( ) , _user , _comunicator );
			_hp = new HistoryPresenter ( _mainForm , selectedRoom );
			_asp = new AdminServicesPresenter ( _mainForm , _comunicator );
		}

	}
}
