using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000C1 RID: 193
	internal sealed class RegexReplacement
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x0001288C File Offset: 0x00010A8C
		public RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
		{
			int ntype = concat.NType;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
			long num = 0L;
			List<RegexNode> children = concat.Children;
			if (children != null)
			{
				int size = children._size;
			}
			RegexNode regexNode = concat.Child((int)num);
			int ntype2 = regexNode.NType;
			string str = regexNode.Str;
			StringBuilder stringBuilder2 = stringBuilder.Append(str);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00012940 File Offset: 0x00010B40
		public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions)
		{
			RegexReplacement regexReplacement;
			return regexReplacement;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00012950 File Offset: 0x00010B50
		public string Pattern
		{
			[CompilerGenerated]
			get
			{
				return this.<Pattern>k__BackingField;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00012964 File Offset: 0x00010B64
		private void ReplacementImpl(StringBuilder sb, Match match)
		{
			int size = this._rules._size;
			List<string> strings = this._strings;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		private void ReplacementImplRTL(List<string> al, Match match)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000129BC File Offset: 0x00010BBC
		public string Replace(Regex regex, string input, int count, int startat)
		{
			int stringLength = input._stringLength;
			if (count != 0)
			{
				Match match = regex.Match(input, startat);
				bool success = match.Success;
				StringBuilder stringBuilder = StringBuilderCache.Acquire(16);
				bool rightToLeft = regex.RightToLeft;
				int stringLength2 = input._stringLength;
				int <Index>k__BackingField = match.<Index>k__BackingField;
				string <Text>k__BackingField = match.<Text>k__BackingField;
				return input.Substring(1073741824, startat);
			}
			return input;
		}

		// Token: 0x04000363 RID: 867
		private const int Specials = 4;

		// Token: 0x04000364 RID: 868
		public const int LeftPortion = -1;

		// Token: 0x04000365 RID: 869
		public const int RightPortion = -2;

		// Token: 0x04000366 RID: 870
		public const int LastGroup = -3;

		// Token: 0x04000367 RID: 871
		public const int WholeString = -4;

		// Token: 0x04000368 RID: 872
		private readonly List<string> _strings;

		// Token: 0x04000369 RID: 873
		private readonly List<int> _rules;

		// Token: 0x0400036A RID: 874
		[CompilerGenerated]
		private readonly string <Pattern>k__BackingField;
	}
}
