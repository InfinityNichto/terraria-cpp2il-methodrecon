using System;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004EF RID: 1263
	internal sealed class SignaturePointerType : SignatureHasElementType
	{
		// Token: 0x0600246E RID: 9326 RVA: 0x00051364 File Offset: 0x0004F564
		internal SignaturePointerType(SignatureType elementType)
		{
			this._elementType = elementType;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00051380 File Offset: 0x0004F580
		protected sealed override bool IsArrayImpl()
		{
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00051390 File Offset: 0x0004F590
		protected sealed override bool IsByRefImpl()
		{
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000513A0 File Offset: 0x0004F5A0
		protected sealed override bool IsPointerImpl()
		{
			return true;
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000513B0 File Offset: 0x0004F5B0
		public sealed override bool IsSZArray
		{
			get
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000513C0 File Offset: 0x0004F5C0
		public sealed override bool IsVariableBoundArray
		{
			get
			{
			}
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0000207A File Offset: 0x0000027A
		public sealed override int GetArrayRank()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000513D0 File Offset: 0x0004F5D0
		protected sealed override string Suffix
		{
			get
			{
				return "*";
			}
		}
	}
}
