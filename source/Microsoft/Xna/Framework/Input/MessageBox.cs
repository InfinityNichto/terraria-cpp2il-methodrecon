using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000354 RID: 852
	public static class MessageBox
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00061548 File Offset: 0x0005F748
		public static bool IsVisible
		{
			[CompilerGenerated]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00061558 File Offset: 0x0005F758
		public static Task<int?> Show(string title, string description, IEnumerable<string> buttons)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00061570 File Offset: 0x0005F770
		public static void Cancel(int? result)
		{
		}

		// Token: 0x040023F0 RID: 9200
		[CompilerGenerated]
		private static bool <IsVisible>k__BackingField;

		// Token: 0x02000355 RID: 853
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <Show>d__4 : IAsyncStateMachine
		{
			// Token: 0x060015E7 RID: 5607 RVA: 0x00061580 File Offset: 0x0005F780
			private void MoveNext()
			{
				IEnumerable<string> enumerable = this.buttons;
			}

			// Token: 0x060015E8 RID: 5608 RVA: 0x0006159C File Offset: 0x0005F79C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040023F1 RID: 9201
			public int <>1__state;

			// Token: 0x040023F2 RID: 9202
			public AsyncTaskMethodBuilder<int?> <>t__builder;

			// Token: 0x040023F3 RID: 9203
			public IEnumerable<string> buttons;
		}
	}
}
