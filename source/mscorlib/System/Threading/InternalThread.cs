using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x0200020E RID: 526
	[StructLayout(0)]
	internal sealed class InternalThread : CriticalFinalizerObject
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x000276CC File Offset: 0x000258CC
		private void Thread_free_internal()
		{
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000276DC File Offset: 0x000258DC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00027710 File Offset: 0x00025910
		public InternalThread()
		{
		}

		// Token: 0x040009E3 RID: 2531
		private int lock_thread_id;

		// Token: 0x040009E4 RID: 2532
		private IntPtr handle;

		// Token: 0x040009E5 RID: 2533
		private IntPtr native_handle;

		// Token: 0x040009E6 RID: 2534
		private IntPtr name_chars;

		// Token: 0x040009E7 RID: 2535
		private int name_free;

		// Token: 0x040009E8 RID: 2536
		private int name_length;

		// Token: 0x040009E9 RID: 2537
		private ThreadState state;

		// Token: 0x040009EA RID: 2538
		private object abort_exc;

		// Token: 0x040009EB RID: 2539
		private int abort_state_handle;

		// Token: 0x040009EC RID: 2540
		internal long thread_id;

		// Token: 0x040009ED RID: 2541
		private IntPtr debugger_thread;

		// Token: 0x040009EE RID: 2542
		private UIntPtr static_data;

		// Token: 0x040009EF RID: 2543
		private IntPtr runtime_thread_info;

		// Token: 0x040009F0 RID: 2544
		private object current_appcontext;

		// Token: 0x040009F1 RID: 2545
		private object root_domain_thread;

		// Token: 0x040009F2 RID: 2546
		internal byte[] _serialized_principal;

		// Token: 0x040009F3 RID: 2547
		internal int _serialized_principal_version;

		// Token: 0x040009F4 RID: 2548
		private IntPtr appdomain_refs;

		// Token: 0x040009F5 RID: 2549
		private int interruption_requested;

		// Token: 0x040009F6 RID: 2550
		private IntPtr longlived;

		// Token: 0x040009F7 RID: 2551
		internal bool threadpool_thread;

		// Token: 0x040009F8 RID: 2552
		private bool thread_interrupt_requested;

		// Token: 0x040009F9 RID: 2553
		internal int stack_size;

		// Token: 0x040009FA RID: 2554
		internal byte apartment_state;

		// Token: 0x040009FB RID: 2555
		internal int critical_region_level;

		// Token: 0x040009FC RID: 2556
		internal int managed_id;

		// Token: 0x040009FD RID: 2557
		private int small_id;

		// Token: 0x040009FE RID: 2558
		private IntPtr manage_callback;

		// Token: 0x040009FF RID: 2559
		private IntPtr flags;

		// Token: 0x04000A00 RID: 2560
		private IntPtr thread_pinning_ref;

		// Token: 0x04000A01 RID: 2561
		private IntPtr abort_protected_block_count;

		// Token: 0x04000A02 RID: 2562
		private int priority = 2;

		// Token: 0x04000A03 RID: 2563
		private IntPtr owned_mutex;

		// Token: 0x04000A04 RID: 2564
		private IntPtr suspended_event;

		// Token: 0x04000A05 RID: 2565
		private int self_suspended;

		// Token: 0x04000A06 RID: 2566
		private IntPtr thread_state;

		// Token: 0x04000A07 RID: 2567
		private IntPtr netcore0;

		// Token: 0x04000A08 RID: 2568
		private IntPtr netcore1;

		// Token: 0x04000A09 RID: 2569
		private IntPtr netcore2;

		// Token: 0x04000A0A RID: 2570
		private IntPtr last;
	}
}
