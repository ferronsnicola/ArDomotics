using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public interface IRoom {
		string Name { get; }
		string Id { get; }
		List<Component> Components { get; }
		Image Image { get; }

		List<BinaryComponent> GetBinaryComponents ( );
		List<MultivaluedComponent> GetMultivaluedComponents ( );

		string ToString ( );
	}
}
