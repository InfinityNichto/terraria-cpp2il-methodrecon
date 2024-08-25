using System;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000A4 RID: 164
	public class Capture
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0000AFD0 File Offset: 0x000091D0
		internal Capture(string text, int index, int length)
		{
			this.Text = text;
			this.Index = index;
			this.Text = length;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0000AFF8 File Offset: 0x000091F8
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000B00C File Offset: 0x0000920C
		public int Index
		{
			[CompilerGenerated]
			get
			{
				return this.<Index>k__BackingField;
			}
			[CompilerGenerated]
			private protected set
			{
				this.<Index>k__BackingField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000B020 File Offset: 0x00009220
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000B034 File Offset: 0x00009234
		public int Length
		{
			[CompilerGenerated]
			get
			{
				return this.<Length>k__BackingField;
			}
			[CompilerGenerated]
			private protected set
			{
				this.<Length>k__BackingField = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0000B048 File Offset: 0x00009248
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000B05C File Offset: 0x0000925C
		protected internal string Text
		{
			[CompilerGenerated]
			internal get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			private protected set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0000B070 File Offset: 0x00009270
		public string Value
		{
			get
			{
				string text = this.<Text>k__BackingField;
				int num = this.<Index>k__BackingField;
				string text2 = this.<Text>k__BackingField;
				string text3;
				return text3;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000B094 File Offset: 0x00009294
		public override string ToString()
		{
			string text = this.<Text>k__BackingField;
			int num = this.<Index>k__BackingField;
			string text2 = this.<Text>k__BackingField;
			string text3;
			return text3;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000B0B8 File Offset: 0x000092B8
		internal ReadOnlySpan<char> GetLeftSubstring()
		{
			string text = this.<Text>k__BackingField;
			int num = this.<Index>k__BackingField;
			if (text != null)
			{
				int stringLength = text._stringLength;
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
				char rawStringData = text.GetRawStringData();
				while (text != null)
				{
				}
			}
			if (num != 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
				return;
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000B0FC File Offset: 0x000092FC
		internal ReadOnlySpan<char> GetRightSubstring()
		{
			string text = this.<Text>k__BackingField;
			int num = this.<Index>k__BackingField;
			string text2 = this.<Text>k__BackingField;
			int stringLength = text._stringLength;
			int stringLength2;
			if (text != null)
			{
				stringLength2 = text._stringLength;
				char rawStringData = text.GetRawStringData();
			}
			if (stringLength2 != 0)
			{
				return;
			}
		}

		// Token: 0x04000280 RID: 640
		[CompilerGenerated]
		private int <Index>k__BackingField;

		// Token: 0x04000281 RID: 641
		[CompilerGenerated]
		private int <Length>k__BackingField;

		// Token: 0x04000282 RID: 642
		[CompilerGenerated]
		private string <Text>k__BackingField;
	}
}
