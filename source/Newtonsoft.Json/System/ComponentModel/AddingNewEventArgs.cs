using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000002 RID: 2
	[Preserve]
	public class AddingNewEventArgs
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		public object NewObject
		{
			[CompilerGenerated]
			get
			{
				return this.<NewObject>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<NewObject>k__BackingField = value;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		public AddingNewEventArgs()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000208C File Offset: 0x0000028C
		public AddingNewEventArgs(object newObject)
		{
			this.NewObject = newObject;
		}

		// Token: 0x04000001 RID: 1
		[CompilerGenerated]
		private object <NewObject>k__BackingField;
	}
}
