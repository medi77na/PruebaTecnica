using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_RecomendacionesProyectoBase.Enums;

namespace _11_RecomendacionesProyectoBase.Models
{
    public class Dog : Animal
    {
        public Temperaments Temperament { get; set; }
        public string? MicroshipNumber { get; set; }
        public double BarkVolume { get; set; }
        public string? CoatType { get; set; }

        public Dog(string? name, DateOnly birthDate, bool breedingStatus, string? color, double weightlnkg, Temperaments temperament, string? microshipNumber, double barkVolume, string? coatType, HairTypes furLength)
        : base(name, birthDate, breedingStatus, color, weightlnkg, furLength)
        {
            Temperament = temperament;
            MicroshipNumber = microshipNumber;
            BarkVolume = barkVolume;
            CoatType = coatType;
        }

        public override void Hairdress()
        {
            if (FurLength == HairTypes.hairless)
            {
                Console.WriteLine($"No podemos peluquear a {name} porque no tiene pelo...");
            }
            else if (FurLength == HairTypes.shortHair)
            {
                Console.WriteLine($"No podemos peluquear a {name} porque tiene pelo corto...");
            }
            else
            {
                Console.WriteLine($"Hemos peluqueado a {name} exitosamente...");
                FurLength = HairTypes.hairless;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Name}, Fecha de nacimiento: {Birthdate}, Estado de reproductividad: {(BreedingStatus? "Si" : "No")}, Color: {Color}, Peso: {Weightlnkg} kg, Temperamento: {Temperament}, Microchip: {MicroshipNumber}, Volumen de ladrar: {BarkVolume} dB, Tipo de pelaje: {CoatType}, Longitud de pelo: {FurLength}";
        }
    }
}