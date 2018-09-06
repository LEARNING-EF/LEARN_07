namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext()
		{
		}

		public System.Data.Entity.DbSet<Country> Countries { get; set; }
	}
}
