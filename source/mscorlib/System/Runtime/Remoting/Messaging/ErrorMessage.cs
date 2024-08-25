using System;
using System.Collections;
using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A7 RID: 935
	[Serializable]
	internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
	{
		// Token: 0x06001DFE RID: 7678 RVA: 0x000418FC File Offset: 0x0003FAFC
		public ErrorMessage()
		{
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0004191C File Offset: 0x0003FB1C
		public int ArgCount
		{
			get
			{
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x0004192C File Offset: 0x0003FB2C
		public object[] Args
		{
			get
			{
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0004193C File Offset: 0x0003FB3C
		public MethodBase MethodBase
		{
			get
			{
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x0004194C File Offset: 0x0003FB4C
		public string MethodName
		{
			get
			{
				return "unknown";
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00041960 File Offset: 0x0003FB60
		public object MethodSignature
		{
			get
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00041970 File Offset: 0x0003FB70
		public virtual IDictionary Properties
		{
			get
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x00041980 File Offset: 0x0003FB80
		public string TypeName
		{
			get
			{
				return "unknown";
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00041994 File Offset: 0x0003FB94
		public string Uri
		{
			get
			{
				return this._uri;
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x000419A8 File Offset: 0x0003FBA8
		public object GetArg(int arg_num)
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000419B8 File Offset: 0x0003FBB8
		public LogicalCallContext LogicalCallContext
		{
			get
			{
			}
		}

		// Token: 0x04000F22 RID: 3874
		private string _uri = "Exception";
	}
}
