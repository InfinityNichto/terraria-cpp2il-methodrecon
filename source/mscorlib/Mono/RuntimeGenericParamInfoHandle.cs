using System;
using System.Reflection;
using Cpp2IlInjected;

namespace Mono
{
	// Token: 0x02000015 RID: 21
	internal struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000241C File Offset: 0x0000061C
		internal unsafe RuntimeGenericParamInfoHandle(IntPtr ptr)
		{
			void* ptr2 = (void*)ptr;
			this.value = (RuntimeStructs.GenericParamInfo*)ptr2;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002438 File Offset: 0x00000638
		internal Type[] Constraints
		{
			get
			{
				return this.GetConstraints();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000207A File Offset: 0x0000027A
		internal GenericParameterAttributes Attributes
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000244C File Offset: 0x0000064C
		private Type[] GetConstraints()
		{
			Type type;
			if (type == null || type != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002468 File Offset: 0x00000668
		private int GetConstraintsCount()
		{
		}

		// Token: 0x0400008D RID: 141
		private unsafe RuntimeStructs.GenericParamInfo* value;
	}
}
