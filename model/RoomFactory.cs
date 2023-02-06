using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {


	public static class RoomFactory {
		private static readonly Dictionary<string, IRoom> _rooms = new Dictionary<string, IRoom>();

		static RoomFactory ( ) {
			#region building home
			List<Component> components = new List<Component> ( );

			components.Add ( new BinaryComponent ( "luce" , "luce00" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "nightmode" , "nightmode00" , Category.Ambient , 1 , Properties.Resources.daymode , Properties.Resources.nightmode ) );
			components.Add ( new MultivaluedComponent ( "finestra" , "finestra00" , Category.Mechanical , 0 , true ) );
			_rooms.Add ( "cucina 1" , new PublicRoom ( "cucina" , "cucina 1" , components , Properties.Resources.cucina ) );

			components = new List<Component> ( );

			components.Add ( new BinaryComponent ( "luce" , "luce01" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "lampadina" , "lampadina00" , Category.Electrical , 0 , Properties.Resources.lampadinaOn , Properties.Resources.lampadinaOff ) );
			components.Add ( new BinaryComponent ( "lampadina" , "lampadina01" , Category.Electrical , 0 , Properties.Resources.lampadinaOn , Properties.Resources.lampadinaOff ) );
			components.Add ( new BinaryComponent ( "ventilatore" , "ventilatore00" , Category.HouseholdAppliance , 0 , Properties.Resources.ventilatoreOn , Properties.Resources.ventilatoreOff ) );
			components.Add ( new BinaryComponent ( "nightmode" , "nightmode01" , Category.Ambient , 1 , Properties.Resources.daymode , Properties.Resources.nightmode ) );
			components.Add ( new MultivaluedComponent ( "porta" , "porta00" , Category.Mechanical , 0 , true ) );
			components.Add ( new MultivaluedComponent ( "finestra" , "finestra01" , Category.Mechanical , 0 , true ) );
			components.Add ( new MultivaluedComponent ( "temperatura" , "temperatura00" , Category.Ambient , 0 , false ) );
			components.Add ( new MultivaluedComponent ( "umidita" , "umidita00" , Category.Ambient , 0 , false ) );
			components.Add ( new MultivaluedComponent ( "luminosita" , "luminosita00" , Category.Ambient , 0 , false ) );
			_rooms.Add ( "camera singola 1" , new PrivateRoom ( "camera singola" , "camera singola 1" , components , false , Properties.Resources.cameraSingola ) );

			components = new List<Component> ( );
			components.Add ( new BinaryComponent ( "luce" , "luce02" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "luce" , "luce03" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "nightmode" , "nightmode02" , Category.Ambient , 1 , Properties.Resources.daymode , Properties.Resources.nightmode ) );
			components.Add ( new MultivaluedComponent ( "finestra" , "finestra02" , Category.Mechanical , 0 , true ) );
			components.Add ( new MultivaluedComponent ( "temperatura" , "temperatura01" , Category.Ambient , 0 , false ) );
			components.Add ( new MultivaluedComponent ( "umidita" , "umidita01" , Category.Ambient , 0 , false ) );
			components.Add ( new MultivaluedComponent ( "luminosita" , "luminosita01" , Category.Ambient , 0 , false ) );
			_rooms.Add ( "sala 1" , new PublicRoom ( "sala" , "sala 1" , components , Properties.Resources.sala ) );

			components = new List<Component> ( );
			components.Add ( new BinaryComponent ( "luce" , "luce04" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "nightmode" , "nightmode03" , Category.Ambient , 1 , Properties.Resources.daymode , Properties.Resources.nightmode ) );
			components.Add ( new MultivaluedComponent ( "finestra" , "finestra03" , Category.Mechanical , 0 , true ) );
			_rooms.Add ( "bagno 1" , new PublicRoom ( "bagno" , "bagno 1" , components , Properties.Resources.bagno ) );

			components = new List<Component> ( );
			components.Add ( new BinaryComponent ( "luce" , "luce05" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "lampadina" , "lampadina02" , Category.Electrical , 0 , Properties.Resources.lampadinaOn , Properties.Resources.lampadinaOff ) );
			components.Add ( new BinaryComponent ( "nightmode" , "nightmode04" , Category.Ambient , 1 , Properties.Resources.daymode , Properties.Resources.nightmode ) );
			components.Add ( new MultivaluedComponent ( "porta" , "porta01" , Category.Mechanical , 0 , true ) );
			components.Add ( new MultivaluedComponent ( "finestra" , "finestra04" , Category.Mechanical , 0 , true ) );
			components.Add ( new MultivaluedComponent ( "temperatura" , "temperatura02" , Category.Ambient , 0 , false ) );
			components.Add ( new MultivaluedComponent ( "umidita" , "umidita02" , Category.Ambient , 0 , false ) );
			_rooms.Add ( "camera doppia 1" , new PrivateRoom ( "camera doppia" , "camera doppia 1" , components , false , Properties.Resources.cameraDoppia ) );

			components = new List<Component> ( );
			components.Add ( new BinaryComponent ( "luce" , "luce06" , Category.Electrical , 0 , Properties.Resources.luceOn , Properties.Resources.luceOff ) );
			components.Add ( new BinaryComponent ( "lampadina" , "lampadina03" , Category.Electrical , 0 , Properties.Resources.lampadinaOn , Properties.Resources.lampadinaOff ) );
			components.Add ( new BinaryComponent ( "ventilatore" , "ventilatore01" , Category.Electrical , 0 , Properties.Resources.ventilatoreOn , Properties.Resources.ventilatoreOff ) );
			components.Add ( new BinaryComponent ( "nightmode" , "nightmode05" , Category.Ambient , 1 , Properties.Resources.daymode , Properties.Resources.nightmode ) );
			components.Add ( new MultivaluedComponent ( "finestra" , "finestra05" , Category.Mechanical , 0 , true ) );
			components.Add ( new MultivaluedComponent ( "luminosita" , "luminosita02" , Category.Ambient , 0 , false ) );
			_rooms.Add ( "studio 1" , new PrivateRoom ( "studio" , "studio 1" , components , true , Properties.Resources.studio ) );

			#endregion
		}

		public static IRoom GetRoomByID ( string id ) {
			if ( id == null || id.Length == 0 )
				throw new ArgumentException ( "Argument id is not valid" );

			if ( _rooms.Keys.Contains ( id ) )
				return _rooms [ id ];
			else
				return null;
		}

		public static List<IRoom> GetPrivateRooms ( ) {
			List<IRoom> result = new List<IRoom> ( );
			foreach ( IRoom room in _rooms.Values ) {
				if ( room is PrivateRoom )
					result.Add ( room );
			}
			return result;
		}

		public static List<IRoom> GetRooms ( ) {
			return _rooms.Values.ToList ( );
		}

		public static List<IRoom> GetRoomsByUser ( User user ) {
			if ( user == null || !Home.GetInstance ( ).Users.Contains ( user ) )
				throw new ArgumentException ( "Argument user is not valid" );

			List<IRoom> result = new List<IRoom> ( );
			result.AddRange ( user.Rooms );

			foreach ( IRoom ir in _rooms.Values ) {
				if ( ir is PrivateRoom ) {
					PrivateRoom r = (PrivateRoom) ir;
					if ( !r.Visibility )
						continue;
				}
				if ( !result.Contains ( ir ) )
					result.Add ( ir );
			}
			return result;
		}

		public static bool PrivateRoomVisibility ( string roomID ) {
			IRoom room = RoomFactory.GetRoomByID ( roomID );
			if ( room == null || !(room is PrivateRoom) )
				throw new ArgumentException ( "Argument roomID is not valid" );

			PrivateRoom privateRoom = (PrivateRoom) room;
			return privateRoom.Visibility;
		}

		public static bool IsRoomPrivate ( string roomID ) {
			IRoom room = RoomFactory.GetRoomByID ( roomID );
			if ( room == null )
				throw new ArgumentException ( "Argument roomID is not valid" );

			return room is PrivateRoom;
		}
		public static void ChangePrivateRoomVisibility ( string roomID ) {
			IRoom room = RoomFactory.GetRoomByID ( roomID );
			if ( room == null || !(room is PrivateRoom) )
				throw new ArgumentException ( "Argument roomID is not valid" );

			PrivateRoom privateRoom = (PrivateRoom) room;
			privateRoom.Visibility = !privateRoom.Visibility;
		}

		public static void ChangeComponentStatus ( string componentID , int newStatus ) {
			if ( RoomFactory.GetComponentbyComponentID ( componentID ) == null )
				throw new ArgumentException ( "Argument componentID is not valid" );

			Component component = GetComponentbyComponentID ( componentID );
			component.Status = newStatus;
		}

		public static Component GetComponentbyComponentID ( string componentID ) {
			if ( componentID == null || componentID.Length == 0 )
				throw new ArgumentException ( "Argument componentID is not valid" );

			foreach ( IRoom room in _rooms.Values ) {
				foreach ( Component component in room.Components ) {
					if ( component.Id == componentID )
						return component;
				}
			}

			return null;
		}

		private class PublicRoom : IRoom {

			private readonly string _name;
			private readonly string _id;
			private readonly List<Component> _components;
			private readonly Image _image;
			public PublicRoom ( string name , string id , List<Component> components , Image image ) {
				if ( name == null || name.Length == 0 )
					throw new ArgumentException ( "Argument name is not valid" );
				if ( id == null || id.Length == 0 || RoomFactory.GetRoomByID ( id ) != null )
					throw new ArgumentException ( "Argument id is not valid" );
				if ( components == null || components.Count == 0 )
					throw new ArgumentException ( "Argument components is not valid" );
				if ( image == null )
					throw new ArgumentException ( "Argument image is not valid" );

				_name = name;
				_id = id;
				_components = components;
				_image = image;
			}

			#region properties

			Image IRoom.Image {
				get {
					return _image;
				}
			}

			List<Component> IRoom.Components {
				get {
					return _components;
				}
			}

			string IRoom.Id {
				get {
					return _id;
				}
			}

			string IRoom.Name {
				get {
					return _name;
				}
			}

			public List<BinaryComponent> GetBinaryComponents ( ) {
				List<BinaryComponent> result = new List<BinaryComponent> ( );
				foreach ( Component c in _components ) {
					if ( c is BinaryComponent )
						result.Add ( (BinaryComponent) c );
				}
				return result;
			}

			public List<MultivaluedComponent> GetMultivaluedComponents ( ) {
				List<MultivaluedComponent> result = new List<MultivaluedComponent> ( );
				foreach ( Component c in _components ) {
					if ( c is MultivaluedComponent )
						result.Add ( (MultivaluedComponent) c );
				}
				return result;
			}

			public override string ToString ( ) {
				return _id;
			}
			#endregion
		}

		private class PrivateRoom : IRoom {
			private readonly string _name;
			private readonly string _id;
			private readonly List<Component> _components;
			private bool _visibility;
			private readonly Image _image;

			public PrivateRoom ( string name , string id , List<Component> components , bool visibility , Image image ) {
				if ( name == null || name.Length == 0 )
					throw new ArgumentException ( "Argument name is not valid" );
				if ( id == null || id.Length == 0 || RoomFactory.GetRoomByID ( id ) != null )
					throw new ArgumentException ( "Argument id is not valid" );
				if ( components == null || components.Count == 0 )
					throw new ArgumentException ( "Argument components is not valid" );
				if ( image == null )
					throw new ArgumentException ( "Argument image is not valid" );

				_name = name;
				_id = id;
				_components = components;
				_visibility = visibility;
				_image = image;
			}

			#region properties

			Image IRoom.Image {
				get {
					return _image;
				}
			}

			List<Component> IRoom.Components {
				get {
					return _components;
				}
			}

			string IRoom.Id {
				get {
					return _id;
				}
			}

			string IRoom.Name {
				get {
					return _name;
				}
			}

			public bool Visibility {
				get {
					return _visibility;
				}
				set {
					_visibility = value;
				}
			}

			public List<BinaryComponent> GetBinaryComponents ( ) {
				List<BinaryComponent> result = new List<BinaryComponent> ( );
				foreach ( Component c in _components ) {
					if ( c is BinaryComponent )
						result.Add ( (BinaryComponent) c );
				}
				return result;
			}

			public List<MultivaluedComponent> GetMultivaluedComponents ( ) {
				List<MultivaluedComponent> result = new List<MultivaluedComponent> ( );
				foreach ( Component c in _components ) {
					if ( c is MultivaluedComponent )
						result.Add ( (MultivaluedComponent) c );
				}
				return result;
			}

			public override string ToString ( ) {
				return _id;
			}
			#endregion

		}
	}
}
