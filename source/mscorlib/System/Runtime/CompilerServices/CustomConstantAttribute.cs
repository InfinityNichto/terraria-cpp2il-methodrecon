using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200046C RID: 1132
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	[Serializable]
	public abstract class CustomConstantAttribute : Attribute
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06002208 RID: 8712
		public abstract object Value { get; }

		// Token: 0x06002209 RID: 8713 RVA: 0x0004CD60 File Offset: 0x0004AF60
		protected CustomConstantAttribute()
		{
		}
	}
}
