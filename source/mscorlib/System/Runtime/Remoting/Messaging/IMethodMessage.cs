using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003AF RID: 943
	[ComVisible(true)]
	public interface IMethodMessage : IMessage
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001E12 RID: 7698
		int ArgCount { get; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001E13 RID: 7699
		object[] Args { get; }

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001E14 RID: 7700
		LogicalCallContext LogicalCallContext { get; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001E15 RID: 7701
		MethodBase MethodBase { get; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001E16 RID: 7702
		string MethodName { get; }

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001E17 RID: 7703
		object MethodSignature { get; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001E18 RID: 7704
		string TypeName { get; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001E19 RID: 7705
		string Uri { get; }

		// Token: 0x06001E1A RID: 7706
		object GetArg(int argNum);
	}
}
