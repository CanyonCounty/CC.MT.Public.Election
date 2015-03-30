using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CC.MT.Public.Election.Classes;
using Newtonsoft.Json;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// Returns information for the next election
  /// </summary>
  public class NextElectionController : ApiController
  {
    /// <summary>
    /// Returns information for the next election
    /// </summary>
    /// <returns>ElectionInfo for the next election</returns>
    /// <see cref="ElectionInfo"/>
    public ElectionInfo GetNextElection()
    {
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/NextElection");
        string json = Encoding.UTF8.GetString(raw);
        return JsonConvert.DeserializeObject<ElectionInfo>(json);
      }
      catch (Exception e)
      {
        return new ElectionInfo(e.Message);
      }
    }
  }
}
