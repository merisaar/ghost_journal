using System;
using System.Collections.Generic;
using System.Linq;

namespace GhostJournal
{
    static class EvidenceCategoryPresentation
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
                Console.WriteLine("Choose evidence from the list. " +
                    "If you choose multiple evidence, separate them with a comma: \n" +
                    EvidenceCategoryPresentation.SpiritBox + ": 1 \n" +
                    EvidenceCategoryPresentation.FingerPrints + ": 2 \n" +
                    EvidenceCategoryPresentation.GhostWriting + ": 3 \n" +
                    EvidenceCategoryPresentation.FreezingTemperatures + ": 4 \n" +
                    EvidenceCategoryPresentation.EMFLevel5 + ": 5 \n" +
                    EvidenceCategoryPresentation.GhostOrb + ": 6 \n" +
                    "Or type Q to quit. \n ");
                Console.WriteLine("------------------");

                List<EvidenceCategory> evidenceList = new List<EvidenceCategory>();
                var filteredGhosts = ghosts;
                var input = Console.ReadLine();
                if (input.ToLower() == "q") { quit = true; break; }
                try
                {
                    var categories = input.Split(',');

                    foreach (var category in categories)
                    {
                        var number = Int32.Parse(category);
                        evidenceList.Add((EvidenceCategory)number);
                    };
                    filteredGhosts = ghosts.Where(ghost => evidenceList.All(evidence => ghost.EvidenceList.Evidences.Contains(evidence))).ToList();
                }
                catch (Exception)
                {
                    Console.WriteLine(input + " is not on the list. Please try again. \n");
                    continue;
                }
                Console.WriteLine();
                if (filteredGhosts.Count == 0) Console.WriteLine("No ghosts found matching the criteria.");
                filteredGhosts.ForEach(ghost =>
                {
                    Console.WriteLine(ghost.ToString().ToUpper());
                    if (filteredGhosts.Count <= 3)
                    {
                        var missingEvidence = ghost.EvidenceList.Evidences.Where(e => !evidenceList.Contains(e)).ToList();
                        Console.WriteLine("Missing evidence: ");
                        missingEvidence.ForEach(missing => Console.WriteLine(MapCategoryToString(missing)));
                        Console.WriteLine();
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
                    };

                }
                );
            }
            string MapCategoryToString(EvidenceCategory category)
            {
                switch (category)
                {
                    case EvidenceCategory.EMFLevel5:
                        return EvidenceCategoryPresentation.EMFLevel5;
                    case EvidenceCategory.FingerPrints:
                        return EvidenceCategoryPresentation.FingerPrints;
                    case EvidenceCategory.FreezingTemperatures:
                        return EvidenceCategoryPresentation.FreezingTemperatures;
                    case EvidenceCategory.GhostOrb:
                        return EvidenceCategoryPresentation.GhostOrb;
                    case EvidenceCategory.GhostWriting:
                        return EvidenceCategoryPresentation.GhostWriting;
                    case EvidenceCategory.SpiritBox:
                        return EvidenceCategoryPresentation.SpiritBox;
                    default:
                        throw new Exception($"Category {category} is not supported");
                }
            }
        }
    }
}
