using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000535 RID: 1333
	[Serializable]
	public class FileNotFoundException : IOException
	{
		// Token: 0x0600273F RID: 10047 RVA: 0x00054EDC File Offset: 0x000530DC
		public FileNotFoundException()
			: base("Unable to find the specified file.")
		{
			this._HResult = 2;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00054EFC File Offset: 0x000530FC
		public FileNotFoundException(string message)
			: base(message)
		{
			this._HResult = 2;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x00054F18 File Offset: 0x00053118
		public FileNotFoundException(string message, string fileName)
			: base(message)
		{
			this._HResult = 2;
			this.FileName = fileName;
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x00054F3C File Offset: 0x0005313C
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00054F58 File Offset: 0x00053158
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this.<FileName>k__BackingField != null)
				{
					string text;
					this._message = text;
					return;
				}
				int hresult = this._HResult;
				this._message = "Unable to find the specified file.";
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x00054F90 File Offset: 0x00053190
		public string FileName
		{
			[CompilerGenerated]
			get
			{
				return this.<FileName>k__BackingField;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x00054FA4 File Offset: 0x000531A4
		public string FusionLog
		{
			[CompilerGenerated]
			get
			{
				return this.<FusionLog>k__BackingField;
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00054FB8 File Offset: 0x000531B8
		public override string ToString()
		{
			Type type = base.GetType();
			string text = this.<FileName>k__BackingField;
			if (text != null && text._stringLength != 0)
			{
				string newLine = Environment.NewLine;
				string text2 = this.<FileName>k__BackingField;
				string text3 = SR.Format("File name: '{0}'", text2);
				string text5;
				string text4 = text5 + newLine + text3;
			}
			if (this._innerException != null)
			{
			}
			if (this != null)
			{
				string newLine2 = Environment.NewLine;
			}
			string text6;
			if (this.<FusionLog>k__BackingField != null)
			{
				string newLine3 = Environment.NewLine;
				string text7;
				text6 = text7 + newLine3;
				string newLine4 = Environment.NewLine;
				string text8 = text6 + newLine4;
				string text9 = this.<FusionLog>k__BackingField;
				return text8 + text9;
			}
			return text6;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00055064 File Offset: 0x00053264
		protected FileNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			string @string = info.GetString("FileNotFound_FileName");
			this.FileName = @string;
			string string2 = info.GetString("FileNotFound_FusionLog");
			this.FusionLog = string2;
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000550A0 File Offset: 0x000532A0
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.<FileName>k__BackingField;
			if (!true)
			{
			}
			Type type;
			info.AddValue("FileNotFound_FileName", text, type);
			string text2 = this.<FusionLog>k__BackingField;
			Type type2;
			info.AddValue("FileNotFound_FusionLog", text2, type2);
		}

		// Token: 0x04001572 RID: 5490
		[CompilerGenerated]
		private readonly string <FileName>k__BackingField;

		// Token: 0x04001573 RID: 5491
		[CompilerGenerated]
		private readonly string <FusionLog>k__BackingField;
	}
}
