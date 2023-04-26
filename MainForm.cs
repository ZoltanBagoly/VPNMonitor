using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace VPNMonitor
{
	public partial class MainForm : Form
	{
		private readonly System.Collections.Generic.List<NetworkInterfaceStatus> StatusList = new System.Collections.Generic.List<NetworkInterfaceStatus>();

		private MonitorSettings Settings = null;
		private string CfgFileName = null;
		private bool AllUp = true;

		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(System.EventArgs e)
		{
			this.Visible = false; // Hide form window.
			this.ShowInTaskbar = false;

			base.OnLoad(e);

			this.bindingSource.DataSource = this.StatusList;

			string[] commandLineArgs = System.Environment.GetCommandLineArgs();

			this.CfgFileName = System.IO.Path.ChangeExtension(
				commandLineArgs[0],
				".cfg"); // DO NOT LOCALIZE

			try
			{
				using (var xmlReader = System.Xml.XmlReader.Create(this.CfgFileName))
				{
					var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(MonitorSettings));

					this.Settings = (MonitorSettings)xmlSerializer.Deserialize(xmlReader);

					xmlReader.Close();
				}
			}
			catch
			{
				this.Settings = new MonitorSettings();
			}

			this.PerformUpdateNetworkStatus();

			NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(this.AddressChangedCallback);
		}

		private void AddressChangedCallback(object sender, System.EventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new MethodInvoker(this.UpdateNetworkStatus));
			}
			else
			{
				this.PerformUpdateNetworkStatus();
			}
		}

		private void UpdateNetworkStatus()
		{
			this.PerformUpdateNetworkStatus();

			this.notifyIcon.ShowBalloonTip(this.Settings.BalloonTipTimeout * 1000);
		}

		private void PerformUpdateNetworkStatus()
		{
			this.AllUp = true;

			this.bindingSource.RaiseListChangedEvents = false;

			try
			{
				this.StatusList.Clear();

				if (NetworkInterface.GetIsNetworkAvailable())
				{
					NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
					foreach (NetworkInterface networkInterface in interfaces)
					{
						var state = new NetworkInterfaceStatus
						{
							Id = networkInterface.Id,
							Name = networkInterface.Name,
							StateValue = networkInterface.OperationalStatus,
						};

						this.StatusList.Add(state);
					}
				}

				foreach (var item in this.Settings.Items)
				{
					var status = this.StatusList.Find(x => x.Id == item.Id);
					if (status == null)
					{
						this.AllUp = false;
					}
					else
					{
						if (status.StateValue != OperationalStatus.Up)
						{
							this.AllUp = false;
						}
					}

					if (!this.AllUp)
					{
						break;
					}
				}

				this.StatusList.Sort();
			}
			finally
			{
				this.bindingSource.RaiseListChangedEvents = true;
				this.bindingSource.ResetBindings(metadataChanged: false);
			}

			if (this.AllUp)
			{
				this.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
				this.notifyIcon.BalloonTipText = Properties.Resources.VPN_State_Up;
				this.notifyIcon.Text = $"{this.Text}{System.Environment.NewLine}{Properties.Resources.VPN_State_Up}";
				this.notifyIcon.Icon = Properties.Resources.Vpn;
			}
			else
			{
				this.notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;
				this.notifyIcon.BalloonTipText = Properties.Resources.VPN_State_Down;
				this.notifyIcon.Text = $"{this.Text}{System.Environment.NewLine}{Properties.Resources.VPN_State_Down}";
				this.notifyIcon.Icon = Properties.Resources.Vpn_red;
			}
		}

		private void ShowWindow()
		{
			this.Show();
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}
			this.Activate();
		}

		private void notifyIcon_DoubleClick(object sender, System.EventArgs e)
		{
			this.ShowWindow();
		}

		private void showMenuItem_Click(object sender, System.EventArgs e)
		{
			this.ShowWindow();
		}

		private void exitMenuItem_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void settingsMenuItem_Click(object sender, System.EventArgs e)
		{
			using (var form = new SettingsForm(this.Settings))
			{
				form.ShowDialog(this);
			}
		}

		private void MainForm_Resize(object sender, System.EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = MessageBox.Show(
				this,
				Properties.Resources.Msg_Que_Exit,
				Properties.Resources.Cap_Confirm,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question,
				MessageBoxDefaultButton.Button2) != DialogResult.Yes;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				var xmlWriterSettings = new System.Xml.XmlWriterSettings
				{
					Indent = true,
					Encoding = System.Text.Encoding.UTF8,
					OmitXmlDeclaration = false,
				};

				using (var xmlWriter = System.Xml.XmlWriter.Create(this.CfgFileName, xmlWriterSettings))
				{
					var xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.Settings.GetType());

					var emptyNamepsaces = new System.Xml.Serialization.XmlSerializerNamespaces(new[] { System.Xml.XmlQualifiedName.Empty });
					xmlSerializer.Serialize(xmlWriter, this.Settings, emptyNamepsaces);

					xmlWriter.Flush();
					xmlWriter.Close();
				}
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}
		}
	}
}
