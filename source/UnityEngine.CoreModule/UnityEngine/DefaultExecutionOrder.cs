using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B5 RID: 181
	[AttributeUsage(AttributeTargets.Class)]
	[UsedByNativeCode]
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00006938 File Offset: 0x00004B38
		public int order
		{
			get
			{
				return this.m_Order;
			}
		}

		// Token: 0x0400036F RID: 879
		private int m_Order;
	}
}
