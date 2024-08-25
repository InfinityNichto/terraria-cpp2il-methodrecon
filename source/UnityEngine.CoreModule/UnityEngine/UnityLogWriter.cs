using System;
using System.IO;
using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200003D RID: 61
	[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
	internal class UnityLogWriter : TextWriter
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002924 File Offset: 0x00000B24
		[ThreadAndSerializationSafe]
		public static void WriteStringToUnityLog(string s)
		{
			if (s != null)
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000293C File Offset: 0x00000B3C
		[FreeFunction(IsThreadSafe = true)]
		private static void WriteStringToUnityLogImpl(string s)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002950 File Offset: 0x00000B50
		public static void Init()
		{
			if (!true)
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002960 File Offset: 0x00000B60
		public override Encoding Encoding
		{
			get
			{
				return Encoding.UTF8;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002974 File Offset: 0x00000B74
		public override void Write(char value)
		{
			string text;
			if (text != null)
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000298C File Offset: 0x00000B8C
		public override void Write(string s)
		{
			if (s != null)
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000029A4 File Offset: 0x00000BA4
		public override void Write(char[] buffer, int index, int count)
		{
			throw new MissingMethodException();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000029BC File Offset: 0x00000BBC
		public UnityLogWriter()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
