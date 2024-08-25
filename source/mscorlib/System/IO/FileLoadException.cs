using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.IO
{
	// Token: 0x02000533 RID: 1331
	[Serializable]
	public class FileLoadException : IOException
	{
		// Token: 0x06002736 RID: 10038 RVA: 0x00054D04 File Offset: 0x00052F04
		public FileLoadException()
			: base("Could not load the specified file.")
		{
			this._HResult = 5665;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00054D28 File Offset: 0x00052F28
		public FileLoadException(string message)
			: base(message)
		{
			this._HResult = 5665;
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x00054D48 File Offset: 0x00052F48
		public override string Message
		{
			get
			{
				string text2;
				if (this._message == null)
				{
					string text = this.<FileName>k__BackingField;
					this._message = text2;
				}
				return text2;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x00054D6C File Offset: 0x00052F6C
		public string FileName
		{
			[CompilerGenerated]
			get
			{
				return this.<FileName>k__BackingField;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x00054D80 File Offset: 0x00052F80
		public string FusionLog
		{
			[CompilerGenerated]
			get
			{
				return this.<FusionLog>k__BackingField;
			}
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00054D94 File Offset: 0x00052F94
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

		// Token: 0x0600273C RID: 10044 RVA: 0x00054E40 File Offset: 0x00053040
		protected FileLoadException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			string @string = info.GetString("FileLoad_FileName");
			this.FileName = @string;
			string string2 = info.GetString("FileLoad_FusionLog");
			this.FusionLog = string2;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x00054E7C File Offset: 0x0005307C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.<FileName>k__BackingField;
			if (!true)
			{
			}
			Type type;
			info.AddValue("FileLoad_FileName", text, type);
			string text2 = this.<FusionLog>k__BackingField;
			Type type2;
			info.AddValue("FileLoad_FusionLog", text2, type2);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00054EBC File Offset: 0x000530BC
		internal static string FormatFileLoadExceptionMessage(string fileName, int hResult)
		{
			return SR.Format("Could not load the file '{0}'.", fileName);
		}

		// Token: 0x04001569 RID: 5481
		[CompilerGenerated]
		private readonly string <FileName>k__BackingField;

		// Token: 0x0400156A RID: 5482
		[CompilerGenerated]
		private readonly string <FusionLog>k__BackingField;
	}
}
