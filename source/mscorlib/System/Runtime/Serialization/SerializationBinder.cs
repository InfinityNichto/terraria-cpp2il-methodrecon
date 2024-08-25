using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	// Token: 0x020003D1 RID: 977
	[Serializable]
	public abstract class SerializationBinder
	{
		// Token: 0x06001EE8 RID: 7912 RVA: 0x00043888 File Offset: 0x00041A88
		public virtual void BindToName(Type serializedType, [Out] string assemblyName, [Out] string typeName)
		{
		}

		// Token: 0x06001EE9 RID: 7913
		public abstract Type BindToType(string assemblyName, string typeName);

		// Token: 0x06001EEA RID: 7914 RVA: 0x00043898 File Offset: 0x00041A98
		protected SerializationBinder()
		{
		}
	}
}
