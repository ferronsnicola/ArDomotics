using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public class History {

		private List<Signal> _signals;
		private static History _instance;

		private History ( ) {
			_signals = new List<Signal> ( );
		}

		public static History GetInstance ( ) {
			if ( _instance == null )
				_instance = new History ( );
			return _instance;
		}

		public List<Signal> Signals {
			get {
				return _signals;
			}
		}

		public List<Signal> Filter ( List<IFilter> filters ) {
            if (filters == null || filters.Count == 0)
                throw new ArgumentException("Argument filters is not valid");

			List<Signal> result = Signals;
			foreach ( IFilter f in filters ) {
				result = f.Filter ( result );
			}
			return result;
		}

	}
}
