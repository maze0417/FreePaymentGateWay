using System;
using Enums;

namespace Models
{
    public class Merchant : BaseTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsNeedInovice { get; set; }
        public StatusCode Status { get; set; }
    }
}