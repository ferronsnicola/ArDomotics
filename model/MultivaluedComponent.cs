using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {


	public class MultivaluedComponent : Component {

		private readonly bool _editableByUser;

		public MultivaluedComponent ( string name , string id , Category category , int status , bool editableByUser ) : base ( name , id , category , status ) {
			if ( status < 0 || status > 100 )
				throw new ArgumentException ( "Argument status is not valid" );
			_editableByUser = editableByUser;
		}

		public bool EditableByUser {
			get { return _editableByUser; }
		}

		public override int Status {
			get {
				return base.Status;
			}
			set {
				if ( value < 0 || value > 100 )
					throw new ArgumentException ( "Argument status is not valid" );
				base.Status = value;
			}
		}
	}
}
