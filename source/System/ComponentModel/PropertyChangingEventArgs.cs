using System;

namespace System.ComponentModel
{
	// Token: 0x020003D2 RID: 978
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x060019D4 RID: 6612 RVA: 0x00047AD0 File Offset: 0x00045CD0
		public PropertyChangingEventArgs(string propertyName)
		{
			if (!true)
			{
			}
			base..ctor();
			this._propertyName = propertyName;
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00047AF0 File Offset: 0x00045CF0
		public virtual string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x040012DF RID: 4831
		private readonly string _propertyName;
	}
}
