using System;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200041C RID: 1052
	internal sealed class SerObjectInfoCache
	{
		// Token: 0x060020A6 RID: 8358 RVA: 0x00048628 File Offset: 0x00046828
		internal SerObjectInfoCache(string typeName, string assemblyName, bool hasTypeForwardedFrom)
		{
			this.fullTypeName = typeName;
			this.assemblyString = assemblyName;
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0004864C File Offset: 0x0004684C
		internal SerObjectInfoCache(Type type)
		{
			if (!true)
			{
			}
			string text = BinaryFormatter.GetTypeInformation(type).fullTypeName;
			this.fullTypeName = text;
			this.hasTypeForwardedFrom = true;
		}

		// Token: 0x04001132 RID: 4402
		internal string fullTypeName;

		// Token: 0x04001133 RID: 4403
		internal string assemblyString;

		// Token: 0x04001134 RID: 4404
		internal bool hasTypeForwardedFrom;

		// Token: 0x04001135 RID: 4405
		internal MemberInfo[] memberInfos;

		// Token: 0x04001136 RID: 4406
		internal string[] memberNames;

		// Token: 0x04001137 RID: 4407
		internal Type[] memberTypes;
	}
}
