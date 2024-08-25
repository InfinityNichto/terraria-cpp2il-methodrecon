using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000BA RID: 186
	internal sealed class RegexFC
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0000E908 File Offset: 0x0000CB08
		public RegexFC(bool nullable)
		{
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000E91C File Offset: 0x0000CB1C
		public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
		{
			int num = 1;
			base..ctor();
			if (not)
			{
				RegexCharClass cc = this._cc;
				return;
			}
			this.<CaseInsensitive>k__BackingField = num != 0;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000E950 File Offset: 0x0000CB50
		public RegexFC(string charClass, bool nullable, bool caseInsensitive)
		{
			if (!true)
			{
			}
			RegexCharClass regexCharClass = RegexCharClass.Parse(charClass);
			this._cc = regexCharClass;
			this.<CaseInsensitive>k__BackingField = true;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000E97C File Offset: 0x0000CB7C
		public bool AddFC(RegexFC fc, bool concatenate)
		{
			bool canMerge = this._cc.CanMerge;
			bool canMerge2 = fc._cc.CanMerge;
			if (this._nullable)
			{
				if (!fc._nullable)
				{
					return canMerge2;
				}
				bool flag = this.<CaseInsensitive>k__BackingField;
				bool flag2 = fc.<CaseInsensitive>k__BackingField;
				RegexCharClass cc = this._cc;
				this.<CaseInsensitive>k__BackingField = flag;
				RegexCharClass cc2 = fc._cc;
				cc.AddCharClass(cc2);
			}
			return true;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0000EA08 File Offset: 0x0000CC08
		public bool CaseInsensitive
		{
			[CompilerGenerated]
			get
			{
				return this.<CaseInsensitive>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000EA18 File Offset: 0x0000CC18
		public string GetFirstChars(CultureInfo culture)
		{
			if (this.<CaseInsensitive>k__BackingField)
			{
				this._cc.AddLowercase(culture);
			}
			return this._cc.ToStringClass();
		}

		// Token: 0x0400032D RID: 813
		private RegexCharClass _cc;

		// Token: 0x0400032E RID: 814
		public bool _nullable;

		// Token: 0x0400032F RID: 815
		[CompilerGenerated]
		private bool <CaseInsensitive>k__BackingField;
	}
}
