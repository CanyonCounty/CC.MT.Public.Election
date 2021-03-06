﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CC.MT.Proxy;
using CC.MT.Public.Election.Classes;
using Newtonsoft.Json;

namespace CC.MT.Public.Election.Controllers
{
  /// <summary>
  /// Returns a list of districts and/or zones for every precinct in the current election
  /// </summary>
  public class ElectionDistrictZonesController : ApiController
  {
    /// <summary>
    /// Get the ElectionDistrictZone List
    /// </summary>
    /// <returns>A List of Election District and Zone</returns>
    /// <see cref="ElectionDistrictZone"/>
    public IQueryable<ElectionDistrictZone> GetResultDetail()
    {
      List<ElectionDistrictZone> list = new ElectionDistrictList();
      try
      {
        //WebClient client = new WebClient();
        //byte[] raw = client.DownloadData("http://ccmtprod08.canyonco.org/Election/ElectionDistrictZones");
        //string json = Encoding.UTF8.GetString(raw);
        CCProxy proxy = new CCProxy();
        string json = proxy.GetJSONFromPath("/Election/ElectionDistrictZones");
        list = JsonConvert.DeserializeObject<List<ElectionDistrictZone>>(json);
      }
      catch (Exception e)
      {
        list.Add(new ElectionDistrictZone(e.Message));
      }
      return list.AsQueryable();
    }
  }
}
