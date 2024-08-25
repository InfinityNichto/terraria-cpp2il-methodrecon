using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	// Token: 0x02000356 RID: 854
	[ComVisible(true)]
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		// Token: 0x06001C83 RID: 7299 RVA: 0x0003E0A0 File Offset: 0x0003C2A0
		public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
		{
			this.assembly_name = assemblyName;
			this.type_name = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly;
			this.obj_uri = objectUri;
			this.obj_mode = mode;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x0003E0F0 File Offset: 0x0003C2F0
		public WellKnownObjectMode Mode
		{
			get
			{
				return this.obj_mode;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0003E104 File Offset: 0x0003C304
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0003E118 File Offset: 0x0003C318
		public string ObjectUri
		{
			get
			{
				return this.obj_uri;
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0003E12C File Offset: 0x0003C32C
		public override string ToString()
		{
			if (this.type_name != null)
			{
			}
			string assembly_name = this.assembly_name;
			if ((assembly_name == null || assembly_name != null) && (" " == null || " " != null))
			{
				string text = this.obj_uri;
				if (text == null || text != null)
				{
					string text2;
					return text2;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000E77 RID: 3703
		private Type obj_type;

		// Token: 0x04000E78 RID: 3704
		private string obj_uri;

		// Token: 0x04000E79 RID: 3705
		private WellKnownObjectMode obj_mode;
	}
}
