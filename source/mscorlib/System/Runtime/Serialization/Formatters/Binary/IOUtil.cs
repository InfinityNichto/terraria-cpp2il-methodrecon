using System;
using System.IO;
using Cpp2IlInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000400 RID: 1024
	internal static class IOUtil
	{
		// Token: 0x06001FD1 RID: 8145 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool FlagTest(MessageEnum flag, MessageEnum target)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00045D64 File Offset: 0x00043F64
		internal static void WriteStringWithCode(string value, __BinaryWriter sout)
		{
			BinaryWriter dataWriter = sout.dataWriter;
			if (value != null)
			{
				BinaryWriter dataWriter2 = sout.dataWriter;
				return;
			}
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00045D84 File Offset: 0x00043F84
		internal static void WriteWithCode(Type type, object value, __BinaryWriter sout)
		{
			if (type != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				InternalPrimitiveTypeE internalPrimitiveTypeE = Converter.ToCode(type);
				BinaryWriter dataWriter = sout.dataWriter;
				sout.WriteValue(internalPrimitiveTypeE, value);
				return;
			}
			BinaryWriter dataWriter2 = sout.dataWriter;
		}
	}
}
