using System;
using FreePayment.Data.Models.Enums;

namespace FreePayment.Data.Models.DbEntities
{
    public class Merchant : BaseTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}