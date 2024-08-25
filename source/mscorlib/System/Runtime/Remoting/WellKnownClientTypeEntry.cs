using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	// Token: 0x02000354 RID: 852
	[ComVisible(true)]
	public class WellKnownClientTypeEntry : TypeEntry
	{
		// Token: 0x06001C7E RID: 7294 RVA: 0x0003DFD8 File Offset: 0x0003C1D8
		public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
		{
			this.obj_url = objectUrl;
			this.assembly_name = assemblyName;
			this.type_name = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0003E020 File Offset: 0x0003C220
		public string ApplicationUrl
		{
			get
			{
				return this.app_url;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0003E034 File Offset: 0x0003C234
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x0003E048 File Offset: 0x0003C248
		public string ObjectUrl
		{
			get
			{
				return this.obj_url;
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0003E05C File Offset: 0x0003C25C
		public override string ToString()
		{
			string text = this.obj_url;
			string text2 = this.app_url;
			string assembly_name = this.assembly_name;
			string type_name = this.type_name;
			string text3;
			if (text2 != null)
			{
				text3 = type_name + assembly_name + text + text2;
				return text3;
			}
			return text3 + assembly_name + text;
		}

		// Token: 0x04000E71 RID: 3697
		private Type obj_type;

		// Token: 0x04000E72 RID: 3698
		private string obj_url;

		// Token: 0x04000E73 RID: 3699
		private string app_url;
	}
}
