//Creacion del Menu 

bool acceso = false;
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("\tBIENVENIDO A NUESTRO SISTEMA CONTABLE");
Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("\tMenu - Estados Financieros a Elaborar");
Console.WriteLine("----------------------------------------------------------------------------");
while (!acceso)
{
    try
    {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("\tPresione el numero de la actividad que desea realizar.");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("1.   Balance General.");
        Console.WriteLine("2.   Estado de Resultado.");
        Console.WriteLine("3.   Estado de Flujo de Efectivo.");
        Console.WriteLine("4.   Estado de Variacion de Patrimonio.");
        Console.WriteLine("0.   Salir.");
        Console.WriteLine("----------------------------------------------------------------------------");
        int option = int.Parse(Console.ReadLine() ?? "");

        switch (option)
        {
            case 1:
                BalanceGeneral.EstadoBalanceGeneral(); //Asi se llama, ya que esta en otra clase
                break;

            case 2:
                EstadoDeResultado.Resultado();
                break;

            case 3:
                FlujoDeEfectivo.EstadoFlujoDeEfetivo();
                break;

            case 4:
                VariacionDeCapital.EstadoVariacionDeCapital();
                break;

            case 0:
                Console.WriteLine("Gracias Por usar nuestros servicios.");
                acceso = true; //Agregar la pregunta "Desea continuar?"
                break;
            default:
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("Error: Por favor ingrese una de las opciones numericas.");
                Console.WriteLine("----------------------------------------------------------------------------");
                acceso = false;

                break;

        }
    }
    catch (System.FormatException)
    {

        Console.WriteLine("\nError: No se permiten letras. Por favor ingrese una de las opciones numericas, intentelo de nuevo.");
        acceso = false;
    }
}



