

using System.Diagnostics.Contracts;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        double dato;
        public void Sumar(double termino)
        {
            dato +=termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino !=0)
            {
                dato /= termino;
            }else{
                Console.WriteLine("No se pudo realizar la operacion");
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }
        public double Resultado
        {
            get => dato;
        }
    }
}
    