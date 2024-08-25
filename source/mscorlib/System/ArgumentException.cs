using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000083 RID: 131
	[Serializable]
	public class ArgumentException : SystemException
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x0000BE3C File Offset: 0x0000A03C
		public ArgumentException()
			: base("Value does not fall within the expected range.")
		{
			this._HResult = 87;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public ArgumentException(string message)
			: base(message)
		{
			this._HResult = 87;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000BE78 File Offset: 0x0000A078
		public ArgumentException(string message, Exception innerException)
			: base(message, innerException)
		{
			this._HResult = 87;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000BE98 File Offset: 0x0000A098
		public ArgumentException(string message, string paramName, Exception innerException)
			: base(message, innerException)
		{
			this._paramName = paramName;
			this._HResult = 87;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		public ArgumentException(string message, string paramName)
			: base(message)
		{
			this._paramName = paramName;
			this._HResult = 87;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		protected ArgumentException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			string @string = info.GetString("ParamName");
			this._paramName = @string;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000BF08 File Offset: 0x0000A108
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string paramName = this._paramName;
			if (!true)
			{
			}
			Type type;
			info.AddValue("ParamName", paramName, type);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000BF34 File Offset: 0x0000A134
		public override string Message
		{
			get
			{
				string message = base.Message;
				bool flag = string.IsNullOrEmpty(this._paramName);
				return message;
			}
		}

		// Token: 0x040001DB RID: 475
		private string _paramName;
	}
}
