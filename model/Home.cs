using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public class Home {
		private static Home _instance;

		private Admin _admin;
		private List<User> _users;
		private List<IRoom> _rooms;
		private User _anonymousUser;

		private Home ( ) {
			_users = new List<User> ( );
			_rooms = new List<IRoom> ( );
			init ( );
		}

		private void init ( ) {
			#region init users
			_rooms.AddRange ( RoomFactory.GetRooms ( ) );

			_admin = new Admin ( "amministratore" , "admin" , "admin" , _rooms );
			_users.Add ( _admin );
			_anonymousUser = new User ( "anonimo" , "anonimo" , "anonimo" , _rooms );

			List<IRoom> ownedRooms = new List<IRoom> ( );

			ownedRooms.Add ( RoomFactory.GetRoomByID ( "camera singola 1" ) );
			_users.Add ( new User ( "figlio" , "son" , "son" , ownedRooms ) );

			ownedRooms = new List<IRoom> ( );
			ownedRooms.Add ( RoomFactory.GetRoomByID ( "camera doppia 1" ) );
			ownedRooms.Add ( RoomFactory.GetRoomByID ( "studio 1" ) );
			_users.Add ( new User ( "madre" , "mum" , "mum" , ownedRooms ) );

			ownedRooms = new List<IRoom> ( );
			ownedRooms.Add ( RoomFactory.GetRoomByID ( "camera doppia 1" ) );
			_users.Add ( new User ( "padre" , "dad" , "dad" , ownedRooms ) );
			#endregion
		}

		public static Home GetInstance ( ) {
			if ( _instance == null )
				_instance = new Home ( );
			return _instance;
		}

		public Admin Admin {
			get {
				return _admin;
			}
		}

		public User AnonymousUser {
			get {
				return _anonymousUser;
			}
		}
		public List<User> Users {
			get {
				return _users;
			}
		}

		public List<IRoom> Rooms {
			get {
				return _rooms;
			}
		}

		public User GetUserByUsername ( string username ) {
			if ( username == null )
				throw new ArgumentException ( "Argument username is not valid" );

			foreach ( User user in _users ) {
				if ( user.Username == username )
					return user;
			}
			return null;
		}

	}
}
