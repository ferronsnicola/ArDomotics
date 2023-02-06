namespace progetto_ingegneria_del_software.view {
	partial class LoginForm {
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
			this._darkTheme = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
			this._panel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this._welcome_lbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this._username_lbl = new System.Windows.Forms.Label();
			this._username_tbx = new System.Windows.Forms.TextBox();
			this._password_lbl = new System.Windows.Forms.Label();
			this._password_tbx = new System.Windows.Forms.TextBox();
			this._loginButton = new System.Windows.Forms.Button();
			this._panel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// _panel
			// 
			this._panel.Controls.Add(this.tableLayoutPanel1);
			this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._panel.Location = new System.Drawing.Point(0, 0);
			this._panel.Name = "_panel";
			this._panel.Size = new System.Drawing.Size(472, 283);
			this._panel.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this._welcome_lbl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 283);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// _welcome_lbl
			// 
			this._welcome_lbl.AutoSize = true;
			this._welcome_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._welcome_lbl.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._welcome_lbl.ForeColor = System.Drawing.Color.Coral;
			this._welcome_lbl.Location = new System.Drawing.Point(3, 0);
			this._welcome_lbl.Name = "_welcome_lbl";
			this._welcome_lbl.Size = new System.Drawing.Size(466, 155);
			this._welcome_lbl.TabIndex = 2;
			this._welcome_lbl.Text = "WELCOME TO ARDOMOTICA";
			this._welcome_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.75034F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.24965F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 158);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(466, 122);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this._username_lbl, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this._username_tbx, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this._password_lbl, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this._password_tbx, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this._loginButton, 1, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 116);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// _username_lbl
			// 
			this._username_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._username_lbl.AutoSize = true;
			this._username_lbl.Font = new System.Drawing.Font("Segoe UI", 12F);
			this._username_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._username_lbl.Location = new System.Drawing.Point(95, 8);
			this._username_lbl.Name = "_username_lbl";
			this._username_lbl.Size = new System.Drawing.Size(84, 21);
			this._username_lbl.TabIndex = 3;
			this._username_lbl.Text = "Username:";
			// 
			// _username_tbx
			// 
			this._username_tbx.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._username_tbx.Location = new System.Drawing.Point(185, 9);
			this._username_tbx.Name = "_username_tbx";
			this._username_tbx.Size = new System.Drawing.Size(177, 20);
			this._username_tbx.TabIndex = 0;
			// 
			// _password_lbl
			// 
			this._password_lbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._password_lbl.AutoSize = true;
			this._password_lbl.Font = new System.Drawing.Font("Segoe UI", 12F);
			this._password_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._password_lbl.Location = new System.Drawing.Point(100, 46);
			this._password_lbl.Name = "_password_lbl";
			this._password_lbl.Size = new System.Drawing.Size(79, 21);
			this._password_lbl.TabIndex = 4;
			this._password_lbl.Text = "Password:";
			// 
			// _password_tbx
			// 
			this._password_tbx.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._password_tbx.Location = new System.Drawing.Point(185, 47);
			this._password_tbx.Name = "_password_tbx";
			this._password_tbx.PasswordChar = '*';
			this._password_tbx.Size = new System.Drawing.Size(177, 20);
			this._password_tbx.TabIndex = 1;
			// 
			// _loginButton
			// 
			this._loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this._loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._loginButton.Font = new System.Drawing.Font("Segoe UI", 10F);
			this._loginButton.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._loginButton.Location = new System.Drawing.Point(236, 79);
			this._loginButton.Name = "_loginButton";
			this._loginButton.Size = new System.Drawing.Size(75, 34);
			this._loginButton.TabIndex = 5;
			this._loginButton.Text = "Login";
			this._loginButton.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 283);
			this.Controls.Add(this._panel);
			this.Name = "LoginForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ThemeName = "VisualStudio2012Dark";
			this._panel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Telerik.WinControls.Themes.VisualStudio2012DarkTheme _darkTheme;
		private System.Windows.Forms.Panel _panel;
		private System.Windows.Forms.Button _loginButton;
		private System.Windows.Forms.Label _password_lbl;
		private System.Windows.Forms.Label _username_lbl;
		private System.Windows.Forms.Label _welcome_lbl;
		private System.Windows.Forms.TextBox _password_tbx;
		private System.Windows.Forms.TextBox _username_tbx;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	}
}
