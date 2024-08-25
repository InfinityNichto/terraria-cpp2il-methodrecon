using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A5 RID: 933
	[ComVisible(true)]
	[CLSCompliant(false)]
	[Serializable]
	public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage
	{
		// Token: 0x06001DF6 RID: 7670 RVA: 0x0004184C File Offset: 0x0003FA4C
		internal ConstructionResponse(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0004185C File Offset: 0x0003FA5C
		internal ConstructionResponse(Exception e, IMethodCallMessage msg)
			: base(e, msg)
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00041874 File Offset: 0x0003FA74
		internal ConstructionResponse(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x0004188C File Offset: 0x0003FA8C
		public override IDictionary Properties
		{
			get
			{
				return base.Properties;
			}
		}
	}
}
