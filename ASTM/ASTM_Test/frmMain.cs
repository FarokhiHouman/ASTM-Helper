using ASTM_Test.RecordForms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;


namespace ASTM_Test;

public partial class frmMain : RibbonForm
{
	public frmMain()
	{
		InitializeComponent();
	}
	private void btNComment_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmComment frm = new();
		frm.MdiParent = this;
		frm.Show();
	}
	private void btnHeader_ItemClick(object sender, ItemClickEventArgs e)
	{
		frmHeader frm = new();
		frm.MdiParent = this;
		frm.Show();
	}
}