using System;
using Cpp2IlInjected;

namespace Mono.Security.Interface
{
	// Token: 0x02000045 RID: 69
	public class ValidationResult
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00008ACC File Offset: 0x00006CCC
		public ValidationResult(bool trusted, bool user_denied, int error_code, MonoSslPolicyErrors? policy_errors)
		{
			this.error_code = error_code;
			this.policy_errors = policy_errors;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public bool Trusted
		{
			get
			{
				return this.trusted;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		public bool UserDenied
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x04000116 RID: 278
		private bool trusted;

		// Token: 0x04000117 RID: 279
		private bool user_denied;

		// Token: 0x04000118 RID: 280
		private int error_code;

		// Token: 0x04000119 RID: 281
		private MonoSslPolicyErrors? policy_errors;
	}
}
