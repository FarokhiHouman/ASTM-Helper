namespace ASTM_Test.RecordForms
{
	partial class frmComment
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
			this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
			this.btnPars = new DevExpress.XtraEditors.SimpleButton();
			this.btnToAstm = new DevExpress.XtraEditors.SimpleButton();
			this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
			this.txtCommentType = new DevExpress.XtraEditors.TextEdit();
			this.txtCommentText = new DevExpress.XtraEditors.TextEdit();
			this.txtCommentSource = new DevExpress.XtraEditors.TextEdit();
			this.txtSeqNo = new DevExpress.XtraEditors.TextEdit();
			this.txtRecordType = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtAstmString = new System.Windows.Forms.RichTextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
			this.tablePanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
			this.tablePanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCommentType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCommentText.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCommentSource.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSeqNo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRecordType.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// tablePanel1
			// 
			this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Separator, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
			this.tablePanel1.Controls.Add(this.btnPars);
			this.tablePanel1.Controls.Add(this.btnToAstm);
			this.tablePanel1.Controls.Add(this.tablePanel2);
			this.tablePanel1.Controls.Add(this.txtAstmString);
			this.tablePanel1.Controls.Add(this.labelControl2);
			this.tablePanel1.Controls.Add(this.labelControl1);
			this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablePanel1.Location = new System.Drawing.Point(0, 0);
			this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tablePanel1.Name = "tablePanel1";
			this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F)});
			this.tablePanel1.Size = new System.Drawing.Size(998, 368);
			this.tablePanel1.TabIndex = 0;
			// 
			// btnPars
			// 
			this.btnPars.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
			this.btnPars.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPars.Appearance.Options.UseBackColor = true;
			this.btnPars.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.btnPars, 2);
			this.btnPars.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPars.Location = new System.Drawing.Point(512, 301);
			this.btnPars.Name = "btnPars";
			this.tablePanel1.SetRow(this.btnPars, 2);
			this.btnPars.Size = new System.Drawing.Size(483, 64);
			this.btnPars.TabIndex = 5;
			this.btnPars.Text = "<<<< Pars";
			this.btnPars.Click += new System.EventHandler(this.btnPars_Click);
			// 
			// btnToAstm
			// 
			this.btnToAstm.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
			this.btnToAstm.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnToAstm.Appearance.Options.UseBackColor = true;
			this.btnToAstm.Appearance.Options.UseFont = true;
			this.tablePanel1.SetColumn(this.btnToAstm, 0);
			this.btnToAstm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnToAstm.Location = new System.Drawing.Point(3, 301);
			this.btnToAstm.Name = "btnToAstm";
			this.tablePanel1.SetRow(this.btnToAstm, 2);
			this.btnToAstm.Size = new System.Drawing.Size(483, 64);
			this.btnToAstm.TabIndex = 4;
			this.btnToAstm.Text = "To ASTM String >>>>";
			this.btnToAstm.Click += new System.EventHandler(this.btnToAstm_Click);
			// 
			// tablePanel2
			// 
			this.tablePanel1.SetColumn(this.tablePanel2, 0);
			this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
			this.tablePanel2.Controls.Add(this.txtCommentType);
			this.tablePanel2.Controls.Add(this.txtCommentText);
			this.tablePanel2.Controls.Add(this.txtCommentSource);
			this.tablePanel2.Controls.Add(this.txtSeqNo);
			this.tablePanel2.Controls.Add(this.txtRecordType);
			this.tablePanel2.Controls.Add(this.labelControl7);
			this.tablePanel2.Controls.Add(this.labelControl6);
			this.tablePanel2.Controls.Add(this.labelControl5);
			this.tablePanel2.Controls.Add(this.labelControl4);
			this.tablePanel2.Controls.Add(this.labelControl3);
			this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablePanel2.Location = new System.Drawing.Point(0, 30);
			this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tablePanel2.Name = "tablePanel2";
			this.tablePanel1.SetRow(this.tablePanel2, 1);
			this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
			this.tablePanel2.Size = new System.Drawing.Size(489, 268);
			this.tablePanel2.TabIndex = 3;
			// 
			// txtCommentType
			// 
			this.tablePanel2.SetColumn(this.txtCommentType, 1);
			this.txtCommentType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCommentType.Location = new System.Drawing.Point(133, 181);
			this.txtCommentType.Name = "txtCommentType";
			this.txtCommentType.Properties.Appearance.Options.UseTextOptions = true;
			this.txtCommentType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.txtCommentType.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.txtCommentType.Properties.AutoHeight = false;
			this.tablePanel2.SetRow(this.txtCommentType, 4);
			this.txtCommentType.Size = new System.Drawing.Size(353, 20);
			this.txtCommentType.TabIndex = 9;
			// 
			// txtCommentText
			// 
			this.tablePanel2.SetColumn(this.txtCommentText, 1);
			this.txtCommentText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCommentText.Location = new System.Drawing.Point(133, 81);
			this.txtCommentText.Name = "txtCommentText";
			this.txtCommentText.Properties.Appearance.Options.UseTextOptions = true;
			this.txtCommentText.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.txtCommentText.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.txtCommentText.Properties.AutoHeight = false;
			this.tablePanel2.SetRow(this.txtCommentText, 3);
			this.txtCommentText.Size = new System.Drawing.Size(353, 94);
			this.txtCommentText.TabIndex = 8;
			// 
			// txtCommentSource
			// 
			this.tablePanel2.SetColumn(this.txtCommentSource, 1);
			this.txtCommentSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCommentSource.Location = new System.Drawing.Point(133, 55);
			this.txtCommentSource.Name = "txtCommentSource";
			this.txtCommentSource.Properties.Appearance.Options.UseTextOptions = true;
			this.txtCommentSource.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.txtCommentSource.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.txtCommentSource.Properties.AutoHeight = false;
			this.tablePanel2.SetRow(this.txtCommentSource, 2);
			this.txtCommentSource.Size = new System.Drawing.Size(353, 20);
			this.txtCommentSource.TabIndex = 7;
			// 
			// txtSeqNo
			// 
			this.tablePanel2.SetColumn(this.txtSeqNo, 1);
			this.txtSeqNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSeqNo.Location = new System.Drawing.Point(133, 29);
			this.txtSeqNo.Name = "txtSeqNo";
			this.txtSeqNo.Properties.Appearance.Options.UseTextOptions = true;
			this.txtSeqNo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.txtSeqNo.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.txtSeqNo.Properties.AutoHeight = false;
			this.tablePanel2.SetRow(this.txtSeqNo, 1);
			this.txtSeqNo.Size = new System.Drawing.Size(353, 20);
			this.txtSeqNo.TabIndex = 6;
			// 
			// txtRecordType
			// 
			this.tablePanel2.SetColumn(this.txtRecordType, 1);
			this.txtRecordType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRecordType.EditValue = "C";
			this.txtRecordType.Location = new System.Drawing.Point(133, 3);
			this.txtRecordType.Name = "txtRecordType";
			this.txtRecordType.Properties.Appearance.Options.UseTextOptions = true;
			this.txtRecordType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.txtRecordType.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.txtRecordType.Properties.AutoHeight = false;
			this.txtRecordType.Properties.ReadOnly = true;
			this.tablePanel2.SetRow(this.txtRecordType, 0);
			this.txtRecordType.Size = new System.Drawing.Size(353, 20);
			this.txtRecordType.TabIndex = 5;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Options.UseTextOptions = true;
			this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.tablePanel2.SetColumn(this.labelControl7, 0);
			this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControl7.Location = new System.Drawing.Point(3, 181);
			this.labelControl7.Name = "labelControl7";
			this.tablePanel2.SetRow(this.labelControl7, 4);
			this.labelControl7.Size = new System.Drawing.Size(124, 20);
			this.labelControl7.TabIndex = 4;
			this.labelControl7.Text = "Comment Type :";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Options.UseTextOptions = true;
			this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.tablePanel2.SetColumn(this.labelControl6, 0);
			this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControl6.Location = new System.Drawing.Point(3, 81);
			this.labelControl6.Name = "labelControl6";
			this.tablePanel2.SetRow(this.labelControl6, 3);
			this.labelControl6.Size = new System.Drawing.Size(124, 94);
			this.labelControl6.TabIndex = 3;
			this.labelControl6.Text = "Comment Text :";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Options.UseTextOptions = true;
			this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.tablePanel2.SetColumn(this.labelControl5, 0);
			this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControl5.Location = new System.Drawing.Point(3, 55);
			this.labelControl5.Name = "labelControl5";
			this.tablePanel2.SetRow(this.labelControl5, 2);
			this.labelControl5.Size = new System.Drawing.Size(124, 20);
			this.labelControl5.TabIndex = 2;
			this.labelControl5.Text = "Comment Source :";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Options.UseTextOptions = true;
			this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.tablePanel2.SetColumn(this.labelControl4, 0);
			this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControl4.Location = new System.Drawing.Point(3, 29);
			this.labelControl4.Name = "labelControl4";
			this.tablePanel2.SetRow(this.labelControl4, 1);
			this.labelControl4.Size = new System.Drawing.Size(124, 20);
			this.labelControl4.TabIndex = 1;
			this.labelControl4.Text = "Sequence Number :";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
			this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.tablePanel2.SetColumn(this.labelControl3, 0);
			this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelControl3.Location = new System.Drawing.Point(3, 3);
			this.labelControl3.Name = "labelControl3";
			this.tablePanel2.SetRow(this.labelControl3, 0);
			this.labelControl3.Size = new System.Drawing.Size(124, 20);
			this.labelControl3.TabIndex = 0;
			this.labelControl3.Text = "Record Type :";
			// 
			// txtAstmString
			// 
			this.txtAstmString.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tablePanel1.SetColumn(this.txtAstmString, 2);
			this.txtAstmString.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAstmString.Location = new System.Drawing.Point(512, 33);
			this.txtAstmString.Name = "txtAstmString";
			this.tablePanel1.SetRow(this.txtAstmString, 1);
			this.txtAstmString.Size = new System.Drawing.Size(483, 262);
			this.txtAstmString.TabIndex = 2;
			this.txtAstmString.Text = "";
			// 
			// labelControl2
			// 
			this.tablePanel1.SetColumn(this.labelControl2, 2);
			this.labelControl2.Location = new System.Drawing.Point(512, 8);
			this.labelControl2.Name = "labelControl2";
			this.tablePanel1.SetRow(this.labelControl2, 0);
			this.labelControl2.Size = new System.Drawing.Size(107, 13);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "ASTM E139491 String:";
			// 
			// labelControl1
			// 
			this.tablePanel1.SetColumn(this.labelControl1, 0);
			this.labelControl1.Location = new System.Drawing.Point(3, 8);
			this.labelControl1.Name = "labelControl1";
			this.tablePanel1.SetRow(this.labelControl1, 0);
			this.labelControl1.Size = new System.Drawing.Size(79, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Comment Fields:";
			// 
			// frmComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(998, 368);
			this.Controls.Add(this.tablePanel1);
			this.Name = "frmComment";
			this.Text = "Comment";
			((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
			this.tablePanel1.ResumeLayout(false);
			this.tablePanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
			this.tablePanel2.ResumeLayout(false);
			this.tablePanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCommentType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCommentText.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCommentSource.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSeqNo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRecordType.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.Utils.Layout.TablePanel tablePanel1;
		private DevExpress.Utils.Layout.TablePanel tablePanel2;
		private System.Windows.Forms.RichTextBox txtAstmString;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SimpleButton btnPars;
		private DevExpress.XtraEditors.SimpleButton btnToAstm;
		private DevExpress.XtraEditors.TextEdit txtCommentType;
		private DevExpress.XtraEditors.TextEdit txtCommentText;
		private DevExpress.XtraEditors.TextEdit txtCommentSource;
		private DevExpress.XtraEditors.TextEdit txtSeqNo;
		private DevExpress.XtraEditors.TextEdit txtRecordType;
	}
}