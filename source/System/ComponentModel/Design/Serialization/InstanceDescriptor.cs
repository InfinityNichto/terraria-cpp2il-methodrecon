using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.ComponentModel.Design.Serialization
{
	// Token: 0x02000414 RID: 1044
	public sealed class InstanceDescriptor
	{
		// Token: 0x06001C17 RID: 7191 RVA: 0x0004CFF4 File Offset: 0x0004B1F4
		public InstanceDescriptor(MemberInfo member, ICollection arguments)
		{
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0004D004 File Offset: 0x0004B204
		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
		{
			this.MemberInfo = member;
			if (arguments != null)
			{
				return;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0004D04C File Offset: 0x0004B24C
		public ICollection Arguments
		{
			[CompilerGenerated]
			get
			{
				return this.<Arguments>k__BackingField;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0004D060 File Offset: 0x0004B260
		public MemberInfo MemberInfo
		{
			[CompilerGenerated]
			get
			{
				return this.<MemberInfo>k__BackingField;
			}
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0004D074 File Offset: 0x0004B274
		public object Invoke()
		{
			ICollection collection = this.<Arguments>k__BackingField;
			ICollection collection2 = this.<Arguments>k__BackingField;
			object obj;
			if (collection2 == null || obj == null || obj != null)
			{
				if (this.<MemberInfo>k__BackingField != null)
				{
				}
				object obj2;
				return obj2;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0400138E RID: 5006
		[CompilerGenerated]
		private readonly ICollection <Arguments>k__BackingField;

		// Token: 0x0400138F RID: 5007
		[CompilerGenerated]
		private readonly bool <IsComplete>k__BackingField;

		// Token: 0x04001390 RID: 5008
		[CompilerGenerated]
		private readonly MemberInfo <MemberInfo>k__BackingField;
	}
}
