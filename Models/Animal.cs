using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_RecomendacionesProyectoBase.Models;
public abstract class Animal
{

    protected Guid id;
    public Guid Id
    {
        get { return id; }
        set { id = value; }
    }

    protected string? name;
    public string? Name
    {
        get { return name; }
        set { name = value; }
    }

    protected DateOnly birthDate;
    public DateOnly Birthdate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }

    protected bool breedingStatus;
    public bool BreedingStatus
    {
        get { return breedingStatus; }
        set { breedingStatus = value; }
    }

    protected string? color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    private double weightlnkg;
    public double Weightlnkg
    {
        get { return weightlnkg; }
        set { weightlnkg = value; }
    }

    public Animal(string? name, DateOnly birthDate, bool breedingStatus, string? color, double weightlnkg)
    {
        Id = Guid.NewGuid();
        Name = name;
        Birthdate = birthDate;
        BreedingStatus = breedingStatus;
        Color = color;
        Weightlnkg = weightlnkg;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Name}, Fecha de Nacimiento: {Birthdate:dd/MM/yyyy}, Raza: {BreedingStatus}, Color: {Color}, Peso: {Weightlnkg} kg";
    }

    public int CalculateAgeInMonths()
    {
        int ageInMonths = DateTime.Now.Month - Birthdate.Month;
        if (DateTime.Now.Day < Birthdate.Day || (DateTime.Now.Day == Birthdate.Day && DateTime.Now.Month < Birthdate.Month))
        {
            ageInMonths--;
        }
        return ageInMonths;
    }

    public void CastrateAnimal()
    {
        if (BreedingStatus)
        {
            Console.WriteLine($"No podemos VOLVER a castrar a {name}...");
            
        }
        else
        {
            Console.WriteLine($"{name} ha sido castrad@ con éxito...");
            BreedingStatus = true;
        }
    }
    public abstract void Hairdress();
}