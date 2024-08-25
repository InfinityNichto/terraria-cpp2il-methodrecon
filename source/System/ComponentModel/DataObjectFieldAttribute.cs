using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000362 RID: 866
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DataObjectFieldAttribute : Attribute
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x00041EE4 File Offset: 0x000400E4
		public DataObjectFieldAttribute(bool primaryKey)
		{
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00041EF8 File Offset: 0x000400F8
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
		{
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00041F0C File Offset: 0x0004010C
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
		{
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00041F20 File Offset: 0x00040120
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
		{
			this.Length = length;
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00041F3C File Offset: 0x0004013C
		public bool IsIdentity
		{
			[CompilerGenerated]
			get
			{
				return this.<IsIdentity>k__BackingField;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00041F50 File Offset: 0x00040150
		public bool IsNullable
		{
			[CompilerGenerated]
			get
			{
				return this.<IsNullable>k__BackingField;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00041F64 File Offset: 0x00040164
		public int Length
		{
			[CompilerGenerated]
			get
			{
				return this.<Length>k__BackingField;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00041F78 File Offset: 0x00040178
		public bool PrimaryKey
		{
			[CompilerGenerated]
			get
			{
				return this.<PrimaryKey>k__BackingField;
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00041F8C File Offset: 0x0004018C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				bool flag = this.<IsIdentity>k__BackingField;
				bool flag2 = this.<IsNullable>k__BackingField;
				int num = this.<Length>k__BackingField;
				bool flag3 = this.<PrimaryKey>k__BackingField;
			}
			return true;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00041FBC File Offset: 0x000401BC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040011EC RID: 4588
		[CompilerGenerated]
		private readonly bool <IsIdentity>k__BackingField;

		// Token: 0x040011ED RID: 4589
		[CompilerGenerated]
		private readonly bool <IsNullable>k__BackingField;

		// Token: 0x040011EE RID: 4590
		[CompilerGenerated]
		private readonly int <Length>k__BackingField;

		// Token: 0x040011EF RID: 4591
		[CompilerGenerated]
		private readonly bool <PrimaryKey>k__BackingField;
	}
}
