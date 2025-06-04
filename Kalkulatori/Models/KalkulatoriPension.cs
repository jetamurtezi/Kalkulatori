using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kalkulatori.Models
{
    public class KalkulatoriPension
    {
        [Required]
        [DisplayName("Emri")]
        public string Emri { get; set; }

        [Required]
        [DisplayName("Mbiemri")]
        public string Mbiemri { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/1920", "01/01/2025", ErrorMessage = "Data duhet te jete mes viteve 1920 dhe 2025")]
        [DisplayName("Data e lindjes")]
        public DateTime DataELindjes { get; set; }

        public int Rezultati => 65 - (DateTime.Now.Year - DataELindjes.Year) - (DateTime.Now.DayOfYear < DataELindjes.DayOfYear ? 1 : 0);

        public string Mesazhi=>

            $"{Emri} {Mbiemri} ju duhen edhe {Rezultati} vite per te dale ne pension!";
    }
}
