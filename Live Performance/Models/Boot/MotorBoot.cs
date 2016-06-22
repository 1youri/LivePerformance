namespace Live_Performance.Models.Boot
{
    class MotorBoot : IBoot
    {
        public MotorBoot(string naam, string soortBeschrijving, string type, int tankInhoud)
        {
            Naam = naam;
            SoortBeschrijving = soortBeschrijving;
            Type = type;
            TankInhoud = tankInhoud;
            ActieRadius = tankInhoud * 15;
        }

        public string Naam { get; set; }
        public string SoortBeschrijving { get; set; }
        public string Type { get; set; }

        public int TankInhoud { get; set; }
        public int ActieRadius { get; set; }
    }
}
