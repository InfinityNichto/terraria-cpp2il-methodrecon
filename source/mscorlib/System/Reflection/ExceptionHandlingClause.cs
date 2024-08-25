using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000504 RID: 1284
	[ComVisible(true)]
	[StructLayout(0)]
	public class ExceptionHandlingClause
	{
		// Token: 0x06002560 RID: 9568 RVA: 0x000529B4 File Offset: 0x00050BB4
		protected ExceptionHandlingClause()
		{
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000529C8 File Offset: 0x00050BC8
		public override string ToString()
		{
			ExceptionHandlingClauseOptions exceptionHandlingClauseOptions = this.flags;
			int num = this.try_offset;
			int num2 = this.try_length;
			int num3 = this.handler_offset;
			int num4 = this.handler_length;
			Type type = this.catch_type;
			Type type2 = this.catch_type;
			string text2;
			string text = string.Format("{0}, CatchType={1}", text2, type2);
			ExceptionHandlingClauseOptions exceptionHandlingClauseOptions2 = this.flags;
			int num5 = this.filter_offset;
			string text3;
			return text3;
		}

		// Token: 0x040014C3 RID: 5315
		internal Type catch_type;

		// Token: 0x040014C4 RID: 5316
		internal int filter_offset;

		// Token: 0x040014C5 RID: 5317
		internal ExceptionHandlingClauseOptions flags;

		// Token: 0x040014C6 RID: 5318
		internal int try_offset;

		// Token: 0x040014C7 RID: 5319
		internal int try_length;

		// Token: 0x040014C8 RID: 5320
		internal int handler_offset;

		// Token: 0x040014C9 RID: 5321
		internal int handler_length;
	}
}
