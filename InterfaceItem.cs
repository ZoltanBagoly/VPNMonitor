namespace VPNMonitor
{
	[System.Serializable]
	public class InterfaceItem : System.IComparable, System.IEquatable<InterfaceItem>
	{
		public InterfaceItem() { }

		/// <summary>
		/// Id
		/// </summary>
		[System.Xml.Serialization.XmlAttribute]
		[System.ComponentModel.DefaultValue(null)]
		public string Id { get; set; } = null;

		/// <summary>
		/// Megnevezés
		/// </summary>
		[System.Xml.Serialization.XmlAttribute]
		[System.ComponentModel.DefaultValue(null)]
		public string Name { get; set; } = null;

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

			if (otherObj is InterfaceItem typedOtherObj)
			{
				return string.Compare(this.Id, typedOtherObj.Id, System.StringComparison.InvariantCultureIgnoreCase);
			}
			else
			{
				throw new System.ArgumentException($"Object is not an {typeof(InterfaceItem)}");
			}
		}

		/// <summary>
		/// Az objektumot reprezentáló string
		/// </summary>
		/// <returns>Az objektumot reprezentáló string: Megnevezés</returns>
		public override string ToString() => this.Id;

		public bool Equals(InterfaceItem other)
		{
			// Check whether the compared object is null.
			if (other is null)
			{
				return false;
			}

			// Check whether the compared object references the same data.
			if (ReferenceEquals(this, other))
			{
				return true;
			}

			// Check whether properties are equal.
			return this.CompareTo(other) == 0;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is InterfaceItem itemObj))
			{
				return false;
			}
			else
			{
				return this.Equals(itemObj);
			}
		}

		public override int GetHashCode()
		{
			return this.Id == null ? 0 : this.Id.GetHashCode();
		}

		public static bool operator ==(InterfaceItem obj1, InterfaceItem obj2)
		{
			return obj1 is null ? object.Equals(obj1, obj2) : obj1.Equals(obj2);
		}

		public static bool operator !=(InterfaceItem obj1, InterfaceItem obj2)
		{
			return obj1 is null ? !object.Equals(obj1, obj2) : !obj1.Equals(obj2);
		}
	}
}
