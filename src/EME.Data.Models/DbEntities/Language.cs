namespace EME.Data.Models.DbEntities
{
    public class Language : BaseTable
    {
        public string CultureCode { get; set; }

        public string LanguageCode { get; set; }

        public string Name { get; set; }

        public string LocalizedName { get; set; }
    }
}