using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace ReLogic.Threading
{
	// Token: 0x02000B11 RID: 2833
	public static class FastParallel
	{
		// Token: 0x06005311 RID: 21265 RVA: 0x00283E78 File Offset: 0x00282078
		static FastParallel()
		{
			if (!true)
			{
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x00283E88 File Offset: 0x00282088
		// (set) Token: 0x06005313 RID: 21267 RVA: 0x00283E9C File Offset: 0x0028209C
		public static bool ForceTasksOnCallingThread
		{
			[CompilerGenerated]
			get
			{
				if (!true)
				{
				}
				return true;
			}
			[CompilerGenerated]
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00283EAC File Offset: 0x002820AC
		public static void For(int fromInclusive, int toExclusive, ParallelForAction callback, [Optional] object context)
		{
			IntPtr method_code = callback.method_code;
			IntPtr invoke_impl = callback.invoke_impl;
			IntPtr method = callback.method;
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00283ED0 File Offset: 0x002820D0
		private static void InvokeTask(object context)
		{
			if (context != null)
			{
			}
		}

		// Token: 0x04008AEC RID: 35564
		[CompilerGenerated]
		private static bool <ForceTasksOnCallingThread>k__BackingField;

		// Token: 0x02000B12 RID: 2834
		private class RangeTask
		{
			// Token: 0x06005316 RID: 21270 RVA: 0x00283EE8 File Offset: 0x002820E8
			public RangeTask(ParallelForAction action, int fromInclusive, int toExclusive, object context, CountdownEvent countdown)
			{
				this._action = action;
				this._fromInclusive = fromInclusive;
				this._context = toExclusive;
				this._context = context;
				this._countdown = countdown;
			}

			// Token: 0x06005317 RID: 21271 RVA: 0x00283F20 File Offset: 0x00282120
			public void Invoke()
			{
				int fromInclusive = this._fromInclusive;
				object context = this._context;
				ParallelForAction action = this._action;
				object context2 = this._context;
				IntPtr invoke_impl = action.invoke_impl;
				IntPtr method_code = action.method_code;
				IntPtr method = action.method;
				bool flag = this._countdown.Signal();
			}

			// Token: 0x04008AED RID: 35565
			private readonly ParallelForAction _action;

			// Token: 0x04008AEE RID: 35566
			private readonly int _fromInclusive;

			// Token: 0x04008AEF RID: 35567
			private readonly int _toExclusive;

			// Token: 0x04008AF0 RID: 35568
			private readonly object _context;

			// Token: 0x04008AF1 RID: 35569
			private readonly CountdownEvent _countdown;
		}
	}
}
