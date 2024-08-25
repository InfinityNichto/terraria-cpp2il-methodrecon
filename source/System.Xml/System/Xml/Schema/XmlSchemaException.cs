using System;
using System.Runtime.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000147 RID: 327
	[Serializable]
	public class XmlSchemaException : SystemException
	{
		// Token: 0x06000ADC RID: 2780 RVA: 0x0001E218 File Offset: 0x0001C418
		protected XmlSchemaException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
				this.res = obj;
				return;
			}
			Type type;
			object value = info.GetValue("args", type);
			if (value != null)
			{
				if (value != null)
				{
					this.args = value;
					if (value != null)
					{
						goto IL_0039;
					}
				}
				throw new InvalidCastException();
			}
			IL_0039:
			Type type2;
			object value2 = info.GetValue("sourceUri", type2);
			if (value2 != null)
			{
				this.sourceUri = value2;
				return;
			}
			Type type3;
			object value3 = info.GetValue("lineNumber", type3);
			Type type4;
			object value4 = info.GetValue("linePosition", type4);
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			bool flag = enumerator.MoveNext();
			SerializationEntry serializationEntry = enumerator.Current;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0001E2C8 File Offset: 0x0001C4C8
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string text = this.res;
			info.AddValue("res", text);
			string[] array = this.args;
			info.AddValue("args", array);
			string text2 = this.sourceUri;
			info.AddValue("sourceUri", text2);
			int num = this.lineNumber;
			info.AddValue("lineNumber", num);
			int num2 = this.linePosition;
			info.AddValue("linePosition", num2);
			info.AddValue("version", "2.0");
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001E350 File Offset: 0x0001C550
		public XmlSchemaException()
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0001E360 File Offset: 0x0001C560
		public XmlSchemaException(string message)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001E370 File Offset: 0x0001C570
		public XmlSchemaException(string message, Exception innerException)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001E384 File Offset: 0x0001C584
		public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
		{
			if (message == null || message != null)
			{
				string text;
				base..ctor(text, innerException);
				this.res = 1;
				this.lineNumber = lineNumber;
				this.sourceSchemaObject = linePosition;
				this._HResult = 6465;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
		internal XmlSchemaException(string res, string arg)
		{
			if (arg == null || arg != null)
			{
				this.res = res;
				this._HResult = 6465;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
		{
			if (arg == null || arg != null)
			{
				this.res = res;
				this.sourceUri = sourceUri;
				this.lineNumber = lineNumber;
				this.sourceSchemaObject = linePosition;
				this._HResult = 6465;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001E438 File Offset: 0x0001C638
		internal XmlSchemaException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source)
		{
			string text = XmlSchemaException.CreateMessage(res, args);
			base..ctor(text, innerException);
			this.res = res;
			this.args = args;
			this.sourceUri = sourceUri;
			this._HResult = 6465;
			this.sourceSchemaObject = source;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001E480 File Offset: 0x0001C680
		internal static string CreateMessage(string res, string[] args)
		{
			string text;
			return text;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001E49C File Offset: 0x0001C69C
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

		// Token: 0x04000591 RID: 1425
		private string res;

		// Token: 0x04000592 RID: 1426
		private string[] args;

		// Token: 0x04000593 RID: 1427
		private string sourceUri;

		// Token: 0x04000594 RID: 1428
		private int lineNumber;

		// Token: 0x04000595 RID: 1429
		private int linePosition;

		// Token: 0x04000596 RID: 1430
		[NonSerialized]
		private XmlSchemaObject sourceSchemaObject;

		// Token: 0x04000597 RID: 1431
		private string message;
	}
}
