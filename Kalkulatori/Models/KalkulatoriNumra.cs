using System.ComponentModel.DataAnnotations;

namespace Kalkulatori.Models
{
    public class KalkulatoriNumra
    {
        [Required]
        [Range(100,int.MaxValue, ErrorMessage ="Numri i shkruar duhet te kete se paku 3 shifra")]
        public int Numri { get; set; }

        public int Numri500 => Numri / 500;
        public int Numri200 => (Numri % 500) / 200;
        public int Numri100 => (Numri % 500 % 200) / 100;
        public int Numri50 => (Numri % 500 % 200 % 100) / 50;
        public int Numri20 => (Numri % 500 % 200 % 100 % 50) / 20;
        public int Numri10 => (Numri % 500 % 200 % 100 % 50 % 20) / 10;
        public int Numri5 => (Numri % 500 % 200 % 100 % 50 % 20 % 10) / 5;

        public int Mbetja=> Numri % 5;


        public string Mesazhi =>

            $" Per kete shume ju duhen: \n" +
            $"{Numri500} x 500she,\n" +
            $"{Numri200} x 200she,\n" +
            $"{Numri100} x 100she,\n" +
            $"{Numri50} x 50she,\n " +
            $"{Numri20} x 20she, \n" +
            $"{Numri10} x 10she, \n" +
            $"{Numri5} x 5she \n" +
            (Mbetja > 0 ? $"Edhe te mbet nje : {Mbetja}she" : "");
    }
}
