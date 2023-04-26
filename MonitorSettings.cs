namespace VPNMonitor
{
	[System.Serializable]
	public class MonitorSettings
	{
		/// <summary>
		/// The time period, in seconds, the balloon tip should display.
		/// </summary>
		[System.ComponentModel.DefaultValue(4)]
		public int BalloonTipTimeout { get; set; } = 4;

		[System.Xml.Serialization.XmlArrayItem("Item")]
		public System.Collections.Generic.List<InterfaceItem> Items { get; private set; } = new System.Collections.Generic.List<InterfaceItem>();
	}
}
