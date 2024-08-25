using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	internal class ReflectionOnlyType : RuntimeType
	{
		// Token: 0x06000E22 RID: 3618 RVA: 0x0001EB58 File Offset: 0x0001CD58
		private ReflectionOnlyType()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0000207A File Offset: 0x0000027A
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
