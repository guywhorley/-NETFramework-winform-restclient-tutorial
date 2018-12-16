using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RestClientBinaryThistle
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region UI Event Handlers

		private void btnGo_Click(object sender, EventArgs e)
		{
			RestClient rc = new RestClient();

			rc.endPoint = txtRequest.Text;
			//rc.authenticationTechnique = AuthenticationTechnique.RollYourOwn;
			rc.authenticationType = AuthenticationType.Basic;
			rc.userName = txtUserName.Text;
			rc.userPassword = txtPassword.Text;

			debugOutput("Rest client created.");

			string strResponse = string.Empty;
			strResponse = rc.makeRequest();
			debugOutput(strResponse);

		}
		#endregion

		#region Utils

		/// <summary>
		/// Write out message to response text box.
		/// </summary>
		/// <param name="strDebugText"></param>
		private void debugOutput(string strDebugText)
		{
			try
			{
				Debug.Write(strDebugText + Environment.NewLine);
				txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
				txtResponse.SelectionStart = txtResponse.TextLength;
				txtResponse.ScrollToCaret();
			}
			catch (Exception ex)
			{
				Debug.Write(ex.Message, ToString() + Environment.NewLine);
			}
		}

		#endregion

		private void button1_Click(object sender, EventArgs e)
		{
			txtResponse.Text = string.Empty;
		}
	}
}
