using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020000A2 RID: 162
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class DefaultParameterValueAttribute : Attribute
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0000AD6C File Offset: 0x00008F6C
		public DefaultParameterValueAttribute(object value)
		{
			this.value = value;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000AD88 File Offset: 0x00008F88
		public object Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x04000277 RID: 631
		private object value;
	}
}
