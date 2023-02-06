using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public class User {

		private string _name;
		private string _username;
		private string _password;
		private List<IRoom> _rooms;

		public User ( string name , string username , string password , List<IRoom> rooms ) {

			if ( name == null || name.Length == 0 )
				throw new ArgumentException ( "Argument name is not valid" );

			if ( username == null || username.Length == 0 )
				throw new ArgumentException ( "Argument id is not valid" );

			if ( password == null || password.Length == 0 )
				throw new ArgumentException ( "Argument password is not valid" );

			if ( rooms == null || rooms.Count == 0 )
				throw new ArgumentException ( "Argument rooms is not valid" );

			_name = name;
			_username = username;
			_password = password;
			_rooms = rooms;
		}

		public string Name {
			get {
				return _name;
			}
			set {
				if ( value == null || value.Length == 0 )
					throw new ArgumentException ( "Argument name is not valid" );
				_name = value;
			}
		}
		public string Username {
			get {
				return _username;
			}
			set {
				if ( value == null || value.Length == 0 || (_username != value && Home.GetInstance ( ).GetUserByUsername ( value ) != null) )
					throw new ArgumentException ( "Argument username is not valid" );
				_username = value;
			}
		}
		public string Password {
			get {
				return _password;
			}
			set {
				if ( value == null || value.Length == 0 )
					throw new ArgumentException ( "Argument password is not valid" );
				_password = value;
			}
		}
		public List<IRoom> Rooms {
			get {
				return _rooms;
			}
			set {
				if ( value == null || value.Count == 0 )
					throw new ArgumentException ( "Argument rooms is not valid" );
				_rooms = value;
			}
		}

		override public string ToString ( ) {
			return _username;
		}

		public override bool Equals ( Object obj ) {
			if ( obj is User ) {
				User other = (User) obj;
				if ( other.Username == _username )
					return true;
				else
					return false;
			} else
				return false;
		}

		public override int GetHashCode ( ) {
			int prime = 31;
			int result = 1;
			result = prime * result + ((_username == null) ? 0 : _username.GetHashCode ( ));
			return result;
		}

	}
}
