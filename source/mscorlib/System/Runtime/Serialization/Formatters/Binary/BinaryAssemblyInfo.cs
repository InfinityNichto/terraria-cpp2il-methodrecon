using System;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000401 RID: 1025
	internal sealed class BinaryAssemblyInfo
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x00045DC4 File Offset: 0x00043FC4
		internal BinaryAssemblyInfo(string assemblyString)
		{
			this.assemblyString = assemblyString;
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x00045DE0 File Offset: 0x00043FE0
		internal BinaryAssemblyInfo(string assemblyString, Assembly assembly)
		{
			this.assemblyString = assemblyString;
			this.assembly = assembly;
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00045E04 File Offset: 0x00044004
		internal Assembly GetAssembly()
		{
			Assembly assembly = this.assembly;
			Assembly assembly2 = FormatterServices.LoadAssemblyFromStringNoThrow(this.assemblyString);
			this.assembly = assembly2;
			return this.assembly;
		}

		// Token: 0x0400105C RID: 4188
		internal string assemblyString;

		// Token: 0x0400105D RID: 4189
		private Assembly assembly;
	}
}
