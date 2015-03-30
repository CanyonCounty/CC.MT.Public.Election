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
  /// The Result Details in a single row per choice. Parsing isn't fun some times
  /// </summary>
  public class ElectionResultDetailsFlatController : ApiController
  {
    /// <summary>
    /// The Result Details in a single row per choice
    /// </summary>
    /// <returns>A List of ResultDetail</returns>
    /// <see cref="ResultDetail"/>
    public IQueryable<ResultDetail> GetResultDetail()
    {
      List<ResultDetail> list = new ResultDetailList();
      try
      {
        //WebClient client = new WebClient();
        //byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/ResultDetails");
        //string json = Encoding.UTF8.GetString(raw);
        CCProxy proxy = new CCProxy();
        string json = proxy.GetJSONFromPath("/Election/ResultDetails");
        list = JsonConvert.DeserializeObject<List<ResultDetail>>(json);
      }
      catch (Exception e)
      {
        list.Add(new ResultDetail(e.Message));
      }
      return list.AsQueryable();
    }

  }
}
