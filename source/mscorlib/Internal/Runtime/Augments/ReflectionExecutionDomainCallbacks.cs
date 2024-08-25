using System;
using Cpp2IlInjected;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000064 RID: 100
	internal class ReflectionExecutionDomainCallbacks
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000207A File Offset: 0x0000027A
		internal Exception CreateMissingMetadataException(Type attributeType)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000082EC File Offset: 0x000064EC
		public ReflectionExecutionDomainCallbacks()
		{
		}
	}
}
