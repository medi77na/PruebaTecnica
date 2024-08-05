using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        Dogs = new List<Dog>();
        Cats = new List<Cat>();
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

    public void SaveCat(Cat cat)
    {
        Console.WriteLine("Añadiendo un gato: ");
        Console.WriteLine("");
        Cats.Add(CatData.AskCat());
    }

    public void UpdateCat(int position, Cat cat)
    {
        Cats[position] = cat;
    }

    public void DeleteCat(Cat cat)
    {
        Cats.Remove(cat);
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

    public void ShowDogs()
    {
        Console.WriteLine(@"LISTA DE PERROS:
--------------------------------------------");
        foreach (var dog in Dogs)
        {
            Console.WriteLine(dog);
        }
    }


    // public List<object> ShowAll()
    // {
    //     return Dogs.Join(Cats);
    // }


    public List<Cat> ShowCats()
    {
        return Cats;
    }
}