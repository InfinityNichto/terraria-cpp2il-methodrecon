using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000438 RID: 1080
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, Inherited = false)]
	[ComVisible(true)]
	public sealed class DispIdAttribute : Attribute
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x0004C004 File Offset: 0x0004A204
		public DispIdAttribute(int dispId)
		{
			this._val = dispId;
		}

		// Token: 0x040011FB RID: 4603
		internal int _val;
	}
}
