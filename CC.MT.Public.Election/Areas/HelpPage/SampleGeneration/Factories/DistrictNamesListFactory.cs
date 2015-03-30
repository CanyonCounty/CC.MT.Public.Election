using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class DistrictNamesListFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy DistrictNamesList data</returns>
    public static DistrictNamesList GetDistrictNamesListSample()
    {
      DistrictNames schca = new DistrictNames
      {
        DistrictNo = "132",
        DistrictCode = "SCHCA",
        DistrictName = "Caldwell School District",
        DistrictTypeName = "School"
      };

      DistrictNames leg13 = new DistrictNames
      {
        DistrictNo = "13",
        DistrictCode = "LEG13",
        DistrictName = "Legislative District 13",
        DistrictTypeName = "Legislative"
      };

      return new DistrictNamesList() { schca, leg13 };
    }
  }
}