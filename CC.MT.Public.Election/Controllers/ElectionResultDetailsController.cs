using System;
using System.Net;
using System.Text;
using System.Web.Http;
using CC.MT.Public.Election.Classes;
using Newtonsoft.Json;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// Returns the ElectionResultDetails
  /// </summary>
  public class ElectionResultDetailsController : ApiController
  {
    /// <summary>
    /// Returns the ElectionResultDetails
    /// </summary>
    /// <returns>A List of Election ResultDetails</returns>
    /// <see cref="ElectionResultDetails"/>
    public ElectionResultDetails GetResultDetail()
    {
      ElectionResultDetails list;
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/ElectionResultDetails");
        string json = Encoding.UTF8.GetString(raw);
        list = JsonConvert.DeserializeObject<ElectionResultDetails>(json);
      }
      catch (Exception e)
      {
        list = new ElectionResultDetails(e.Message);
      }
      return list;
    }
  }
}
