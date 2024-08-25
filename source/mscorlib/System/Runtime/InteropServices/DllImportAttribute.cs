using System;
using System.Reflection;
using Cpp2IlInjected;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000449 RID: 1097
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class DllImportAttribute : Attribute
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x0004C124 File Offset: 0x0004A324
		internal static Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsDefined(RuntimeMethodInfo method)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0004C134 File Offset: 0x0004A334
		internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
		{
			this._val = dllName;
			this.EntryPoint = entryPoint;
			this.CharSet = charSet;
			this.CallingConvention = callingConvention;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0004C164 File Offset: 0x0004A364
		public DllImportAttribute(string dllName)
		{
			this._val = dllName;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x0004C180 File Offset: 0x0004A380
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04001267 RID: 4711
		internal string _val;

		// Token: 0x04001268 RID: 4712
		public string EntryPoint;

		// Token: 0x04001269 RID: 4713
		public CharSet CharSet;

		// Token: 0x0400126A RID: 4714
		public bool SetLastError;

		// Token: 0x0400126B RID: 4715
		public bool ExactSpelling;

		// Token: 0x0400126C RID: 4716
		public bool PreserveSig;

		// Token: 0x0400126D RID: 4717
		public CallingConvention CallingConvention;

		// Token: 0x0400126E RID: 4718
		public bool BestFitMapping;

		// Token: 0x0400126F RID: 4719
		public bool ThrowOnUnmappableChar;
	}
}
