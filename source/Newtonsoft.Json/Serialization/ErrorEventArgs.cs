using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000085 RID: 133
	[Preserve]
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		public object CurrentObject
		{
			[CompilerGenerated]
			get
			{
				return this.<CurrentObject>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<CurrentObject>k__BackingField = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0000C90C File Offset: 0x0000AB0C
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0000C920 File Offset: 0x0000AB20
		public ErrorContext ErrorContext
		{
			[CompilerGenerated]
			get
			{
				return this.<ErrorContext>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ErrorContext>k__BackingField = value;
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000C934 File Offset: 0x0000AB34
		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
			if (!true)
			{
			}
			base..ctor();
			this.CurrentObject = currentObject;
			this.ErrorContext = errorContext;
		}

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		private object <CurrentObject>k__BackingField;

		// Token: 0x04000221 RID: 545
		[CompilerGenerated]
		private ErrorContext <ErrorContext>k__BackingField;
	}
}
