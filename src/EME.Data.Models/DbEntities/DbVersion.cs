using System;

namespace EME.Data.Models.DbEntities
{
    public class DbVersion
    {
        public long Version { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}