using DefEmpleados;

Empleado [] empleados = new Empleado[3];

for (int i = 0; i < 3; i++)
{
    string fechaInput;
    DateTime fechaIngresada;
    empleados[i] = new Empleado();
    char estadoCivil;
    double sBasico;
    int selecCargo;

    Console.WriteLine($"--------- Ingresar datos Persona {i+1} ---------");

    Console.WriteLine("Ingrese el nombre:"); 
    empleados[i].Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el Apellido:"); 
    empleados[i].Apellido = Console.ReadLine();

    Console.WriteLine("Ingrese la fecha de nacimiento (formato: yyyy-mm-dd):");
    fechaInput = Console.ReadLine();
    // Intenta convertir la entrada en un valor DateTime
    while (!DateTime.TryParse(fechaInput, out fechaIngresada))
        {
            Console.WriteLine("Formato de fecha incorrecto. Por favor, ingrese la fecha de nacimiento (formato: yyyy-mm-dd):");
            fechaInput = Console.ReadLine();
        }
    empleados[i].FecNac = fechaIngresada;

    do
    {
        Console.WriteLine("Ingrese el Estado civil de la persona (C: Casado S: Soltero V: Viudo D: Divorsiado):"); 
        char.TryParse(Console.ReadLine(), out estadoCivil);
        if (estadoCivil !='C' && estadoCivil !='S' && estadoCivil !='V' && estadoCivil !='D')
        {
            Console.WriteLine("Ingrese la letra en mayuscula");
        }
    } while (estadoCivil !='C' && estadoCivil !='S' && estadoCivil !='V' && estadoCivil !='D');
    empleados[i].EstadoCivil = estadoCivil;

    Console.WriteLine("Ingrese la fecha de ingreso en la empresa (formato: yyyy-mm-dd):");
    fechaInput = Console.ReadLine();
    // Intenta convertir la entrada en un valor DateTime
    while (!DateTime.TryParse(fechaInput, out fechaIngresada))
        {
            Console.WriteLine("Formato de fecha incorrecto. Por favor, ingrese la fecha de nacimiento (formato: yyyy-mm-dd):");
            fechaInput = Console.ReadLine();
        }
    empleados[i].FecIngreso = fechaIngresada;
   
    do{ 
        Console.WriteLine("Ingrese el Sueldo Basico:");
    } while (!double.TryParse(Console.ReadLine(), out sBasico));
    empleados[i].SueldoBasico = sBasico;
        
    do
    {
         Console.WriteLine("Ingrese el Cargo (1:Auxiliar 2:Administrativo 3:Ingeniero, 4:Especialista , 5:Investigador)");
    } while (!int.TryParse(Console.ReadLine(), out selecCargo));
    switch (selecCargo)
    {
        case 1:
            empleados[i].Cargo = Empleado.Cargos.Auxiliar;
        break;
        case 2:
            empleados[i].Cargo = Empleado.Cargos.Administrativo;
        break;
        case 3:
            empleados[i].Cargo = Empleado.Cargos.Ingeniero;
        break;
        case 4:
            empleados[i].Cargo = Empleado.Cargos.Especialista;
        break;
        case 5:
            empleados[i].Cargo = Empleado.Cargos.Investigador;
        break;
        
    }
    
    

}



double montoTotal = 0;
int añosParaJubilarse = 65;
for (int k = 0; k < 3; k++)
{
    if (añosParaJubilarse > empleados[k].jubilacion()   )
    {
        añosParaJubilarse = empleados[k].jubilacion(); 
    }
    montoTotal += empleados[k].calcularSalario();
}

Console.WriteLine($"\n El monto Total a pagar en Salarios: {montoTotal}");

for (int l = 0; l < 3; l++)
{
    if (añosParaJubilarse == empleados[l].jubilacion())
    {
        Console.WriteLine($"\n ### Empleado {l+1} es el mas proximo a jubilarse ###");
        Console.WriteLine($"Nombre: {empleados[l].Nombre}");
        Console.WriteLine($"Apellido: {empleados[l].Apellido}");
        Console.WriteLine($"Fecha de nacimiento: {empleados[l].FecNac}");
        Console.WriteLine($"Estado Civil: {empleados[l].EstadoCivil}");
        Console.WriteLine($"Fecha de ingreso en la empresa: {empleados[l].FecIngreso}");
        Console.WriteLine($"Sueldo Basico: {empleados[l].SueldoBasico}");
        Console.WriteLine($"Cargo: {empleados[l].Cargo}");
        Console.WriteLine($"Antiguedad: {empleados[l].antiguedad()} anios");
        Console.WriteLine($"Edad: {empleados[l].edad()} anios");
        Console.WriteLine($"Cantidad de años faltantes para jubilarse: {empleados[l].jubilacion()}");
        Console.WriteLine($"Salario: $ {empleados[l].calcularSalario()}");
    } 
}

Console.WriteLine($"El monto Total en salarios: $ {montoTotal}");






/*
using EspacioCalculadora;

int opcion;
double num;
Calculadora operacion = new Calculadora();

do
{
    Console.WriteLine("######### Calculadora #########");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar");
    Console.WriteLine("0 - Salir");
    int.TryParse(Console.ReadLine(),out opcion);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Sumar | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Sumar(num);
        break;
        case 2:
            Console.WriteLine("Restar | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Restar(num);
        break;
        case 3:
            Console.WriteLine("Multiplicar | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Multiplicar(num);
        break;
        case 4:
            Console.WriteLine("Dividir | Ingrese el numero: ");
            double.TryParse(Console.ReadLine(),out num);
            operacion.Dividir(num);
        break;
        case 5:
            operacion.Limpiar();
        break;

    }
    Console.WriteLine("El numero resultante es: " + operacion.Resultado);
} while (opcion!=0);
*/


    
