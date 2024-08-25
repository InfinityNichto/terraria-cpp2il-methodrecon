using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000483 RID: 1155
	public readonly struct ValueTaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x0600222E RID: 8750 RVA: 0x0004D0AC File Offset: 0x0004B2AC
		internal ValueTaskAwaiter(ValueTask value)
		{
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x0004D0BC File Offset: 0x0004B2BC
		public bool IsCompleted
		{
			get
			{
				int value = 1.m_value;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0004D0D4 File Offset: 0x0004B2D4
		[StackTraceHidden]
		public void GetResult()
		{
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0004D0E4 File Offset: 0x0004B2E4
		public void UnsafeOnCompleted(Action continuation)
		{
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x0004D0FC File Offset: 0x0004B2FC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTaskAwaiter()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040012B9 RID: 4793
		internal static readonly Action<object> s_invokeActionDelegate;

		// Token: 0x040012BA RID: 4794
		private readonly ValueTask _value;

		// Token: 0x02000484 RID: 1156
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002233 RID: 8755 RVA: 0x0004D10C File Offset: 0x0004B30C
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x0004D11C File Offset: 0x0004B31C
			public <>c()
			{
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x0004D130 File Offset: 0x0004B330
			internal void <.cctor>b__9_0(object state)
			{
				if (state != null)
				{
				}
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.state);
			}

			// Token: 0x040012BB RID: 4795
			public static readonly ValueTaskAwaiter.<>c <>9;
		}
	}
}
