using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000009 RID: 9
	[Preserve]
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000240C File Offset: 0x0000060C
		public PropertyChangingEventArgs(string propertyName)
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002424 File Offset: 0x00000624
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002438 File Offset: 0x00000638
		public virtual string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return this.<PropertyName>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<PropertyName>k__BackingField = value;
			}
		}

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		private string <PropertyName>k__BackingField;
	}
}
