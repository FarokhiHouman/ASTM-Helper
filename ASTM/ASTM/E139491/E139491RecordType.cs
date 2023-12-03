using System.ComponentModel;


namespace ASTM.E139491;

public enum E139491RecordType
{
	[Description(description: "C")]  Comment                 = 100,
	[Description(description: "M")]  ManufacturerInformation = 200,
	[Description(description: "H")]  MessageHeader           = 300,
	[Description(description: "L")]  MessageTerminator       = 400,
	[Description(description: null)] Other                   = 500,
	[Description(description: "P")]  PatientIdentifying      = 600,
	[Description(description: "R")]  Result                  = 700,
	[Description(description: "S")]  Scientific              = 800,
	[Description(description: "O")]  TestOrder               = 900
}

