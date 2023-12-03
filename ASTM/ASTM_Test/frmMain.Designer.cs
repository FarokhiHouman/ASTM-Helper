namespace ASTM_Test
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btNComment = new DevExpress.XtraBars.BarButtonItem();
			this.btnManufacturer = new DevExpress.XtraBars.BarButtonItem();
			this.btnHeader = new DevExpress.XtraBars.BarButtonItem();
			this.btnTerminator = new DevExpress.XtraBars.BarButtonItem();
			this.btnPatient = new DevExpress.XtraBars.BarButtonItem();
			this.btnResult = new DevExpress.XtraBars.BarButtonItem();
			this.btnScientific = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btNComment,
            this.btnManufacturer,
            this.btnHeader,
            this.btnTerminator,
            this.btnPatient,
            this.btnResult,
            this.btnScientific});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 8;
			this.ribbon.Name = "ribbon";
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbon.Size = new System.Drawing.Size(1071, 158);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			// 
			// btNComment
			// 
			this.btNComment.Caption = "Comment";
			this.btNComment.Id = 1;
			this.btNComment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btNComment.ImageOptions.Image")));
			this.btNComment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btNComment.ImageOptions.LargeImage")));
			this.btNComment.Name = "btNComment";
			this.btNComment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btNComment_ItemClick);
			// 
			// btnManufacturer
			// 
			this.btnManufacturer.Caption = "Manufacturer";
			this.btnManufacturer.Id = 2;
			this.btnManufacturer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnManufacturer.ImageOptions.Image")));
			this.btnManufacturer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnManufacturer.ImageOptions.LargeImage")));
			this.btnManufacturer.Name = "btnManufacturer";
			// 
			// btnHeader
			// 
			this.btnHeader.Caption = "Header";
			this.btnHeader.Id = 3;
			this.btnHeader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHeader.ImageOptions.Image")));
			this.btnHeader.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHeader.ImageOptions.LargeImage")));
			this.btnHeader.Name = "btnHeader";
			this.btnHeader.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHeader_ItemClick);
			// 
			// btnTerminator
			// 
			this.btnTerminator.Caption = "Terminator";
			this.btnTerminator.Id = 4;
			this.btnTerminator.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTerminator.ImageOptions.Image")));
			this.btnTerminator.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTerminator.ImageOptions.LargeImage")));
			this.btnTerminator.Name = "btnTerminator";
			// 
			// btnPatient
			// 
			this.btnPatient.Caption = "Patient";
			this.btnPatient.Id = 5;
			this.btnPatient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPatient.ImageOptions.SvgImage")));
			this.btnPatient.Name = "btnPatient";
			// 
			// btnResult
			// 
			this.btnResult.Caption = "Result";
			this.btnResult.Id = 6;
			this.btnResult.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnResult.ImageOptions.SvgImage")));
			this.btnResult.Name = "btnResult";
			// 
			// btnScientific
			// 
			this.btnScientific.Caption = "Scientific";
			this.btnScientific.Id = 7;
			this.btnScientific.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnScientific.ImageOptions.Image")));
			this.btnScientific.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnScientific.ImageOptions.LargeImage")));
			this.btnScientific.Name = "btnScientific";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "ASTM";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btNComment);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnManufacturer);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnHeader);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnTerminator);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnPatient);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnResult);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnScientific);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "RecordType";
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 797);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbon;
			this.ribbonStatusBar.Size = new System.Drawing.Size(1071, 24);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 821);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbon);
			this.IsMdiContainer = true;
			this.Name = "frmMain";
			this.Ribbon = this.ribbon;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "ASTM String";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.BarButtonItem btNComment;
		private DevExpress.XtraBars.BarButtonItem btnManufacturer;
		private DevExpress.XtraBars.BarButtonItem btnHeader;
		private DevExpress.XtraBars.BarButtonItem btnTerminator;
		private DevExpress.XtraBars.BarButtonItem btnPatient;
		private DevExpress.XtraBars.BarButtonItem btnResult;
		private DevExpress.XtraBars.BarButtonItem btnScientific;
	}
}