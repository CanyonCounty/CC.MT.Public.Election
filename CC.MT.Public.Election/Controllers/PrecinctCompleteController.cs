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
  /// Returns a list of precincts for the current election. It also specifies if counting has been completed
  /// </summary>
  public class PrecinctCompleteController : ApiController
  {
    /// <summary>
    /// Returns a list of precincts for the current election. It also specifies if counting has been completed
    /// </summary>
    /// <returns>PrecinctComplete</returns>
    /// <see cref="PrecinctComplete"/>
    public IQueryable<PrecinctComplete> GetPrecinctComplete()
    {
      List<PrecinctComplete> list = new PrecinctCompleteList();
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/PrecinctComplete");
        string json = Encoding.UTF8.GetString(raw);
        list = JsonConvert.DeserializeObject<List<PrecinctComplete>>(json);
      }
      catch (Exception e)
      {
        list.Add(new PrecinctComplete(e.Message));
      }
      return list.AsQueryable();
    }

  }
}
