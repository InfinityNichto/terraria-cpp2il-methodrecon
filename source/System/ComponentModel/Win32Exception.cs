using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	// Token: 0x02000400 RID: 1024
	[Serializable]
	public class Win32Exception : ExternalException, ISerializable
	{
		// Token: 0x06001BD5 RID: 7125 RVA: 0x0004C804 File Offset: 0x0004AA04
		public Win32Exception()
		{
			if (!true)
			{
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			string errorMessage = Win32Exception.GetErrorMessage(lastWin32Error);
			base..ctor(errorMessage);
			this.nativeErrorCode = lastWin32Error;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0004C834 File Offset: 0x0004AA34
		public Win32Exception(int error)
		{
			string errorMessage = Win32Exception.GetErrorMessage(error);
			base..ctor(errorMessage);
			this.nativeErrorCode = error;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0004C858 File Offset: 0x0004AA58
		public Win32Exception(int error, string message)
			: base(message)
		{
			this.nativeErrorCode = error;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0004C874 File Offset: 0x0004AA74
		public Win32Exception(string message)
		{
			if (!true)
			{
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			base..ctor(message);
			this.nativeErrorCode = lastWin32Error;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0004C89C File Offset: 0x0004AA9C
		public Win32Exception(string message, Exception innerException)
			: base(message, innerException)
		{
			if (!true)
			{
			}
			int lastWin32Error = Marshal.GetLastWin32Error();
			this.nativeErrorCode = lastWin32Error;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0004C8C4 File Offset: 0x0004AAC4
		protected Win32Exception(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			int @int = info.GetInt32("NativeErrorCode");
			this.nativeErrorCode = @int;
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0004C8EC File Offset: 0x0004AAEC
		public int NativeErrorCode
		{
			get
			{
				return this.nativeErrorCode;
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0004C900 File Offset: 0x0004AB00
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			int num = this.nativeErrorCode;
			info.AddValue("NativeErrorCode", num);
			base.GetObjectData(info, context);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0004C92C File Offset: 0x0004AB2C
		internal static string GetErrorMessage(int error)
		{
			return "Sharing violation";
		}

		// Token: 0x04001378 RID: 4984
		private readonly int nativeErrorCode;
	}
}
