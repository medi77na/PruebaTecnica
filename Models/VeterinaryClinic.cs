using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Enums;
using _11_RecomendacionesProyectoBase.Request;
using _11_RecomendacionesProyectoBase.Validations;
using Microsoft.VisualBasic;

namespace _11_RecomendacionesProyectoBase.Models;
public class VeterinaryClinic
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Cat> Cats { get; set; }

    public VeterinaryClinic()
    {

    }
    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
        Dogs = new List<Dog>(){
            new Dog("buddy", new DateOnly(2021, 1, 1), true, "blanco", 3.5, Temperaments.normal, "123456789", 2.5, HairTypes.hairless),
            new Dog("max", new DateOnly(2020, 12, 15), false, "negro", 4.0, Temperaments.shy, "987654321", 3.0, HairTypes.mediumHair),
            new Dog("tommy", new DateOnly(2021, 3, 20), true, "marrón", 3.8, Temperaments.aggressive, "321654987", 3.2, HairTypes.longHair),
            new Dog("bruno", new DateOnly(2021, 5, 10), false, "gris", 3.2, Temperaments.normal, "741852963", 2.8, HairTypes.shortHair)
        };
        Cats = new List<Cat>(){
            new Cat("momo", new DateOnly(2021, 2, 1), true, "blanco", 2.5, HairTypes.hairless),
            new Cat("michi", new DateOnly(2020, 11, 25), false, "negro", 3.0, HairTypes.mediumHair),
            new Cat("canelo", new DateOnly(2021, 6, 5), false, "gris", 3.2, HairTypes.shortHair),
            new Cat("micky", new DateOnly(2021, 5, 10), true, "marrón", 3.8, HairTypes.longHair)
        };
    }

    public void SaveDog()
    {
        Console.WriteLine("Añadiendo un perro: ");
        Console.WriteLine("");
        Dogs.Add(DogData.AskDog());
    }

    public void UpdateDog()
    {
        Console.WriteLine("ACTUALIZANDO UN PERRO: ");
        Console.WriteLine("");
        Dog dog = SearchDogById();
        int option = ShowDogProperties();
        switch (option)
        {
            case 1:
                dog.Name = AnimalData.AskName();
                break;
            case 2:
                dog.Birthdate = AnimalData.AskBirthDate();
                break;
            case 3:
                dog.BreedingStatus = AnimalData.AskBreedingStatus();
                break;
            case 4:
                dog.Color = AnimalData.AskColor();
                break;
            case 5:
                dog.Weightlnkg = AnimalData.AskWeight();
                break;
            case 6:
                dog.Temperament = DogData.AskTemperament();
                break;
            case 7:
                dog.MicroshipNumber = DogData.AskMicroshipNumber();
                break;
            case 8:
                dog.BarkVolume = DogData.AskBarkVolume();
                break;
            case 9:
                dog.FurLength = AnimalData.AskFurLength();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                VisualInterfaceProgram.WaitForKey();
                break;
        }
    }

    public int ShowDogProperties()
    {
        return Validation.ValidateIntRange(@"(1) Nombre
(2) Fecha de nacimiento
(3) Estado de reproductivo
(4) Color
(5) Peso
(6) Temperamento
(7) Microchip
(8) Volumen de ladrar
(9) Longitud de pelo
--------------------------------------------------------
Digite la opción: ", 1, 9);
    }

    public void DeleteDog()
    {
        Console.WriteLine("Eliminando un perro: ");
        Console.WriteLine("");
        Dogs.Remove(SearchDogById());
    }

    public Dog SearchDogById()
    {
        bool flag = true;
        Dog dog;

        do
        {
            int id = Validation.ValidateInt("Ingrese el ID del perro: ");
            dog = Dogs.Find(d => d.Id == id);
            if (dog != null)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("No se encontró un perro con ese ID.");
                VisualInterfaceProgram.WaitForKey();
            }
        } while (flag);
        return dog;
    }

    public void ShowDogs()
    {
        foreach (var dog in Dogs)
        {
            Console.WriteLine(dog);
        }
    }

    public void CastrateDog()
    {
        Console.WriteLine("Castrando un perro: ");
        Console.WriteLine("");
        Dog dog = SearchDogById();
        dog.CastrateAnimal();
    }

    public void HairdresDog()
    {
        Console.WriteLine("BARBERÍA CANINA: ");
        Console.WriteLine("");
        Dog dog = SearchDogById();
        dog.Hairdress();
    }

    public void SaveCat()
    {
        Console.WriteLine("Añadiendo un gato: ");
        Console.WriteLine("");
        Cats.Add(CatData.AskCat());
    }

    public void UpdateCat()
    {
        Console.WriteLine("ACTUALIZANDO UN GATO: ");
        Console.WriteLine("");
        Cat cat = SearchCatById();
        int option = ShowCatProperties();
        switch (option)
        {
            case 1:
                cat.Name = AnimalData.AskName();
                break;
            case 2:
                cat.Birthdate = AnimalData.AskBirthDate();
                break;
            case 3:
                cat.BreedingStatus = AnimalData.AskBreedingStatus();
                break;
            case 4:
                cat.Color = AnimalData.AskColor();
                break;
            case 5:
                cat.Weightlnkg = AnimalData.AskWeight();
                break;
            case 6:
                cat.FurLength = AnimalData.AskFurLength();
                break;
            default:
                Console.WriteLine("Opción inválida.");
                VisualInterfaceProgram.WaitForKey();
                break;
        }
    }

    public int ShowCatProperties()
    {
        return Validation.ValidateIntRange(@"(1) Nombre
(2) Fecha de nacimiento
(3) Estado de reproductivo
(4) Color
(5) Peso
(6) Longitud de pelo
--------------------------------------------------------
Digite la opción: ", 1, 6);
    }

    public void DeleteCat()
    {
        Console.WriteLine("Eliminando un gato: ");
        Console.WriteLine("");
        Cats.Remove(SearchCatById());
    }

    public Cat SearchCatById()
    {
        bool flag = true;
        Cat cat;

        do
        {
            int id = Validation.ValidateInt("Ingrese el ID del gato: ");
            cat = Cats.Find(c => c.Id == id);
            if (cat != null)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine("No se encontró un gato con ese ID.");
                VisualInterfaceProgram.WaitForKey();
            }
        } while (flag);
        return cat;
    }

    public void CastrateCat()
    {
        Console.WriteLine("Castrando un gato: ");
        Console.WriteLine("");
        Cat cat = SearchCatById();
        cat.CastrateAnimal();
    }

    public void ShowCats()
    {
        foreach (var cat in Cats)
        {
            Console.WriteLine(cat);
        }
    }

    public void HairdresCat()
    {
        Console.WriteLine("BARBERÍA FELINA: ");
        Console.WriteLine("");
        Cat cat = SearchCatById();
        cat.Hairdress();
    }

}