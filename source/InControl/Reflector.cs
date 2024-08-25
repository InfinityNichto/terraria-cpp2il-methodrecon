using System;
using System.Collections.Generic;
using System.Reflection;

namespace InControl
{
	// Token: 0x0200006C RID: 108
	public static class Reflector
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0000FC54 File Offset: 0x0000DE54
		public static IEnumerable<Type> AllAssemblyTypes
		{
			get
			{
				do
				{
					if (!true)
					{
					}
				}
				while (true);
				if (!true)
				{
				}
				return Reflector.GetAllAssemblyTypes();
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000FC70 File Offset: 0x0000DE70
		private static bool IgnoreAssemblyWithName(string assemblyName)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000FC88 File Offset: 0x0000DE88
		private static IEnumerable<Type> GetAllAssemblyTypes()
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			bool flag;
			if (flag)
			{
				return;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		// Note: this type is marked as 'beforefieldinit'.
		static Reflector()
		{
			if (("Unity" == null || "Unity" != null) && ("UnityEngine" == null || "UnityEngine" != null) && ("UnityEditor" == null || "UnityEditor" != null) && ("mscorlib" == null || "mscorlib" != null) && ("Microsoft" == null || "Microsoft" != null) && ("System" == null || "System" != null) && ("Mono" == null || "Mono" != null) && ("JetBrains" == null || "JetBrains" != null) && ("nunit" == null || "nunit" != null) && ("ExCSS" == null || "ExCSS" != null) && ("ICSharpCode" == null || "ICSharpCode" != null) && ("AssetStoreTools" == null || "AssetStoreTools" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly string[] ignoreAssemblies;

		// Token: 0x040003F1 RID: 1009
		private static IEnumerable<Type> assemblyTypes;
	}
}
