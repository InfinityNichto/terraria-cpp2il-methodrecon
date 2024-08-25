using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	// Token: 0x020005CC RID: 1484
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
	[ComVisible(true)]
	public sealed class DebuggableAttribute : Attribute
	{
		// Token: 0x06002D51 RID: 11601 RVA: 0x00064518 File Offset: 0x00062718
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
			this.m_debuggingModes = modes;
		}

		// Token: 0x0400194F RID: 6479
		private DebuggableAttribute.DebuggingModes m_debuggingModes;

		// Token: 0x020005CD RID: 1485
		[ComVisible(true)]
		[Flags]
		public enum DebuggingModes
		{
			// Token: 0x04001951 RID: 6481
			None = 0,
			// Token: 0x04001952 RID: 6482
			Default = 1,
			// Token: 0x04001953 RID: 6483
			DisableOptimizations = 256,
			// Token: 0x04001954 RID: 6484
			IgnoreSymbolStoreSequencePoints = 2,
			// Token: 0x04001955 RID: 6485
			EnableEditAndContinue = 4
		}
	}
}
