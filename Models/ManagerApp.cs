using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Validations;

namespace _11_RecomendacionesProyectoBase.Models;

public static class ManagerApp
{

    public static VeterinaryClinic animalClinic { get; set; } = new VeterinaryClinic("Veterinary", "Street 89"); //
    public static int ShowMenu()
    {
        Console.Clear();
        return Validation.ValidateIntRange(@"BIENVENIDOS A LA CLÍNICA VETERINARIA
---------------------------------------------------------------------------------------------------------
1. Gestion para perros
2. Gestión para gatos
3. Listar todas las mascotas
4. Salir
---------------------------------------------------------------------------------------------------------
INGRESE LA OPCIÓN: ", 1, 4);
    }

    public static void MainMenu()
    {
        int option;
        do
        {
            option = ShowMenu();
            switch (option)
            {
                case 1:
                    MenuByDog();
                    Console.Clear();
                    break;
                case 2:
                    MenuByCat();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    ShowPets();
                    VisualInterfaceProgram.WaitForKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.WriteLine("¡Hasta luego!");
                    VisualInterfaceProgram.WaitForKey();
                    Console.Clear();
                    break;
                default:
                    break;
            }
        } while (option != 4);
    }

    public static void MenuByDog()
    {
        int option;
        do
        {
            option = ShowMenuByDog();

            switch (option)
            {
                case 1:
                    animalClinic.SaveDog();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 2:
                    animalClinic.UpdateDog();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 3:
                    animalClinic.DeleteDog();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 4:
                    ShowHeaderPets();
                    animalClinic.ShowDogs();
                    Separators();
                    VisualInterfaceProgram.WaitForKey();
                    Console.Clear();
                    break;
                case 5:
                    animalClinic.CastrateDog();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 6:
                    animalClinic.HairdresDog();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (option != 7);
    }

    public static int ShowMenuByDog()
    {
        Console.Clear();
        return Validation.ValidateIntRange(@"GESTIÓN DE PERROS
---------------------------------------------------------------------------------------------------------
1. Añadir perro
2. Actualizar perro
3. Eliminar perro
4. Listar perros
5. Castrar perro
6. Motilar perro
7. Volver al menú principal
---------------------------------------------------------------------------------------------------------
INGRESE LA OPCIÓN: ", 1, 7);
    }

    public static void MenuByCat()
    {
        int option;
        do
        {
            option = ShowMenuByCat();

            switch (option)
            {
                case 1:
                    animalClinic.SaveCat();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 2:
                    animalClinic.UpdateCat();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 3:
                    animalClinic.DeleteCat();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 4:
                    ShowHeaderPets();
                    animalClinic.ShowCats();
                    Separators();
                    VisualInterfaceProgram.WaitForKey();
                    Console.Clear();
                    break;
                case 5:
                    animalClinic.CastrateCat();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 6:
                    animalClinic.HairdresCat();
                    VisualInterfaceProgram.WaitForKey();
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (option != 7);
    }

    public static int ShowMenuByCat()
    {
        Console.Clear();
        return Validation.ValidateIntRange(@"GESTIÓN DE GATOS
---------------------------------------------------------------------------------------------------------
1. Añadir gato
2. Actualizar gato
3. Eliminar gato
4. Listar gatos
5. Castrar gato
6. Motilar gato
7. Volver al menú principal
---------------------------------------------------------------------------------------------------------
INGRESE LA OPCIÓN: ", 1, 7);
    }

    public static void ShowPets()
    {
        Console.WriteLine("LISTA DE MASCOTAS EN LA CLÍNICA:");
        Console.WriteLine($"Nombre: {animalClinic.Name}");
        Console.WriteLine($"Dirección: {animalClinic.Address}");
        Separators();
        Console.WriteLine("PERROS:");
        ShowHeaderPets();
        animalClinic.ShowDogs();
        Separators();
        Console.WriteLine("GATOS:");
        ShowHeaderPets();
        animalClinic.ShowCats();
        Separators();
    }

    public static void ShowHeaderPets()
    {
        Separators();
        Console.WriteLine("| ID |  Nombre  | Fecha de nacimiento | Estado reproductivo |   Color   |    Peso    | Longitud de pelo |");
        Separators();
    }

    public static void Separators()
    {
        Console.WriteLine("---------------------------------------------------------------------------------------------------------");
    }


}