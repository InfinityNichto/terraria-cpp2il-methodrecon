using System;
using System.IO;
using System.Text;

namespace Ionic.Zip
{
	// Token: 0x0200002D RID: 45
	public class ReadOptions
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00007EC4 File Offset: 0x000060C4
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00007ED8 File Offset: 0x000060D8
		public EventHandler<ReadProgressEventArgs> ReadProgress
		{
			get
			{
				return this.<ReadProgress>k__BackingField;
			}
			set
			{
				this.<ReadProgress>k__BackingField = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00007EEC File Offset: 0x000060EC
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00007F00 File Offset: 0x00006100
		public TextWriter StatusMessageWriter
		{
			get
			{
				return this.<StatusMessageWriter>k__BackingField;
			}
			set
			{
				this.<StatusMessageWriter>k__BackingField = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00007F14 File Offset: 0x00006114
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00007F28 File Offset: 0x00006128
		public Encoding Encoding
		{
			get
			{
				return this.<Encoding>k__BackingField;
			}
			set
			{
				this.<Encoding>k__BackingField = value;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007F3C File Offset: 0x0000613C
		public ReadOptions()
		{
		}

		// Token: 0x0400010B RID: 267
		private EventHandler<ReadProgressEventArgs> <ReadProgress>k__BackingField;

		// Token: 0x0400010C RID: 268
		private TextWriter <StatusMessageWriter>k__BackingField;

		// Token: 0x0400010D RID: 269
		private Encoding <Encoding>k__BackingField;
	}
}
