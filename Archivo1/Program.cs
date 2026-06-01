/*Almacenar 10 registros de estudiantes: nombre, carrera y promedio*/

Estudiante[] estudiante = new Estudiante[10];

int Menu()
{
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Mostrar");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Digita tu opcion: ");
    return int.Parse(Console.ReadLine());
}

void pedirDatos()
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Nombre: ");
        estudiante[i].nombre = Console.ReadLine();
        Console.Write("Carrera: ");
        estudiante[i].carrera = Console.ReadLine();
        Console.Write("Promedio: ");
        estudiante[i].promedio = Double.Parse(Console.ReadLine());
    }
}

void mostrarDatos()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{estudiante[i].nombre} | {estudiante[i].carrera} | {estudiante[i].promedio}");
    }
}

void main()
{
    int op;
    do
    {
        op = Menu();
        switch (op)
        {
            case 1:
                pedirDatos();
                break;
            case 2:
                    mostrarDatos();
                break;
            case 3:
                Console.WriteLine("Adios...");
                break;
            default:
                Console.WriteLine("Opcion Invalida");
                break;
        }
    } while (op != 3);
}
main();
struct Estudiante
{
   public string nombre;
   public string carrera;
   public double promedio;
}
