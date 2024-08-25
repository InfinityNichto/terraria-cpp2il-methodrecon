using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200043D RID: 1085
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false)]
	public sealed class ClassInterfaceAttribute : Attribute
	{
		// Token: 0x0600216A RID: 8554 RVA: 0x0004C058 File Offset: 0x0004A258
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
			this._val = classInterfaceType;
		}

		// Token: 0x04001207 RID: 4615
		internal ClassInterfaceType _val;
	}
}
