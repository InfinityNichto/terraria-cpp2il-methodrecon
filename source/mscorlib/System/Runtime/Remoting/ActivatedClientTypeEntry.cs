using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
	// Token: 0x02000338 RID: 824
	[ComVisible(true)]
	public class ActivatedClientTypeEntry : TypeEntry
	{
		// Token: 0x06001BB1 RID: 7089 RVA: 0x0003BB60 File Offset: 0x00039D60
		public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
		{
			this.assembly_name = assemblyName;
			this.type_name = typeName;
			this.applicationUrl = appUrl;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly;
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0003BBA8 File Offset: 0x00039DA8
		public string ApplicationUrl
		{
			get
			{
				return this.applicationUrl;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x0003BBBC File Offset: 0x00039DBC
		public IContextAttribute[] ContextAttributes
		{
			get
			{
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0003BBCC File Offset: 0x00039DCC
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		public override string ToString()
		{
			string assembly_name = this.assembly_name;
			string type_name = this.type_name;
			string text = this.applicationUrl;
			return type_name + assembly_name + text;
		}

		// Token: 0x04000E19 RID: 3609
		private string applicationUrl;

		// Token: 0x04000E1A RID: 3610
		private Type obj_type;
	}
}
