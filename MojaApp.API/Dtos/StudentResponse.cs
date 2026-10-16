namespace MojaApp.API.Dtos
{
    public class StudentResponse
    {
        public int Id { get; set; }
        public string imePrezime { get; set; } = "";
        public string BrojIndeksa { get; set; } = "";
        public DateOnly? DatumRodjenja { get; set; }
    }
}
