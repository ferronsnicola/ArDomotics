namespace progetto_ingegneria_del_software.view {
	partial class UserSelectionForm {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this._deleteButton = new System.Windows.Forms.Button();
			this._modifyButton = new System.Windows.Forms.Button();
			this._selezionaLabel = new System.Windows.Forms.Label();
			this._usersComboBox = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._deleteButton);
			this.panel1.Controls.Add(this._modifyButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 150);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(465, 34);
			this.panel1.TabIndex = 0;
			// 
			// _deleteButton
			// 
			this._deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
			this._deleteButton.Location = new System.Drawing.Point(315, 0);
			this._deleteButton.Name = "_deleteButton";
			this._deleteButton.Size = new System.Drawing.Size(75, 34);
			this._deleteButton.TabIndex = 1;
			this._deleteButton.Text = "Elimina";
			this._deleteButton.UseVisualStyleBackColor = true;
			// 
			// _modifyButton
			// 
			this._modifyButton.Dock = System.Windows.Forms.DockStyle.Right;
			this._modifyButton.Location = new System.Drawing.Point(390, 0);
			this._modifyButton.Name = "_modifyButton";
			this._modifyButton.Size = new System.Drawing.Size(75, 34);
			this._modifyButton.TabIndex = 0;
			this._modifyButton.Text = "Modifica";
			this._modifyButton.UseVisualStyleBackColor = true;
			// 
			// _selezionaLabel
			// 
			this._selezionaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._selezionaLabel.AutoSize = true;
			this._selezionaLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._selezionaLabel.Location = new System.Drawing.Point(55, 47);
			this._selezionaLabel.Name = "_selezionaLabel";
			this._selezionaLabel.Size = new System.Drawing.Size(94, 13);
			this._selezionaLabel.TabIndex = 2;
			this._selezionaLabel.Text = "Seleziona Utente";
			// 
			// _usersComboBox
			// 
			this._usersComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._usersComboBox.FormattingEnabled = true;
			this._usersComboBox.Location = new System.Drawing.Point(187, 44);
			this._usersComboBox.Name = "_usersComboBox";
			this._usersComboBox.Size = new System.Drawing.Size(121, 21);
			this._usersComboBox.TabIndex = 3;
			// 
			// UserSelectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 184);
			this.Controls.Add(this._usersComboBox);
			this.Controls.Add(this._selezionaLabel);
			this.Controls.Add(this.panel1);
			this.Name = "UserSelectionForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Selezione utente";
			this.ThemeName = "VisualStudio2012Dark";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button _deleteButton;
		private System.Windows.Forms.Button _modifyButton;
		private System.Windows.Forms.Label _selezionaLabel;
		private System.Windows.Forms.ComboBox _usersComboBox;
	}
}