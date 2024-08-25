using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200008A RID: 138
	public class AssemblyLoadEventArgs : EventArgs
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x0000C550 File Offset: 0x0000A750
		public AssemblyLoadEventArgs(Assembly loadedAssembly)
		{
			if (!true)
			{
			}
			base..ctor();
			this.<LoadedAssembly>k__BackingField = loadedAssembly;
		}

		// Token: 0x040001E5 RID: 485
		[CompilerGenerated]
		private readonly Assembly <LoadedAssembly>k__BackingField;
	}
}
