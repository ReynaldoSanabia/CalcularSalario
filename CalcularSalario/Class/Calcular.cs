namespace CalcularSalario.Class
{
    public class Calcular
    {
        public void CalcularSalario() {

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

        public void CalcularProducto() { 
        
            int num1, num2;
            int suma=0, multiplicacion=0;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            multiplicacion = num1 * num2;

            Console.WriteLine($"El resultado de la suma es: {suma}");
            Console.WriteLine($"El resultado de la Multiplicacion es: {multiplicacion}");

        }
    }
}
