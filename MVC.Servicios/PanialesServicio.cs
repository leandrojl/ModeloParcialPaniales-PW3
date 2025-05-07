using System.ComponentModel;
using MVC.Entidades;

namespace MVC.Servicios
{

    public interface IPanialesServicio
    {
        string CalcularPaniales(double pesoDelNinio, int edadDelNinio);

        void AgregarPanial(Panial panial);
        
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

        public string CalcularPaniales(double pesoDelNinio, int edadDelNinio)
        {
            string talle = "";
            return talle;
        }
    }
}
