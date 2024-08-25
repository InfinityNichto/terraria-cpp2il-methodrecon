using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200039F RID: 927
	internal class CADMethodCallMessage : CADMessageBase
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00041134 File Offset: 0x0003F334
		internal string Uri
		{
			get
			{
				return this._uri;
			}
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0000207A File Offset: 0x0000027A
		internal static CADMethodCallMessage Create(IMessage callMsg)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00041148 File Offset: 0x0003F348
		internal CADMethodCallMessage(IMethodCallMessage callMsg)
			: base(callMsg)
		{
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00041188 File Offset: 0x0003F388
		internal ArrayList GetArguments()
		{
			while (this._serializedArgs != null)
			{
				byte[] serializedArgs = this._serializedArgs;
				object obj;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000411B4 File Offset: 0x0003F3B4
		internal object[] GetArgs(ArrayList args)
		{
			object[] args2 = this._args;
			return base.UnmarshalArguments(args2, args);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000411D0 File Offset: 0x0003F3D0
		internal int PropertiesCount
		{
			get
			{
				return this._propertyCount;
			}
		}

		// Token: 0x04000F12 RID: 3858
		private string _uri;
	}
}
