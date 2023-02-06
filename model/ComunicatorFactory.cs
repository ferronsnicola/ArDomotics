using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.model {

	public delegate void notify ( string componentID , int newStatus );

	public static class ComunicatorFactory {

		private static IComunicator _arduinoCoumincator;

		static ComunicatorFactory ( ) {
			_arduinoCoumincator = new ArduinoSerialComunicator ( );
		}

		public static IComunicator GetArduinoComunicator ( ) {
			return _arduinoCoumincator;
		}

		private class ArduinoSerialComunicator : IComunicator {

			private readonly int BAUD_RATE = 9600;
			private readonly string PORT = "COM5";

			private SerialPort _serialPort;
			public event notify ChangeBinaryStatusFromSerial;
			public event notify ChangeMultivaluedStatusFromSerial;

			public ArduinoSerialComunicator ( ) {
				_serialPort = new SerialPort ( PORT , BAUD_RATE );
				_serialPort.DtrEnable = true;
				_serialPort.RtsEnable = true;
				_serialPort.DataReceived += new SerialDataReceivedEventHandler ( DataReceivedHandler );

				try {
					if ( !_serialPort.IsOpen )
						_serialPort.Open ( );
				} catch ( Exception ) {
					MessageBox.Show ( "SerialPort error" );
					Application.Exit ( );
				}
			}


			private void DataReceivedHandler ( object sender , SerialDataReceivedEventArgs e ) {
				string line;
				while ( _serialPort.BytesToRead > 0 ) {
					line = _serialPort.ReadLine ( ).Trim ( );
					string [ ] data = line.Split ( ' ' );

					bool test = false;
					foreach ( IRoom room in Home.GetInstance ( ).Rooms ) {
						foreach ( Component component in room.Components ) {
							if ( data [ 0 ].Trim ( ) == component.Id ) {
								test = true;
								break;
							}
						}
					}

					if ( data.Length == 2 && test ) {
						Component componente = RoomFactory.GetComponentbyComponentID ( data [ 0 ].Trim ( ) );
						if ( componente is BinaryComponent )
							ChangeBinaryStatusFromSerial ( data [ 0 ].Trim ( ) , Int32.Parse ( data [ 1 ].Trim ( ) ) );
						else
							ChangeMultivaluedStatusFromSerial ( data [ 0 ].Trim ( ) , Int32.Parse ( data [ 1 ].Trim ( ) ) );
						Console.WriteLine ( line );
					}
				}
			}

			public void WriteCommand ( string command ) {
				if ( command == null )
					throw new ArgumentException ( "invalid command" );
				_serialPort.WriteLine ( command );
				Console.WriteLine ( command );
			}

		}
	}
}
