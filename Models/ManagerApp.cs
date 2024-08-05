using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Validations;

namespace _11_RecomendacionesProyectoBase.Models;

public static class ManagerApp
{

    public static VeterinaryClinic animalClinic { get; set;} = new VeterinaryClinic("Veterinary","Street 89"); //
    public static int ShowMenu()
    {
        return Validation.ValidateIntRange(@"BIENVENIDOS A LA CLÍNICA VETERINARIA
----------------------------------------------------------------
1. Gestion para perros
2. Gestión para gatos
3. Listar todas las mascotas
4. Salir
----------------------------------------------------------------
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
                    break;
                case 4:
                    Console.WriteLine("¡Hasta luego!");
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
                    break;
                case 2:
                    // animalClinic.UpdateDog(1,);
                    break;
                case 3:
                    animalClinic.DeleteDog();
                    break;
                case 4:
                    animalClinic.ShowDogs();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (option != 5);



    }

    public static int ShowMenuByDog()
    {
        return Validation.ValidateIntRange(@"GESTIÓN DE PERROS
----------------------------------------------------------------
1. Añadir perro
2. Actualizar perro
3. Eliminar perro
4. Listar perros
5. Volver al menú principal
----------------------------------------------------------------
INGRESE LA OPCIÓN: ", 1, 5);
    }



}