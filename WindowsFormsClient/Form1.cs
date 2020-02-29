using System;
using System.Configuration;
using System.Windows.Forms;
using WebServiceManagement;

namespace WindowsFormsClient
{
	public partial class Form1 : Form
	{
		private WebServiceManager webServiceManager;
		private static readonly int port = int.Parse(ConfigurationManager.AppSettings["DefaultPort"]);

		public Form1()
		{
			InitializeComponent();
			webServiceManager = new WebServiceManager(port);

			arrays.Click += delegate (object sender, EventArgs e) { CustomOnClickEvent(sender, e, ButtonType.B1); };
			average.Click += delegate (object sender, EventArgs e) { CustomOnClickEvent(sender, e, ButtonType.B2); };
			multiplication.Click += delegate (object sender, EventArgs e) { CustomOnClickEvent(sender, e, ButtonType.B3); };
			sortingAscending.Click += delegate (object sender, EventArgs e) { CustomOnClickEvent(sender, e, ButtonType.B4); };
			sortingDescending.Click += delegate (object sender, EventArgs e) { CustomOnClickEvent(sender, e, ButtonType.B5); };
			exit.Click += delegate (object sender, EventArgs e) { CustomOnClickEvent(sender, e, ButtonType.B6); };
		}

		private async void CustomOnClickEvent(object sender, EventArgs e, ButtonType type)
		{
			try
			{
				switch (type)
				{
					case ButtonType.B1:
						mainTextBox.Text += await webServiceManager.GetDataFromServiceAsync("arrays", "[1, 3, 5]") + "\n";
						MessageBox.Show("Test data is array [1, 3, 5]", "Test data info");
						break;
					case ButtonType.B2:
						mainTextBox.Text += await webServiceManager.GetDataFromServiceAsync("average", "[1, 3, 5]") + "\n";
						MessageBox.Show("Test data is array [1, 3, 5]", "Test data info");
						break;
					case ButtonType.B3:
						mainTextBox.Text += await webServiceManager.GetDataFromServiceAsync("multiplication", "{\"x\":5,\"y\":4}") + "\n";
						MessageBox.Show("Test data is x = 5; y = 4", "Test data info");
						break;
					case ButtonType.B4:
						mainTextBox.Text += await webServiceManager.GetDataFromServiceAsync("sorting", "{\"numbers\": [1, 78, 27, 3],\"sortType\":0}") + "\n";
						MessageBox.Show("Test data is array [1, 78, 27, 3]", "Test data info");
						break;
					case ButtonType.B5:
						mainTextBox.Text += await webServiceManager.GetDataFromServiceAsync("sorting", "{\"numbers\": [1, 78, 27, 3],\"sortType\":1}") + "\n";
						MessageBox.Show("Test data is array [1, 78, 27, 3]", "Test data info");
						break;
					case ButtonType.B6:
						Environment.Exit(0);
						break;
				}
			}
			catch
			{
				MessageBox.Show("Server unreachable. Please check server state", "Error");
			}
		}

		public enum ButtonType
		{
			B1, B2, B3, B4, B5, B6
		}
	}
}