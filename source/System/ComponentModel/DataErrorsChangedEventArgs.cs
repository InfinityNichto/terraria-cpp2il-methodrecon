using System;

namespace System.ComponentModel
{
	// Token: 0x020003CC RID: 972
	public class DataErrorsChangedEventArgs : EventArgs
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x000479D4 File Offset: 0x00045BD4
		public DataErrorsChangedEventArgs(string propertyName)
		{
			if (!true)
			{
			}
			base..ctor();
			this._propertyName = propertyName;
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x000479F4 File Offset: 0x00045BF4
		public virtual string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x040012DD RID: 4829
		private readonly string _propertyName;
	}
}
