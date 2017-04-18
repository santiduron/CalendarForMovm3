namespace NgCalendar
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class MyModel : DbContext
	{
		public MyModel()
			: base("name=MyModel")
		{
		}

		public virtual DbSet<Event> Events { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Event>()
				.Property(e => e.Title)
				.IsUnicode(false);

			modelBuilder.Entity<Event>()
				.Property(e => e.Description)
				.IsUnicode(false);
		}
	}
}
