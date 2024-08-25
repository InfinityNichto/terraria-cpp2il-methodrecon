using System;
using System.Globalization;
using System.Threading;

namespace System.Net
{
	// Token: 0x020001B2 RID: 434
	internal class WebRequestPrefixElement
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00023664 File Offset: 0x00021864
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x000236F8 File Offset: 0x000218F8
		public IWebRequestCreate Creator
		{
			get
			{
				IWebRequestCreate webRequestCreate;
				if (this.creator == null)
				{
					Type type = this.creatorType;
					long num = 0L;
					Monitor.Enter(this, num != 0L);
					if (this.creator == null)
					{
						Type type2 = this.creatorType;
						CultureInfo invariantCulture = CultureInfo.InvariantCulture;
						object obj;
						if (obj == null)
						{
							return webRequestCreate;
						}
						if (obj == null)
						{
							throw new InvalidCastException();
						}
						this.creator = obj;
						if (obj == null)
						{
							throw new InvalidCastException();
						}
					}
					long num2 = 0L;
					Monitor.Exit(this);
					if (num2 != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				webRequestCreate = this.creator;
				return webRequestCreate;
			}
			set
			{
				this.creator = value;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002370C File Offset: 0x0002190C
		public WebRequestPrefixElement(string P, Type creatorType)
		{
			if (!true)
			{
			}
			this.Prefix = P;
			this.creatorType = creatorType;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002373C File Offset: 0x0002193C
		public WebRequestPrefixElement(string P, IWebRequestCreate C)
		{
			this.Prefix = P;
			this.creator = C;
		}

		// Token: 0x0400090B RID: 2315
		public string Prefix;

		// Token: 0x0400090C RID: 2316
		internal IWebRequestCreate creator;

		// Token: 0x0400090D RID: 2317
		internal Type creatorType;
	}
}
