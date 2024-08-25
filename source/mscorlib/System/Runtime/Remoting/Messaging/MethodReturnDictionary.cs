using System;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003B6 RID: 950
	internal class MethodReturnDictionary : MessageDictionary
	{
		// Token: 0x06001E73 RID: 7795 RVA: 0x00042AA0 File Offset: 0x00040CA0
		public MethodReturnDictionary(IMethodReturnMessage message)
		{
			this._message = message;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00042ABC File Offset: 0x00040CBC
		// Note: this type is marked as 'beforefieldinit'.
		static MethodReturnDictionary()
		{
			if (("__Uri" == null || "__Uri" != null) && ("__MethodName" == null || "__MethodName" != null) && ("__TypeName" == null || "__TypeName" != null) && ("__MethodSignature" == null || "__MethodSignature" != null) && ("__OutArgs" == null || "__OutArgs" != null) && ("__Return" == null || "__Return" != null) && ("__CallContext" == null || "__CallContext" != null) && ("__CallContext" == null || "__CallContext" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000F49 RID: 3913
		public static string[] InternalReturnKeys;

		// Token: 0x04000F4A RID: 3914
		public static string[] InternalExceptionKeys;
	}
}
