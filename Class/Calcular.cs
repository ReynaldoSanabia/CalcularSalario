namespace CalcularSalario.Class
{
    public class Calcular
    {
        public void CalcularSalario()
        {

            int horasTrabajadas = 0;
        int costoHora = 0;
        decimal sueldo = 0;

            Console.WriteLine("Ingrese la cantidad de horas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el costo por hora: ");
            costoHora = Convert.ToInt32(Console.ReadLine());

            sueldo = (horasTrabajadas*costoHora);
            Console.WriteLine($"El sueldo es: {sueldo}");
        }
    }
}
