using Droplab_DATA.Entities;
using MySql.Data.Entity;

namespace Droplab_DATA
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DroplabModel : DbContext
    {
        public DroplabModel()
            : base("name=DroplabModel")
        {
        }

        public virtual DbSet<TOS> TOS { get; set; }

    }
}
    