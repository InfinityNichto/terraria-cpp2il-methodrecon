using System;
using System.Reflection;
using System.Threading;

namespace System
{
	// Token: 0x02000168 RID: 360
	internal sealed class TypeNameParser
	{
		// Token: 0x06000E90 RID: 3728 RVA: 0x0001F7CC File Offset: 0x0001D9CC
		internal static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, StackCrawlMark stackMark)
		{
			Type type;
			return type;
		}
	}
}
