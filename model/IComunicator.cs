using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public interface IComunicator {

		event notify ChangeBinaryStatusFromSerial;
        event notify ChangeMultivaluedStatusFromSerial;
        void WriteCommand ( string command );
	}
}
