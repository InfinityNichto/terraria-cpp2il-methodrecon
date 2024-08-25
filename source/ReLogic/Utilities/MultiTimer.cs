using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ReLogic.Utilities
{
	// Token: 0x02000B03 RID: 2819
	public class MultiTimer
	{
		// Token: 0x0600527B RID: 21115 RVA: 0x00282F9C File Offset: 0x0028119C
		public MultiTimer(int ticksBetweenPrint = 100)
		{
			this._ticksBetweenPrint = ticksBetweenPrint;
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x00282FB8 File Offset: 0x002811B8
		public void Start()
		{
			this._timer.Reset();
			this._timer.Start();
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00282FDC File Offset: 0x002811DC
		public void Record(string key)
		{
			this._timer.Stop();
			double totalMilliseconds = this._timer.Elapsed.TotalMilliseconds;
			Dictionary<string, MultiTimer.TimerData> timerDataMap = this._timerDataMap;
			Dictionary<string, MultiTimer.TimerData> timerDataMap2 = this._timerDataMap;
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0028302C File Offset: 0x0028122C
		public bool StopAndPrint()
		{
			this._timer.Stop();
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

		// Token: 0x04008AC3 RID: 35523
		private readonly int _ticksBetweenPrint;

		// Token: 0x04008AC4 RID: 35524
		private int _ticksElapsedForPrint;

		// Token: 0x04008AC5 RID: 35525
		private readonly Stopwatch _timer;

		// Token: 0x04008AC6 RID: 35526
		private readonly Dictionary<string, MultiTimer.TimerData> _timerDataMap;

		// Token: 0x02000B04 RID: 2820
		private struct TimerData
		{
			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x0600527F RID: 21119 RVA: 0x00283188 File Offset: 0x00281388
			public double Average
			{
				get
				{
					/*
An exception occurred when decompiling this method (0600527F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double ReLogic.Utilities.MultiTimer/TimerData::get_Average()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(TimerData::Ticks, ldloc:valuetype ReLogic.Utilities.MultiTimer/TimerData&(this)))
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

			// Token: 0x06005280 RID: 21120 RVA: 0x0028319C File Offset: 0x0028139C
			private TimerData(double min, double max, double ticks, double total)
			{
				this.Min = min;
				this.Ticks = ticks;
			}

			// Token: 0x06005281 RID: 21121 RVA: 0x002831B8 File Offset: 0x002813B8
			public TimerData(double startTime)
			{
				this.Min = startTime;
				this.Total = startTime;
			}

			// Token: 0x06005282 RID: 21122 RVA: 0x002831D4 File Offset: 0x002813D4
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

			// Token: 0x04008AC7 RID: 35527
			public readonly double Min;

			// Token: 0x04008AC8 RID: 35528
			public readonly double Max;

			// Token: 0x04008AC9 RID: 35529
			public readonly double Ticks;

			// Token: 0x04008ACA RID: 35530
			public readonly double Total;
		}
	}
}
