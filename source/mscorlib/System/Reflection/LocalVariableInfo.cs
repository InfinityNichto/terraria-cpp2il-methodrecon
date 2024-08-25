using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000505 RID: 1285
	[ComVisible(true)]
	[StructLayout(0)]
	public class LocalVariableInfo
	{
		// Token: 0x06002562 RID: 9570 RVA: 0x00052A34 File Offset: 0x00050C34
		protected LocalVariableInfo()
		{
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00052A48 File Offset: 0x00050C48
		public override string ToString()
		{
			bool flag = this.is_pinned;
			Type type = this.type;
			ushort num = this.position;
			if (flag)
			{
				return "{0} ({1}) (pinned)";
			}
			string text;
			return text;
		}

		// Token: 0x040014CA RID: 5322
		internal Type type;

		// Token: 0x040014CB RID: 5323
		internal bool is_pinned;

		// Token: 0x040014CC RID: 5324
		internal ushort position;
	}
}
