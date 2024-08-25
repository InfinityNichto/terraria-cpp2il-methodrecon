using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000012 RID: 18
	public class Leaderboard
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002624 File Offset: 0x00000824
		public Leaderboard()
		{
			this.timeScope = TimeScope.AllTime;
			this.id = "Invalid";
			this.m_Title = "Invalid";
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002658 File Offset: 0x00000858
		public override string ToString()
		{
			if ("ID: '" == null || "ID: '" != null)
			{
				string text = this.<id>k__BackingField;
				if ((text == null || text != null) && ("' Title: '" == null || "' Title: '" != null))
				{
					string title = this.m_Title;
					string text2;
					string text3;
					string text4;
					string text5;
					if ((title == null || title != null) && ("' Loading: '" == null || "' Loading: '" != null) && (text2 == null || text2 != null) && ("' Range: [" == null || "' Range: [" != null) && (text3 == null || text3 != null) && ("," == null || "," != null) && (text4 == null || text4 != null) && ("] MaxRange: '" == null || "] MaxRange: '" != null) && (text5 == null || text5 != null) && ("' Scores: '" == null || "' Scores: '" != null))
					{
						IScore[] scores = this.m_Scores;
						string text6;
						if ((text6 == null || text6 != null) && ("' UserScope: '" == null || "' UserScope: '" != null))
						{
							UserScope userScope = this.<userScope>k__BackingField;
							string text7;
							if ((text7 == null || text7 != null) && ("' TimeScope: '" == null || "' TimeScope: '" != null))
							{
								TimeScope timeScope = this.<timeScope>k__BackingField;
								string text8;
								if ((text8 == null || text8 != null) && ("' UserFilter: '" == null || "' UserFilter: '" != null))
								{
									string[] userIDs = this.m_UserIDs;
									string text9;
									if (text9 == null || text9 != null)
									{
										string text10;
										return text10;
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000027A0 File Offset: 0x000009A0
		public void SetScores(IScore[] scores)
		{
			this.m_Scores = scores;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000027B4 File Offset: 0x000009B4
		public void SetTitle(string title)
		{
			this.m_Title = title;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000027C8 File Offset: 0x000009C8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000027DC File Offset: 0x000009DC
		public string id
		{
			[CompilerGenerated]
			get
			{
				return this.<id>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<id>k__BackingField = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002804 File Offset: 0x00000A04
		public UserScope userScope
		{
			[CompilerGenerated]
			get
			{
				return this.<userScope>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<userScope>k__BackingField = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002076 File Offset: 0x00000276
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002818 File Offset: 0x00000A18
		public Range range
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002828 File Offset: 0x00000A28
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000283C File Offset: 0x00000A3C
		public TimeScope timeScope
		{
			[CompilerGenerated]
			get
			{
				return this.<timeScope>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<timeScope>k__BackingField = value;
			}
		}

		// Token: 0x0400002F RID: 47
		private bool m_Loading;

		// Token: 0x04000030 RID: 48
		private IScore m_LocalUserScore;

		// Token: 0x04000031 RID: 49
		private uint m_MaxRange;

		// Token: 0x04000032 RID: 50
		private IScore[] m_Scores;

		// Token: 0x04000033 RID: 51
		private string m_Title;

		// Token: 0x04000034 RID: 52
		private string[] m_UserIDs;

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string <id>k__BackingField;

		// Token: 0x04000036 RID: 54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private UserScope <userScope>k__BackingField;

		// Token: 0x04000037 RID: 55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Range <range>k__BackingField;

		// Token: 0x04000038 RID: 56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private TimeScope <timeScope>k__BackingField;
	}
}
