namespace HallOfBeorn.Models.Scenarios
{
    public class EncounterAtAmonDin : Scenario
    {
        public EncounterAtAmonDin()
        {
            Title = "Encounter at Amon Dîn";
            ProductName = "Encounter at Amon Dîn";
            GroupName = "Against the Shadow";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/against-the-shadow-quest-encounter-at-amon-din.html";

            AddEncounterSet(EncounterSet.EncounterAtAmonDin);
            AddEncounterSet(EncounterSet.EncounterAtAmonDinNightmare);
            AddEncounterSet(EncounterSet.RavagingOrcs);

            AddQuestCardId("Savagery-of-the-Orcs-EaAD");
            AddQuestCardId("Protect-the-Villagers-EaAD");

            ExcludeFromEasyMode("Burnt-Homestead-EaAD", 2);
            ExcludeFromEasyMode("Craven-Eagle-EaAD", 2);
            ExcludeFromEasyMode("Orc-Rabble-HoN", 3);

            ExcludeFromNightmareMode("Burning-Farmhouse-EaAD", 2);
            ExcludeFromNightmareMode("Craven-Eagle-EaAD", 2);
            ExcludeFromNightmareMode("Gondorian-Hamlet-EaAD", 2);
            ExcludeFromNightmareMode("Marauding-Orc-EaAD", 1);
            ExcludeFromNightmareMode("Orc-Ravager-EaAD", 3);
            ExcludeFromNightmareMode("Panicked-EaAD", 2);
            ExcludeFromNightmareMode("Trapped-Inside-EaAD", 2);
            ExcludeFromNightmareMode("Orc-Rabble-HoN", 1);
            ExcludeFromNightmareMode("Scourge-of-Mordor-HoN", 2);
        }
    }
}
