using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class ElectionDistrictPrecinctsListFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy ElectionDistrictPrecinctsList data</returns>
    public static ElectionDistrictPrecinctsList GetElectionDistrictPrecinctsListSample()
    {
      ElectionDistrictPrecincts elpCald = new ElectionDistrictPrecincts
      {
        Name = "Caldwell School District",
        Precinct = "07,08,09,10,11,12,13,14,15,16,17,18,20,33,34,39"
      };

      ElectionDistrictPrecincts elpValli = new ElectionDistrictPrecincts
      {
        Name = "Vallivue School District",
        Precinct = "08,12,16,18,19,26,27,30,31,32,33,34,35,37,43,49,50,51,52,53,54,55"
      };

      return new ElectionDistrictPrecinctsList() { elpCald, elpValli };
    }
  }
}