using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000AF RID: 175
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[RequiredByNativeCode]
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x0600031E RID: 798 RVA: 0x000068A8 File Offset: 0x00004AA8
		public RequireComponent(Type requiredComponent)
		{
			this.m_Type0 = requiredComponent;
		}

		// Token: 0x0400036A RID: 874
		public Type m_Type0;

		// Token: 0x0400036B RID: 875
		public Type m_Type1;

		// Token: 0x0400036C RID: 876
		public Type m_Type2;
	}
}
