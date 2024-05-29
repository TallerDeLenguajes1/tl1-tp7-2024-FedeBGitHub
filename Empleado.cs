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
       public string Nombre{ get => nombre; set => nombre = value;}
       public string Apellido { get => apellido; set => apellido = value; }
       public DateTime FecNac { get => fecNac; set => fecNac = value; }
       public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
       public DateTime FecIngreso { get => fecIngreso; set => fecIngreso = value; }
       public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
       
       private Cargos cargo; 
       public Cargos Cargo { 
            get => cargo;
            set => cargo = value; 
        }
        
        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public int antiguedad ()
        {
            DateTime FechaActual = DateTime.Now;
            int anios = FechaActual.Year - FecIngreso.Year;
            int meses = FechaActual.Month - FecIngreso.Month;
            int dias = FechaActual.Day - FecIngreso.Day;
            if (dias<0)
            {
                meses--;
            }
            if (meses<0)
            {
                anios--;
                meses += 12;
            }
            return anios;
        }
        public int edad ()
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
            return anios;
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
         public int jubilacion ()
        {
            int edadd = edad();
             if (edadd>=65)
            {
                edadd = 0;
            }else{
                edadd = 65 - edadd;
            }
            return edadd;
        }

        public double calcularSalario()
        {
            double salario;
            double adicional;
            int anti = antiguedad();

            if (anti<=20)
            {
                adicional =(double) anti / 100;
                adicional = adicional * sueldoBasico;   
                
            }else{
                adicional = 0.25 * sueldoBasico;
            }
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional = adicional * 1.50;
                
            }
            if (estadoCivil == 'C')
            {
                adicional = adicional + 150000;
                salario = sueldoBasico + adicional ;
                
            }else{
                salario = sueldoBasico + adicional;
            }
             return salario;
        }
    }
}

