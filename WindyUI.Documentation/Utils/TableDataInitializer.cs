using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindyUI.Documentation.Utils
{
    public record MammalData(string Name, double WeightInKilos, int LifespanInYears, string Habitat, string PrimaryLocation);

    public static class TableDataInitializer
    {
        public static List<MammalData> GetMammalData()
        {
            return new List<MammalData>
            {
                new MammalData("Dog", 25.9, 12, "Human Settlements", "The Entire World"),
                new MammalData("Cat", 6.5, 16, "Human Settlements", "The Entire World"),
                new MammalData("Gorilla", 226.8, 39, "Montane Rainforest", "Sub-Saharan Africa"),
                new MammalData("Cow", 1100, 22, "Grasslands", "The Entire World"),
                new MammalData("Tiger", 150, 9, "Mangrove Swamps and Rainforests", "Continental Asia"),
                new MammalData("Lion", 270, 12, "Human Settlements", "East and Southern Africa"),
                new MammalData("Zebra", 367, 25, "Grasslands and Savannas", "East and Southern Africa"),
                new MammalData("Horse", 752, 30, "Plains, prairies and steppes", "The Entire World"),
                new MammalData("Elephant", 4752, 60, "Grasslands, Deserts and Highlands", "Africa"),
                new MammalData("Platypus", 1.56, 17, "Rivers and Lakes", "Australia"),
                new MammalData("Beaver", 32, 10, "Lakes, Rivers and Marshes", "Continental Europe"),
            };
        }
    }
}
