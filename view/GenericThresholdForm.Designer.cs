namespace progetto_ingegneria_del_software.view
{
    partial class GenericThresholdForm
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
			this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._thresholdName = new System.Windows.Forms.Label();
			this._threshText = new System.Windows.Forms.TextBox();
			this._okButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this._thresholdName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this._threshText, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this._okButton, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 66);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// _thresholdName
			// 
			this._thresholdName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._thresholdName.AutoSize = true;
			this._thresholdName.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._thresholdName.Location = new System.Drawing.Point(50, 26);
			this._thresholdName.Name = "_thresholdName";
			this._thresholdName.Size = new System.Drawing.Size(42, 13);
			this._thresholdName.TabIndex = 0;
			this._thresholdName.Text = "Soglia:";
			// 
			// _threshText
			// 
			this._threshText.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._threshText.Location = new System.Drawing.Point(98, 23);
			this._threshText.Name = "_threshText";
			this._threshText.Size = new System.Drawing.Size(89, 20);
			this._threshText.TabIndex = 1;
			// 
			// _okButton
			// 
			this._okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._okButton.Location = new System.Drawing.Point(201, 21);
			this._okButton.Name = "_okButton";
			this._okButton.Size = new System.Drawing.Size(75, 23);
			this._okButton.TabIndex = 2;
			this._okButton.Text = "OK";
			this._okButton.UseVisualStyleBackColor = true;
			// 
			// GenericThresholdForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 66);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "GenericThresholdForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Impostazione nuova soglia";
			this.ThemeName = "VisualStudio2012Dark";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label _thresholdName;
		private System.Windows.Forms.TextBox _threshText;
		private System.Windows.Forms.Button _okButton;
	}
}
