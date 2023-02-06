using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public class BinaryComponent : Component {

		private readonly int OFF=0;
		private readonly int ON=1;
		private readonly int SIZE=2;

		private Image[] _images;

		public BinaryComponent ( string name , string id , Category category , int status , Image on , Image off ) : base ( name , id , category , status ) {
			if ( off == null )
				throw new ArgumentException ( "Argument off is not valid" );
			if ( on == null )
				throw new ArgumentException ( "Argument on is not valid" );
			if ( status != OFF && status != ON )
				throw new ArgumentException ( "Argument status is not valid" );

			_images = new Image [ SIZE ];
			_images [ OFF ] = off;
			_images [ ON ] = on;
		}

		public override int Status {
			get {
				return base.Status;
			}

			set {
				if ( value == OFF || value == ON )
					base.Status = value;
				else
					throw new ArgumentException ( "Argument status is not valid" );
			}
		}

		public Image Image {
			get { return _images [ Status ]; }
		}

		public void SwitchStatus ( ) {
			Status = Status == OFF ? ON : OFF;
		}

	}
}
