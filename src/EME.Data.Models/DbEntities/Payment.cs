using System;
using EME.Data.Models.Enums;

namespace EME.Data.Models.DbEntities
{
    public class Payment :BaseTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PaywayId { get; set; }
        public DateTimeOffset EnableStartTime { get; set; }
        public DateTimeOffset EnableEndTime { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
    }
}