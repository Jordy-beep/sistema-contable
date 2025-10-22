//Metodo, este tiene que ser estatico y publico para que los demas archivos tengan acceso al mismo

//Se tienen que crear nueva clase y usar el using System, ya que solo un archivo permite top-level statements 

using System;

public static class BalanceGeneral
{
    public static void EstadoBalanceGeneral()
    {
        string[] ActivosCirculante = { "Caja General", "Caja Chica", "Fondo de oportunidades", "Bancos", "Inversiones Temporales", "Clientes", "Documentos Por Cobrar", "Deudores", "Funcionarios y Empleados", "IVA Acreditable", "Anticipo de Impuestos", "Inventarios", "Mercancia en transito", "Anticipo a Proveedores", "Papeleria y utiles", "Propaganda y pubicidad", "Muestras medicas y literaturas", "Primas de Seguros y fianzas", "Rentas Pagadas por anticipado", "Intereses pagados por anticipado", "Otros" };

        String[] ActivosFijosTangible = { "Terrenos", "Edificios", "Maquinaria y equipo", "Mobiliario y equipo de oficina", "Equipo de transporte", "Equipo de reparto" };

        String[] ActivosIntangible = { "Derechos de autor", "Patentes", "Marcas comerciales", "Nombres Comerciales", "Crédito Comercial", "Gastos Preoperativos", "Descuento en emision de obligaciones", "Gastos en colocación de valores", "Gastos de Constitución", "Gastos de Organización", "Gastos de Instalación", "Fondo de amortización de obligaciones", "Depósito de Garantía", "Inversiones en proceso", "Terrenos no utilizados", "Maquinaria no utilizada" };

        String[] PasivosCirculante = { "Proveedores", "Cuentas por pagar", "Documentos por pagar", "Acreedores Diversos", "Anticipo de Clientes", "Dividendos por pagar", "IVA por pagar", "Impuesto sobre la renta por pagar", "Impuestos y derechos retenidos por enterar", "Intereses por pagar", "Sueldos acumulados por pagar", "Gastos acumulados por pagar", "Rentas cobradas por anticipado", "Intereses cobrados por anticipado" };

        String[] PasivosFijos = { "Acreedores hipotecarios", "Acreedores bancarios", "Documentos por pagar a largo plazo", "Obligaciones Acirculación", "Bonos por pagar", "Hipoteca por pagar" };

        String[] CapitalContribuido = { "Capital social", "Aportaciones para futuros aumentos de capital", "Prima en venta de acciones", "Donaciones" };

        String[] CapitalGanado = { "Utilidades retenidas", "Perdidas acumuladas", "Exceso del capital contable" };

        String nombreEmpresa;
        Console.WriteLine("-------BALANCE GENERAL-------");
        //          Pedir nombre de la empresa 
        while (true)
        {
            try
            {
                Console.WriteLine("Introduzca el nombre de la Entidad/Empresa");
                nombreEmpresa = Console.ReadLine() ?? "";

                    //Aniadir validacion de que no acepte signos.
                    
                if (nombreEmpresa.Length < 6)
                {
                    Console.WriteLine("Nombre de empresa no valida.");
                    continue;
                }

                break;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Error: Por favor inserte un nombre correcto. Intentelo de nuevo. ");
                Console.WriteLine("-----------------------------------------");
                continue;
            }

        }

        //          Pedir fecha del periodo contable 
        DateTime periodoInicio;
        DateTime periodoFinal;

        while (true)
        {
            Console.WriteLine("Ingrese el inicio del periodo contable (dd/MM/yyyy)");
            String fechaInicio = Console.ReadLine() ?? "";

            Console.WriteLine("Ingrese el final del periodo contable (dd/MM/yyyy)");
            String fechaFinal = Console.ReadLine() ?? "";

            //bool TryParse(string input, out DateTime result)
            //Intenta convertir 
            //                              Esto da un valor de salida "out" si fue exitosa tira un bool como true, y si no es false. 
            bool validoInicio = DateTime.TryParseExact(fechaInicio, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out periodoInicio);

            bool validoFinal = DateTime.TryParseExact(fechaFinal, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out periodoFinal);

            if (!validoInicio || !validoFinal)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("ERROR: Una de las Fechas no es valida, inténtelo de nuevo.");
                Console.WriteLine("------------------------------------------------------------");
                continue;
            }

            //Validacion logica: La fecha fin no puede ser menor que la de inicio 
            if (periodoFinal < periodoInicio)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("ERROR: El fin del periodo no puede ser menor a la fecha de inicio del periodo, inténtelo de nuevo.");
                Console.WriteLine("------------------------------------------------------------");
                continue;
            }

            //Validacion logica: No se pueden ingresar fechas mayores a las de este anio

            if (periodoInicio > DateTime.Today || periodoFinal > DateTime.Today)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("ERROR: No se pueden ingresar fechas mayores a las del dia de hoy, inténtelo de nuevo.");
                Console.WriteLine("------------------------------------------------------------");
                continue;
            }

            if (periodoInicio == periodoFinal)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("ERROR: Las fechas no pueden ser iguales, inténtelo de nuevo.");
                Console.WriteLine("------------------------------------------------------------");
                continue;
            }

            // TOdo bien se corta el ciclo 
            break;
        }
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"EMPRESA LA {nombreEmpresa}");
        Console.WriteLine($"DEL {periodoInicio} AL {periodoFinal}");

    }
}