using System;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004EC RID: 1260
	internal sealed class SignatureByRefType : SignatureHasElementType
	{
		// Token: 0x0600243B RID: 9275 RVA: 0x0005103C File Offset: 0x0004F23C
		internal SignatureByRefType(SignatureType elementType)
		{
			this._elementType = elementType;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00051058 File Offset: 0x0004F258
		protected sealed override bool IsArrayImpl()
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00051068 File Offset: 0x0004F268
		protected sealed override bool IsByRefImpl()
		{
			return true;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00051078 File Offset: 0x0004F278
		protected sealed override bool IsPointerImpl()
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x00051088 File Offset: 0x0004F288
		public sealed override bool IsSZArray
		{
			get
			{
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x00051098 File Offset: 0x0004F298
		public sealed override bool IsVariableBoundArray
		{
			get
			{
			}
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override int GetArrayRank()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000510A8 File Offset: 0x0004F2A8
		protected sealed override string Suffix
		{
			get
			{
				return "&";
			}
		}
	}
}
