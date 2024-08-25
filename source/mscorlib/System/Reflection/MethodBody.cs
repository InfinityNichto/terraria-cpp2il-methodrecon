using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x02000506 RID: 1286
	[ComVisible(true)]
	public class MethodBody
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x00052A74 File Offset: 0x00050C74
		protected MethodBody()
		{
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00052A88 File Offset: 0x00050C88
		internal MethodBody(ExceptionHandlingClause[] clauses, LocalVariableInfo[] locals, byte[] il, bool init_locals, int sig_token, int max_stack)
		{
			this.clauses = clauses;
			this.locals = locals;
			this.il = il;
			this.sig_token = sig_token;
		}

		// Token: 0x040014CD RID: 5325
		private ExceptionHandlingClause[] clauses;

		// Token: 0x040014CE RID: 5326
		private LocalVariableInfo[] locals;

		// Token: 0x040014CF RID: 5327
		private byte[] il;

		// Token: 0x040014D0 RID: 5328
		private bool init_locals;

		// Token: 0x040014D1 RID: 5329
		private int sig_token;

		// Token: 0x040014D2 RID: 5330
		private int max_stack;
	}
}
