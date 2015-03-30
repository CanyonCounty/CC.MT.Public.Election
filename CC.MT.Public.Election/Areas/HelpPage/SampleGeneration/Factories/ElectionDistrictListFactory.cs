using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class ElectionDistrictListFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy ElectionDistrictList data</returns>
    public static ElectionDistrictList GetElectionDistrictListSample()
    {
      ElectionDistrictZone edCald = new ElectionDistrictZone
      {
        Number = "132",
        Code = "SCHCA",
        Name = "Caldwell School District",
        PrecinctNo = "07-10",
        Precinct = "07",
        DistrictTypeName = "School",
        Label = "District"
      };

      ElectionDistrictZone edMid = new ElectionDistrictZone
      {
        Number = "134-2",
        Code = "SCHMDZ2",
        Name = "Middleton School District Zone 2",
        PrecinctNo = "40-11",
        Precinct = "40",
        DistrictTypeName = "School",
        Label = "Zone"
      };

      return new ElectionDistrictList() { edCald, edMid };
    }
  }
}