using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002D3 RID: 723
	[ComVisible(true)]
	public abstract class DeriveBytes : IDisposable
	{
		// Token: 0x06001861 RID: 6241
		public abstract byte[] GetBytes(int cb);

		// Token: 0x06001862 RID: 6242
		public abstract void Reset();

		// Token: 0x06001863 RID: 6243 RVA: 0x000341F0 File Offset: 0x000323F0
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00034204 File Offset: 0x00032404
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00034214 File Offset: 0x00032414
		protected DeriveBytes()
		{
		}
	}
}
