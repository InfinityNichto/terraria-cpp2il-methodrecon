using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
	// Token: 0x02000347 RID: 839
	[AttributeUsage(AttributeTargets.All)]
	public sealed class AmbientValueAttribute : Attribute
	{
		// Token: 0x060015CC RID: 5580 RVA: 0x00040974 File Offset: 0x0003EB74
		public AmbientValueAttribute(Type type, string value)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			object obj = TypeDescriptor.GetConverter(type).ConvertFromInvariantString(value);
			this.Value = obj;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000409A8 File Offset: 0x0003EBA8
		public AmbientValueAttribute(char value)
		{
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000409BC File Offset: 0x0003EBBC
		public AmbientValueAttribute(byte value)
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000409D0 File Offset: 0x0003EBD0
		public AmbientValueAttribute(short value)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000409E4 File Offset: 0x0003EBE4
		public AmbientValueAttribute(int value)
		{
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x000409F8 File Offset: 0x0003EBF8
		public AmbientValueAttribute(long value)
		{
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00040A0C File Offset: 0x0003EC0C
		public AmbientValueAttribute(float value)
		{
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00040A20 File Offset: 0x0003EC20
		public AmbientValueAttribute(double value)
		{
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00040A34 File Offset: 0x0003EC34
		public AmbientValueAttribute(bool value)
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00040A48 File Offset: 0x0003EC48
		public AmbientValueAttribute(string value)
		{
			this.Value = value;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00040A64 File Offset: 0x0003EC64
		public AmbientValueAttribute(object value)
		{
			this.Value = value;
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00040A80 File Offset: 0x0003EC80
		public object Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00040A94 File Offset: 0x0003EC94
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			return true;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00040AB0 File Offset: 0x0003ECB0
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040011B1 RID: 4529
		[CompilerGenerated]
		private readonly object <Value>k__BackingField;
	}
}
