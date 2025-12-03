namespace WebApplication1.Model
{
    public class Gast
    {
        public int GastID { get; set; }
        public string VoorNaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Telefoon { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }
        public string Land { get; set; }
        public string Opmerking { get; set; }

        public string GetVolledigeNaam()
            => $"{VoorNaam} {Achternaam}";

        public bool IsContactGegevensCompleet()
            => !string.IsNullOrWhiteSpace(Email) &&
               !string.IsNullOrWhiteSpace(Telefoon);

    }
}
