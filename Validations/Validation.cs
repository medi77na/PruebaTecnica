using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Models;
using _11_RecomendacionesProyectoBase.Request;

namespace _11_RecomendacionesProyectoBase.Validations;
public class Validation
{

    public static string ValidateString(string text)
    {
        bool bandera = true;
        string? value;
        do
        {
            Console.Write(text);
            value = Console.ReadLine().Trim().ToLower();
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: El campo -{text}- no puede estar vacío.");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                bandera = false;
            }
        } while (bandera);
        return value;
    }

    public static double ValidateDouble(string text)
    {
        bool bandera = true;
        double result = 0;
        do
        {
            Console.Write(text);
            string? value = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(value) || !Double.TryParse(value, out result))
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: El campo -{text}- no fue digtado correctamente.");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                bandera = false;
            }
        } while (bandera);
        return result;
    }

    public static int ValidateInt(string text)
    {
        bool bandera = true;
        int result = 0;
        do
        {
            Console.Write(text);
            string? value = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(value) || !int.TryParse(value, out result))
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: El campo -{text}- no fue digitado correctamente.");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                bandera = false;
            }
        } while (bandera);
        return result;
    }

    public static int ValidateIntRange(string text, int min, int max)
    {
        bool flag;
        int number;

        do
        {
            number = ValidateInt(text);
            if (number >= min && number <= max)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("El número ingresado está fuera del rango, digitelo nuevamente...");
                VisualInterfaceProgram.WaitForKey();
                flag = true;
            }
        } while (flag);

        return number;
    }

    public static int ValidateIntRangeList(string text, int min, List<Object> list)
    {
        bool flag;
        int number;

        do
        {
            number = ValidateInt(text);
            if (number >= min && number <= list.Count())
            {
                flag = false;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("El número ingresado está fuera del rango, digitelo nuevamente...");
                VisualInterfaceProgram.WaitForKey();
                flag = true;
            }
        } while (flag);
        return number;
    }

    public static int ValidateIntRangeEnum(string text, int min, Type enumType)
    {
        bool flag;
        int number;

        do
        {
            number = ValidateInt(text);
            if (number >= min && number <= Enum.GetValues(enumType).Length)
            {
                flag = false;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("El número ingresado está fuera del rango, digitelo nuevamente...");
                VisualInterfaceProgram.WaitForKey();
                flag = true;
            }
        } while (flag);
        return number;
    }

    public static DateOnly ValidateDate()
    {
        bool flag = true;
        DateOnly date;

        do
        {
            date = DateOnly.FromDateTime(new DateTime(AnimalData.AskBirthYear(), AnimalData.AskBirthMonth(), AnimalData.AskBirthDay()));
            if (date.Month > DateTime.Now.Month && date.Year > DateTime.Now.Year)
            {
                Console.WriteLine(" ");
                Console.WriteLine("La fecha ingresada no es válida, digitelo nuevamente...");
                VisualInterfaceProgram.WaitForKey();
            }
            else
            {
                flag = false;
            }
        } while (flag);
        return date;
    }
}