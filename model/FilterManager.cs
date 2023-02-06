using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ingegneria_del_software.model {
	static class FilterManager {

		#region Metodi di accesso ai filtri
		public static IFilter CreateUsersFilter ( List<User> users ) {
			if ( users == null )
				throw new ArgumentException ( "Argument users is not valid" );
			return new UserFilter ( users );
		}

		public static IFilter CreateComponentsFilter ( List<Component> components ) {
			if ( components == null )
				throw new ArgumentException ( "Argument components is not valid" );
			return new ComponentsFilter ( components );
		}

		public static IFilter CreateRoomFilter ( IRoom room ) {
			if ( room == null )
				throw new ArgumentException ( "Argument room is not valid" );
			return new RoomFilter ( room );
		}

		public static IFilter CreateCategoriesFilter ( List<Category> categories ) {
			if ( categories == null )
				throw new ArgumentException ( "Argument categories is not valid" );
			return new CategoriesFilter ( categories );
		}

		public static IFilter CreateFromTimeFilter ( TimeSpan from ) {
			if ( from == null )
				throw new ArgumentException ( "Argument from is not valid" );
			return new FromTimeFilter ( from );
		}

		public static IFilter CreateToTimeFilter ( TimeSpan to ) {
			if ( to == null )
				throw new ArgumentException ( "Argument to is not valid" );
			return new ToTimeFilter ( to );
		}


		public static IFilter CreateFromDateFilter ( DateTime from ) {
			if ( from == null )
				throw new ArgumentException ( "Argument from is not valid" );
			return new FromDateFilter ( from );
		}

		public static IFilter CreateToDateFilter ( DateTime to ) {
			if ( to == null )
				throw new ArgumentException ( "Argument to is not valid" );
			return new ToDateFilter ( to );
		}
		#endregion


		#region Implementazioni di Filtro
		private class UserFilter : IFilter {
			private List<User> _users;

			public UserFilter ( List<User> users ) {
				if ( users == null )
					throw new ArgumentException ( "Argument users is not valid" );
				_users = users;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					if ( _users.Contains ( signal.User ) )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class ComponentsFilter : IFilter {
			private List<Component> _components;

			public ComponentsFilter ( List<Component> components ) {
				if ( components == null )
					throw new ArgumentException ( "Argument components is not valid" );
				_components = components;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					if ( _components.Contains ( signal.Component ) )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class CategoriesFilter : IFilter {
			private List<Category> _categories;

			public CategoriesFilter ( List<Category> categories ) {
				if ( categories == null )
					throw new ArgumentException ( "Argument categories is not valid" );
				_categories = categories;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					if ( _categories.Contains ( signal.Component.Category ) )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class ToTimeFilter : IFilter {

			private TimeSpan _to;

			public ToTimeFilter ( TimeSpan to ) {
				if ( to == null )
					throw new ArgumentException ( "argument to is not valid" );
				_to = to;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					TimeSpan current = new TimeSpan ( signal.Instant.Hour , signal.Instant.Minute , 0 );
					if ( current <= _to )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class FromTimeFilter : IFilter {

			private TimeSpan _from;

			public FromTimeFilter ( TimeSpan from ) {
				if ( from == null )
					throw new ArgumentException ( "Argument from is not valid" );
				_from = from;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					TimeSpan current = new TimeSpan ( signal.Instant.Hour , signal.Instant.Minute , 0 );
					if ( _from <= current )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class FromDateFilter : IFilter {

			private DateTime _from;

			public FromDateFilter ( DateTime from ) {
				if ( from == null )
					throw new ArgumentException ( "Argument from is not valid" );
				_from = from;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					DateTime current = new DateTime ( signal.Instant.Year , signal.Instant.Month , signal.Instant.Day );
					if ( _from <= current )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class ToDateFilter : IFilter {
			private DateTime _to;

			public ToDateFilter ( DateTime to ) {
				if ( to == null )
					throw new ArgumentException ( "Argument to is not valid" );
				_to = to;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					DateTime current = new DateTime ( signal.Instant.Year , signal.Instant.Month , signal.Instant.Day );
					if ( current <= _to )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		private class RoomFilter : IFilter {

			private IRoom _room;

			public RoomFilter ( IRoom room ) {
				if ( room == null )
					throw new ArgumentException ( "Argument room is not valid" );
				_room = room;
			}

			public List<Signal> Filter ( List<Signal> allSignals ) {
				if ( allSignals == null )
					throw new ArgumentException ( "Argument allSignals is not valid" );

				List<Signal> filtered = new List<Signal> ( );

				foreach ( Signal signal in allSignals ) {
					if ( _room.Components.Contains ( signal.Component ) )
						filtered.Add ( signal );
				}
				return filtered;
			}
		}

		#endregion
	}
}
