using System;
using System.Runtime.ConstrainedExecution;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004A3 RID: 1187
	public static class RuntimeHelpers
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x0004DF24 File Offset: 0x0004C124
		private static void InitializeArray(Array array, IntPtr fldHandle)
		{
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0004DF34 File Offset: 0x0004C134
		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			while (array == null)
			{
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0000207A File Offset: 0x0000027A
		public static int OffsetToStringData
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0004DF44 File Offset: 0x0004C144
		public static int GetHashCode(object o)
		{
			int num;
			return num;
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0004DF54 File Offset: 0x0004C154
		private static void RunClassConstructor(IntPtr type)
		{
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0004DF64 File Offset: 0x0004C164
		public static void RunClassConstructor(RuntimeTypeHandle type)
		{
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool SufficientExecutionStack()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool TryEnsureSufficientExecutionStack()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0004DF74 File Offset: 0x0004C174
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void PrepareConstrainedRegions()
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0004DF84 File Offset: 0x0004C184
		public static void PrepareMethod(RuntimeMethodHandle method)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0004DF94 File Offset: 0x0004C194
		public static bool IsReferenceOrContainsReferences<T>()
		{
			Type type;
			bool isValueType = type.IsValueType;
			Type type2;
			if (type2 != null)
			{
			}
			bool flag;
			return flag;
		}
	}
}
