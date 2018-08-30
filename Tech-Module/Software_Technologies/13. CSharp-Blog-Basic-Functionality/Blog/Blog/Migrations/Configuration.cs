namespace Blog.Migrations
{
    using System.Data.Entity.Migrations;
    
    public sealed class Configuration : DbMigrationsConfiguration<Blog.Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Blog.Models.BlogDbContext context)
        {

        }
    }
}
