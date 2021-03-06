﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamCard
    {
        private ArkhamCard()
        {
            Cost = ArkhamCardCost.NA;
            Level = Level.NA;
            AssetSlot = AssetSlot.NA;
        }

        private readonly List<string> traits = new List<string>();
        private readonly List<string> keywords = new List<string>();
        private readonly List<SkillIcon> skillIcons = new List<SkillIcon>();

        public ArkhamProduct Product { get; set; }
        public ArkhamDeckType DeckType { get; set; }
        public ArkhamCardType CardType { get; set; }
        public string Name { get; protected set; }
        public bool IsUnique { get; protected set; }

        public byte Willpower { get; protected set; }
        public byte Intellect { get; protected set; }
        public byte Combat { get; protected set; }
        public byte Agility { get; protected set; }
        public ArkhamCardCost Cost { get; protected set; }
        public Level Level { get; protected set; }
        public AssetSlot AssetSlot { get; protected set; }
        public Shroud? Shroud { get; protected set; }
        public ClueValue? ClueValue { get; protected set; }

        public string FrontText { get; protected set; }
        public string FrontFlavor { get; protected set; }
        public string BackText { get; private set; }
        public string BackFlavor { get; private set; }

        public ushort Number { get; protected set; }
        public byte Quanity { get; protected set; }
        public Artist Artist { get; protected set; }

        public string Subtitle { get; private set; }
        public ArkhamClass Class { get; private set; }
        public byte Health { get; private set; }
        public byte Sanity { get; private set; }
        public byte VictoryPoints { get; private set; }
        public ArkhamEncounterSet EncounterSet { get; private set; }

        protected void addTraits(IEnumerable<string> traits)
        {
            this.traits.AddRange(traits);
        }

        protected void addKeywords(IEnumerable<string> keywords)
        {
            this.keywords.AddRange(keywords);
        }

        protected void addSkillIcons(IEnumerable<SkillIcon> skillIcons)
        {
            this.skillIcons.AddRange(skillIcons);
        }

        public static string GetSlug(ArkhamCard card)
        {
            var name = card.Name.ToUrlSafeString();
            var level = (card.Level != Level.NA && card.Level != Level.Zero) ? ((sbyte)card.Level).ToString() : string.Empty;
            var product = card.Product.Abbreviation;
            return string.Format("{0}{1}-{2}", name, level, product);
        }

        public string Slug
        {
            get { return GetSlug(this); }
        }

        public IEnumerable<string> Traits()
        {
            return traits;
        }

        public IEnumerable<string> Keywords()
        {
            return keywords;
        }

        public IEnumerable<SkillIcon> SkillIcons()
        {
            return skillIcons;
        }

        public static ArkhamCard Investigator(string name, string nickName, ArkhamClass cl, byte health, byte sanity)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Investigator,
                DeckType = ArkhamDeckType.Player,
                Name = name,
                IsUnique = true,
                Subtitle = nickName,
                Class = cl,
                Health = health,
                Sanity = sanity
            };
        }

        public static ArkhamCard Asset(string name, ArkhamClass cl, ArkhamCardCost cost, AssetSlot assetSlot)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Asset,
                DeckType = ArkhamDeckType.Player,
                Name = name,
                Class = cl,
                Cost = cost,
                AssetSlot = assetSlot
            };
        }

        public static ArkhamCard Event(string name, ArkhamClass cl, ArkhamCardCost cost, Level level)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Event,
                DeckType = ArkhamDeckType.Player,
                Name = name,
                Class = cl,
                Cost = cost,
                Level = level
            };
        }

        public static ArkhamCard Location(string name, Shroud shroud, ClueValue clueValue, ArkhamEncounterSet encounterSet)
        {
            return new ArkhamCard()
            {
                CardType = ArkhamCardType.Location,
                DeckType = ArkhamDeckType.Encounter,
                Name = name,
                Shroud = shroud,
                ClueValue = clueValue,
                EncounterSet = encounterSet
            };
        }

        public ArkhamCard WithUnique()
        {
            this.IsUnique = true;
            return this;
        }

        public ArkhamCard WithSubtitle(string subtitle)
        {
            this.Subtitle = subtitle;
            return this;
        }

        public ArkhamCard WithTraits(params string[] traits)
        {
            addTraits(traits);
            return this;
        }

        public ArkhamCard WithKeywords(params string[] keywords)
        {
            addKeywords(keywords);
            return this;
        }

        public ArkhamCard WithCost(ArkhamCardCost cost)
        {
            this.Cost = cost;
            return this;
        }

        public ArkhamCard WithLevel(Level level)
        {
            this.Level = level;
            return this;
        }

        public ArkhamCard WithAssetSlot(AssetSlot assetSlot)
        {
            this.AssetSlot = assetSlot;
            return this;
        }

        public ArkhamCard WithVictoryPoints(byte victoryPoints)
        {
            this.VictoryPoints = victoryPoints;
            return this;
        }

        /*
        public ArkhamCard WithWillpower(byte willpower)
        {
            addSkill(Skill.Willpower, willpower);
            return this;
        }

        public ArkhamCard WithIntellect(byte intellect)
        {
            addSkill(Skill.Intellect, intellect);
            return this;
        }

        public ArkhamCard WithCombat(byte combat)
        {
            addSkill(Skill.Combat, combat);
            return this;
        }

        public ArkhamCard WithAgility(byte agility)
        {
            addSkill(Skill.Agility, agility);
            return this;
        }*/

        public ArkhamCard WithSkills(byte willpower, byte intellect, byte combat, byte agility)
        {
            this.Willpower = willpower;
            this.Intellect = intellect;
            this.Combat = combat;
            this.Agility = agility;
            return this;
        }

        public ArkhamCard WithSkillIcons(params SkillIcon[] skillIcons)
        {
            addSkillIcons(skillIcons);
            return this;
        }

        public ArkhamCard WithShroud(byte value, bool perInvestigator, bool isVariable)
        {
            this.Shroud = new Shroud { Value = value, PerInvestigator = perInvestigator, IsVariable = isVariable };
            return this;
        }

        public ArkhamCard WithClueValue(byte value, bool perInvestigator, bool isVariable)
        {
            this.ClueValue = new ClueValue { Value = value, PerInvestigator = perInvestigator, IsVariable = isVariable };
            return this;
        }

        public ArkhamCard WithFrontText(string text)
        {
            this.FrontText = text;
            return this;
        }

        public ArkhamCard WithFrontFlavor(string flavor)
        {
            this.FrontFlavor = flavor;
            return this;
        }

        public ArkhamCard WithBackText(string text)
        {
            this.BackText = text;
            return this;
        }

        public ArkhamCard WithBackFlavor(string flavor)
        {
            this.BackFlavor = flavor;
            return this;
        }

        public ArkhamCard WithInfo(byte number, byte quantity, Artist artist)
        {
            this.Number = number;
            this.Quanity = quantity;
            this.Artist = artist;
            return this;
        }
    }
}