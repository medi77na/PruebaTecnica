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
            new Dog("buddy", new DateOnly(2021, 1, 1), true, "blanco", 3.5, Temperaments.normal, "123456789", 2.5, "suave", HairTypes.hairless),
            new Dog("max", new DateOnly(2020, 12, 15), false, "negro", 4.0, Temperaments.shy, "987654321", 3.0, "aspero", HairTypes.mediumHair),
            new Dog("tommy", new DateOnly(2021, 3, 20), true, "marrón", 3.8, Temperaments.aggressive, "321654987", 3.2, "grueso", HairTypes.longHair),
            new Dog("bruno", new DateOnly(2021, 5, 10), false, "gris", 3.2, Temperaments.normal, "741852963", 2.8, "liso", HairTypes.shortHair)
        };
        Cats = new List<Cat>(){
            new Cat("momo", new DateOnly(2021, 2, 1), true, "blanco", 2.5, HairTypes.hairless),
            new Cat("michi", new DateOnly(2020, 11, 25), false, "negro", 3.0, HairTypes.mediumHair),
            new Cat("robert", new DateOnly(2021, 4, 10), true, "marrón", 3.8, HairTypes.longHair),
            new Cat("canelo", new DateOnly(2021, 6, 5), false, "gris", 3.2, HairTypes.shortHair),
            new Cat("topo", new DateOnly(2020, 10, 15), false, "negro", 3.0, HairTypes.mediumHair),
            new Cat("micky", new DateOnly(2021, 5, 10), true, "marrón", 3.8, HairTypes.longHair)
        };
    }
    
    public void SaveDog()
    {
        Console.WriteLine("Añadiendo un perro: ");
        Console.WriteLine("");
        Dogs.Add(DogData.AskDog());
    }

    public void UpdateDog(int position, Dog dog)
    {
        Dogs[position] = dog;
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
        Console.WriteLine(@"LISTA DE PERROS:
--------------------------------------------");
        foreach (var dog in Dogs)
        {
            Console.WriteLine(dog);
        }
    }

    public void SaveCat()
    {
        Console.WriteLine("Añadiendo un gato: ");
        Console.WriteLine("");
        Cats.Add(CatData.AskCat());
    }

    public void UpdateCat(int position, Cat cat)
    {
        Cats[position] = cat;
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

    public void ShowCats()
    {
        Console.WriteLine(@"LISTA DE GATOS:
--------------------------------------------");
        foreach (var cat in Cats)
        {
            Console.WriteLine(cat);
        }
    }


    // public List<object> ShowAll()
    // {
    //     return Dogs.Join(Cats);
    // }
}