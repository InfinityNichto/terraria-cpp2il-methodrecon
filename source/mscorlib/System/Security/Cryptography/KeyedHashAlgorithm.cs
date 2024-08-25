using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002E2 RID: 738
	[ComVisible(true)]
	public abstract class KeyedHashAlgorithm : HashAlgorithm
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x0003505C File Offset: 0x0003325C
		protected KeyedHashAlgorithm()
		{
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00035070 File Offset: 0x00033270
		protected override void Dispose(bool disposing)
		{
			if (this.KeyValue != null)
			{
			}
			this._disposed = true;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0003508C File Offset: 0x0003328C
		// (set) Token: 0x060018C5 RID: 6341 RVA: 0x000350AC File Offset: 0x000332AC
		public virtual byte[] Key
		{
			get
			{
				byte[] keyValue = this.KeyValue;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				if (this.State == 0)
				{
					object obj;
					if (obj != null)
					{
						if (obj == null)
						{
							goto IL_002A;
						}
						this.KeyValue = obj;
						if (obj == null)
						{
							throw new InvalidCastException();
						}
					}
					return;
				}
				string resourceString = Environment.GetResourceString("Hash key cannot be changed after the first write to the stream.");
				IL_002A:
				throw new InvalidCastException();
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0000207A File Offset: 0x0000027A
		public new static KeyedHashAlgorithm Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000350E8 File Offset: 0x000332E8
		public new static KeyedHashAlgorithm Create(string algName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x04000CBA RID: 3258
		protected byte[] KeyValue;
	}
}
