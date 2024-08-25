using System;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x02000131 RID: 305
	[Serializable]
	public class MissingFieldException : MissingMemberException, ISerializable
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x0001A604 File Offset: 0x00018804
		public MissingFieldException()
			: base("Attempted to access a non-existing field.")
		{
			this._HResult = 5393;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0001A628 File Offset: 0x00018828
		public MissingFieldException(string message)
			: base(message)
		{
			this._HResult = 5393;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0001A648 File Offset: 0x00018848
		public MissingFieldException(string className, string fieldName)
		{
			this.ClassName = className;
			this.MemberName = fieldName;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0001A66C File Offset: 0x0001886C
		protected MissingFieldException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0001A684 File Offset: 0x00018884
		public override string Message
		{
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				string className;
				if (this.Signature != null)
				{
					className = this.ClassName;
					string text;
					return text;
				}
				string memberName = this.MemberName;
				string text2 = "" + className + "." + memberName;
				return SR.Format("Field '{0}' not found.", text2);
			}
		}
	}
}
