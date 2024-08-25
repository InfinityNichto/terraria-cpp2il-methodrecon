using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Reflection
{
	// Token: 0x020004F9 RID: 1273
	public struct CustomAttributeTypedArgument
	{
		// Token: 0x060024E7 RID: 9447 RVA: 0x00051910 File Offset: 0x0004FB10
		public CustomAttributeTypedArgument(object value)
		{
			while (value == null)
			{
			}
			object obj = CustomAttributeTypedArgument.CanonicalizeValue(value);
			this.Value = obj;
			Type type = value.GetType();
			this.<ArgumentType>k__BackingField = type;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0005193C File Offset: 0x0004FB3C
		public CustomAttributeTypedArgument(Type argumentType, object value)
		{
			if (!true)
			{
			}
			Type type;
			if (value != null)
			{
				object obj = CustomAttributeTypedArgument.CanonicalizeValue(value);
				this.<ArgumentType>k__BackingField = argumentType;
				this.Value = obj;
				type = value.GetType();
				Type type2;
				bool flag = type == type2;
				return;
			}
			this.<ArgumentType>k__BackingField = type;
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0000207A File Offset: 0x0000027A
		public readonly Type ArgumentType
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x00051984 File Offset: 0x0004FB84
		public readonly object Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00051998 File Offset: 0x0004FB98
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x000519A8 File Offset: 0x0004FBA8
		public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x000519B8 File Offset: 0x0004FBB8
		public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x000519C8 File Offset: 0x0004FBC8
		public override string ToString()
		{
			long num = 0L;
			return this.ToString(num != 0L);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000519E0 File Offset: 0x0004FBE0
		internal string ToString(bool typed)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00051BDC File Offset: 0x0004FDDC
		private static object CanonicalizeValue(object value)
		{
			throw new InvalidCastException();
		}

		// Token: 0x04001444 RID: 5188
		[CompilerGenerated]
		private readonly Type <ArgumentType>k__BackingField;

		// Token: 0x04001445 RID: 5189
		[CompilerGenerated]
		private readonly object <Value>k__BackingField;
	}
}
