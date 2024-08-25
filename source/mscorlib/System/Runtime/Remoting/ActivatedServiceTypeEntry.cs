using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	// Token: 0x02000339 RID: 825
	[ComVisible(true)]
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		// Token: 0x06001BB6 RID: 7094 RVA: 0x0003BC0C File Offset: 0x00039E0C
		public ActivatedServiceTypeEntry(string typeName, string assemblyName)
		{
			this.assembly_name = assemblyName;
			this.type_name = typeName;
			Assembly assembly = Assembly.Load(assemblyName);
			this.obj_type = assembly;
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0003BC50 File Offset: 0x00039E50
		public Type ObjectType
		{
			get
			{
				return this.obj_type;
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0003BC64 File Offset: 0x00039E64
		public override string ToString()
		{
			string assembly_name = this.assembly_name;
			string type_name = this.type_name;
			return assembly_name + type_name;
		}

		// Token: 0x04000E1B RID: 3611
		private Type obj_type;
	}
}
