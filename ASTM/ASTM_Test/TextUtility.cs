using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace ASTM_Test;

public static class TextUtility
{
	public static void ClearAllTextBoxes(Control control)
	{
		foreach (Control c in control.Controls)
			switch (c)
			{
				case TextBox textBox:
					textBox.Text = string.Empty;
					break;
				case RichTextBox richTextbox:
					richTextbox.Text = string.Empty;
					break;
				case TextEdit textEdit:
					textEdit.Text = string.Empty;
					break;
				default:
				{
					if (c.HasChildren) ClearAllTextBoxes(control: c); // Recursively search for textboxes in child controls
					break;
				}
			}
	}
	public static void ClearAllTextBoxes(Control control, Control Exception)
	{
		foreach (Control c in control.Controls)
			if (c != Exception)
				switch (c)
				{
					case TextBox textBox:
						textBox.Text = string.Empty;
						break;
					case RichTextBox richTextbox:
						richTextbox.Text = string.Empty;
						break;
					case TextEdit textEdit:
						textEdit.Text = string.Empty;
						break;
					default:
					{
						if (c.HasChildren) ClearAllTextBoxes(control: c, Exception: Exception); // Recursively search for textboxes in child controls
						break;
					}
				}
	}
}