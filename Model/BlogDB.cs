namespace Bootstrap.Model {
    using System;
    using Newtonsoft.Json;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogDB : DbContext {
        public BlogDB()
            : base("name=BlogDB") {
        }

        public virtual DbSet<Durumlar> Durumlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        
        }
    }
}
