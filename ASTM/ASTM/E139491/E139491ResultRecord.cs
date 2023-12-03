using System;


namespace ASTM.E139491;

public class E139491ResultRecord : E139491Record
{
#region Properties, Indexers
	public string    RecordType                 { get; set; }
	public int       SequenceNumber             { get; set; }
	public string    UniversalTestId            { get; set; }
	public string    DataMeasurement            { get; set; }
	public string    Units                      { get; set; }
	public string    ReferenceRanges            { get; set; }
	public string    ResultAbnormalFlag         { get; set; }
	public string    NatureOfAbnormalityTesting { get; set; }
	public string    ResultStatus               { get; set; }
	public string    DateOfChange               { get; set; }
	public string    OperatorIdentification     { get; set; }
	public string    DateTimeTestStarted        { get; set; }
	public DateTime? DateTimeTestCompleted      { get; set; }
	public string    InstrumentIdentification   { get; set; }
#endregion
	public static E139491ResultRecord Parse(string text)
	{
		E139491ResultRecord e139491ResultRecord = new();
		string[]            strArray            = text.Split('|');
		if (strArray.Length >= 1)
		{
			e139491ResultRecord.RecordType        = strArray[0];
			e139491ResultRecord.E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: e139491ResultRecord.RecordType);
		}
		if (strArray.Length >= 2 && !string.IsNullOrWhiteSpace(value: strArray[1])) e139491ResultRecord.SequenceNumber = int.Parse(s: strArray[1]);
		if (strArray.Length >= 3) e139491ResultRecord.UniversalTestId                                                  = strArray[2];
		if (strArray.Length >= 4) e139491ResultRecord.DataMeasurement                                                  = strArray[3];
		if (strArray.Length >= 5) e139491ResultRecord.Units                                                            = strArray[4];
		if (strArray.Length >= 6) e139491ResultRecord.ReferenceRanges                                                  = strArray[5];
		if (strArray.Length >= 7) e139491ResultRecord.ResultAbnormalFlag                                               = strArray[6];
		if (strArray.Length >= 8) e139491ResultRecord.NatureOfAbnormalityTesting                                       = strArray[7];
		if (strArray.Length >= 9) e139491ResultRecord.ResultStatus                                                     = strArray[8];
		if (strArray.Length >= 10) e139491ResultRecord.DateOfChange                                                    = strArray[9];
		if (strArray.Length >= 11) e139491ResultRecord.OperatorIdentification                                          = strArray[10];
		if (strArray.Length >= 12) e139491ResultRecord.DateTimeTestStarted                                             = strArray[11];
		if (strArray.Length >= 13 && !string.IsNullOrWhiteSpace(value: strArray[12]))
			e139491ResultRecord.DateTimeTestCompleted = E139491Utility.GetAstmDateTimeValue(text: strArray[12]);
		if (strArray.Length >= 14) e139491ResultRecord.InstrumentIdentification = strArray[13];
		return e139491ResultRecord;
	}
	public override string ToString()
	{
		string str                              = "";
		if (DateTimeTestCompleted.HasValue) str = E139491Utility.GetAstmDateTimeString(dateTime: DateTimeTestCompleted.Value);
		return $"{(object)base.ToString()}|{(object)SequenceNumber}|{(object)UniversalTestId}|{(object)DataMeasurement}|" +
			   Units                                                                                                      +
			   "|"                                                                                                        +
			   ReferenceRanges                                                                                            +
			   "|"                                                                                                        +
			   ResultAbnormalFlag                                                                                         +
			   "|"                                                                                                        +
			   NatureOfAbnormalityTesting                                                                                 +
			   "|"                                                                                                        +
			   ResultStatus                                                                                               +
			   "|"                                                                                                        +
			   DateOfChange                                                                                               +
			   "|"                                                                                                        +
			   OperatorIdentification                                                                                     +
			   "|"                                                                                                        +
			   DateTimeTestStarted                                                                                        +
			   "|"                                                                                                        +
			   str                                                                                                        +
			   "|"                                                                                                        +
			   InstrumentIdentification;
	}
}