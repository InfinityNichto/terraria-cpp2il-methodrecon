using System;

namespace UnityEngine
{
	// Token: 0x0200008D RID: 141
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public HeaderAttribute(string header)
		{
			this.header = header;
		}

		// Token: 0x04000324 RID: 804
		public readonly string header;
	}
}
