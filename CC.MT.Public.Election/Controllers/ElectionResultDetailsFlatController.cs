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
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/ResultDetails");
        string json = Encoding.UTF8.GetString(raw);
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
