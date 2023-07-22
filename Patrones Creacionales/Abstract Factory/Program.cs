using System.Reflection;
using Abstract_Factory.ConcreteFactory;
using Abstract_Factory.Interfaces;
using Abstract_Factory.Models;
using static System.Console;

//Normalmente estos tipos de fábrica se inicializa al inicio de un programa
//indicando el tipo de fábrica con el que se trabajará

AbstractFactory factory = null;
int opcion = 0;
WriteLine("Bienvenido a la creacion de fabricas dinamicas\nSeleccione el tipo de fabrica");

WriteLine("Seleccione el tipo de fabrica");
Menu();
opcion = int.Parse(ReadLine());


switch (opcion)
{
    case 1:
        factory = new ArtFactory();
        break;

    case 2:
    factory = new ModernaFactory();    
        break;

    case 3:
    factory = new VictorianaFactory();
        break;

    default:
        WriteLine("Opcion no valida");
        break;
}

if (factory is null){
    return ; //terminar ejecucion del programa si ninguna opción es seleccionada
}


PrintObjectAsTable(factory.CrearSofa());

void Menu()
{
    WriteLine("1. Fabrica Artistica");
    WriteLine("2. Fabrica Moderna");
    WriteLine("3. Fabrica Victoriana");
}

static void PrintObjectAsTable(object obj)
    {
        Type type = obj.GetType();
        PropertyInfo[] properties = type.GetProperties();

        Console.WriteLine($"{"Atributos", -20} {"Value"}");

        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(obj);
            string attributeName = property.Name;

            if (value != null)
            {
                string valueString = value.ToString();
                Console.WriteLine($"{attributeName, -20} {valueString}");
            }
        }
    }