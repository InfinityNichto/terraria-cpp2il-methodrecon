using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004E RID: 78
	[Preserve]
	internal class ReflectionMember
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00008FCC File Offset: 0x000071CC
		public Type MemberType
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			set
			{
				this.<MemberType>k__BackingField = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00008FE0 File Offset: 0x000071E0
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00008FF4 File Offset: 0x000071F4
		public Func<object, object> Getter
		{
			[CompilerGenerated]
			get
			{
				return this.<Getter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Getter>k__BackingField = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00009008 File Offset: 0x00007208
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x0000901C File Offset: 0x0000721C
		public Action<object, object> Setter
		{
			[CompilerGenerated]
			get
			{
				return this.<Setter>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Setter>k__BackingField = value;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00009030 File Offset: 0x00007230
		public ReflectionMember()
		{
		}

		// Token: 0x04000189 RID: 393
		[CompilerGenerated]
		private Type <MemberType>k__BackingField;

		// Token: 0x0400018A RID: 394
		[CompilerGenerated]
		private Func<object, object> <Getter>k__BackingField;

		// Token: 0x0400018B RID: 395
		[CompilerGenerated]
		private Action<object, object> <Setter>k__BackingField;
	}
}
