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

    protected bool breed;
    public bool Breed
    {
        get { return breed; }
        set { breed = value; }
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

    public Animal(string? name, DateOnly birthDate, bool breed, string? color, double weightlnkg)
    {
        
        Id = Guid.NewGuid();
        Name = name;
        Birthdate = birthDate;
        Breed = breed;
        Color = color;
        Weightlnkg = weightlnkg;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nombre: {Name}, Fecha de Nacimiento: {Birthdate:dd/MM/yyyy}, Raza: {Breed}, Color: {Color}, Peso: {Weightlnkg} kg";
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
}