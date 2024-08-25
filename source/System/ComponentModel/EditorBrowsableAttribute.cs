using System;

namespace System.ComponentModel
{
	// Token: 0x0200032C RID: 812
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x0600152D RID: 5421 RVA: 0x0003FA98 File Offset: 0x0003DC98
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
			this.browsableState = state;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0003FAB4 File Offset: 0x0003DCB4
		public EditorBrowsableAttribute()
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		public EditorBrowsableState State
		{
			get
			{
				return this.browsableState;
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0003FADC File Offset: 0x0003DCDC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0400116E RID: 4462
		private EditorBrowsableState browsableState;
	}
}
