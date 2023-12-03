using System;
using System.Diagnostics.Eventing.Reader;
using ASTM.E139491;
using DevExpress.XtraEditors;


namespace ASTM_Test.RecordForms;

public partial class frmHeader : XtraForm
{
	public frmHeader()
	{
		InitializeComponent();
	}

	private void btnToAstm_Click(object sender, System.EventArgs e)
	{
		E139491MessageHeaderRecord record = new();
		record.MessageDateAndTime = DateTime.TryParse(s: dttMessageDateAndTime.Text, result: out DateTime date) ? date : DateTime.Now;
		record.RecordType         = txtRecordType.Text;
		record.DelimitersDefinition = txtDelimitersDefinition.Text;
		record.MessageControlId = txtMessageControlId.Text;
		EventRecordWrittenEve

	}
}