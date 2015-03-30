using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CC.MT.Proxy;
using CC.MT.Public.Election.Classes;
using Newtonsoft.Json;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// Returns a list of districts and/or zones that are in the current election with associated precincts
  /// </summary>  
  public class ElectionDistrictPrecinctsController : ApiController
  {
    /// <summary>
    /// Get the Election District Precincts List
    /// </summary>
    /// <returns>A List of District and/or Zone for the current election as well as the precincts involved.</returns>
    /// <see cref="ElectionDistrictPrecincts"/>
    public IQueryable<ElectionDistrictPrecincts> GetResultDetail()
    {
      List<ElectionDistrictPrecincts> list = new ElectionDistrictPrecinctsList();
      try
      {
        //WebClient client = new WebClient();
        //byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/ElectionDistrictPrecincts");
        //string json = Encoding.UTF8.GetString(raw);
        CCProxy proxy = new CCProxy();
        string json = proxy.GetJSONFromPath("/Election/ElectionDistrictPrecincts");
        list = JsonConvert.DeserializeObject<List<ElectionDistrictPrecincts>>(json);
      }
      catch (Exception e)
      {
        list.Add(new ElectionDistrictPrecincts(e.Message));
      }
      return list.AsQueryable();
    }
  }
}
