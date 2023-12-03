namespace ASTM.E139491;

public class E139491Record
{
	public E139491RecordType? E139491RecordType { get; set; }
	public static E139491RecordType? DetectE139491RecordType(string text)
	{
		return E139491Utility.GetE139491RecordTypeValue(text: text[index: 0].ToString().ToUpper());
	}
	public override string ToString()
	{
		return E139491Utility.GetE139491RecordTypeString(e139491RecordType: E139491RecordType);
	}
}