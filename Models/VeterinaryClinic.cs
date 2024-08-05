using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    public void SaveDog(Dog dog)
    {
        Dogs.Add(dog);
    }

    public void UpdateDog(int position, Dog dog)
    {
        Dogs[position] = dog;
    }

    public void DeleteDog(Dog dog)
    {
        Dogs.Remove(dog);
    }


    public void SaveCat(Cat cat)
    {
        Cats.Add(cat);
    }

    public void UpdateCat(int position, Cat cat)
    {
        Cats[position] = cat;
    }

    public void DeleteCat(Cat cat)
    {
        Cats.Remove(cat);
    }

    // public List<object> ShowAll()
    // {
    //     return Dogs.Join(Cats);
    // }

    public List<Dog> ShowDogs()
    {
        return Dogs;
    }
    public List<Cat> ShowCats()
    {
        return Cats;
    }
}