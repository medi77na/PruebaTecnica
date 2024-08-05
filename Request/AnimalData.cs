using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Enums;
using _11_RecomendacionesProyectoBase.Models;
using _11_RecomendacionesProyectoBase.Validations;

namespace _11_RecomendacionesProyectoBase.Request;

public static class AnimalData
{
    // public Animal(string? name, DateOnly birthDate, bool breedingStatus, string? color, double weightlnkg, HairTypes furLength)


    public static string AskName()
    {
        return Validation.ValidateString("Digite el nombre de la mascota: ");
    }

    private static int AskBirthYear()
    {
        return Validation.ValidateInt("Digite el año de nacimiento: ");
    }

    private static int AskBirthMonth()
    {
        return Validation.ValidateInt("Digite el número del mes de nacimiento: ");
    }

    private static int AskBirthDay()
    {
        return Validation.ValidateInt("Digite el número del día de nacimiento: ");
    }

    public static DateOnly AskBirthDate()
    {
        return Validation.ValidateDate(DateOnly.FromDateTime(new DateTime(AskBirthYear(), AskBirthMonth(), AskBirthDay())));
    }

    public static bool AskBreedingStatus()
    {
        int option = Validation.ValidateIntRange("¿Está en estado de reproductivo? (1) Si (2) No: ", 1, 2);
        if (option == 1)
        {
            return true;
        }else
        {
            return false;
        }
    }

    public static string AskColor()
    {
        return Validation.ValidateString("Digite el color de la mascota: ");
    }

    public static double AskWeight()
    {
        return Validation.ValidateDouble("Digite el peso de la mascota (en kilogramos): ");
    }

    public static HairTypes AskFurLength()
    {
        int option = Validation.ValidateIntRangeEnum("¿Cuál es la longitud de la peloza de la mascota? (1) Corto (2) Mediano (3) Largo: ", 1, typeof(HairTypes));
        return (HairTypes)option;
    }

    public static Animal GetAnimal()
    {
        return new Animal(AskName, AskBirthDate, AskBreedingStatus, AskColor, AskWeight, AskFurLength);
    }



}
