using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200043B RID: 1083
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x0004C03C File Offset: 0x0004A23C
		public ComDefaultInterfaceAttribute(Type defaultInterface)
		{
			this._val = defaultInterface;
		}

		// Token: 0x04001202 RID: 4610
		internal Type _val;
	}
}
