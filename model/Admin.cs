using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	public class Admin : User {

		public Admin ( string name , string username , string password , List<IRoom> rooms ) : base ( name , username , password , rooms ) { }

	}
}
