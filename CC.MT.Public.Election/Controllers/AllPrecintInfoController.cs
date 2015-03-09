using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http;
using CC.MT.Public.Election.Classes;
using Newtonsoft.Json;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// Returns all precinct information.
  /// </summary>
  public class AllPrecinctInfoController : ApiController
  {
    /// <summary>
    /// Get the Precinct Info List
    /// </summary>
    /// <returns>A List of Precinct Information</returns>
    /// <see cref="PrecinctInfo"/>
    public IQueryable<PrecinctInfo> GetAllPrecinctInfo()
    {
      List<PrecinctInfo> list = new PrecinctInfoList();
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/AllPrecinctInfo");
        string json = Encoding.UTF8.GetString(raw);
        list = JsonConvert.DeserializeObject<List<PrecinctInfo>>(json);
      }
      catch (Exception e)
      {
        list.Add(new PrecinctInfo(e.Message));
      }
      return list.AsQueryable();
    }
  }
}
