using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000011 RID: 17
	public class Score : IScore
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000024A0 File Offset: 0x000006A0
		public Score(string leaderboardID, long value)
		{
			if (!true)
			{
			}
			DateTime now = DateTime.Now;
			base..ctor();
			this.leaderboardID = leaderboardID;
			this.value = value;
			this.m_FormattedValue = "";
			this.m_UserID = "0";
			this.m_Date = now;
			this.m_Rank = 1;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000024F0 File Offset: 0x000006F0
		public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank)
		{
			this.leaderboardID = leaderboardID;
			this.value = value;
			this.m_FormattedValue = formattedValue;
			this.m_UserID = userID;
			this.m_Date = date;
			this.m_Rank = rank;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002530 File Offset: 0x00000730
		public override string ToString()
		{
			string text;
			if (("Rank: '" == null || "Rank: '" != null) && (text == null || text != null) && ("' Value: '" == null || "' Value: '" != null))
			{
				long num = this.<value>k__BackingField;
				string text2;
				if ((text2 == null || text2 != null) && ("' Category: '" == null || "' Category: '" != null))
				{
					string text3 = this.<leaderboardID>k__BackingField;
					if ((text3 == null || text3 != null) && ("' PlayerID: '" == null || "' PlayerID: '" != null))
					{
						string userID = this.m_UserID;
						string text4;
						if ((userID == null || userID != null) && ("' Date: '" == null || "' Date: '" != null) && (text4 == null || text4 != null))
						{
							string text5;
							return text5;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000025D4 File Offset: 0x000007D4
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000025E8 File Offset: 0x000007E8
		public string leaderboardID
		{
			[CompilerGenerated]
			get
			{
				return this.<leaderboardID>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<leaderboardID>k__BackingField = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000025FC File Offset: 0x000007FC
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002610 File Offset: 0x00000810
		public long value
		{
			[CompilerGenerated]
			get
			{
				return this.<value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<value>k__BackingField = value;
			}
		}

		// Token: 0x04000029 RID: 41
		private DateTime m_Date;

		// Token: 0x0400002A RID: 42
		private string m_FormattedValue;

		// Token: 0x0400002B RID: 43
		private string m_UserID;

		// Token: 0x0400002C RID: 44
		private int m_Rank;

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string <leaderboardID>k__BackingField;

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long <value>k__BackingField;
	}
}
