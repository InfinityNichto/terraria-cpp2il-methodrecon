using System;

namespace System.Collections.Generic
{
	// Token: 0x0200065E RID: 1630
	[Serializable]
	internal sealed class InternalStringComparer : EqualityComparer<string>
	{
		// Token: 0x060031B6 RID: 12726 RVA: 0x0006B9D0 File Offset: 0x00069BD0
		public override int GetHashCode(string obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0006B9E4 File Offset: 0x00069BE4
		public override bool Equals(string x, string y)
		{
			bool flag;
			if (x != null)
			{
				flag = x.Equals(y);
				return flag;
			}
			return flag;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0006BA04 File Offset: 0x00069C04
		internal override int IndexOf(string[] array, string value, int startIndex, int count)
		{
			return startIndex;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x0006BA14 File Offset: 0x00069C14
		public InternalStringComparer()
		{
		}
	}
}
