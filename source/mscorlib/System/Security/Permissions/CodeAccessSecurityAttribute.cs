using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	// Token: 0x020002AC RID: 684
	[Obsolete("CAS support is not available with Silverlight applications.")]
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public abstract class CodeAccessSecurityAttribute : SecurityAttribute
	{
		// Token: 0x0600174E RID: 5966 RVA: 0x00031EA4 File Offset: 0x000300A4
		protected CodeAccessSecurityAttribute(SecurityAction action)
		{
			this.m_Action = action;
		}
	}
}
