namespace DefEmpleados
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fecNac;
        private char estadoCivil;
        private DateTime fecIngreso;
        private double sueldoBasico;

        public enum Cargos
        {
            Auxiliar = 1,
            Administrativo = 2,
            Ingeniero = 3,
            Especializata = 4,
            Investigador = 5
        }

        public void Antiguedad ()
        {
            DateTime FechaActual = DateTime.Now;
            int anios = FechaActual.Year - fecIngreso.Year;
            int meses = FechaActual.Month - fecIngreso.Month;
            int dias = FechaActual.Day - fecIngreso.Day;
            if (dias<0)
            {
                meses--;
            }
            if (meses<0)
            {
                anios--;
                meses += 12;
            }
            Console.WriteLine($"El empleado tiene una antiguedad de {anios} años y {meses} meses");
        }
        public void Edad ()
        {
            DateTime FechaActual = DateTime.Now;
            int anios = FechaActual.Year - fecNac.Year;
            int meses = FechaActual.Month - fecNac.Month;
            int dias = FechaActual.Day - fecNac.Day;
            if (dias<0)
            {
                meses--;
            }
            if (meses<0)
            {
                anios--;
                meses += 12;
            }
            Console.WriteLine($"Edad {anios} años");
        }
        /*
        public void Jubilacion (int edad)
        {
            if (edad>=65)
            {
                Console.WriteLine($"Edad {edad} años , ya puede jubilarse");
            }else{
                Console.WriteLine($"Edad {edad} años , Le faltan {65-edad} años para jubilarse");
            }
        }
        */
         public void Jubilacion ()
        {
            DateTime FechaActual = DateTime.Now;
            int anios = FechaActual.Year - fecNac.Year;
            int meses = FechaActual.Month - fecNac.Month;
            int dias = FechaActual.Day - fecNac.Day;
            if (dias<0)
            {
                meses--;
            }
            if (meses<0)
            {
                anios--;
                meses += 12;
            }
             if (anios>=65)
            {
                Console.WriteLine($"Edad {anios} años , ya puede jubilarse");
            }else{
                Console.WriteLine($"Edad {anios} años , Le faltan {65-anios} años para jubilarse");
            }
            
        }
    }
}

