namespace VPNMonitor
{
	[System.Serializable]
	public class NetworkInterfaceStatus : System.IComparable
	{
		/// <summary>
		/// Id
		/// </summary>
		[System.ComponentModel.DefaultValue(null)]
		public string Id { get; set; }

		/// <summary>
		/// Megnevezés
		/// </summary>
		[System.ComponentModel.DefaultValue(null)]
		public string Name { get; set; }

		/// <summary>
		/// Állapot
		/// </summary>
		[System.ComponentModel.DefaultValue(System.Net.NetworkInformation.OperationalStatus.Unknown)]
		public System.Net.NetworkInformation.OperationalStatus StateValue { get; set; }

		[System.Xml.Serialization.XmlIgnore]
		public string StateName => StateValue.ToString();

		/// <summary>
		/// Összehasonlít két objektumot.
		/// </summary>
		/// <param name="otherObj">A másik objektum.</param>
		/// <returns>
		/// Az összehasonlítás eredménye: 
		/// megelőzi, azonos, vagy mögöttes a sorrendben.
		/// </returns>
		public int CompareTo(object otherObj)
		{
			if (otherObj == null)
			{
				return 1;
			}

			if (this.Name == null)
			{
				return -1;
			}

			if (otherObj is NetworkInterfaceStatus typedOtherObj)
			{
				return this.Name.ToString().CompareTo(typedOtherObj.Name?.ToString());
			}
			else
			{
				throw new System.ArgumentException($"Object is not an {typeof(NetworkInterfaceStatus)}");
			}
		}
	}
}
