using System;

namespace FreePayment.Data.Models.DbEntities
{
    public class Localization
    {
        public Guid Id { get; set; }
        public string Context { get; set; }
        public string Code { get; set; }
        public string Translation { get; set; }
        public string Description { get; set; }
        public string CultureCode { get; set; }
        public Language Language { get; set; }
    }
}