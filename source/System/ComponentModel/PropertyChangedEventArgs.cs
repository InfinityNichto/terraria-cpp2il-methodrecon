using System;

namespace System.ComponentModel
{
	// Token: 0x020003D0 RID: 976
	public class PropertyChangedEventArgs : EventArgs
	{
		// Token: 0x060019CE RID: 6606 RVA: 0x00047A08 File Offset: 0x00045C08
		public PropertyChangedEventArgs(string propertyName)
		{
			if (!true)
			{
			}
			base..ctor();
			this._propertyName = propertyName;
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00047A28 File Offset: 0x00045C28
		public virtual string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x040012DE RID: 4830
		private readonly string _propertyName;
	}
}
