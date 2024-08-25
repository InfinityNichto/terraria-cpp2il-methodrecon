using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2IlInjected;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200037A RID: 890
	internal class CADSerializer
	{
		// Token: 0x06001D3E RID: 7486 RVA: 0x0000207A File Offset: 0x0000027A
		internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0000207A File Offset: 0x0000027A
		internal static MemoryStream SerializeMessage(IMessage msg)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		internal static object DeserializeObjectSafe(byte[] mem)
		{
			object obj;
			return obj;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0000207A File Offset: 0x0000027A
		internal static MemoryStream SerializeObject(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00040008 File Offset: 0x0003E208
		internal static object DeserializeObject(MemoryStream mem)
		{
			object obj;
			return obj;
		}
	}
}
