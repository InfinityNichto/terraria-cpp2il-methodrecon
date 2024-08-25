using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200047B RID: 1147
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		// Token: 0x06002220 RID: 8736 RVA: 0x0004CF28 File Offset: 0x0004B128
		public RuntimeCompatibilityAttribute()
		{
		}

		// Token: 0x1700046D RID: 1133
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x0004CF3C File Offset: 0x0004B13C
		public bool WrapNonExceptionThrows
		{
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x040012B4 RID: 4788
		[CompilerGenerated]
		private bool <WrapNonExceptionThrows>k__BackingField;
	}
}
