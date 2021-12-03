using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            numeros.Push(1);
            numeros.Push(2);
            numeros.Push(3);
            numeros.Push(4);
            numeros.Push(5);
            numeros.Push(6);
            Console.WriteLine($"Cantidad de elementos: {numeros.Count}");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Eliminamos un numero");
            numeros.Pop();
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Primer cliente en la Pila: {numeros.Peek()}");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Queue<string> Clientes = new Queue<string>();
            Clientes.Enqueue("Tomas");
            Clientes.Enqueue("Ludmila");
            Clientes.Enqueue("Paula");
            Clientes.Enqueue("Jesus");
            Console.WriteLine($"Cantidad de elementos: {Clientes.Count}");

            //recorrer
            foreach (string item in Clientes)
            {
                Console.WriteLine(item);
            }
            //eliminar cola
            Console.WriteLine("------------------");
            Console.WriteLine("Eliminamos un Cliente");
            Clientes.Dequeue();
            foreach (string item in Clientes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Primer cliente en la cola: {Clientes.Peek()}");

            Console.ReadKey();



            Dictionary<string, string> comidasDelMundo = new Dictionary<string, string>();
            comidasDelMundo.Add("taco", "Mexico"); // (key,value) las keys no se pueden repetir, los values si
            comidasDelMundo.Add("mole", "Mexico");
            comidasDelMundo.Add("totopos", "Mexico");
            comidasDelMundo.Add("empanadas", "Argentina");
            comidasDelMundo.Add("Pasta", "Italia");
            comidasDelMundo.Add("Pizza", "Italia");
            Console.WriteLine($"Cantidad de elementos  en el diccionario: {comidasDelMundo.Count}");
            //Mostrar Elementos Diccionario
            foreach (KeyValuePair<string,string> item in comidasDelMundo)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }
            //Eliminar elementos del diccionario
            comidasDelMundo.Remove("Pasta");
            Console.WriteLine("----------------");
            Console.WriteLine("Elimino Pasta");
            foreach (KeyValuePair<string, string> item in comidasDelMundo)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }

            Console.WriteLine($"Pais al que pertenece mole es {comidasDelMundo["mole"]}"); //comidasDelMundo esta indexado por key string

            //Busqueda por key - ContainsKey
            if (comidasDelMundo.ContainsKey("mole")) //ContainsKey busca por las key de cada item
            {
                Console.WriteLine("mole pertenece al diccionario");
            }
            else
            {
                Console.WriteLine("mole no pertenece al diccionario");
            }
            if (comidasDelMundo.ContainsKey("Pizza"))
            {
                Console.WriteLine("Pizza pertenece al diccionario");
            }
            else
            {
                Console.WriteLine("Pizza no pertenece al diccionario");
            }
            if (comidasDelMundo.ContainsKey("Milanesa"))
            {
                Console.WriteLine("Milanesa pertenece al diccionario");
            }
            else
            {
                Console.WriteLine("Milanesa no pertenece al diccionario");
            }

            //Busqueda por values - ContainsValue
            if (comidasDelMundo.ContainsValue("Argentina"))
            {
                Console.WriteLine("Argentina esta en el diccionario");
            }
            if (!comidasDelMundo.ContainsValue("Brasil"))
            {
                Console.WriteLine("Brasil no esta en el diccionario");
            }



            Console.ReadKey();

            List<string> listaPaises = new List<string>();
            Console.WriteLine($"Cantidad de elementos {listaPaises.Count}");
            listaPaises.Add("España");
            listaPaises.Add("Argentina");
            listaPaises.Add("Chile");
            listaPaises.Add("Mexico");
            listaPaises.Insert(1, "China"); // (index,value)  va a insertar en la posicion 1 chima  //insercion especifica
            /*
            Console.ReadKey();
            Console.WriteLine($"Cantidad de elementos {listaPaises.Count}");*/
            foreach (string item in listaPaises)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"El valor de la segunda posicion es {listaPaises[1]}");
            Console.WriteLine("Eliminar Chile");
            listaPaises.Remove("Chile");
            Console.WriteLine("---------------------");
            foreach (string item in listaPaises)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Eliminar indice 1");
            listaPaises.RemoveAt(1); //elimina apartir de indice
            Console.WriteLine("---------------------");
            foreach (string item in listaPaises)
            {
                Console.WriteLine(item);
            }
        }
    }
}
