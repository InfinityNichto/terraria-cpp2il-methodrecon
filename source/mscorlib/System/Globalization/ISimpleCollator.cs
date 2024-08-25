using System;

namespace System.Globalization
{
	// Token: 0x020005B7 RID: 1463
	internal interface ISimpleCollator
	{
		// Token: 0x06002C97 RID: 11415
		SortKey GetSortKey(string source, CompareOptions options);

		// Token: 0x06002C98 RID: 11416
		int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

		// Token: 0x06002C99 RID: 11417
		bool IsPrefix(string src, string target, CompareOptions opt);

		// Token: 0x06002C9A RID: 11418
		bool IsSuffix(string src, string target, CompareOptions opt);

		// Token: 0x06002C9B RID: 11419
		int IndexOf(string s, string target, int start, int length, CompareOptions opt);

		// Token: 0x06002C9C RID: 11420
		int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
	}
}
