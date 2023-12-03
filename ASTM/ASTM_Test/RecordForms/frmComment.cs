using System;
using System.Windows.Forms;
using ASTM;
using ASTM.E139491;
using DevExpress.XtraEditors;


namespace ASTM_Test.RecordForms;

public partial class frmComment : XtraForm
{
	public frmComment()
	{
		InitializeComponent();
	}
	private void btnToAstm_Click(object sender, EventArgs e)
	{
		txtAstmString.Text = string.Empty;
		if (string.IsNullOrEmpty(value: txtCommentSource.Text.Trim()) ||
			string.IsNullOrEmpty(value: txtCommentType.Text.Trim())   ||
			string.IsNullOrEmpty(value: txtRecordType.Text.Trim())    ||
			string.IsNullOrEmpty(value: txtSeqNo.Text.Trim())         ||
			string.IsNullOrEmpty(value: txtCommentText.Text.Trim()))
			return;
		if (!string.Equals(a: txtRecordType.Text.ToUpper(), b: "C")) return;
		E139491CommentRecord newComment = new()
										  {
											  CommentSource     = txtCommentSource.Text,
											  CommentText       = txtCommentText.Text,
											  CommentType       = txtCommentType.Text,
											  RecordType        = txtRecordType.Text.ToUpper(),
											  E139491RecordType = E139491Utility.GetE139491RecordTypeValue(text: txtRecordType.Text)
										  };
		if (int.TryParse(s: txtSeqNo.Text, result: out int sqlNo))
			newComment.SequenceNumber = sqlNo;
		else
			return;
		txtAstmString.Text = newComment.ToString();
	}
	private void btnPars_Click(object sender, EventArgs e)
	{
		TextUtility.ClearAllTextBoxes(control: tablePanel1, Exception: txtAstmString);
		try
		{
			E139491CommentRecord newCommentRecord = E139491CommentRecord.Pars(text: txtAstmString.Text);
			if (!string.Equals(a: newCommentRecord.RecordType, b: "C"))
			{
				MessageBox.Show(text: "It's Not Comment String", caption: "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
				if (newCommentRecord.E139491RecordType != null)
					MessageBox.Show(text: $"It's a -{newCommentRecord.E139491RecordType.ToString()}- String",
						caption: "Warning",
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Warning);
			}
			else
			{
				txtRecordType.Text    = newCommentRecord.RecordType;
				txtSeqNo.Text         = newCommentRecord.SequenceNumber.ToString();
				txtCommentText.Text   = newCommentRecord.CommentText;
				txtCommentSource.Text = newCommentRecord.CommentSource;
				txtCommentType.Text   = newCommentRecord.CommentType;
			}
		}
		catch (Exception exception)
		{
			MessageBox.Show(text: exception.Source + " : " + exception.Message, caption: "Error");
		}
	}
}