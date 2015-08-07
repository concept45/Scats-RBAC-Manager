///--------------------------------------------------------------------
///--------------- Copyright © 2013-2014 by Daniel Otto ---------------
///--------------------------------------------------------------------


namespace RBACManager
{
	/// @brief Represets a permission from the database.
	public class Permission
	{
		/// @brief Constructor
		/// @param id The identifier
		/// @param name The name
		/// @param granted True if granted
		public Permission(int id, string name, bool granted)
		{
			this.Id = id;
			this.Name = name;
			this.Granted = granted;
		}

		/// @brief The permissions identifier.
		public int Id;
		/// @brief The permissions name.
		public string Name;
		/// @brief True if the permission is granted.
		public bool Granted;
	}
}
