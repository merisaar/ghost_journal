﻿
using System.Collections.Generic;

namespace GhostJournal
{
    public abstract class Ghost
    {
        public Evidence EvidenceList { get; set; }
        public string Name { get; set; }
        public string UniqueStrength { get; set; }
        public string Weaknesses { get; set; }
        public string Description { get; set; }

        public sealed override string ToString()
        {
            return Name;
        }
    }
    public class Mare : Ghost
    {
        public Mare()
        {
            Name = "Mare";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.SpiritBox,
                EvidenceCategory.GhostOrb,
                EvidenceCategory.FreezingTemperatures
                }
            );
            UniqueStrength = "A Mare will have an increased chance to attack in the dark.";
            Weaknesses = "Turning the lights on around the Mare will lower it’s chance to attack.";
            Description = "A Mare is the source of all nightmares, making it most powerful in the dark.";
        }
    }
    public class Spirit : Ghost
    {
        public Spirit()
        {
            Name = "Spirit";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.SpiritBox,
                EvidenceCategory.GhostWriting,
                EvidenceCategory.FingerPrints
                }
            );
            UniqueStrength = "Nothing.";
            Weaknesses = "Using Smudge Sticks on a Spirit will stop it attacking for a long period of time.";
            Description = "A spirit is the most common Ghost you will come across however it is still very powerful and dangerous. They are usually discovered at one of their hunting grounds after an unexplained death.";
        }
    }
    public class Wraith : Ghost
    {
        public Wraith()
        {
            Name = "Wraith";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.FreezingTemperatures,
                EvidenceCategory.SpiritBox,
                EvidenceCategory.FingerPrints
                }
            );
            UniqueStrength = "Wraiths almost never touch the ground meaning it can’t be tracked by footsteps.";
            Weaknesses = "Wraiths have a toxic reaction to Salt";
            Description = "A Wraith is one of the most dangerous Ghosts you will find. It is also the only known Ghost that has the ability of flight and has sometimes been known to travel through walls.";
        }
    }
    public class Phantom : Ghost
    {
        public Phantom()
        {
            Name = "Phantom";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.EMFLevel5,
                EvidenceCategory.GhostOrb,
                EvidenceCategory.FreezingTemperatures
                }
            );
            UniqueStrength = "Looking at a Phantom will considerably drop your sanity.";
            Weaknesses = "Taking a photo of the Phantom will make it temporarily disappear.";
            Description = "A spirit is the most common Ghost you will come across however it is still very powerful and dangerous. They are usually discovered at one of their hunting grounds after an unexplained death.";
        }
    }
    public class Poltergeist : Ghost
    {
        public Poltergeist()
        {
            Name = "Poltergeist";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.SpiritBox,
                EvidenceCategory.FingerPrints,
                EvidenceCategory.GhostOrb
                }
            );
            UniqueStrength = "A Poltergeist can throw huge amounts of objects at once.";
            Weaknesses = "A Poltergeist is almost ineffective in an empty room";
            Description = "One of the most famous Ghosts, a Poltergeist, also known as a noisy ghost can manipulate objects around it to spread fear into it’s victims.";
        }
    }
    public class Banshee : Ghost
    {
        public Banshee()
        {
            Name = "Banshee";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.EMFLevel5,
                EvidenceCategory.FingerPrints,
                EvidenceCategory.FreezingTemperatures
                }
            );
            UniqueStrength = "A Banshee will only target one person at a time.";
            Weaknesses = "Banshees fear the Crucifix and will be less aggressive when near one.";
            Description = "A Banshee is a natural hunter and will attack anything. It has been known to stalk it’s prey one at a time until making it’s kill.";
        }
    }
    public class Jinn : Ghost
    {
        public Jinn()
        {
            Name = "Jinn";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.SpiritBox,
                EvidenceCategory.GhostOrb,
                EvidenceCategory.EMFLevel5
                }
            );
            UniqueStrength = "A Jinn will travel at a faster speed if it’s victim is far away.";
            Weaknesses = "Turning off the locations power source will prevent the Jinn from using it’s ability";
            Description = "A Jinn is territorial Ghost that will attack when threatened. It has also been known to be able to travel at significant speed.";
        }
    }
    public class Revenant : Ghost
    {
        public Revenant()
        {
            Name = "Revenant";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.EMFLevel5,
                EvidenceCategory.FingerPrints,
                EvidenceCategory.GhostWriting
                }
            );
            UniqueStrength = " A Revenant will travel at a significantly faster speed when hunting a victim.";
            Weaknesses = "Hiding from the Revenant will cause it to move very slowly.";
            Description = "A Revenant is a slow but violent Ghost that will attack indiscriminately. It has been rumoured to travel at a significantly high speed when hunting.";
        }
    }

    public class Shade : Ghost
    {
        public Shade()
        {
            Name = "Shade";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.EMFLevel5,
                EvidenceCategory.GhostOrb,
                EvidenceCategory.GhostWriting
                }
            );
            UniqueStrength = "Being shy means the Ghost will be harder to find.";
            Weaknesses = " The Ghost will not enter hunting mode if there is multiple people nearby.";
            Description = "A Shade is known to be a Shy Ghost. There is evidence that a Shade will stop all paranormal activity if there are multiple people nearby.";
        }
    }
    public class Demon : Ghost
    {
        public Demon()
        {
            Name = "Demon";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.SpiritBox,
                EvidenceCategory.GhostWriting,
                EvidenceCategory.FreezingTemperatures
                }
            );
            UniqueStrength = "Demons will attack more often then any other Ghost.";
            Weaknesses = "Asking a Demon successful questions on the Ouija Board won’t lower the users sanity.";
            Description = "A Demon is one of the worst Ghosts you can encounter. It has been known to attack without a reason.";
        }
    }
    public class Yurei : Ghost
    {
        public Yurei()
        {
            Name = "Yurei";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.GhostWriting,
                EvidenceCategory.FreezingTemperatures,
                EvidenceCategory.GhostOrb
                }
            );
            UniqueStrength = "Yurei’s have been known to have a stronger effect on people’s sanity.";
            Weaknesses = "Smudging the Yurei’s room will cause it to not wander around the location for a long time.";
            Description = "A Yurei is a Ghost that has returned to the physical world, usually for the purpose of revenge or hatred";
        }
    }
    public class Oni : Ghost
    {
        public Oni()
        {
            Name = "Oni";
            EvidenceList =
                new Evidence(new List<EvidenceCategory>() {
                EvidenceCategory.EMFLevel5,
                EvidenceCategory.SpiritBox,
                EvidenceCategory.GhostWriting
                }
            );
            UniqueStrength = "Oni’s are more active when people are nearby and have been seen moving objects at great speed.";
            Weaknesses = "Being more active will make the Oni easier to find and identify.";
            Description = "Oni’s are a cousin to the Demon and possess the extreme strength. There have been rumours that they become more active around their prey.";
        }
    }
    
}
