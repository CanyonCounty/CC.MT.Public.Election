using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// Returns all district name information
  /// </summary>
  public class DistrictNamesController : ApiController
  {
    /// <summary>
    /// Get the District Names List
    /// </summary>
    /// <returns>A List of District Information</returns>
    /// <see cref="DistrictNames"/>
    public IQueryable<DistrictNames> GetDistrictNames()
    {
      List<DistrictNames> list = new DistrictNamesList();
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/DistrictNames");
        string json = Encoding.UTF8.GetString(raw);
        list = JsonConvert.DeserializeObject<List<DistrictNames>>(json);
      }
      catch (Exception e)
      {
        list.Add(new DistrictNames(e.Message));
      }
      return list.AsQueryable();
    }
  }
}
