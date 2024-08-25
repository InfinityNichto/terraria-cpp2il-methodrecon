using System;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000013 RID: 19
	internal struct RuntimeClassHandle
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000023B0 File Offset: 0x000005B0
		internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
		{
			this.value = value;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000023C4 File Offset: 0x000005C4
		internal unsafe RuntimeClassHandle(IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
			this.value = (RuntimeStructs.MonoClass*)ptr2;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe RuntimeStructs.MonoClass* Value
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000023E0 File Offset: 0x000005E0
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				Type type = obj.GetType();
				Type type2;
				bool flag = type2 != type;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002408 File Offset: 0x00000608
		public override int GetHashCode()
		{
			IntPtr intPtr;
			return intPtr.GetHashCode();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000207A File Offset: 0x0000027A
		internal unsafe static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000207A File Offset: 0x0000027A
		internal RuntimeTypeHandle GetTypeHandle()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400008B RID: 139
		private unsafe RuntimeStructs.MonoClass* value;
	}
}
