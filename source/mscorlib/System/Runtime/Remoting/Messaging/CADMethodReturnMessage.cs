using System;
using System.Collections;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003A0 RID: 928
	internal class CADMethodReturnMessage : CADMessageBase
	{
		// Token: 0x06001DD4 RID: 7636 RVA: 0x0000207A File Offset: 0x0000027A
		internal static CADMethodReturnMessage Create(IMessage callMsg)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000411E4 File Offset: 0x0003F3E4
		internal CADMethodReturnMessage(IMethodReturnMessage retMsg)
			: base(retMsg)
		{
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00041244 File Offset: 0x0003F444
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

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00041270 File Offset: 0x0003F470
		internal object[] GetArgs(ArrayList args)
		{
			object[] args2 = this._args;
			return base.UnmarshalArguments(args2, args);
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0004128C File Offset: 0x0003F48C
		internal object GetReturnValue(ArrayList args)
		{
			object returnValue = this._returnValue;
			return base.UnmarshalArgument(returnValue, args);
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000412A8 File Offset: 0x0003F4A8
		internal Exception GetException(ArrayList args)
		{
			do
			{
				CADArgHolder exception = this._exception;
				if (exception == null)
				{
					return;
				}
				int index = exception.index;
			}
			while (args == null);
			throw new InvalidCastException();
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000412D0 File Offset: 0x0003F4D0
		internal int PropertiesCount
		{
			get
			{
				return this._propertyCount;
			}
		}

		// Token: 0x04000F13 RID: 3859
		private object _returnValue;

		// Token: 0x04000F14 RID: 3860
		private CADArgHolder _exception;

		// Token: 0x04000F15 RID: 3861
		private Type[] _sig;
	}
}
