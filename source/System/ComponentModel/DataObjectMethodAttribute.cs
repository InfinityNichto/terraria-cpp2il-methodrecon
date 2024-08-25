using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000363 RID: 867
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		// Token: 0x060016A3 RID: 5795 RVA: 0x00041FD0 File Offset: 0x000401D0
		public DataObjectMethodAttribute(DataObjectMethodType methodType)
		{
			this.MethodType = methodType;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00041FEC File Offset: 0x000401EC
		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
			this.MethodType = methodType;
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00042008 File Offset: 0x00040208
		public bool IsDefault
		{
			[CompilerGenerated]
			get
			{
				return this.<IsDefault>k__BackingField;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x0004201C File Offset: 0x0004021C
		public DataObjectMethodType MethodType
		{
			[CompilerGenerated]
			get
			{
				return this.<MethodType>k__BackingField;
			}
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00042030 File Offset: 0x00040230
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				DataObjectMethodType dataObjectMethodType = this.<MethodType>k__BackingField;
				bool flag = this.<IsDefault>k__BackingField;
			}
			return true;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00042054 File Offset: 0x00040254
		public override int GetHashCode()
		{
			DataObjectMethodType dataObjectMethodType = this.<MethodType>k__BackingField;
			bool flag = this.<IsDefault>k__BackingField;
			int num;
			return num;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00042070 File Offset: 0x00040270
		public override bool Match(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x040011F0 RID: 4592
		[CompilerGenerated]
		private readonly bool <IsDefault>k__BackingField;

		// Token: 0x040011F1 RID: 4593
		[CompilerGenerated]
		private readonly DataObjectMethodType <MethodType>k__BackingField;
	}
}
