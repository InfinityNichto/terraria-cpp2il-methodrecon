using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	// Token: 0x0200033E RID: 830
	[ComVisible(true)]
	public interface IRemotingTypeInfo
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001BBD RID: 7101
		string TypeName { get; }

		// Token: 0x06001BBE RID: 7102
		bool CanCastTo(Type fromType, object o);
	}
}
