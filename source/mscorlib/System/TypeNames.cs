using System;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x02000197 RID: 407
	internal class TypeNames
	{
		// Token: 0x02000198 RID: 408
		internal abstract class ATypeName : TypeName, IEquatable<TypeName>
		{
			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000FC2 RID: 4034
			public abstract string DisplayName { get; }

			// Token: 0x06000FC3 RID: 4035 RVA: 0x00021A8C File Offset: 0x0001FC8C
			public bool Equals(TypeName other)
			{
				if (other != null)
				{
				}
				long value = 0.m_value;
				bool flag;
				return flag;
			}

			// Token: 0x06000FC4 RID: 4036 RVA: 0x0000207A File Offset: 0x0000027A
			public override int GetHashCode()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000FC5 RID: 4037 RVA: 0x00021AA4 File Offset: 0x0001FCA4
			public override bool Equals(object other)
			{
				bool flag;
				return flag;
			}

			// Token: 0x06000FC6 RID: 4038 RVA: 0x00021AB4 File Offset: 0x0001FCB4
			protected ATypeName()
			{
			}
		}
	}
}
