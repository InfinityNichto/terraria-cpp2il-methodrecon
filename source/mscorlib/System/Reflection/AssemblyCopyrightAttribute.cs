using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020004BE RID: 1214
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyCopyrightAttribute : Attribute
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x000502AC File Offset: 0x0004E4AC
		public AssemblyCopyrightAttribute(string copyright)
		{
			this.<Copyright>k__BackingField = copyright;
		}

		// Token: 0x04001359 RID: 4953
		[CompilerGenerated]
		private readonly string <Copyright>k__BackingField;
	}
}
