using System;
using System.Text;


namespace ASTM.E139491;

public class E139491MessageHeaderRecord : E139491Record
{
#region Properties, Indexers
	public string   RecordType              { get; set; }
	public string   DelimitersDefinition    { get; set; }
	public string   MessageControlId        { get; set; }
	public string   AccessPassword          { get; set; }
	public string   SenderNameOrId          { get; set; }
	public string   SenderStreetAddress     { get; set; }
	public string   ReservedField           { get; set; }
	public string   SenderPhoneNumber       { get; set; }
	public string   CharacteristicsOfSender { get; set; }
	public string   ReceiverId              { get; set; }
	public string   CommentOrSpecialIns     { get; set; }
	public string   ProcessingId            { get; set; }
	public string   VersionNumber           { get; set; }
	public DateTime MessageDateAndTime      { get; set; }
#endregion
	public static E139491MessageHeaderRecord Pars(string text)
	{
		E139491MessageHeaderRecord record   = new();
		string[]                   strArray = text.Split('|');
		int                        length   = Math.Min(val1: strArray.Length, val2: 14);
		for (int i = 0; i < length; i++)
		{
			string strArrayMember = strArray[i];
			switch (i)
			{
				case 0:
					record.RecordType        = strArrayMember;
					record.E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: record.RecordType);
					break;
				case 1:
					record.DelimitersDefinition = strArrayMember;
					break;
				case 2:
					record.MessageControlId = strArrayMember;
					break;
				case 3:
					record.AccessPassword = strArrayMember;
					break;
				case 4:
					record.SenderNameOrId = strArrayMember;
					break;
				case 5:
					record.SenderStreetAddress = strArrayMember;
					break;
				case 6:
					record.ReservedField = strArrayMember;
					break;
				case 7:
					record.SenderPhoneNumber = strArrayMember;
					break;
				case 8:
					record.CharacteristicsOfSender = strArrayMember;
					break;
				case 9:
					record.ReceiverId = strArrayMember;
					break;
				case 10:
					record.CommentOrSpecialIns = strArrayMember;
					break;
				case 11:
					record.ProcessingId = strArrayMember;
					break;
				case 12:
					record.VersionNumber = strArrayMember;
					break;
				case 13 when !string.IsNullOrWhiteSpace(value: strArrayMember):
					record.MessageDateAndTime = E139491Utility.GetAstmDateTimeValue(text: strArrayMember);
					break;
			}
		}
		return record;
	}
	public override string ToString()
	{
		StringBuilder stringBuilder = new(value: base.ToString());
		stringBuilder.Append(value: "|" + DelimitersDefinition)
					 .Append(value: "|" + MessageControlId)
					 .Append(value: "|" + AccessPassword)
					 .Append(value: "|" + SenderNameOrId)
					 .Append(value: "|" + SenderStreetAddress)
					 .Append(value: "|" + ReservedField)
					 .Append(value: "|" + SenderPhoneNumber)
					 .Append(value: "|" + CharacteristicsOfSender)
					 .Append(value: "|" + ReceiverId)
					 .Append(value: "|" + CommentOrSpecialIns)
					 .Append(value: "|" + ProcessingId)
					 .Append(value: "|" + VersionNumber)
					 .Append(value: "|" + E139491Utility.GetAstmDateTimeString(dateTime: MessageDateAndTime));
		return stringBuilder.ToString();
	}
}