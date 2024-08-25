using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	// Token: 0x02000352 RID: 850
	[ComVisible(true)]
	public class TypeEntry
	{
		// Token: 0x06001C76 RID: 7286 RVA: 0x0003DE88 File Offset: 0x0003C088
		protected TypeEntry()
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x0003DE9C File Offset: 0x0003C09C
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
		public string AssemblyName
		{
			get
			{
				return this.assembly_name;
			}
			set
			{
				this.assembly_name = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x0003DEC4 File Offset: 0x0003C0C4
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0003DED8 File Offset: 0x0003C0D8
		public string TypeName
		{
			get
			{
				return this.type_name;
			}
			set
			{
				this.type_name = value;
			}
		}

		// Token: 0x04000E6C RID: 3692
		private string assembly_name;

		// Token: 0x04000E6D RID: 3693
		private string type_name;
	}
}
