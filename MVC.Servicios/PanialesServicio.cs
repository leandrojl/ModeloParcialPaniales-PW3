using System.ComponentModel;
using MVC.Entidades;

namespace MVC.Servicios
{

    public interface IPanialesServicio
    {
        string CalcularPaniales(double pesoDelNinio, int edadDelNinio);

        void AgregarPanial(Panial panial);

        List<Panial> obtenerPaniales();
        
    }
    public class PanialesServicio : IPanialesServicio
    {
        public static List<Panial> listaDePaniales;

        public PanialesServicio()
        {
            listaDePaniales = new List<Panial>();
        }

        public void AgregarPanial(Panial panial)
        {
            listaDePaniales.Add(panial);
        }

        public List<Panial> obtenerPaniales()
        {
            return listaDePaniales;
        }

        public string CalcularPaniales(double pesoDelNinio, int edadDelNinio)
        {
            if (pesoDelNinio <= 3)
            {
                return "RN"; // Recién nacido
            }
            else if (pesoDelNinio >= 3 && pesoDelNinio < 5)
            {
                return "XS"; // Extra pequeño
            }
            else if (pesoDelNinio >= 5 && pesoDelNinio < 7)
            {
                return "S"; // Pequeño
            }
            else if (pesoDelNinio >= 7 && pesoDelNinio < 9)
            {
                return "M"; // Mediano
            }
            else if (pesoDelNinio >= 9 && pesoDelNinio < 12)
            {
                return "G"; // Grande
            }
            else if (pesoDelNinio >= 12 && pesoDelNinio <= 15)
            {
                return "XG"; // Extra grande
            }
            else if (pesoDelNinio > 15)
            {
                return "XXG"; // Doble extra grande
            }
            else
            {
                return "Tamaño no definido"; // Caso por defecto
            }
        }

        
    }
}
