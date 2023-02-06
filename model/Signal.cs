using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public class Signal {

		private readonly Component _component;
		private readonly DateTime _instant;
		private readonly User _user;
		private readonly int _newStatus;

		public Signal ( Component component , int newStatus , DateTime instant , User user ) {
			if ( component == null )
				throw new ArgumentException ( "Argument component is not valid" );
			if ( instant == null )
				throw new ArgumentException ( "Argument instant is not valid" );
			if ( user == null )
				throw new ArgumentException ( "Argument user is not valid" );
			if ( component is BinaryComponent && (newStatus != 0 && newStatus != 1) )
				throw new ArgumentException ( "Argument newStatus is not valid" );
			else if ( component is MultivaluedComponent && (newStatus > 100 || newStatus < 0) )
				throw new ArgumentException ( "Argument newStatus is not valid" );

			_component = component;
			_instant = instant;
			_newStatus = newStatus;

			_user = user;
		}


		public Component Component {
			get {
				return _component;
			}
		}
		public DateTime Instant {
			get {
				return _instant;
			}
		}
		public User User {
			get {
				return _user;
			}
		}

		public int NewStatus {
			get {
				return _newStatus;
			}
		}

	}
}
