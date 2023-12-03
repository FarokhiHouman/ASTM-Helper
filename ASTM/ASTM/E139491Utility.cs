using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using ASTM.E139491;
using FarsiLibrary.Utils;


namespace ASTM;

public static class E139491Utility
{
	public static string ExtractAstmText(byte[] data)
	{
		List<byte> byteList = new();
		foreach (byte num in data.Skip(count: 2))
			if (num != ASTMConstByts.Etx)
				byteList.Add(item: num);
			else
				break;
		return Encoding.ASCII.GetString(bytes: byteList.ToArray());
	}
	public static E139491RecordType? GetE139491RecordTypeValue(string text)
	{
		text = text.ToUpper();
		if (text.Length != 1) return null;
		return text switch
			   {
				   "C" => E139491RecordType.Comment,
				   "H" => E139491RecordType.MessageHeader,
				   "L" => E139491RecordType.MessageTerminator,
				   "M" => E139491RecordType.ManufacturerInformation,
				   "O" => E139491RecordType.TestOrder,
				   "P" => E139491RecordType.PatientIdentifying,
				   "R" => E139491RecordType.Result,
				   "S" => E139491RecordType.Scientific,
				   _   => null
			   };
	}
	public static string GetE139491RecordTypeString(E139491RecordType? e139491RecordType)
	{
		// ReSharper disable once InvokeAsExtensionMethod
		return EnumExtensions.GetDescription(value: e139491RecordType);
	}
	public static DateTime GetAstmDateTimeValue(string text)
	{
		return new(year: int.Parse(s: text.Substring(startIndex: 0, length: 4)),
			month: int.Parse(s: text.Substring(startIndex: 4,       length: 2)),
			day: int.Parse(s: text.Substring(startIndex: 6,         length: 2)),
			hour: int.Parse(s: text.Substring(startIndex: 8,        length: 2)),
			minute: int.Parse(s: text.Substring(startIndex: 10,     length: 2)),
			second: int.Parse(s: text.Substring(startIndex: 12,     length: 2)));
	}
	public static PersianDate GetAstmPersianDateTimeValue(string text)
	{
		DateTime GDateTime = GetAstmDateTimeValue(text: text);
		return new(dt: GDateTime);
	}
	public static string GetAstmDateTimeString(DateTime dateTime)
	{
		return string.Format(format: "{0:D4}{1:D2}{2:D2}{3:D2}", dateTime.Year, dateTime.Month, dateTime.Date, dateTime.Hour) +
			   $"{(object)dateTime.Minute:D2}{(object)dateTime.Second:D2}";
	}
	public static string GetAstmPersianDateTimeString(PersianDate PdateTime)
	{
		DateTime dateTime = PersianDateConverter.ToGregorianDateTime(date: PdateTime);
		return GetAstmDateTimeString(dateTime: dateTime);
	}
}
public static class EnumExtensions
{
	public static string GetDescription(this Enum value)
	{
		if (value != null)
		{
			FieldInfo fieldInfo = value.GetType().GetField(name: value.ToString());
			DescriptionAttribute[] attributes =
				fieldInfo.GetCustomAttributes(attributeType: typeof(DescriptionAttribute), inherit: false) as DescriptionAttribute[];
			return attributes is { Length: > 0 } ? attributes[0].Description : value.ToString();
		}
		return null;
	}
}