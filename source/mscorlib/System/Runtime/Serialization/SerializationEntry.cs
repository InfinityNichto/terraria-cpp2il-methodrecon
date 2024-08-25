using System;
using Cpp2IlInjected;

namespace System.Runtime.Serialization
{
	// Token: 0x020003C9 RID: 969
	public readonly struct SerializationEntry
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x00043500 File Offset: 0x00041700
		internal SerializationEntry(string entryName, object entryValue, Type entryType)
		{
			this._name = entryName;
			this._value = entryValue;
			this._type = entryType;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00043524 File Offset: 0x00041724
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0000207A File Offset: 0x0000027A
		public string Name
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000F76 RID: 3958
		private readonly string _name;

		// Token: 0x04000F77 RID: 3959
		private readonly object _value;

		// Token: 0x04000F78 RID: 3960
		private readonly Type _type;
	}
}
