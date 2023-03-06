namespace Sim_ProyeccionC
{
    class Program
    {
        public static int IngresosA()
        {
            int ventaAB = 0;
            Console.WriteLine("Ingrese el total recaudado en ventas de comida y bebida: ");
            ventaAB = Convert.ToInt32(Console.ReadLine());

            int servicio = 0;
            Console.WriteLine("Ingrese el total recaudado en servicios catering: ");
            servicio = Convert.ToInt32(Console.ReadLine());

            int ventasPP = 0;
            Console.WriteLine("Ingrese el total recaudado en ventas de productos promocionales: ");
            ventasPP = Convert.ToInt32(Console.ReadLine());

            int resultado = ventaAB + servicio + ventasPP;
            Console.WriteLine($"El resultado es: {resultado}");

            Console.WriteLine("----------------------------------------------------------------");

            return resultado;
        }

        public static int CostoIngredientes() 
        {
            int Costo = 0;
            Console.WriteLine("Ingrese el costo total de los ingredientes: ");
            Costo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------------------");

            return Costo;
        }
        public static int CostosOperativos()
        {
            int costoR = 0;
            Console.WriteLine("Ingrese el costo de la renta: ");
            costoR = Convert.ToInt32(Console.ReadLine());

            int servicioP = 0;
            Console.WriteLine("Ingrese el costo de los servicios publicos: ");
            servicioP = Convert.ToInt32(Console.ReadLine());

            int cSeguro = 0;
            Console.WriteLine("Ingrese el costo del seguro: ");
            cSeguro = Convert.ToInt32(Console.ReadLine());

            int nominaEmp = 0;
            Console.WriteLine("Ingrese el costo de la nomina de los empleados: ");
            nominaEmp = Convert.ToInt32(Console.ReadLine());

            int equiposySum = 0;
            Console.WriteLine("Ingrese el costo total en equipos y suministros: ");
            equiposySum = Convert.ToInt32(Console.ReadLine());

            int mantenimiento = 0;
            Console.WriteLine("Ingrese el costo de mantenimiento: ");
            mantenimiento = Convert.ToInt32(Console.ReadLine());

            int publicidad = 0;
            Console.WriteLine("Ingrese el costo de publicidad: ");
            publicidad = Convert.ToInt32(Console.ReadLine());

            int resultadoC = costoR + servicioP + cSeguro + nominaEmp + equiposySum + mantenimiento + publicidad;
            Console.WriteLine($"El resultado es: {resultadoC}");

            Console.WriteLine("----------------------------------------------------------------");

            return resultadoC;
        }

        public static void gananciaAn()
        {
            int resultado = IngresosA();
            int Costo = CostoIngredientes();
            int resultadoC = CostosOperativos();

            int gananciaAn = 0;
            int resultadofinal = 0;
            gananciaAn = resultado - Costo - resultadoC;
            Console.WriteLine($"La ganancia anual es: {gananciaAn}");

            resultadofinal = gananciaAn * 10;
            Console.WriteLine($"El resultado a 10 años es: {resultadofinal}");

        }
        static void Main(string[] args)
        {
            gananciaAn();
            //Console.WriteLine("Hello, World!");
        }
    }
}
