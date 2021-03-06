namespace HallOfBeorn.Models.Scenarios
{
    public class JourneyAlongTheAnduin : Scenario
    {
        public JourneyAlongTheAnduin()
        {
            Title = "Journey Along the Anduin";
            AlternateTitle = "Journey Down the Anduin";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 2;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/core-set-quest-journey-down-the-anduin.html";

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduinNightmare);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("To-the-River-Core");
            AddQuestCardId("Anduin-Passage-Core");
            AddQuestCardId("Ambush-on-the-Shore-Core");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Gladden-Fields-Core", 2);
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

            ExcludeFromNightmareMode("Evil-Storm-Core", 3);
            ExcludeFromNightmareMode("Treacherous-Fog-Core", 2);
            ExcludeFromNightmareMode("Banks-of-the-Anduin-Core", 2);
            ExcludeFromNightmareMode("Dol-Guldur-Orcs-Enemy-Core", 3);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Despair-Core", 2);
            ExcludeFromNightmareMode("Misty-Mountain-Goblins-Core", 3);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 2);
        }
    }
}
