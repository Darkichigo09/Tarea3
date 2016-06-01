using System;

namespace Lista_Estudiantes
{
    class Program
    {
        static int opcion = 0;
        static int i = 0;
        static int sexo = 0;
        static int tamano = 5;

        struct Estudiante
        {
            public int codigo;
            public string nombre;
            public int edad;
            public char genero;
        };

        static Estudiante[] info_estudiante;

        static void ingreso_estudiante()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < info_estudiante.Length)
                {

                    Console.WriteLine("Ingreso de estudiante");
                    Console.WriteLine("Digite el Codigo del Estudiante:");
                    info_estudiante[i].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del Estudiante: ");
                    info_estudiante[i].nombre = Console.ReadLine();
                    Console.Write("Digite la edad del Estudiante: ");
                    info_estudiante[i].edad = int.Parse(Console.ReadLine());
                    Console.Write("Digite el Sexo del Estudiante:\n1. Hombre\n2. Mujer\n");
                    sexo = int.Parse(Console.ReadLine());
                    if (sexo == 1)
                    {
                        info_estudiante[i].genero = 'M';
                    }
                    else if (sexo == 2)
                    {
                        info_estudiante[i].genero = 'F';
                    }
                    else { Console.WriteLine("Sexo no especificado"); }


                    r = tamano;
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de Estudiantes al Limite");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }
        static void modificar_estudiante()
        {
            int r = 0;
            while (r != 1)
            {
                int codigo = 0;
                Console.Clear();
                Console.WriteLine("Modificacion de estudiante");
                Console.WriteLine("Digite el Codigo del Estudiante a modificar:");
                codigo = int.Parse(Console.ReadLine());

                for (int i = 0; i < info_estudiante.Length; i++)
                {
                    if (info_estudiante[i].codigo == codigo)
                    {
                        Console.Write("Digite el nuevo Nombre del Estudiante:    ");
                        info_estudiante[i].nombre = Console.ReadLine();
                        Console.Write("Digite la nueva edad del Estudiante:");
                        info_estudiante[i].edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Desea Modificar otro Estudiante 0-Sí 1-No");
                        r = int.Parse(Console.ReadLine());
                        i++;
                    }
                }

                Console.ReadKey();

            }

        }

        static void listado_estudiantes()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("             Listado Estudiantil.             ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Universidad UH");
            Console.WriteLine("_______________________________________________");
            Console.Write("Reg  Codigo     Nombre     Sexo         Edad\n");
            for (i = 0; i < info_estudiante.Length; i++)
            {
                if (info_estudiante[i].codigo != 0)
                {
                    reg = i + 1;

                    Console.Write(reg + "      " + info_estudiante[i].codigo + "       " + info_estudiante[i].nombre + "         " + info_estudiante[i].genero + "        " + info_estudiante[i].edad + "\n");
                }
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Fin del Informe");
            Console.ReadKey();
        }
        static int contador_hombres()
        {
            int contadorh = 0;
            for (int i = 0; i < info_estudiante.Length; i++)
            {
                if (info_estudiante[i].genero == 'M')
                {
                    contadorh++;
                }
            }
            return contadorh;
        }
        static int contador_mujeres()
        {
            int contadorm = 0;
            for (int i = 0; i < info_estudiante.Length; i++)
            {
                if (info_estudiante[i].genero == 'F')
                {
                    contadorm++;
                }
            }
            return contadorm;
        }
        static int cont_menor()
        {
            int contmenor = 0;
            for (int i = 0; i < info_estudiante.Length; i++)
            {
                if (info_estudiante[i].edad <= 18)
                {
                    contmenor++;
                }
            }
            return contmenor;
        }
        static int cont_joven()
        {
            int contjoven = 0;
            for (int i = 0; i < info_estudiante.Length; i++)
            {

                if (info_estudiante[i].edad >= 19 && info_estudiante[i].edad <= 29)
                {
                    contjoven++;
                }
            }
            return contjoven;
        }
        static int cont_adult()
        {
            int contadult = 0;
            for (int i = 0; i < info_estudiante.Length; i++)
            {
                if (info_estudiante[i].edad >= 30)
                {
                    contadult++;
                }
            }
            return contadult;
        }
        static void borrar_estudiante()
        {
            int codigo = 0;
            Console.Clear();
            Console.WriteLine("Borrado de estudiantes");
            Console.WriteLine("Digite el Codigo del estudiante a borrar");
            codigo = int.Parse(Console.ReadLine());
            for (i = 0; i < info_estudiante.Length; i++)
            {
                if (info_estudiante[i].codigo == codigo)
                {
                    info_estudiante[i].codigo = 0;
                    info_estudiante[i].nombre = "";
                    info_estudiante[i].edad = 0;
                    info_estudiante[i].genero = ' ';
                }

            }
        }

        static void busqueda_estudiantes()
        {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Busqueda de estudiantes");
                Console.WriteLine("Digite el Codigo del estudiante a buscar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < info_estudiante.Length; i++)
                {
                    if (codigo == info_estudiante[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + info_estudiante[i].codigo);
                        Console.WriteLine("Nombre:   " + info_estudiante[i].nombre);
                        Console.WriteLine("Edad:     " + info_estudiante[i].edad);
                        Console.WriteLine("Sexo:   " + info_estudiante[i].genero);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese Codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro Estudiante: 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }
        static void informe_estudiantes()
        {

            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("       Informe Clasificacion Estudiantil UH             ");
            Console.WriteLine("===============================================");
            Console.WriteLine("  Clasificaion por edad   ||   Clasificaion por genero");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Menores de edad: " + cont_menor() + "        ||        Hombres:  " + contador_hombres() + "\n");
            Console.Write("     Jovenes: " + cont_joven() + "           ||        Mujeres:  " + contador_mujeres() + "\n");
            Console.Write("     Adultos: " + cont_adult() + "           ||     " + "\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("Fin del informe");
            Console.ReadKey();
        }

        static void Main()
        {
            Console.WriteLine("Digite el monto de estudiantes a ingresar:");
            tamano = int.Parse(Console.ReadLine());
            info_estudiante = new Estudiante[tamano];
            do
            {
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("1. Ingreso de Estudiantes.");
                Console.WriteLine("2. Modificación de Estudiantes.");
                Console.WriteLine("3. Borrado de Estudiantes.");
                Console.WriteLine("4. Búsquedad de Estudiantes.");
                Console.WriteLine("5. Listado de Estudiantes.");
                Console.WriteLine("6. Informe de Clasificacion de Estudiantes.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            ingreso_estudiante();
                            break;
                        }
                    case 2:
                        {
                            modificar_estudiante();
                            break;
                        }
                    case 3:
                        {
                            borrar_estudiante();
                            break;
                        }
                    case 4:
                        {
                            busqueda_estudiantes();
                            break;
                        }
                    case 5:
                        {
                            listado_estudiantes();
                            break;
                        }
                    case 6:
                        {
                            informe_estudiantes();
                            break;
                        }
                    case 7:
                        break;
                    default:
                        {
                            Console.WriteLine("Valor inconrrecto intente de nuevo...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (opcion != 7);
        }
    }
}