using System;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000112 RID: 274
	internal abstract class X509ChainImpl : IDisposable
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600064E RID: 1614
		public abstract bool IsValid { get; }

		// Token: 0x0600064F RID: 1615 RVA: 0x00017704 File Offset: 0x00015904
		protected void ThrowIfContextInvalid()
		{
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000650 RID: 1616
		public abstract X509ChainElementCollection ChainElements { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000651 RID: 1617
		public abstract X509ChainPolicy ChainPolicy { get; }

		// Token: 0x06000652 RID: 1618
		public abstract bool Build(X509Certificate2 certificate);

		// Token: 0x06000653 RID: 1619
		public abstract void AddStatus(X509ChainStatusFlags errorCode);

		// Token: 0x06000654 RID: 1620
		public abstract void Reset();

		// Token: 0x06000655 RID: 1621 RVA: 0x0001771C File Offset: 0x0001591C
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00017730 File Offset: 0x00015930
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00017740 File Offset: 0x00015940
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00017774 File Offset: 0x00015974
		protected X509ChainImpl()
		{
		}
	}
}
