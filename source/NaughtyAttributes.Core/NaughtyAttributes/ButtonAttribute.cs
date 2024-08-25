using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NaughtyAttributes
{
	// Token: 0x02000006 RID: 6
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class ButtonAttribute : DrawerAttribute
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002174 File Offset: 0x00000374
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

		// Token: 0x0600000E RID: 14 RVA: 0x00002188 File Offset: 0x00000388
		public ButtonAttribute([Optional] string text)
		{
			this.Text = text;
		}

		// Token: 0x04000007 RID: 7
		[CompilerGenerated]
		private string <Text>k__BackingField;
	}
}
