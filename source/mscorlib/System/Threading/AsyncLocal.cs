using System;

namespace System.Threading
{
	// Token: 0x020001B6 RID: 438
	public sealed class AsyncLocal<T> : IAsyncLocal
	{
		// Token: 0x060010A8 RID: 4264 RVA: 0x00023564 File Offset: 0x00021764
		public AsyncLocal(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
		{
			this.m_valueChangedHandler = valueChangedHandler;
		}

		// Token: 0x17000185 RID: 389
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00023580 File Offset: 0x00021780
		public T Value
		{
			set
			{
				Action valueChangedHandler = this.m_valueChangedHandler;
				if (!true)
				{
				}
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00023598 File Offset: 0x00021798
		void IAsyncLocal.OnValueChanged(object previousValueObj, object currentValueObj, bool contextChanged)
		{
			if (previousValueObj != null)
			{
				if (previousValueObj == null)
				{
					throw new InvalidCastException();
				}
				if (currentValueObj != null && currentValueObj == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				while (currentValueObj != null)
				{
				}
			}
			Action valueChangedHandler = this.m_valueChangedHandler;
		}

		// Token: 0x040008FC RID: 2300
		private readonly Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler;
	}
}
