using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000010 RID: 16
	public class AchievementDescription
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002318 File Offset: 0x00000518
		public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points)
		{
			this.id = id;
			this.m_Title = title;
			this.m_Image = image;
			this.m_AchievedDescription = achievedDescription;
			this.m_UnachievedDescription = unachievedDescription;
			this.m_Points = points;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002358 File Offset: 0x00000558
		public override string ToString()
		{
			string text = this.<id>k__BackingField;
			if ((text == null || text != null) && (" - " == null || " - " != null))
			{
				string title = this.m_Title;
				if ((title == null || title != null) && (" - " == null || " - " != null))
				{
					string achievedDescription = this.m_AchievedDescription;
					if ((achievedDescription == null || achievedDescription != null) && (" - " == null || " - " != null))
					{
						string unachievedDescription = this.m_UnachievedDescription;
						if ((unachievedDescription == null || unachievedDescription != null) && (" - " == null || " - " != null))
						{
							int points = this.m_Points;
							string text2;
							if ((text2 == null || text2 != null) && (" - " == null || " - " != null))
							{
								bool hidden = this.m_Hidden;
								string text3;
								if (text3 == null || text3 != null)
								{
									string text4;
									return text4;
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002428 File Offset: 0x00000628
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000243C File Offset: 0x0000063C
		public string title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002450 File Offset: 0x00000650
		public string achievedDescription
		{
			get
			{
				return this.m_AchievedDescription;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002464 File Offset: 0x00000664
		public string unachievedDescription
		{
			get
			{
				return this.m_UnachievedDescription;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002478 File Offset: 0x00000678
		public bool hidden
		{
			get
			{
				return this.m_Hidden;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000248C File Offset: 0x0000068C
		public int points
		{
			get
			{
				return this.m_Points;
			}
		}

		// Token: 0x04000022 RID: 34
		private string m_Title;

		// Token: 0x04000023 RID: 35
		private Texture2D m_Image;

		// Token: 0x04000024 RID: 36
		private string m_AchievedDescription;

		// Token: 0x04000025 RID: 37
		private string m_UnachievedDescription;

		// Token: 0x04000026 RID: 38
		private bool m_Hidden;

		// Token: 0x04000027 RID: 39
		private int m_Points;

		// Token: 0x04000028 RID: 40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string <id>k__BackingField;
	}
}
