using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Xml
{
	// Token: 0x020000A8 RID: 168
	[Serializable]
	public class XmlException : SystemException
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00018BC8 File Offset: 0x00016DC8
		protected XmlException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("res", type);
			if (value != null)
			{
				this.res = value;
				return;
			}
			Type type2;
			object value2 = info.GetValue("args", type2);
			if (value2 != null)
			{
				if (value2 != null)
				{
					this.args = value2;
					if (value2 != null)
					{
						goto IL_0046;
					}
				}
				throw new InvalidCastException();
			}
			IL_0046:
			Type type3;
			object value3 = info.GetValue("lineNumber", type3);
			Type type4;
			object value4 = info.GetValue("linePosition", type4);
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			SerializationEntry serializationEntry = enumerator.Current;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00018C98 File Offset: 0x00016E98
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.res;
			info.AddValue("res", text);
			string[] array = this.args;
			info.AddValue("args", array);
			int num = this.lineNumber;
			info.AddValue("lineNumber", num);
			int num2 = this.linePosition;
			info.AddValue("linePosition", num2);
			string text2 = this.sourceUri;
			info.AddValue("sourceUri", text2);
			info.AddValue("version", "2.0");
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00018D20 File Offset: 0x00016F20
		public XmlException()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00018D30 File Offset: 0x00016F30
		public XmlException(string message)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00018D40 File Offset: 0x00016F40
		public XmlException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00018D50 File Offset: 0x00016F50
		internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
			string text = XmlException.FormatUserMessage(message, lineNumber, linePosition);
			base..ctor(text, innerException);
			this._HResult = 6464;
			this.res = 6464;
			if (message == null || message != null)
			{
				this.sourceUri = sourceUri;
				this.lineNumber = lineNumber;
				this.sourceUri = linePosition;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00018DA8 File Offset: 0x00016FA8
		internal XmlException(string res, string[] args)
		{
			long num = 0L;
			long num2 = 0L;
			string text = XmlException.CreateMessage(res, args, (int)num, (int)num2);
			this.res = res;
			this.args = args;
			this._HResult = 6464;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00018DDC File Offset: 0x00016FDC
		internal XmlException(string res, string arg)
		{
			if (arg == null || arg != null)
			{
				this.res = res;
				this._HResult = 6464;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00018E08 File Offset: 0x00017008
		internal XmlException(string res, string arg, string sourceUri)
		{
			if (arg == null || arg != null)
			{
				this.res = res;
				this.sourceUri = sourceUri;
				this._HResult = 6464;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00018E3C File Offset: 0x0001703C
		internal XmlException(string res, string arg, int lineNumber, int linePosition)
		{
			if (arg == null || arg != null)
			{
				this.res = res;
				this._HResult = 6464;
				this.lineNumber = lineNumber;
				this.sourceUri = linePosition;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00018E78 File Offset: 0x00017078
		internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri)
		{
			if (arg == null || arg != null)
			{
				this.res = res;
				this.sourceUri = sourceUri;
				this._HResult = 6464;
				this.lineNumber = lineNumber;
				this.sourceUri = linePosition;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00018EBC File Offset: 0x000170BC
		internal XmlException(string res, string[] args, int lineNumber, int linePosition)
		{
			string text = XmlException.CreateMessage(res, args, lineNumber, linePosition);
			this.res = res;
			this.args = args;
			this._HResult = 6464;
			this.lineNumber = lineNumber;
			this.sourceUri = linePosition;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00018EFC File Offset: 0x000170FC
		internal XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri)
		{
			string text = XmlException.CreateMessage(res, args, lineNumber, linePosition);
			this.res = res;
			this.args = args;
			this.sourceUri = sourceUri;
			this._HResult = 6464;
			this.lineNumber = lineNumber;
			this.sourceUri = linePosition;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00018F44 File Offset: 0x00017144
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition)
		{
			string text = XmlException.CreateMessage(res, args, lineNumber, linePosition);
			base..ctor(text, innerException);
			this.res = res;
			this.args = args;
			this._HResult = 6464;
			this.lineNumber = lineNumber;
			this.sourceUri = linePosition;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00018F90 File Offset: 0x00017190
		internal XmlException(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri)
		{
			string text = XmlException.CreateMessage(res, args, lineNumber, linePosition);
			base..ctor(text, innerException);
			this.res = res;
			this.args = args;
			this.sourceUri = sourceUri;
			this._HResult = 6464;
			this.lineNumber = lineNumber;
			this.sourceUri = linePosition;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00018FE4 File Offset: 0x000171E4
		private static string FormatUserMessage(string message, int lineNumber, int linePosition)
		{
			string text;
			if (true)
			{
				return text;
			}
			return text;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00019000 File Offset: 0x00017200
		private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition)
		{
			if (args == null)
			{
				string text;
				return text;
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			if (res != null)
			{
			}
			string text2;
			if (text2 != null && text2 == null)
			{
				throw new ArrayTypeMismatchException();
			}
			string text3;
			if (text3 != null && text3 == null)
			{
				throw new ArrayTypeMismatchException();
			}
			string text4;
			if (text4 == null || text4 != null)
			{
				string text5;
				return text5;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001909C File Offset: 0x0001729C
		internal static string[] BuildCharExceptionArgs(string data, int invCharIndex)
		{
			long num = 0L;
			char c;
			return XmlException.BuildCharExceptionArgs(c, (char)num);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000190B4 File Offset: 0x000172B4
		internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex)
		{
			string[] array;
			return array;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000190C4 File Offset: 0x000172C4
		internal static string[] BuildCharExceptionArgs(char invChar, char nextChar)
		{
			string text;
			if (text == null || text != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string text2;
				if (text2 == null || text2 != null)
				{
					return text2;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001912C File Offset: 0x0001732C
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00019140 File Offset: 0x00017340
		public int LinePosition
		{
			get
			{
				return this.linePosition;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00019154 File Offset: 0x00017354
		public override string Message
		{
			get
			{
				string text = this.message;
				if (text != null)
				{
					return text;
				}
				string text2;
				return text2;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00019170 File Offset: 0x00017370
		internal string ResString
		{
			get
			{
				return this.res;
			}
		}

		// Token: 0x040003BC RID: 956
		private string res;

		// Token: 0x040003BD RID: 957
		private string[] args;

		// Token: 0x040003BE RID: 958
		private int lineNumber;

		// Token: 0x040003BF RID: 959
		private int linePosition;

		// Token: 0x040003C0 RID: 960
		[OptionalField]
		private string sourceUri;

		// Token: 0x040003C1 RID: 961
		private string message;
	}
}
