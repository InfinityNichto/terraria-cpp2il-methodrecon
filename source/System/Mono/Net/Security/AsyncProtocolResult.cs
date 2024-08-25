using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Mono.Net.Security
{
	// Token: 0x0200004C RID: 76
	internal class AsyncProtocolResult
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003D20 File Offset: 0x00001F20
		public int UserResult
		{
			[CompilerGenerated]
			get
			{
				return this.<UserResult>k__BackingField;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003D34 File Offset: 0x00001F34
		public ExceptionDispatchInfo Error
		{
			[CompilerGenerated]
			get
			{
				return this.<Error>k__BackingField;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003D48 File Offset: 0x00001F48
		public AsyncProtocolResult(int result)
		{
			this.UserResult = result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003D64 File Offset: 0x00001F64
		public AsyncProtocolResult(ExceptionDispatchInfo error)
		{
			this.Error = error;
		}

		// Token: 0x040000A6 RID: 166
		[CompilerGenerated]
		private readonly int <UserResult>k__BackingField;

		// Token: 0x040000A7 RID: 167
		[CompilerGenerated]
		private readonly ExceptionDispatchInfo <Error>k__BackingField;
	}
}
