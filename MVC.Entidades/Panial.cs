using System.ComponentModel.DataAnnotations;

namespace MVC.Entidades
{
    public class Panial
    {

        public string tamanio { get; set; }

        [Required(ErrorMessage = "El nombre del niño es obligatorio.")]
        public string nombreDelNinio { get; set; }

        [Required(ErrorMessage = "El peso del niño es obligatorio.")]
        [Range(1, 20, ErrorMessage = "El peso debe estar entre 1 y 20 kg.")]
        public double pesoDelNinio { get; set; }

        [Range(0, 5, ErrorMessage = "La edad debe estar entre 0 y 5 anios.")]
        public int edadDelNinio { get; set; }

        

        public Panial(string nombreDelNinio, double pesoDelNinio, int edadDelNinio)
        {
            this.nombreDelNinio = nombreDelNinio;
            this.pesoDelNinio = pesoDelNinio;
            this.edadDelNinio = edadDelNinio;
            this.tamanio = "";
        }

        public Panial()
        {
            this.nombreDelNinio = "";
            this.pesoDelNinio = 0;
            this.edadDelNinio = 0;
            this.tamanio = "";
        }

    }
}
