using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NaughtyAttributes
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	public class InfoBoxAttribute : MetaAttribute
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000270C File Offset: 0x0000090C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002720 File Offset: 0x00000920
		public string Text
		{
			[CompilerGenerated]
			get
			{
				return this.<Text>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Text>k__BackingField = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002734 File Offset: 0x00000934
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002748 File Offset: 0x00000948
		public InfoBoxType Type
		{
			[CompilerGenerated]
			get
			{
				return this.<Type>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Type>k__BackingField = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000275C File Offset: 0x0000095C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002770 File Offset: 0x00000970
		public string VisibleIf
		{
			[CompilerGenerated]
			get
			{
				return this.<VisibleIf>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<VisibleIf>k__BackingField = value;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002784 File Offset: 0x00000984
		public InfoBoxAttribute(string text, InfoBoxType type = InfoBoxType.Normal, [Optional] string visibleIf)
		{
			this.Text = text;
			this.Type = type;
			this.VisibleIf = visibleIf;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000027AC File Offset: 0x000009AC
		public InfoBoxAttribute(string text, string visibleIf)
		{
			this.Text = text;
			this.VisibleIf = visibleIf;
		}

		// Token: 0x04000025 RID: 37
		[CompilerGenerated]
		private string <Text>k__BackingField;

		// Token: 0x04000026 RID: 38
		[CompilerGenerated]
		private InfoBoxType <Type>k__BackingField;

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		private string <VisibleIf>k__BackingField;
	}
}
