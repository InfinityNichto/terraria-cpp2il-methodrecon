using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200044A RID: 1098
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public sealed class FieldOffsetAttribute : Attribute
	{
		// Token: 0x06002178 RID: 8568 RVA: 0x0004C194 File Offset: 0x0004A394
		public FieldOffsetAttribute(int offset)
		{
			this._val = offset;
		}

		// Token: 0x04001270 RID: 4720
		internal int _val;
	}
}
