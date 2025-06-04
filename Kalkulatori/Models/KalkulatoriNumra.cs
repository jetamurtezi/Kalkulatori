using System.ComponentModel.DataAnnotations;

namespace Kalkulatori.Models
{
    public class KalkulatoriNumra
    {
        [Required]
        [Range(100,int.MaxValue, ErrorMessage ="Numri i shkruar duhet te kete se paku 3 shifra")]
        public int Numri { get; set; }

        public int Numri500 => Numri / 500;
        public int Numri200 => Numri / 200;
        public int Numri100 => Numri / 100;
        public int Numri50 => Numri / 50;
        public int Numri20 => Numri / 20;
        public int Numri10 => Numri / 10;
        public int Numri5 => Numri / 5;


        public string Mesazhi =>

            $" Per kete shume ju duhen: \n" +
            $"{Numri500} x 500she,\n" +
            $"{Numri200} x 200she,\n" +
            $"{Numri100} x 100she,\n" +
            $"{Numri50} x 50she,\n " +
            $"{Numri20} x 20she, \n" +
            $"{Numri10} x 10she, \n" +
            $"{Numri5} x 5she ";
    }
}
