using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CC.MT.Public.Election
{
  /// <summary>
  /// A List of <see cref="DistrictNames"/>
  /// </summary>
  public class DistrictNamesList : List<DistrictNames> { }

  /// <summary>
  /// Containing DistrictNames Class
  /// </summary>
  public class DistrictNames
  {
    private string _districtNo;
    private string _districtCode;
    private string _districtName;
    private string _districtTypeName;
    private string _error;

    /// <summary>
    /// Default Construtor
    /// </summary>
    public DistrictNames() : this(String.Empty) { }

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public DistrictNames(string error)
    {
      _districtNo = String.Empty;
      _districtCode = String.Empty;
      _districtName = String.Empty;
      _districtTypeName = String.Empty;
      _error = error;
    }

    /// <summary>
    /// The District Number
    /// </summary>
    public String DistrictNo
    {
      get { return _districtNo; }
      set { _districtNo = value; }
    }

    /// <summary>
    /// The District Code (used for ballot type)
    /// </summary>
    public String DistrictCode
    {
      get { return _districtCode; }
      set { _districtCode = value; }
    }

    /// <summary>
    /// The name of the district
    /// </summary>
    public String DistrictName
    {
      get { return _districtName; }
      set { _districtName = value; }
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
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error
    {
      get { return _error; }
      set { _error = value; }
    }
  }
}