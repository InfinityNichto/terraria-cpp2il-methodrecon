using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200042F RID: 1071
	public readonly struct HandleRef
	{
		// Token: 0x0600214C RID: 8524 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		public HandleRef(object wrapper, IntPtr handle)
		{
			this._wrapper = wrapper;
			this._handle = handle;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0004BE04 File Offset: 0x0004A004
		public IntPtr Handle
		{
			get
			{
				return this._handle;
			}
		}

		// Token: 0x040011F0 RID: 4592
		private readonly object _wrapper;

		// Token: 0x040011F1 RID: 4593
		private readonly IntPtr _handle;
	}
}
