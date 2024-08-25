using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000DD RID: 221
	[Serializable]
	public class MissingMethodException : MissingMemberException
	{
		// Token: 0x0600083A RID: 2106 RVA: 0x00013298 File Offset: 0x00011498
		public MissingMethodException()
			: base("Attempted to access a missing method.")
		{
			this._HResult = 5395;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000132BC File Offset: 0x000114BC
		public MissingMethodException(string message)
			: base(message)
		{
			this._HResult = 5395;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000132DC File Offset: 0x000114DC
		public MissingMethodException(string className, string methodName)
		{
			this.ClassName = className;
			this.MemberName = methodName;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00013300 File Offset: 0x00011500
		protected MissingMethodException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00013318 File Offset: 0x00011518
		public override string Message
		{
			get
			{
				if (this.ClassName == null)
				{
					string text;
					return text;
				}
				string memberName = this.MemberName;
				if (this.Signature != null)
				{
					string text2;
					return text2;
				}
				string text3;
				return SR.Format("Method '{0}' not found.", text3);
			}
		}
	}
}
