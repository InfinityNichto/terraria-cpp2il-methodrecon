using System;

namespace System
{
	// Token: 0x02000094 RID: 148
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[Serializable]
	public sealed class CLSCompliantAttribute : Attribute
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		public CLSCompliantAttribute(bool isCompliant)
		{
		}

		// Token: 0x0400020A RID: 522
		private bool _compliant;
	}
}
