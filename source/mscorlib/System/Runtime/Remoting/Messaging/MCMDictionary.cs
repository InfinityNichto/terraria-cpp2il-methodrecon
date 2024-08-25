using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B2 RID: 946
	internal class MCMDictionary : MessageDictionary
	{
		// Token: 0x06001E39 RID: 7737 RVA: 0x00041FAC File Offset: 0x000401AC
		public MCMDictionary(IMethodMessage message)
		{
			this._message = message;
			if (!true)
			{
			}
			this._methodKeys = 1;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00041FD0 File Offset: 0x000401D0
		// Note: this type is marked as 'beforefieldinit'.
		static MCMDictionary()
		{
			if (("__Uri" == null || "__Uri" != null) && ("__MethodName" == null || "__MethodName" != null) && ("__TypeName" == null || "__TypeName" != null) && ("__MethodSignature" == null || "__MethodSignature" != null) && ("__Args" == null || "__Args" != null) && ("__CallContext" == null || "__CallContext" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000F32 RID: 3890
		public static string[] InternalKeys;
	}
}
