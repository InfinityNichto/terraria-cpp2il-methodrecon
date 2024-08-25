using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000434 RID: 1076
	[Serializable]
	public class COMException : ExternalException
	{
		// Token: 0x0600215E RID: 8542 RVA: 0x0004BF74 File Offset: 0x0004A174
		public COMException()
		{
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0004BF88 File Offset: 0x0004A188
		protected COMException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0004BFA0 File Offset: 0x0004A1A0
		public override string ToString()
		{
			Type type = base.GetType();
			if (this._HResult == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (this != null)
			{
				string className = this._className;
			}
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
