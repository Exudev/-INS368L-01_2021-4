
using System;
class HelloWorld {
  static void Main() {
    
    int a, b, lim, ultimo; 
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            lim = int.Parse(Console.ReadLine()); 
            a = 0;
            b = 1; 
            for (int i = 0; i < lim; i++)  
        {
                ultimo = a;
                a = b; 
                b = ultimo + a; 
                Console.WriteLine(a); 
                if((a % 2) == 0)
            {
               Console.WriteLine("Es Par");
            }
            else
            {
               Console.WriteLine("Es Impar");
            }
                if(EsPrimo(a))
            {
                Console.WriteLine("primo");
            }
            else
            {
                //No es un número primo
            }
            
       
     
}  
Console.ReadKey(); 
}
 static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if((numero % i) == 0)
                {
                    // No es primo :(
                    return false;
                }
            }

            // Es primo :)
            return true;
        }
}

