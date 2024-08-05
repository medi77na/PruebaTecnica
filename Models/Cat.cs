using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Models.Enums;

namespace _11_RecomendacionesProyectoBase.Models
{
    public class Cat : Animal
    {

        public HairTypes? FurLength { get; set; } 

        public Cat(string? name, DateOnly birthDate, bool breedingStatus, string? color, double weightlnkg, HairTypes furLength)
        : base(name, birthDate, breedingStatus, color, weightlnkg)
        {
            FurLength = furLength;
        }

        public override void Hairdress()
        {
            if (FurLength == HairTypes.hairless)
            {
                Console.WriteLine($"No podemos peluquear a {name} porque no tiene pelo...");
            }else
            {
                Console.WriteLine($"Hemos peluqueado a {name} exitosamente...");
                FurLength = HairTypes.hairless;
            }
        }
    }
}