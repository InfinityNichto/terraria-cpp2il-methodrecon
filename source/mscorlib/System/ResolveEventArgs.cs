using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000F4 RID: 244
	public class ResolveEventArgs : EventArgs
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x00015F6C File Offset: 0x0001416C
		public ResolveEventArgs(string name)
		{
			if (!true)
			{
			}
			base..ctor();
			this.<Name>k__BackingField = name;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00015F8C File Offset: 0x0001418C
		public ResolveEventArgs(string name, Assembly requestingAssembly)
		{
			if (!true)
			{
			}
			base..ctor();
			this.<Name>k__BackingField = name;
			this.<RequestingAssembly>k__BackingField = requestingAssembly;
		}

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private readonly string <Name>k__BackingField;

		// Token: 0x04000394 RID: 916
		[CompilerGenerated]
		private readonly Assembly <RequestingAssembly>k__BackingField;
	}
}
