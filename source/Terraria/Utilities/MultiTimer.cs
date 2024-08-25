using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Terraria.Utilities
{
	// Token: 0x020004FB RID: 1275
	public class MultiTimer
	{
		// Token: 0x060030E8 RID: 12520 RVA: 0x001F722C File Offset: 0x001F542C
		public MultiTimer()
		{
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x001F7248 File Offset: 0x001F5448
		public MultiTimer(int ticksBetweenPrint)
		{
			this._ticksBetweenPrint = ticksBetweenPrint;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x001F726C File Offset: 0x001F546C
		public void Start()
		{
			this._timer.Reset();
			this._timer.Start();
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x001F7290 File Offset: 0x001F5490
		public void Record(string key)
		{
			double totalMilliseconds = this._timer.Elapsed.TotalMilliseconds;
			Dictionary<string, MultiTimer.TimerData> timerDataMap = this._timerDataMap;
			Dictionary<string, MultiTimer.TimerData> timerDataMap2 = this._timerDataMap;
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x001F72C8 File Offset: 0x001F54C8
		public bool StopAndPrint()
		{
			int ticksBetweenPrint = this._ticksBetweenPrint;
			Stopwatch timer = this._timer;
			this._ticksElapsedForPrint = timer;
			Console.WriteLine("Average elapsed time: ");
			Dictionary<string, MultiTimer.TimerData> timerDataMap = this._timerDataMap;
			if (ticksBetweenPrint == 0)
			{
			}
			string text;
			if (text == null || text != null)
			{
				if (" : (Average: " != null && " : (Average: " == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text2;
				if (text2 != null && text2 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (" Min: " != null && " Min: " == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text3;
				if (text3 != null && text3 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (" Max: " != null && " Max: " == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text4;
				if (text4 != null && text4 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (" from " != null && " from " == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text5;
				if (text5 != null && text5 == null)
				{
					throw new ArrayTypeMismatchException();
				}
				if (" records)" != null && " records)" == null)
				{
					throw new ArrayTypeMismatchException();
				}
				string text6;
				Console.WriteLine(text6);
				string text8;
				string text7 = "Total : " + text8 + "ms";
				if ("ms" == null)
				{
				}
				Console.WriteLine(text7);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x04003ACF RID: 15055
		private int _ticksBetweenPrint = 100;

		// Token: 0x04003AD0 RID: 15056
		private int _ticksElapsedForPrint;

		// Token: 0x04003AD1 RID: 15057
		private Stopwatch _timer;

		// Token: 0x04003AD2 RID: 15058
		private Dictionary<string, MultiTimer.TimerData> _timerDataMap;

		// Token: 0x020004FC RID: 1276
		private struct TimerData
		{
			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x060030ED RID: 12525 RVA: 0x001F7418 File Offset: 0x001F5618
			public double Average
			{
				get
				{
					/*
An exception occurred when decompiling this method (060030ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.Utilities.MultiTimer/TimerData::get_Average()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(TimerData::Ticks, ldloc:valuetype Terraria.Utilities.MultiTimer/TimerData&(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
				}
			}

			// Token: 0x060030EE RID: 12526 RVA: 0x001F742C File Offset: 0x001F562C
			private TimerData(double min, double max, double ticks, double total)
			{
				this.Min = min;
				this.Ticks = ticks;
			}

			// Token: 0x060030EF RID: 12527 RVA: 0x001F7448 File Offset: 0x001F5648
			public TimerData(double startTime)
			{
				this.Min = startTime;
				this.Total = startTime;
			}

			// Token: 0x060030F0 RID: 12528 RVA: 0x001F7464 File Offset: 0x001F5664
			public MultiTimer.TimerData AddTick(double time)
			{
				if (!true)
				{
				}
				double max = this.Max;
				double num = Math.Max(max, time);
				double ticks = this.Ticks;
				return 1;
			}

			// Token: 0x04003AD3 RID: 15059
			public readonly double Min;

			// Token: 0x04003AD4 RID: 15060
			public readonly double Max;

			// Token: 0x04003AD5 RID: 15061
			public readonly double Ticks;

			// Token: 0x04003AD6 RID: 15062
			public readonly double Total;
		}
	}
}
