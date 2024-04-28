namespace CalcularSalario.Class
{
    public class Calcular
    {
        public void CalcularImpuesto() {

            int horasTrabajadas = 0;
            int costoHora = 0;
            decimal sueldo = 0;
            decimal impuesto = 0.18m;
            decimal valorImpuesto;
            try
            {
                Console.WriteLine("Ingrese la cantidad de horas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el costo por hora: ");
                costoHora = Convert.ToInt32(Console.ReadLine());

                sueldo = (horasTrabajadas * costoHora);
                Console.WriteLine($"El sueldo sin impuestos es: {sueldo}");
                if (sueldo > 3000) {
                    valorImpuesto = (sueldo * impuesto);
                    sueldo = (sueldo-valorImpuesto);

                    Console.WriteLine($"El valor del impuesto es: {valorImpuesto}");
                    Console.WriteLine($"El sueldo despues de cobro del impuesto es: {sueldo}");

                
                }else
                {
                    Console.WriteLine("El sueldo esta por debajo de tarifa");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine ($"Ocurrio un error { ex.Message} calculando el sueldo");

                throw;
            }
            
        
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
