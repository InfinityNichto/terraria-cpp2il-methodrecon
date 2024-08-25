using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000442 RID: 1090
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class GuidAttribute : Attribute
	{
		// Token: 0x0600216D RID: 8557 RVA: 0x0004C09C File Offset: 0x0004A29C
		public GuidAttribute(string guid)
		{
			this._val = guid;
		}

		// Token: 0x0400125D RID: 4701
		internal string _val;
	}
}
