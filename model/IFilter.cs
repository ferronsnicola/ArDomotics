using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public interface IFilter {
		List<Signal> Filter ( List<Signal> allSignals );
	}
}
