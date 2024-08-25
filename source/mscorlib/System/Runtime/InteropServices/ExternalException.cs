using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200042E RID: 1070
	[Serializable]
	public class ExternalException : SystemException
	{
		// Token: 0x06002145 RID: 8517 RVA: 0x0004BD00 File Offset: 0x00049F00
		public ExternalException()
			: base("External component has thrown an exception.")
		{
			this._HResult = 16389;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0004BD24 File Offset: 0x00049F24
		public ExternalException(string message)
			: base(message)
		{
			this._HResult = 16389;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0004BD44 File Offset: 0x00049F44
		public ExternalException(string message, Exception inner)
			: base(message, inner)
		{
			this._HResult = 16389;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0004BD64 File Offset: 0x00049F64
		public ExternalException(string message, int errorCode)
			: base(message)
		{
			this._HResult = errorCode;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0004BD80 File Offset: 0x00049F80
		protected ExternalException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x0004BD98 File Offset: 0x00049F98
		public virtual int ErrorCode
		{
			get
			{
				return this._HResult;
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0004BDAC File Offset: 0x00049FAC
		public override string ToString()
		{
			Type type = base.GetType();
			if (this._HResult == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (this._innerException != null)
			{
			}
			if (this != null)
			{
				string newLine = Environment.NewLine;
			}
			string text;
			return text;
		}
	}
}
