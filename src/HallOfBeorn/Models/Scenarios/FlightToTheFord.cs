namespace HallOfBeorn.Models.Scenarios
{
    public class FlightToTheFord : Scenario
    {
        public FlightToTheFord()
        {
            Title = "Flight to the Ford";
            ProductName = "The Black Riders";
            GroupName = "The Lord of the Rings";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/lotr-the-black-riders-quest-flight-to-the-ford.html";

            AddEncounterSet(EncounterSet.FlightToTheFord);
            AddEncounterSet(EncounterSet.FlightToTheFordNightmare);
            AddEncounterSet(EncounterSet.Hunted);
            AddEncounterSet(EncounterSet.TheBlackRiders);
            AddEncounterSet(EncounterSet.TheNazgul);

            AddQuestCardId("Pursued-by-the-Enemy-TBR");
            AddQuestCardId("Race-To-Rivendell-TBR");

            ExcludeFromEasyMode("The-Enemy-is-Upon-Us-TBR", 2);
            ExcludeFromEasyMode("The-Nine-are-Abroad-TBR", 1);
            ExcludeFromEasyMode("Piercing-Cry-TBR", 2);
            ExcludeFromEasyMode("Black-Steed-TBR", 2);
            ExcludeFromEasyMode("Pale-Blade-TBR", 2);
            ExcludeFromEasyMode("Power-In-Their-Terror-TBR", 2);
            ExcludeFromEasyMode("Ringwraith-TBR", 2);

        }
    }
}
