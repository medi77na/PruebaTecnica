using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_RecomendacionesProyectoBase.Operations;
public class DisplayTraverse
{

    public static void DisplayEnums(Type enumType)
    {
        foreach (var position in Enum.GetValues(enumType))
        {
            Console.WriteLine($"{((int)position) + 1}. {position}");
        }
    }
}