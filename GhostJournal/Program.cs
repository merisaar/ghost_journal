using System;
using System.Collections.Generic;
using System.Linq;

namespace GhostJournal
{
    static class EvidenceCategoryStatic
    {
        public const string SpiritBox = "Spirit Box";
        public const string FingerPrints = "Fingerprints";
        public const string GhostWriting = "Ghost Writing";
        public const string FreezingTemperatures = "Freezing Temperatures";
        public const string EMFLevel5 = "EMF Level 5";
        public const string GhostOrb = "Ghost Orb";
    }
    public class Evidence
    {
        public Evidence(List<EvidenceCategory> evidenceCategories)
        {
            Evidences = evidenceCategories;
        }

        public List<EvidenceCategory> Evidences { get; set; }
    }
    public enum EvidenceCategory
    {
       SpiritBox = 1,
       FingerPrints = 2,
       GhostWriting = 3,
       FreezingTemperatures = 4,
       EMFLevel5 = 5,
       GhostOrb = 6,
    }

    class Program
    {
        private static List<Ghost> ghosts = new List<Ghost>();
        static void Main(string[] args)
        {
            ghosts.AddRange(new List<Ghost>(){ new Spirit(), new Wraith(), new Phantom(), new Poltergeist(),
                new Banshee(), new Jinn(), new Mare(), new Revenant(), new Shade(),
                new Demon(), new Yurei(), new Oni()});
            var quit = false;
            while (!quit)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Hey. Choose from the list. If you choose multiple separate them with comma: \n" +
                    EvidenceCategoryStatic.SpiritBox + " 1 \n" +
                    EvidenceCategoryStatic.FingerPrints + " 2 \n" +
                    EvidenceCategoryStatic.GhostWriting + " 3 \n" +
                    EvidenceCategoryStatic.FreezingTemperatures + " 4 \n" +
                    EvidenceCategoryStatic.EMFLevel5 + " 5 \n" +
                    EvidenceCategoryStatic.GhostOrb + " 6 \n" +
                    "Or type Q to quit. \n ");
                Console.WriteLine("------------------");

                var filteredGhosts = ghosts;
                var input = Console.ReadLine();
                if (input.ToLower() == "q") { quit = true; break; }
                try
                {
                    var categories = input.Split(',');
                    List<EvidenceCategory> evidences = new List<EvidenceCategory>();
                    foreach(var category in categories) 
                    {
                        var number = Int32.Parse(category);
                        evidences.Add((EvidenceCategory)number);
                    };
                    filteredGhosts = ghosts.Where(ghost => evidences.All(evidence => ghost.EvidenceList.Evidences.Contains(evidence))).ToList();
                }
                catch (Exception e)
                {
                    Console.WriteLine(input + " is not on the list. Please try again. \n");
                    continue;
                }
                 Console.WriteLine();
                if (filteredGhosts.Count == 0) Console.WriteLine("No ghosts found matching to criteria.");
                filteredGhosts.ForEach(ghost => {
                    Console.WriteLine(ghost.ToString());
                    if (filteredGhosts.Count <= 3)
                    {
                        Console.WriteLine("Description: ");
                        Console.WriteLine(ghost.Description);
                        Console.WriteLine();
                    };
                    if (filteredGhosts.Count <= 2)
                    {
                        Console.WriteLine("Weaknesses: ");
                        Console.WriteLine(ghost.Weaknesses);
                        Console.WriteLine();
                        Console.WriteLine("Unique strength: ");
                        Console.WriteLine(ghost.UniqueStrength);
                        Console.WriteLine();
                        Console.WriteLine();

                    };

                    }
                );
            }
        }
    }
}
