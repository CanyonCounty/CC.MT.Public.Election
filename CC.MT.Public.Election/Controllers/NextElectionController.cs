using System;
using System.Web.Http;
using CC.MT.Proxy;
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
        //WebClient client = new WebClient();
        //byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/NextElection");
        //string json = Encoding.UTF8.GetString(raw);
        CCProxy proxy = new CCProxy();
        string json = proxy.GetJSONFromPath("/Election/NextElection");
        return JsonConvert.DeserializeObject<ElectionInfo>(json);
      }
      catch (Exception e)
      {
        return new ElectionInfo(e.Message);
      }
    }
  }
}
