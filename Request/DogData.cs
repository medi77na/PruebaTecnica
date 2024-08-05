using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Enums;
using _11_RecomendacionesProyectoBase.Models;
using _11_RecomendacionesProyectoBase.Validations;

namespace _11_RecomendacionesProyectoBase.Request;
public static class DogData
{

    public static Temperaments AskTemperament()
    {
        int option = Validation.ValidateIntRangeEnum("¿Cuál es el tipo de temperamento de la mascota? (1) Tímido (2) Normal (3) Agresivo: ", 1, typeof(Temperaments));
        return (Temperaments)option;
    }

    public static string? AskMicroshipNumber()
    {
        return Validation.ValidateString("¿Cuál es el número de microchip de la mascota?: ");
    }

    public static double AskBarkVolume()
    {
        return Validation.ValidateDouble("¿Cuál es el volumen de ladrar de la mascota en decibelios?: ");
    }

    public static string? AskCoatType()
    {
        return Validation.ValidateString("¿Cuál es el tipo de pelaje de la mascota?: ");
    }

    public static Dog AskDog()
    {
        return new Dog(AnimalData.AskName(), AnimalData.AskBirthDate(), AnimalData.AskBreedingStatus(), AnimalData.AskColor(), AnimalData.AskWeight(), AskTemperament(), AskMicroshipNumber(), AskBarkVolume(), AskCoatType(), AnimalData.AskFurLength());
    }
}
