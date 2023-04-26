using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace VPNMonitor
{
	public partial class SettingsForm : Form
	{
		private readonly MonitorSettings Settings = null;
		private readonly System.Collections.Generic.List<InterfaceItem> Items = new System.Collections.Generic.List<InterfaceItem>();

		public SettingsForm(MonitorSettings settings)
		{
			InitializeComponent();

			this.Settings = settings;
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			foreach (var item in this.Settings.Items)
			{
				var newItem = new InterfaceItem
				{
					Id = item.Id,
					Name = item.Name,
				};

				this.Items.Add(newItem);
			}

			this.bindingSource.DataSource = this.Items;

			this.balloonTipTimeoutEdit.Value = this.Settings.BalloonTipTimeout;
		}

		private void fillListBtn_Click(object sender, System.EventArgs e)
		{
			if (NetworkInterface.GetIsNetworkAvailable())
			{
				NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
				foreach (NetworkInterface networkInterface in interfaces)
				{
					var item = new InterfaceItem
					{
						Id = networkInterface.Id,
						Name = networkInterface.Name,
					};

					if (this.Items.Contains(item))
					{
						this.Items.Remove(item);
					}

					this.Items.Add(item);
				}
			}

			this.bindingSource.ResetBindings(false);
		}

		private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.DialogResult == DialogResult.OK)
			{
				this.Settings.BalloonTipTimeout = (int)this.balloonTipTimeoutEdit.Value;

				this.Settings.Items.Clear();
				this.Settings.Items.AddRange(this.Items);
			}
		}
	}
}
