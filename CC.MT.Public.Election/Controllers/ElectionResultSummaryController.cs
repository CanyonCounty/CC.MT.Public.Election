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
  /// Returns the Current Election Summary
  /// </summary>
  public class ElectionResultSummaryController : ApiController
  {
    /// <summary>
    /// Returns the Current Election Summary
    /// </summary>
    /// <returns>ResultSummary</returns>
    /// <see cref="ResultSummary"/>
    public ResultSummary GetResultSummary()
    {
      try
      {
        WebClient client = new WebClient();
        byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/ResultSummary");
        string json = Encoding.UTF8.GetString(raw);
        return JsonConvert.DeserializeObject<ResultSummary>(json);
      }
      catch (Exception e)
      {
        return new ResultSummary(e.Message);
      }
    }
  }
}
