using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class PartyListFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy PartyList data</returns>
    public static PartyList GetPartyListSample()
    {
      Choice mickey = new Choice { Name = "Mickey Duck", Percentage = "30", VoteCount = "3" };
      Choice donald = new Choice { Name = "Donald Mouse", Percentage = "70", VoteCount = "7" };

      Contest senator = new Contest { Name = "UNITED STATES SENATOR" };
      senator.Choices.Add(mickey);
      senator.Choices.Add(donald);

      Party repub = new Party { PartyName = "REPUBLICAN PARTY" };
      repub.Contests.Add(senator);

      Choice bugs = new Choice() { Name = "Bugs Duck", Percentage = "70", VoteCount = "7" };
      Choice daffy = new Choice() { Name = "Daffy Bunny", Percentage = "30", VoteCount = "3" };

      Contest rep = new Contest() { Name = "REPRESENTATIVE IN CONGRESS DISTRICT 1" };
      rep.Choices.Add(bugs);
      rep.Choices.Add(daffy);

      Party dem = new Party() { PartyName = "DEMOCRATIC PARY" };
      dem.Contests.Add(rep);

      Choice infavor = new Choice() { Name = "IN FAVOR OF", Percentage = "", VoteCount = "" };
      Choice against = new Choice() { Name = "AGAINST", Percentage = "", VoteCount = "" };

      Contest school = new Contest() { Name = "YOUR SCHOOL BOND OR LEVEY" };
      school.Choices.Add(infavor);
      school.Choices.Add(against);

      Party none = new Party();
      none.Contests.Add(school);

      return new PartyList { repub, dem, none };
    }
  }
}