using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000132 RID: 306
	[Serializable]
	public class MissingMemberException : MemberAccessException
	{
		// Token: 0x06000BDE RID: 3038 RVA: 0x0001A6D8 File Offset: 0x000188D8
		public MissingMemberException()
			: base("Attempted to access a missing member.")
		{
			this._HResult = 5394;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0001A6FC File Offset: 0x000188FC
		public MissingMemberException(string message)
			: base(message)
		{
			this._HResult = 5394;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0001A71C File Offset: 0x0001891C
		protected MissingMemberException(SerializationInfo info, StreamingContext context)
		{
			string @string = info.GetString("MMClassName");
			this.ClassName = @string;
			string string2 = info.GetString("MMMemberName");
			this.MemberName = string2;
			if (!true)
			{
			}
			Type type;
			object value = info.GetValue("MMSignature", type);
			if (value != null)
			{
				if (value == null)
				{
					throw new InvalidCastException();
				}
				this.Signature = value;
				if (value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0001A77C File Offset: 0x0001897C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			string className = this.ClassName;
			if (!true)
			{
			}
			Type type;
			info.AddValue("MMClassName", className, type);
			string memberName = this.MemberName;
			Type type2;
			info.AddValue("MMMemberName", memberName, type2);
			byte[] signature = this.Signature;
			Type type3;
			info.AddValue("MMSignature", signature, type3);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0001A7D4 File Offset: 0x000189D4
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
				return SR.Format("Member '{0}' not found.", text3);
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0000207A File Offset: 0x0000027A
		internal static string FormatSignature(byte[] signature)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040004CE RID: 1230
		protected string ClassName;

		// Token: 0x040004CF RID: 1231
		protected string MemberName;

		// Token: 0x040004D0 RID: 1232
		protected byte[] Signature;
	}
}
