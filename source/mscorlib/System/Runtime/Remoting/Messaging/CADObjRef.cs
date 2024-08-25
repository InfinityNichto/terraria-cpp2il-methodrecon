using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200039C RID: 924
	internal class CADObjRef
	{
		// Token: 0x06001DBE RID: 7614 RVA: 0x00040DF4 File Offset: 0x0003EFF4
		public CADObjRef(ObjRef o, int sourceDomain)
		{
			this.objref = o;
			byte[] array = o.SerializeType();
			this.TypeInfo = array;
			this.SourceDomain = sourceDomain;
		}

		// Token: 0x04000F05 RID: 3845
		internal ObjRef objref;

		// Token: 0x04000F06 RID: 3846
		internal int SourceDomain;

		// Token: 0x04000F07 RID: 3847
		internal byte[] TypeInfo;
	}
}
