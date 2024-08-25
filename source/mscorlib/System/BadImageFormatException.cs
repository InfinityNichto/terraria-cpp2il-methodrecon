using System;
using System.IO;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200008F RID: 143
	[Serializable]
	public class BadImageFormatException : SystemException
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0000C70C File Offset: 0x0000A90C
		public BadImageFormatException()
			: base("Format of the executable (.exe) or library (.dll) is invalid.")
		{
			this._HResult = 11;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000C72C File Offset: 0x0000A92C
		public BadImageFormatException(string message)
			: base(message)
		{
			this._HResult = 11;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000C748 File Offset: 0x0000A948
		public BadImageFormatException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 11;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000C768 File Offset: 0x0000A968
		public BadImageFormatException(string message, string fileName)
			: base(message)
		{
			this._HResult = 11;
			this._fileName = fileName;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000C78C File Offset: 0x0000A98C
		protected BadImageFormatException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			string @string = info.GetString("BadImageFormat_FileName");
			this._fileName = @string;
			string string2 = info.GetString("BadImageFormat_FusionLog");
			this._fusionLog = string2;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string fileName = this._fileName;
			if (!true)
			{
			}
			Type type;
			info.AddValue("BadImageFormat_FileName", fileName, type);
			string fusionLog = this._fusionLog;
			Type type2;
			info.AddValue("BadImageFormat_FusionLog", fusionLog, type2);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000C808 File Offset: 0x0000AA08
		public override string Message
		{
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000C824 File Offset: 0x0000AA24
		private void SetMessageField()
		{
			if (this._message == null)
			{
				string fileName = this._fileName;
				int hresult = this._HResult;
				if (fileName == null)
				{
					this._message = "Format of the executable (.exe) or library (.dll) is invalid.";
					return;
				}
				string text = FileLoadException.FormatFileLoadExceptionMessage(fileName, hresult);
				this._message = text;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000C868 File Offset: 0x0000AA68
		public override string ToString()
		{
			Type type = base.GetType();
			string fileName = this._fileName;
			if (fileName != null && fileName._stringLength != 0)
			{
				string newLine = Environment.NewLine;
				string fileName2 = this._fileName;
				string text = SR.Format("File name: '{0}'", fileName2);
				string text3;
				string text2 = text3 + newLine + text;
			}
			if (this._innerException != null)
			{
			}
			if (this != null)
			{
				string newLine2 = Environment.NewLine;
			}
			string text4;
			if (this._fusionLog != null)
			{
				string newLine3 = Environment.NewLine;
				string text5;
				text4 = text5 + newLine3;
				string newLine4 = Environment.NewLine;
				string text6 = text4 + newLine4;
				string fusionLog = this._fusionLog;
				return text6 + fusionLog;
			}
			return text4;
		}

		// Token: 0x040001FB RID: 507
		private string _fileName;

		// Token: 0x040001FC RID: 508
		private string _fusionLog;
	}
}
