using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Diagnostics
{
	// Token: 0x020005D3 RID: 1491
	[MonoTODO("Serialized objects are not compatible with MS.NET")]
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class StackFrame
	{
		// Token: 0x06002D5D RID: 11613 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool get_frame_info(int skip, bool needFileInfo, [Out] MethodBase method, [Out] int iloffset, [Out] int native_offset, [Out] string file, [Out] int line, [Out] int column)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00064610 File Offset: 0x00062810
		public StackFrame()
		{
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x00064624 File Offset: 0x00062824
		public StackFrame(int skipFrames, bool fNeedFileInfo)
		{
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x00064638 File Offset: 0x00062838
		public virtual int GetFileLineNumber()
		{
			return this.lineNumber;
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x0006464C File Offset: 0x0006284C
		public virtual string GetFileName()
		{
			return this.fileName;
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00064660 File Offset: 0x00062860
		internal string GetSecureFileName()
		{
			if (this.fileName != null)
			{
				return;
			}
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00064678 File Offset: 0x00062878
		public virtual int GetILOffset()
		{
			return this.ilOffset;
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x0006468C File Offset: 0x0006288C
		public virtual MethodBase GetMethod()
		{
			return this.methodBase;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000646A0 File Offset: 0x000628A0
		public virtual int GetNativeOffset()
		{
			return this.nativeOffset;
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x000646B4 File Offset: 0x000628B4
		internal long GetMethodAddress()
		{
			return this.methodAddress;
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000646C8 File Offset: 0x000628C8
		internal uint GetMethodIndex()
		{
			return this.methodIndex;
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000646DC File Offset: 0x000628DC
		internal string GetInternalMethodName()
		{
			return this.internalMethodName;
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000646F0 File Offset: 0x000628F0
		public override string ToString()
		{
			MethodBase methodBase = this.methodBase;
			return Locale.GetText("<unknown method>");
		}

		// Token: 0x04001960 RID: 6496
		public const int OFFSET_UNKNOWN = -1;

		// Token: 0x04001961 RID: 6497
		private int ilOffset;

		// Token: 0x04001962 RID: 6498
		private int nativeOffset;

		// Token: 0x04001963 RID: 6499
		private long methodAddress;

		// Token: 0x04001964 RID: 6500
		private uint methodIndex;

		// Token: 0x04001965 RID: 6501
		private MethodBase methodBase;

		// Token: 0x04001966 RID: 6502
		private string fileName;

		// Token: 0x04001967 RID: 6503
		private int lineNumber;

		// Token: 0x04001968 RID: 6504
		private int columnNumber;

		// Token: 0x04001969 RID: 6505
		private string internalMethodName;
	}
}
