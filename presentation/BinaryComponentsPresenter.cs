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

	public class BinaryComponentsPresenter {

		private readonly int ON=1;
		private readonly int OFF=0;

		private MainForm _mainForm;
		private IComunicator _comunicator;
		private User _user;
		private List<BinaryComponent> _components;
		private TableLayoutPanel _panel;
		private List<Tuple<PictureBox, BinaryComponent>> _imagesMap;
		private Dictionary<Label, PictureBox> _labelsMap;

		public BinaryComponentsPresenter ( MainForm mainForm , List<BinaryComponent> components , User user , IComunicator comunicator ) {

			if ( mainForm == null )
				throw new ArgumentException ( "Argument mainForm is not valid" );
			if ( components == null || components.Count == 0 )
				throw new ArgumentException ( "Argument components is not valid" );
			if ( user == null )
				throw new ArgumentException ( "Argumentuser is not valid" );
			if ( comunicator == null )
				throw new ArgumentException ( "comunicastor is not valid" );

			_mainForm = mainForm;
			_components = components;
			_user = user;
			_panel = _mainForm.BinaryComponentsPanel;
			_panel.Controls.Clear ( );
			_comunicator = comunicator;
			_imagesMap = new List<Tuple<PictureBox , BinaryComponent>> ( );
			_labelsMap = new Dictionary<Label , PictureBox> ( );
			_comunicator.ChangeBinaryStatusFromSerial += ComponentStatusChangeFromSerial;
			Init ( );
		}

		private void ComponentStatusChangeFromSerial ( string componentID , int newStatus ) {
			if ( componentID == null || componentID.Length == 0 || RoomFactory.GetComponentbyComponentID ( componentID ) == null )
				throw new ArgumentException ( "Argument compontentID is not valid" );
			if ( newStatus != ON && newStatus != OFF )
				throw new ArgumentException ( "Argument newStatus is not valid" );

			BinaryComponent component = (BinaryComponent) RoomFactory.GetComponentbyComponentID ( componentID );
			HandlerStatusChanging ( componentID , newStatus , Home.GetInstance ( ).AnonymousUser , component );
		}

		private void HandlerStatusChanging ( string componentID , int status , User user , BinaryComponent component ) {
			RoomFactory.ChangeComponentStatus ( componentID , status );
			History.GetInstance ( ).Signals.Add ( new Signal ( component , component.Status , DateTime.Now , user ) );
			ChangeImage ( component );
		}

		public void ChangeImage ( BinaryComponent binaryComponent ) {
			if ( binaryComponent == null )
				throw new ArgumentException ( "Argument binaryComponent is not valid" );

			for ( int i = 0 ; i < _imagesMap.Count ; i++ ) {
				if ( _imagesMap [ i ].Item2.Equals ( binaryComponent ) ) {
					_imagesMap [ i ].Item1.Image = binaryComponent.Image;
				}
			}
		}

		public List<BinaryComponent> Components {
			get { return _components; }
			set { _components = value; }
		}

		public void Init ( ) {
			_imagesMap.Clear ( );
			_panel.Controls.Clear ( );
			foreach ( BinaryComponent bc in _components ) {

				PictureBox pictureBox = new PictureBox {
					Image = bc.Image ,
					SizeMode = PictureBoxSizeMode.Zoom
				};

				pictureBox.Dock = DockStyle.Fill;
				pictureBox.Click += PictureBoxClick;

				Label pictureBoxLabel = new Label ( );
				pictureBoxLabel.Text = bc.Id;
				pictureBoxLabel.ForeColor = Color.CornflowerBlue;
				pictureBoxLabel.BackColor = Color.Transparent;
				pictureBoxLabel.Click += PictureBoxLabelClick;

				pictureBox.Controls.Add ( pictureBoxLabel );

				_imagesMap.Add ( Tuple.Create ( pictureBox , bc ) );
				_labelsMap.Add ( pictureBoxLabel , pictureBox );
				_panel.Controls.Add ( pictureBox );
			}
		}

		private void Handler ( PictureBox pictureBox ) {
			for ( int i = 0 ; i < _imagesMap.Count ; i++ ) {
				if ( _imagesMap [ i ].Item1.Equals ( pictureBox ) ) {
					_imagesMap [ i ].Item2.SwitchStatus ( );

					BinaryComponent component = (BinaryComponent) RoomFactory.GetComponentbyComponentID ( _imagesMap [ i ].Item2.Id );
					HandlerStatusChanging ( _imagesMap [ i ].Item2.Id , _imagesMap [ i ].Item2.Status , _user , component );
					_comunicator.WriteCommand ( component.ToSerial ( ) );
					break;
				}
			}
		}

		private void PictureBoxClick ( object sender , EventArgs e ) {
			PictureBox pictureBox = (PictureBox) sender;
			Handler ( pictureBox );
		}

		private void PictureBoxLabelClick ( object sender , EventArgs e ) {
			Handler ( _labelsMap [ (Label) sender ] );
		}
	}
}
