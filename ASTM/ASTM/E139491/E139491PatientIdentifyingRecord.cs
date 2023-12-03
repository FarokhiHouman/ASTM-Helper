namespace ASTM.E139491;

public class E139491PatientIdentifyingRecord : E139491Record
{
#region Properties, Indexers
	public string RecordType                                 { get; set; }
	public int    SequenceNumber                             { get; set; }
	public string PracticeAssignedPatientId                  { get; set; }
	public string LabAssignedPatientId                       { get; set; }
	public string PatientIdNo3                               { get; set; }
	public string PatientName                                { get; set; }
	public string MothersMaidenName                          { get; set; }
	public string Birthdate                                  { get; set; }
	public string PatientSex                                 { get; set; }
	public string PatientRace                                { get; set; }
	public string PatientAddress                             { get; set; }
	public string ReservedField                              { get; set; }
	public string PatientTelephone                           { get; set; }
	public string AttendingPhysicianId                       { get; set; }
	public string SpecialField1                              { get; set; }
	public string SpecialField2                              { get; set; }
	public string PatientHeight                              { get; set; }
	public string PatientWeight                              { get; set; }
	public string PatientDiagnosis                           { get; set; }
	public string PatientMedications                         { get; set; }
	public string PatientDiet                                { get; set; }
	public string PracticeFieldNo1                           { get; set; }
	public string PracticeFieldNo2                           { get; set; }
	public string AdmissionAndDischargeDates                 { get; set; }
	public string AdmissionStatus                            { get; set; }
	public string Location                                   { get; set; }
	public string NatureOfAltDiagCodeAndClass                { get; set; }
	public string AlternativeDiagnosticCodeAndClassification { get; set; }
	public string PatientReligion                            { get; set; }
	public string MaritalStatus                              { get; set; }
	public string IsolationStatus                            { get; set; }
	public string Language                                   { get; set; }
	public string HospitalService                            { get; set; }
	public string HospitalInstitution                        { get; set; }
	public string DosageCategory                             { get; set; }
#endregion
	public static E139491PatientIdentifyingRecord Parse(string text)
	{
		E139491PatientIdentifyingRecord result   = new();
		string[]                        strArray = text.Split('|');
		if (strArray.Length >= 1)
		{
			result.RecordType        = strArray[0];
			result.E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: result.RecordType);
		}
		if (strArray.Length >= 2 && !string.IsNullOrWhiteSpace(value: strArray[1])) result.SequenceNumber = int.Parse(s: strArray[1]);
		if (strArray.Length >= 3) result.PracticeAssignedPatientId                                        = strArray[2];
		if (strArray.Length >= 4) result.LabAssignedPatientId                                             = strArray[3];
		if (strArray.Length >= 5) result.PatientIdNo3                                                     = strArray[4];
		if (strArray.Length >= 6) result.PatientName                                                      = strArray[5];
		if (strArray.Length >= 7) result.MothersMaidenName                                                = strArray[6];
		if (strArray.Length >= 8) result.Birthdate                                                        = strArray[7];
		if (strArray.Length >= 9) result.PatientSex                                                       = strArray[8];
		if (strArray.Length >= 10) result.PatientRace                                                     = strArray[9];
		if (strArray.Length >= 11) result.PatientAddress                                                  = strArray[10];
		if (strArray.Length >= 12) result.ReservedField                                                   = strArray[11];
		if (strArray.Length >= 13) result.PatientTelephone                                                = strArray[12];
		if (strArray.Length >= 14) result.AttendingPhysicianId                                            = strArray[13];
		if (strArray.Length >= 15) result.SpecialField1                                                   = strArray[14];
		if (strArray.Length >= 16) result.SpecialField2                                                   = strArray[15];
		if (strArray.Length >= 17) result.PatientHeight                                                   = strArray[16];
		if (strArray.Length >= 18) result.PatientWeight                                                   = strArray[17];
		if (strArray.Length >= 19) result.PatientDiagnosis                                                = strArray[18];
		if (strArray.Length >= 20) result.PatientMedications                                              = strArray[19];
		if (strArray.Length >= 21) result.PatientDiet                                                     = strArray[20];
		if (strArray.Length >= 22) result.PracticeFieldNo1                                                = strArray[21];
		if (strArray.Length >= 23) result.PracticeFieldNo2                                                = strArray[22];
		if (strArray.Length >= 24) result.AdmissionAndDischargeDates                                      = strArray[23];
		if (strArray.Length >= 25) result.AdmissionStatus                                                 = strArray[24];
		if (strArray.Length >= 26) result.Location                                                        = strArray[25];
		if (strArray.Length >= 27) result.NatureOfAltDiagCodeAndClass                                     = strArray[26];
		if (strArray.Length >= 28) result.AlternativeDiagnosticCodeAndClassification                      = strArray[27];
		if (strArray.Length >= 29) result.PatientReligion                                                 = strArray[28];
		if (strArray.Length >= 30) result.MaritalStatus                                                   = strArray[29];
		if (strArray.Length >= 31) result.IsolationStatus                                                 = strArray[30];
		if (strArray.Length >= 32) result.Language                                                        = strArray[31];
		if (strArray.Length >= 33) result.HospitalService                                                 = strArray[32];
		if (strArray.Length >= 34) result.HospitalInstitution                                             = strArray[33];
		if (strArray.Length >= 35) result.DosageCategory                                                  = strArray[34];
		return result;
	}
	public override string ToString()
	{
		return string.Format(format: "{0}|{1}|{2}|{3}|", base.ToString(), SequenceNumber, PracticeAssignedPatientId, LabAssignedPatientId) +
			   PatientIdNo3                                                                                                                +
			   "|"                                                                                                                         +
			   PatientName                                                                                                                 +
			   "|"                                                                                                                         +
			   MothersMaidenName                                                                                                           +
			   "|"                                                                                                                         +
			   Birthdate                                                                                                                   +
			   "|"                                                                                                                         +
			   PatientSex                                                                                                                  +
			   "|"                                                                                                                         +
			   PatientRace                                                                                                                 +
			   "|"                                                                                                                         +
			   PatientAddress                                                                                                              +
			   "|"                                                                                                                         +
			   ReservedField                                                                                                               +
			   "|"                                                                                                                         +
			   PatientTelephone                                                                                                            +
			   "|"                                                                                                                         +
			   AttendingPhysicianId                                                                                                        +
			   "|"                                                                                                                         +
			   SpecialField1                                                                                                               +
			   "|"                                                                                                                         +
			   SpecialField2                                                                                                               +
			   "|"                                                                                                                         +
			   PatientHeight                                                                                                               +
			   "|"                                                                                                                         +
			   PatientWeight                                                                                                               +
			   "|"                                                                                                                         +
			   PatientDiagnosis                                                                                                            +
			   "|"                                                                                                                         +
			   PatientMedications                                                                                                          +
			   "|"                                                                                                                         +
			   PatientDiet                                                                                                                 +
			   "|"                                                                                                                         +
			   PracticeFieldNo1                                                                                                            +
			   "|"                                                                                                                         +
			   PracticeFieldNo2                                                                                                            +
			   "|"                                                                                                                         +
			   AdmissionAndDischargeDates                                                                                                  +
			   "|"                                                                                                                         +
			   AdmissionStatus                                                                                                             +
			   "|"                                                                                                                         +
			   Location                                                                                                                    +
			   "|"                                                                                                                         +
			   NatureOfAltDiagCodeAndClass                                                                                                 +
			   "|"                                                                                                                         +
			   AlternativeDiagnosticCodeAndClassification                                                                                  +
			   "|"                                                                                                                         +
			   PatientReligion                                                                                                             +
			   "|"                                                                                                                         +
			   MaritalStatus                                                                                                               +
			   "|"                                                                                                                         +
			   IsolationStatus                                                                                                             +
			   "|"                                                                                                                         +
			   Language                                                                                                                    +
			   "|"                                                                                                                         +
			   HospitalService                                                                                                             +
			   "|"                                                                                                                         +
			   HospitalInstitution                                                                                                         +
			   "|"                                                                                                                         +
			   DosageCategory;
	}
}