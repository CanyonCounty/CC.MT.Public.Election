using System.Web;
using System.Web.Mvc;

namespace CC.MT.Public.Election
{
  /// <summary>
  /// Filter Config
  /// </summary>
  public class FilterConfig
  {
    /// <summary>
    /// Register Global Filters
    /// </summary>
    /// <param name="filters">GlobalFilterCollection</param>
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}