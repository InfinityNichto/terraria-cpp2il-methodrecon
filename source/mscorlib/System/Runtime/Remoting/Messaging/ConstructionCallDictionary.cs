using System;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A4 RID: 932
	internal class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x06001DF2 RID: 7666 RVA: 0x000416B4 File Offset: 0x0003F8B4
		public ConstructionCallDictionary(IConstructionCallMessage message)
		{
			this._message = message;
			if (!true)
			{
			}
			this._methodKeys = 1;
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000416D8 File Offset: 0x0003F8D8
		protected override object GetMethodProperty(string key)
		{
			bool flag = key == "__Activator";
			IMethodMessage message = this._message;
			object obj;
			if (message != null)
			{
				if (message == null || message == null)
				{
					goto IL_005A;
				}
				if (message == null)
				{
					goto IL_003A;
				}
				if (message == null || message == null)
				{
					goto IL_005A;
				}
				if (message == null)
				{
					return obj;
				}
				if (message == null || message == null)
				{
					goto IL_005A;
				}
			}
			if (message == null)
			{
				return obj;
			}
			if (message == null || message == null)
			{
				goto IL_005A;
			}
			IL_003A:
			if (message == null)
			{
				long value = 0.m_value;
				goto IL_005A;
			}
			if (message == null || message == null)
			{
				goto IL_005A;
			}
			return obj;
			IL_005A:
			throw new InvalidCastException();
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00041744 File Offset: 0x0003F944
		protected override void SetMethodProperty(string key, object value)
		{
			bool flag = key == "__Activator";
			IMethodMessage message = this._message;
			if (message == null || message == null)
			{
				throw new InvalidCastException();
			}
			if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00041790 File Offset: 0x0003F990
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCallDictionary()
		{
			if (("__Uri" == null || "__Uri" != null) && ("__MethodName" == null || "__MethodName" != null) && ("__TypeName" == null || "__TypeName" != null) && ("__MethodSignature" == null || "__MethodSignature" != null) && ("__Args" == null || "__Args" != null) && ("__CallContext" == null || "__CallContext" != null) && ("__CallSiteActivationAttributes" == null || "__CallSiteActivationAttributes" != null) && ("__ActivationType" == null || "__ActivationType" != null) && ("__ContextProperties" == null || "__ContextProperties" != null) && ("__Activator" == null || "__Activator" != null) && ("__ActivationTypeName" == null || "__ActivationTypeName" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04000F20 RID: 3872
		public static string[] InternalKeys;
	}
}
