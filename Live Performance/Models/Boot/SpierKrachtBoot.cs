namespace Live_Performance.Models.Boot
{
    public class SpierKrachtBoot : IBoot
    {
        public SpierKrachtBoot(string naam, string soortBeschrijving, string type)
        {
            Naam = naam;
            SoortBeschrijving = soortBeschrijving;
            Type = type;
        }

        public string Naam { get; set; }
        public string SoortBeschrijving { get; set; }
        public string Type { get; set; }
    }
}
