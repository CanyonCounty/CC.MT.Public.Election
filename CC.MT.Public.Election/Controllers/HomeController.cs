using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// HomeController
  /// </summary>
  public class HomeController : Controller
  {
    /// <summary>
    /// Index Action
    /// </summary>
    /// <returns>A Page or null and a Redirect</returns>
    public ActionResult Index()
    {
#if DEBUG
      string path = String.Empty;

      //path = "/AllPrecinctInfo";
      //path = "/DistrictNames";
      //path = "/ElectionDistrictPrecincts";
      //path = "/ElectionDistrictZones";
      //path = "/ElectionResultDetails";
      //path = "/NextElection";
      //path = "/PrecinctComplete";
      //path = "/ElectionResultSummary";
      path = "/ElectionResultDetailsFlat";

      Response.Redirect(Request.AppRelativeCurrentExecutionFilePath + path);
      return null;
#else
      return View();
#endif
    }
  }
}
