using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 3, 4 };
            try
            {
                int numero = array[55];
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine($"IndexOutOfRange {ex.Message} ");
                throw new MiExcepcion("Error al intentar dividir por cero", ex);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Cualquier excepcion {e.Message}");
            }
            finally
            {
                Console.WriteLine("Se ejecuto el bloque finally");
            }
        }
    }
}
