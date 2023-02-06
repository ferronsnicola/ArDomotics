using progetto_ingegneria_del_software.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ingegneria_del_software.model {


	public abstract class Component {

		private string _name;
		private string _id;
		private Category _category;
		private int _status;


		public Component ( string name , string id , Category category , int status ) {
			if ( name == null || name.Length == 0 )
				throw new ArgumentException ( "argument name is not valid" );
			if ( id == null || id.Length == 0 || RoomFactory.GetComponentbyComponentID ( id ) != null )
				throw new ArgumentException ( "argument id is not valid" );

			_name = name;
			_id = id;
			_category = category;
			_status = status;
		}

		public virtual int Status {
			get {
				return _status;
			}
			set {
				_status = value;
			}
		}
		public string Name {
			get {
				return _name;
			}
			set {
				if ( value == null || value.Length == 0 )
					throw new ArgumentException ( "argument name is not valid" );
				_name = value;
			}
		}
		public string Id {
			get {
				return _id;
			}
			set {
				if ( value == null || value.Length == 0 )
					throw new ArgumentException ( "argument id is not valid" );
				_id = value;
			}
		}
		public Category Category {
			get {
				return _category;
			}
			set {
				_category = value;
			}
		}

		public override string ToString ( ) {
			return Id;
		}

		public string ToSerial ( ) {
			return Id + " " + Status;
		}

	}
}
