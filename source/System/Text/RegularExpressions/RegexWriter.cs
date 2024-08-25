using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000C5 RID: 197
	internal ref struct RegexWriter
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x00013038 File Offset: 0x00011238
		private RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00013048 File Offset: 0x00011248
		public static RegexCode Write(RegexTree tree)
		{
			RegexCode regexCode;
			return regexCode;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00013058 File Offset: 0x00011258
		public void Dispose()
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		public RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00013068 File Offset: 0x00011268
		private void PatchJump(int offset, int jumpDest)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00013078 File Offset: 0x00011278
		private void Emit(int op)
		{
			int trackCount = this._trackCount;
			this._trackCount = trackCount;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00013094 File Offset: 0x00011294
		private void Emit(int op, int opd1)
		{
			int trackCount = this._trackCount;
			this._trackCount = trackCount;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000130B8 File Offset: 0x000112B8
		private void Emit(int op, int opd1, int opd2)
		{
			int trackCount = this._trackCount;
			this._trackCount = trackCount;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		private int StringCode(string str)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000130DC File Offset: 0x000112DC
		private int MapCapnum(int capnum)
		{
			if (this._caps != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000130F8 File Offset: 0x000112F8
		private void EmitFragment(int nodetype, RegexNode node, int curIndex)
		{
		}

		// Token: 0x04000385 RID: 901
		private global::System.Collections.Generic.ValueListBuilder<int> _emitted;

		// Token: 0x04000386 RID: 902
		private global::System.Collections.Generic.ValueListBuilder<int> _intStack;

		// Token: 0x04000387 RID: 903
		private readonly Dictionary<string, int> _stringHash;

		// Token: 0x04000388 RID: 904
		private readonly List<string> _stringTable;

		// Token: 0x04000389 RID: 905
		private Hashtable _caps;

		// Token: 0x0400038A RID: 906
		private int _trackCount;
	}
}
