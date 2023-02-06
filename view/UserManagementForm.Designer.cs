namespace progetto_ingegneria_del_software.view
{
    partial class UserManagementForm
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
			this._nomeUtenteLabel = new System.Windows.Forms.Label();
			this._usernameLabel = new System.Windows.Forms.Label();
			this._passwordLabel = new System.Windows.Forms.Label();
			this._cameraLable = new System.Windows.Forms.Label();
			this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._addUserButton = new System.Windows.Forms.Button();
			this._modifyUserButton = new System.Windows.Forms.Button();
			this._nameTextBox = new System.Windows.Forms.TextBox();
			this._passwordTextBox = new System.Windows.Forms.TextBox();
			this._usernameTextBox = new System.Windows.Forms.TextBox();
			this._roomsCheckList = new Telerik.WinControls.UI.RadCheckedDropDownList();
			this._tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._roomsCheckList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// _nomeUtenteLabel
			// 
			this._nomeUtenteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._nomeUtenteLabel.AutoSize = true;
			this._nomeUtenteLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._nomeUtenteLabel.Location = new System.Drawing.Point(29, 29);
			this._nomeUtenteLabel.Name = "_nomeUtenteLabel";
			this._nomeUtenteLabel.Size = new System.Drawing.Size(75, 13);
			this._nomeUtenteLabel.TabIndex = 1;
			this._nomeUtenteLabel.Text = "Nome Utente";
			// 
			// _usernameLabel
			// 
			this._usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._usernameLabel.AutoSize = true;
			this._usernameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._usernameLabel.Location = new System.Drawing.Point(29, 74);
			this._usernameLabel.Name = "_usernameLabel";
			this._usernameLabel.Size = new System.Drawing.Size(58, 13);
			this._usernameLabel.TabIndex = 2;
			this._usernameLabel.Text = "Username";
			// 
			// _passwordLabel
			// 
			this._passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._passwordLabel.AutoSize = true;
			this._passwordLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._passwordLabel.Location = new System.Drawing.Point(29, 118);
			this._passwordLabel.Name = "_passwordLabel";
			this._passwordLabel.Size = new System.Drawing.Size(56, 13);
			this._passwordLabel.TabIndex = 3;
			this._passwordLabel.Text = "Password";
			// 
			// _cameraLable
			// 
			this._cameraLable.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._cameraLable.AutoSize = true;
			this._cameraLable.ForeColor = System.Drawing.Color.CornflowerBlue;
			this._cameraLable.Location = new System.Drawing.Point(29, 162);
			this._cameraLable.Name = "_cameraLable";
			this._cameraLable.Size = new System.Drawing.Size(45, 13);
			this._cameraLable.TabIndex = 4;
			this._cameraLable.Text = "Camera";
			// 
			// _tableLayoutPanel
			// 
			this._tableLayoutPanel.ColumnCount = 2;
			this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tableLayoutPanel.Controls.Add(this._addUserButton, 0, 0);
			this._tableLayoutPanel.Controls.Add(this._modifyUserButton, 1, 0);
			this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._tableLayoutPanel.Location = new System.Drawing.Point(0, 229);
			this._tableLayoutPanel.Name = "_tableLayoutPanel";
			this._tableLayoutPanel.RowCount = 1;
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayoutPanel.Size = new System.Drawing.Size(284, 32);
			this._tableLayoutPanel.TabIndex = 5;
			// 
			// _addUserButton
			// 
			this._addUserButton.Cursor = System.Windows.Forms.Cursors.Default;
			this._addUserButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._addUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._addUserButton.Location = new System.Drawing.Point(3, 3);
			this._addUserButton.Name = "_addUserButton";
			this._addUserButton.Size = new System.Drawing.Size(136, 26);
			this._addUserButton.TabIndex = 4;
			this._addUserButton.Text = "Add User";
			this._addUserButton.UseVisualStyleBackColor = true;
			// 
			// _modifyUserButton
			// 
			this._modifyUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this._modifyUserButton.Location = new System.Drawing.Point(145, 3);
			this._modifyUserButton.Name = "_modifyUserButton";
			this._modifyUserButton.Size = new System.Drawing.Size(136, 26);
			this._modifyUserButton.TabIndex = 5;
			this._modifyUserButton.Text = "Modify User";
			this._modifyUserButton.UseVisualStyleBackColor = true;
			// 
			// _nameTextBox
			// 
			this._nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._nameTextBox.Location = new System.Drawing.Point(138, 22);
			this._nameTextBox.Name = "_nameTextBox";
			this._nameTextBox.Size = new System.Drawing.Size(125, 20);
			this._nameTextBox.TabIndex = 0;
			// 
			// _passwordTextBox
			// 
			this._passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._passwordTextBox.Location = new System.Drawing.Point(138, 111);
			this._passwordTextBox.Name = "_passwordTextBox";
			this._passwordTextBox.Size = new System.Drawing.Size(125, 20);
			this._passwordTextBox.TabIndex = 2;
			// 
			// _usernameTextBox
			// 
			this._usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._usernameTextBox.Location = new System.Drawing.Point(138, 67);
			this._usernameTextBox.Name = "_usernameTextBox";
			this._usernameTextBox.Size = new System.Drawing.Size(125, 20);
			this._usernameTextBox.TabIndex = 1;
			// 
			// _roomsCheckList
			// 
			this._roomsCheckList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this._roomsCheckList.Location = new System.Drawing.Point(138, 162);
			this._roomsCheckList.Name = "_roomsCheckList";
			this._roomsCheckList.Size = new System.Drawing.Size(125, 24);
			this._roomsCheckList.TabIndex = 3;
			this._roomsCheckList.ThemeName = "VisualStudio2012Light";
			// 
			// UserManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this._roomsCheckList);
			this.Controls.Add(this._usernameTextBox);
			this.Controls.Add(this._passwordTextBox);
			this.Controls.Add(this._nameTextBox);
			this.Controls.Add(this._tableLayoutPanel);
			this.Controls.Add(this._cameraLable);
			this.Controls.Add(this._passwordLabel);
			this.Controls.Add(this._usernameLabel);
			this.Controls.Add(this._nomeUtenteLabel);
			this.Name = "UserManagementForm";
			// 
			// 
			// 
			this.RootElement.ApplyShapeToControl = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Gestione utente";
			this.ThemeName = "VisualStudio2012Dark";
			this._tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._roomsCheckList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nomeUtenteLabel;
        private System.Windows.Forms.Label _usernameLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _cameraLable;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Button _addUserButton;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.TextBox _usernameTextBox;
        private Telerik.WinControls.UI.RadCheckedDropDownList _roomsCheckList;
		private System.Windows.Forms.Button _modifyUserButton;
	}
}