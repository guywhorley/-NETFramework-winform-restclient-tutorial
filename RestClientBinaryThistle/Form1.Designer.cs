namespace RestClientBinaryThistle
{
	partial class Form1
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
			this.txtRequest = new System.Windows.Forms.TextBox();
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.grpbxAuthType = new System.Windows.Forms.GroupBox();
			this.grpboxTechnique = new System.Windows.Forms.GroupBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.rbBasicAuth = new System.Windows.Forms.RadioButton();
			this.rbNtlmAuth = new System.Windows.Forms.RadioButton();
			this.rbRollYourOwn = new System.Windows.Forms.RadioButton();
			this.rbNetworkCred = new System.Windows.Forms.RadioButton();
			this.grpbxAuthType.SuspendLayout();
			this.grpboxTechnique.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtRequest
			// 
			this.txtRequest.Location = new System.Drawing.Point(73, 12);
			this.txtRequest.Name = "txtRequest";
			this.txtRequest.Size = new System.Drawing.Size(545, 20);
			this.txtRequest.TabIndex = 0;
			// 
			// txtResponse
			// 
			this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtResponse.Location = new System.Drawing.Point(73, 160);
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResponse.Size = new System.Drawing.Size(545, 209);
			this.txtResponse.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Request Url";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Response";
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(543, 378);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 24);
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "GO!";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnClear
			// 
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Location = new System.Drawing.Point(443, 378);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear Response";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(73, 41);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(242, 20);
			this.txtUserName.TabIndex = 6;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(376, 38);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(242, 20);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// grpbxAuthType
			// 
			this.grpbxAuthType.Controls.Add(this.rbNtlmAuth);
			this.grpbxAuthType.Controls.Add(this.rbBasicAuth);
			this.grpbxAuthType.Location = new System.Drawing.Point(73, 66);
			this.grpbxAuthType.Name = "grpbxAuthType";
			this.grpbxAuthType.Size = new System.Drawing.Size(242, 91);
			this.grpbxAuthType.TabIndex = 8;
			this.grpbxAuthType.TabStop = false;
			this.grpbxAuthType.Text = "Authentication Type";
			// 
			// grpboxTechnique
			// 
			this.grpboxTechnique.Controls.Add(this.rbNetworkCred);
			this.grpboxTechnique.Controls.Add(this.rbRollYourOwn);
			this.grpboxTechnique.Location = new System.Drawing.Point(376, 66);
			this.grpboxTechnique.Name = "grpboxTechnique";
			this.grpboxTechnique.Size = new System.Drawing.Size(242, 91);
			this.grpboxTechnique.TabIndex = 9;
			this.grpboxTechnique.TabStop = false;
			this.grpboxTechnique.Text = "Technique";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(321, 41);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 10;
			this.lblPassword.Text = "Password";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(4, 41);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(57, 13);
			this.lblUserName.TabIndex = 11;
			this.lblUserName.Text = "UserName";
			// 
			// rbBasicAuth
			// 
			this.rbBasicAuth.AutoSize = true;
			this.rbBasicAuth.Checked = true;
			this.rbBasicAuth.Location = new System.Drawing.Point(22, 31);
			this.rbBasicAuth.Name = "rbBasicAuth";
			this.rbBasicAuth.Size = new System.Drawing.Size(51, 17);
			this.rbBasicAuth.TabIndex = 0;
			this.rbBasicAuth.TabStop = true;
			this.rbBasicAuth.Text = "Basic";
			this.rbBasicAuth.UseVisualStyleBackColor = true;
			// 
			// rbNtlmAuth
			// 
			this.rbNtlmAuth.AutoSize = true;
			this.rbNtlmAuth.Location = new System.Drawing.Point(22, 55);
			this.rbNtlmAuth.Name = "rbNtlmAuth";
			this.rbNtlmAuth.Size = new System.Drawing.Size(55, 17);
			this.rbNtlmAuth.TabIndex = 1;
			this.rbNtlmAuth.Text = "NTLM";
			this.rbNtlmAuth.UseVisualStyleBackColor = true;
			// 
			// rbRollYourOwn
			// 
			this.rbRollYourOwn.AutoSize = true;
			this.rbRollYourOwn.Checked = true;
			this.rbRollYourOwn.Location = new System.Drawing.Point(24, 31);
			this.rbRollYourOwn.Name = "rbRollYourOwn";
			this.rbRollYourOwn.Size = new System.Drawing.Size(93, 17);
			this.rbRollYourOwn.TabIndex = 0;
			this.rbRollYourOwn.TabStop = true;
			this.rbRollYourOwn.Text = "Roll Your Own";
			this.rbRollYourOwn.UseVisualStyleBackColor = true;
			// 
			// rbNetworkCred
			// 
			this.rbNetworkCred.AutoSize = true;
			this.rbNetworkCred.Location = new System.Drawing.Point(24, 55);
			this.rbNetworkCred.Name = "rbNetworkCred";
			this.rbNetworkCred.Size = new System.Drawing.Size(143, 17);
			this.rbNetworkCred.TabIndex = 1;
			this.rbNetworkCred.Text = "Network Credential Class";
			this.rbNetworkCred.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 407);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.grpboxTechnique);
			this.Controls.Add(this.grpbxAuthType);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResponse);
			this.Controls.Add(this.txtRequest);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Rest Client";
			this.grpbxAuthType.ResumeLayout(false);
			this.grpbxAuthType.PerformLayout();
			this.grpboxTechnique.ResumeLayout(false);
			this.grpboxTechnique.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRequest;
		private System.Windows.Forms.TextBox txtResponse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.GroupBox grpbxAuthType;
		private System.Windows.Forms.GroupBox grpboxTechnique;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.RadioButton rbNtlmAuth;
		private System.Windows.Forms.RadioButton rbBasicAuth;
		private System.Windows.Forms.RadioButton rbNetworkCred;
		private System.Windows.Forms.RadioButton rbRollYourOwn;
	}
}

