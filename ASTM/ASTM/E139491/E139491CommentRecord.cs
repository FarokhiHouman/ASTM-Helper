namespace ASTM.E139491;

public class E139491CommentRecord : E139491Record
{
#region Properties, Indexers
	public string RecordType
	{
		get => _recordType;
		set
		{
			_recordType       = value;
			E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: _recordType);
		}
	}
	public int    SequenceNumber { get; set; }
	public string CommentSource  { get; set; }
	public string CommentText    { get; set; }
	public string CommentType    { get; set; }
#endregion
#region
	private string _recordType;
#endregion
	public static E139491CommentRecord Pars(string text)
	{
		E139491CommentRecord e139491CommentRecord = new();
		string[]             strArray             = text.Split('|');
		if (strArray.Length >= 1)
		{
			e139491CommentRecord.RecordType        = strArray[0];
			e139491CommentRecord.E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: e139491CommentRecord.RecordType);
		}
		if (strArray.Length >= 2 && !string.IsNullOrWhiteSpace(value: strArray[1])) e139491CommentRecord.SequenceNumber = int.Parse(s: strArray[1]);
		if (strArray.Length >= 3) e139491CommentRecord.CommentSource                                                    = strArray[2];
		if (strArray.Length >= 4) e139491CommentRecord.CommentText                                                      = strArray[3];
		if (strArray.Length >= 5) e139491CommentRecord.CommentType                                                      = strArray[4];
		return e139491CommentRecord;
	}
	public override string ToString()
	{
		return string.Format(format: $"{base.ToString()}|{SequenceNumber}|{CommentSource}|{CommentText}|{CommentType}");
	}
}