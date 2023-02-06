namespace progetto_ingegneria_del_software.view {
	partial class NightModeThresholdForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && (components != null) ) {
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( ) {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._from = new Telerik.WinControls.UI.RadTimePicker();
			this._to = new Telerik.WinControls.UI.RadTimePicker();
			this._okButton = new System.Windows.Forms.Button();
			this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._from)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._to)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this._from, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._to, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this._okButton, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 128);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Location = new System.Drawing.Point(100, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "DA:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Location = new System.Drawing.Point(108, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "A:";
			// 
			// _from
			// 
			this._from.Location = new System.Drawing.Point(131, 3);
			this._from.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
			this._from.MinValue = new System.DateTime(((long)(0)));
			this._from.Name = "_from";
			this._from.Size = new System.Drawing.Size(96, 24);
			this._from.TabIndex = 2;
			this._from.TabStop = false;
			this._from.Text = "radTimePicker1";
			this._from.ThemeName = "VisualStudio2012Dark";
			this._from.Value = new System.DateTime(2016, 7, 14, 23, 45, 4, 595);
			// 
			// _to
			// 
			this._to.Location = new System.Drawing.Point(131, 45);
			this._to.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
			this._to.MinValue = new System.DateTime(((long)(0)));
			this._to.Name = "_to";
			this._to.Size = new System.Drawing.Size(96, 24);
			this._to.TabIndex = 3;
			this._to.TabStop = false;
			this._to.Text = "radTimePicker2";
			this._to.ThemeName = "VisualStudio2012Dark";
			this._to.Value = new System.DateTime(2016, 7, 14, 23, 45, 8, 136);
			// 
			// _okButton
			// 
			this._okButton.Location = new System.Drawing.Point(131, 87);
			this._okButton.Name = "_okButton";
			this._okButton.Size = new System.Drawing.Size(75, 23);
			this._okButton.TabIndex = 4;
			this._okButton.Text = "OK";
			this._okButton.UseVisualStyleBackColor = true;
			// 
			// NightModeThresholdForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 128);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "NightModeThresholdForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Impostazione nuova soglia";
			this.ThemeName = "VisualStudio2012Dark";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._from)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._to)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Telerik.WinControls.UI.RadTimePicker _from;
		private Telerik.WinControls.UI.RadTimePicker _to;
		private System.Windows.Forms.Button _okButton;
		private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
	}
}