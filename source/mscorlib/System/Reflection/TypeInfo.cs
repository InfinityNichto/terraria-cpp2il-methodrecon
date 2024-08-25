using System;

namespace System.Reflection
{
	// Token: 0x020004F7 RID: 1271
	public abstract class TypeInfo : Type
	{
		// Token: 0x060024DA RID: 9434 RVA: 0x000516F8 File Offset: 0x0004F8F8
		protected TypeInfo()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x0400143E RID: 5182
		private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
