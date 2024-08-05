using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Models;
using _11_RecomendacionesProyectoBase.Validations;

namespace _11_RecomendacionesProyectoBase.Request;
public class CatData
{
    public static Cat AskCat()
    {
        return new Cat(AnimalData.AskName(), AnimalData.AskBirthDate(), AnimalData.AskBreedingStatus(), AnimalData.AskColor(), AnimalData.AskWeight(), AnimalData.AskFurLength());
    }
}