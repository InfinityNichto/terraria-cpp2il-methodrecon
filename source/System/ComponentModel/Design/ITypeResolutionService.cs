using System;
using System.Reflection;

namespace System.ComponentModel.Design
{
	// Token: 0x02000413 RID: 1043
	public interface ITypeResolutionService
	{
		// Token: 0x06001C15 RID: 7189
		Type GetType(string name);

		// Token: 0x06001C16 RID: 7190
		string GetPathOfAssembly(AssemblyName name);
	}
}
