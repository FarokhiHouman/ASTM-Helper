namespace ASTM.E139491;

public class E139491MessageTerminatorRecord : E139491Record
{
#region Properties, Indexers
	public string RecordType     { get; set; }
	public int    SequenceNumber { get; set; }
	public string TerminatorCode { get; set; }
#endregion
	/// <summary>
	///     Parses a string and creates an instance of E139491MessageTerminatorRecord.
	/// </summary>
	/// <param name="text">The string to parse.</param>
	/// <returns>An instance of E139491MessageTerminatorRecord.</returns>
	public static E139491MessageTerminatorRecord Parse(string text)
	{
		E139491MessageTerminatorRecord terminatorRecord = new();
		string[]                       strArray         = text.Split('|');
		terminatorRecord.RecordType        = strArray[0];
		terminatorRecord.E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: terminatorRecord.RecordType);
		terminatorRecord.SequenceNumber    = int.Parse(s: strArray[1]);
		terminatorRecord.TerminatorCode    = strArray[2];
		return terminatorRecord;
	}
	/// <summary>
	///     Overrides the ToString() method to return a string representation of the object.
	/// </summary>
	/// <returns>
	///     A string representation of the object, including the base ToString() result, the SequenceNumber, and the
	///     TerminatorCode.
	/// </returns>
	public override string ToString()
	{
		return $"{(object)base.ToString()}|{(object)SequenceNumber}|{(object)TerminatorCode}";
	}
}