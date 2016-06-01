using System;

namespace CA3
{
    class Program
    {
        static int opcion = 0;
        static void Conver_Bin()
        {
            int numero = 0;
            int integer = 0;
            string binary = "";
            bool nobinary = false;
            Console.Clear();
            Console.WriteLine("Agilidad Numerica");
            Console.WriteLine("Conversiones Binarias");
            Console.WriteLine("Seleccione la opción a convertir");
            Console.WriteLine("1. Octal");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("3. Hexadecimal");
            numero = int.Parse(Console.ReadLine());
        back:
            Console.WriteLine("Ingrese el número binario");
            binary = Console.ReadLine();
            foreach (char posicion in binary)
            {
                integer = (int)Char.GetNumericValue(posicion);
                if (integer > 1)
                {
                    nobinary = true;
                }
            }
            if (nobinary)
            {
                Console.WriteLine("Número binario inválido");
                nobinary = false;
                goto back;
            }

            if (numero == 1)
            {
                integer = Convert.ToInt32(binary, 2);
                Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
            }
            else if (numero == 2)
            {
                integer = Convert.ToInt32(binary, 2);
                Console.WriteLine("Decimal: " + Convert.ToString(integer, 10));
            }
            else if (numero == 3)
            {
                integer = Convert.ToInt32(binary, 2);
                Console.WriteLine("Hexadecimal: " + Convert.ToString(integer, 16));
            }
            Console.ReadLine();
        }
        static void Conver_Oct()
        {
            int numero = 0;
            int integer = 0;
            string octal = "";
            bool nooctal = false;
            Console.Clear();
            Console.WriteLine("Agilidad Numerica");
            Console.WriteLine("Conversiones Octales");
            Console.WriteLine("Seleccione la opción a convertir");
            Console.WriteLine("1. Binaria");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("3. Hexadecimal");
            numero = int.Parse(Console.ReadLine());
        back:
            Console.WriteLine("Ingrese el número Octal");
            octal = Console.ReadLine();
            foreach (char posicion in octal)
            {
                integer = (int)Char.GetNumericValue(posicion);
                if (integer > 7)
                {
                    nooctal = true;
                }
            }
            if (nooctal)
            {
                Console.WriteLine("Número binario inválido");
                nooctal = false;
                goto back;
            }

            if (numero == 1)
            {
                integer = Convert.ToInt32(octal, 7);
                Console.WriteLine("Binario: " + Convert.ToString(integer, 2));
            }
            else if (numero == 2)
            {
                integer = Convert.ToInt32(octal, 7);
                Console.WriteLine("Decimal: " + Convert.ToString(integer, 10));
            }
            else if (numero == 3)
            {
                integer = Convert.ToInt32(octal, 7);
                Console.WriteLine("Hexadecimal: " + Convert.ToString(integer, 16));
            }
            Console.ReadLine();
        }
        static void Conver_Dec()
        {
            int numero = 0;
            int integer = 0;
            string decim = "";
            bool nobinary = false;
            Console.Clear();
            Console.WriteLine("Sistemas numéricos");
            Console.WriteLine("Conversiones Binarias");
            Console.WriteLine("Seleccione la opción a convertir");
            Console.WriteLine("1. Octal");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("3. Hexadecimal");
            numero = int.Parse(Console.ReadLine());
        back:
            Console.WriteLine("Ingrese el número binario");
            decim = Console.ReadLine();
            foreach (char posicion in decim)
            {
                integer = (int)Char.GetNumericValue(posicion);
                if (integer > 1)
                {
                    nobinary = true;
                }
            }
            if (nobinary)
            {
                Console.WriteLine("Número binario inválido");
                nobinary = false;
                goto back;
            }

            if (numero == 1)
            {
                integer = Convert.ToInt32(decim, 2);
                Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
            }
            else if (numero == 2)
            {
                integer = Convert.ToInt32(decim, 7);
                Console.WriteLine("Octal: " + Convert.ToString(integer, 10));
            }
            else if (numero == 3)
            {
                integer = Convert.ToInt32(decim, 16);
                Console.WriteLine("Hexadecimal: " + Convert.ToString(integer, 16));
            }
            Console.ReadLine();
        }
        static void Conver_Hex()
        {
            int numero = 0;
            int integer = 0;
            string hex = "";
            bool nohex = false;
            Console.Clear();
            Console.WriteLine("Sistemas numéricos");
            Console.WriteLine("Conversiones Binarias");
            Console.WriteLine("Seleccione la opción a convertir");
            Console.WriteLine("1. Octal");
            Console.WriteLine("2. Decimal");
            Console.WriteLine("3. Hexadecimal");
            numero = int.Parse(Console.ReadLine());
        back:
            Console.WriteLine("Ingrese el número binario");
            hex= Console.ReadLine();
            foreach (char posicion in hex)
            {
                integer = (int)Char.GetNumericValue(posicion);
                if (integer > 1)
                {
                    nohex = true;
                }
            }
            if (nohex)
            {
                Console.WriteLine("Número binario inválido");
                nohex= false;
                goto back;
            }

            if (numero == 1)
            {
                integer = Convert.ToInt32(hex, 2);
                Console.WriteLine("Octal: " + Convert.ToString(integer, 8));
            }
            else if (numero == 2)
            {
                integer = Convert.ToInt32(hex, 2);
                Console.WriteLine("Decimal: " + Convert.ToString(integer, 10));
            }
            else if (numero == 3)
            {
                integer = Convert.ToInt32(hex, 2);
                Console.WriteLine("Hexadecimal: " + Convert.ToString(integer, 16));
            }
            Console.ReadLine();
        }
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Sistemas numéricos");
            Console.WriteLine("1. Binario");
            Console.WriteLine("2. Octal");
            Console.WriteLine("3. Decimal");
            Console.WriteLine("4. Hexadecimal");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción.");
            opcion = int.Parse(Console.ReadLine());
           
            switch (opcion)
            {
                case 1:
                    {
                        Conver_Bin();
                        break;
                    }
                case 2:
                    {
                        Conver_Oct();
                        break;
                    }
                case 3:
                    {
                        Conver_Dec();
                        break;
                    }
                case 4:
                    {
                        Conver_Hex();
                        break;
                    }
                default:
                    {

                        break;
                    }
                    Console.WriteLine("Perdiste");
            }
        }
    }
}