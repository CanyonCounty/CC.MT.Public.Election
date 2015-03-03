using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CC.Common.Data;
using System.Globalization;

namespace CC.MT.Public.Election
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
    private string _displayAddress;
    private string _address;
    private string _pollingPlaceName;
    private string _locationName;
    private string _locationDesc;
    private string _cityState;
    private string _precinctNo;
    private decimal _latitude;
    private decimal _longitude;
    private string _error;

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
      _pollingPlaceName = String.Empty;
      _locationName = String.Empty;
      _locationDesc = String.Empty;
      _cityState = String.Empty;
      _precinctNo = String.Empty;
      _latitude = 0.0m;
      _longitude = 0.0m;
      _error = error;
    }

    /// <summary>
    /// The PollingPlaceName and Address
    /// </summary>
    public string DisplayAddress
    {
      //get { return _locationName + " " + _cityState; }
      get { return _displayAddress; }
      set { _displayAddress = value; }
    }

    /// <summary>
    /// The full address
    /// </summary>
    public string Address
    {
      get { return _address; }
      set { _address = value; }
    }

    /// <summary>
    /// The name of the polling place
    /// </summary>
    public string PollingPlaceName
    {
      get { return _pollingPlaceName; }
      set { _pollingPlaceName = value; }
    }

    /// <summary>
    /// The street number and name
    /// </summary>
    public string LocationName
    {
      get { return _locationName; }
      set { _locationName = value; }
    }

    /// <summary>
    /// Any additional information - (ie. clubhouse, north ballroom). Can be empty
    /// </summary>
    public string LocationDesc
    {
      get { return _locationDesc; }
      set { _locationDesc = value; }
    }

    /// <summary>
    /// The City, State and Zip
    /// </summary>
    public string CityStateZip
    {
      get { return _cityState; }
      set { _cityState = value; }
    }

    /// <summary>
    /// The full precinct number 'precinct-district' (ie. 69-13)
    /// </summary>
    public string PrecinctNo
    {
      get { return _precinctNo; }
      set { _precinctNo = value; }
    }

    /// <summary>
    /// The Latitude of the precinct location
    /// </summary>
    public decimal Latitude
    {
      get { return _latitude; }
      set { _latitude = value; }
    }

    /// <summary>
    /// The Longitude of the precinct location
    /// </summary>
    public decimal Longitude
    {
      get { return _longitude; }
      set { _longitude = value; }
    }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public string Error
    {
      get { return _error; }
      set { _error = value; }
    }

    //public override string ToString()
    //{
    //  string ret = String.Empty;

    //  ret += _pollingPlaceName;
    //  if (_locationName != String.Empty)
    //    ret += " " + _locationName;
    //  if (_locationDesc != String.Empty)
    //    ret += " " + _locationDesc;

    //  ret += " " + _cityState;

    //  //if (_precinctNo != String.Empty)
    //  //  ret += "    Precinct: " + _precinctNo;

    //  //ret = ret.ToLower();
    //  //return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(ret);
    //  return ret;
    //}
  }
}