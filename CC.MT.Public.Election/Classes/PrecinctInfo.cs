using System;
using System.Collections.Generic;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of <see cref="PrecinctInfo"/>
  /// </summary>
  public class PrecinctInfoList : List<PrecinctInfo> { }

  /// <summary>
  /// Containing PrecinctInfo Class
  /// </summary>
  public class PrecinctInfo
  {
    /// <summary>
    /// Default Construtor
    /// </summary>
    public PrecinctInfo() : this(String.Empty) { }

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public PrecinctInfo(string error)
    {
      PollingPlaceName = String.Empty;
      LocationName = String.Empty;
      LocationDesc = String.Empty;
      CityStateZip = String.Empty;
      PrecinctNo = String.Empty;
      Latitude = 0.0m;
      Longitude = 0.0m;
      Error = error;
    }

    /// <summary>
    /// The PollingPlaceName and Address
    /// </summary>
    public string DisplayAddress { //get { return _locationName + " " + _cityState; }
      get; set; }

    /// <summary>
    /// The full address
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// The name of the polling place
    /// </summary>
    public string PollingPlaceName { get; set; }

    /// <summary>
    /// The street number and name
    /// </summary>
    public string LocationName { get; set; }

    /// <summary>
    /// Any additional information - (ie. clubhouse, north ballroom). Can be empty
    /// </summary>
    public string LocationDesc { get; set; }

    /// <summary>
    /// The City, State and Zip
    /// </summary>
    public string CityStateZip { get; set; }

    /// <summary>
    /// The full precinct number 'precinct-district' (ie. 69-13)
    /// </summary>
    public string PrecinctNo { get; set; }

    /// <summary>
    /// The Latitude of the precinct location
    /// </summary>
    public decimal Latitude { get; set; }

    /// <summary>
    /// The Longitude of the precinct location
    /// </summary>
    public decimal Longitude { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public string Error { get; set; }
  }
}