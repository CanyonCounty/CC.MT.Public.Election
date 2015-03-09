using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CC.MT.Public.Election
{
  /// <summary>
  /// A List of <see cref="ElectionDistrictZone"/>
  /// </summary>
  public class ElectionDistrictList : List<ElectionDistrictZone> { }

  /// <summary>
  /// Containing ElectionDistrictZone Class
  /// </summary>
  public class ElectionDistrictZone
  {
    private string _number;
    private string _code;
    private string _name;
    private string _precinctNo;
    private string _precinct;
    private string _precinctID;
    private string _districtTypeName;
    private string _label;
    private string _error;

    /// <summary>
    /// Default Construtor
    /// </summary>
    public ElectionDistrictZone() : this(String.Empty) { }

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public ElectionDistrictZone(string error)
    {
      _number = String.Empty;
      _code = String.Empty;
      _name = String.Empty;
      _precinctNo = String.Empty;
      _precinct = String.Empty;
      _precinctID = String.Empty;
      _districtTypeName = String.Empty;
      _label = String.Empty;
      _error = error;
    }

    /// <summary>
    /// The District and/or Zone number
    /// </summary>
    public String Number
    {
      get { return _number; }
      set { _number = value; }
    }

    /// <summary>
    /// The District and/or Zone Code (used for ballot type)
    /// </summary>
    public String Code
    {
      get { return _code; }
      set { _code = value; }
    }

    /// <summary>
    /// The District and/or Zone name
    /// </summary>
    public String Name
    {
      get { return _name; }
      set { _name = value; }
    }

    /// <summary>
    /// The full precinct number 'precinct-district' (ie. 69-13)
    /// </summary>
    public String PrecinctNo
    {
      get { return _precinctNo; }
      set { _precinctNo = value; }
    }

    /// <summary>
    /// The short precinct number 'precinct' (ie. 69) zero padded
    /// </summary>
    public String Precinct
    {
      get { return _precinct; }
      set { _precinct = value; }
    }

    /// <summary>
    /// The precinct ID
    /// </summary>
    [IgnoreDataMember]
    public String PrecinctID
    {
      get { return _precinctID; }
      set { _precinctID = value; }
    }

    /// <summary>
    /// The type of the district
    /// </summary>
    public String DistrictTypeName
    {
      get { return _districtTypeName; }
      set { _districtTypeName = value; }
    }

    /// <summary>
    /// Specifies District or Zone
    /// </summary>
    public String Label
    {
      get { return _label; }
      set { _label = value; }
    }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error
    {
      get { return _error; }
      set { _error = value; }
    }
  }
}