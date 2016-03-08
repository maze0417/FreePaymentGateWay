using System;
using EME.Data.Models.Enums;

namespace EME.Data.Models.DbEntities
{
    public class Merchant : BaseTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}