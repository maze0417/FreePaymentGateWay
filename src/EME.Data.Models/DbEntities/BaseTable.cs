using System;

namespace EME.Data.Models.DbEntities
{
    public abstract class BaseTable
    {
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid UpdatedByUserId { get; set; }

        public User CreatedBy { get; set; }
        public User UpdatedBy { get; set; }
    }
}