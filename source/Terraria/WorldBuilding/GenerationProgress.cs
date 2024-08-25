using System;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004B0 RID: 1200
	public class GenerationProgress
	{
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002FE0 RID: 12256 RVA: 0x001F4F1C File Offset: 0x001F311C
		// (set) Token: 0x06002FE1 RID: 12257 RVA: 0x001F4F38 File Offset: 0x001F3138
		public string Message
		{
			get
			{
				string message = this._message;
				double value = this._value;
				string text;
				return text;
			}
			set
			{
				string text = value.Replace("%", "{0:0.0%}");
				this._message = text;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x001F4F78 File Offset: 0x001F3178
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x001F4F60 File Offset: 0x001F3160
		public double Value
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002FE3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.WorldBuilding.GenerationProgress::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(GenerationProgress::_value, ldloc:GenerationProgress(this)))
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
			set
			{
				if (!true)
				{
				}
				this._value = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x001F4F8C File Offset: 0x001F318C
		public double TotalProgress
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002FE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double Terraria.WorldBuilding.GenerationProgress::get_TotalProgress()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float64(var_0_06, ldfld:float64(GenerationProgress::TotalWeight, ldloc:GenerationProgress(this)))
	stloc:float64(var_1_0D, ldfld:float64(GenerationProgress::CurrentPassWeight, ldloc:GenerationProgress(this)))
	stloc:float64(var_2_14, ldfld:float64(GenerationProgress::_value, ldloc:GenerationProgress(this)))
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

		// Token: 0x06002FE5 RID: 12261 RVA: 0x001F4FB0 File Offset: 0x001F31B0
		public void Set(double value)
		{
			this.Value = value;
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x001F4FC4 File Offset: 0x001F31C4
		public void Start(double weight)
		{
			this.CurrentPassWeight = weight;
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x001F4FD8 File Offset: 0x001F31D8
		public void End()
		{
			double totalProgress = this._totalProgress;
			double currentPassWeight = this.CurrentPassWeight;
			this._totalProgress = totalProgress;
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x001F4FFC File Offset: 0x001F31FC
		public GenerationProgress()
		{
		}

		// Token: 0x0400399B RID: 14747
		private string _message = "";

		// Token: 0x0400399C RID: 14748
		private double _value;

		// Token: 0x0400399D RID: 14749
		private double _totalProgress;

		// Token: 0x0400399E RID: 14750
		public double TotalWeight;

		// Token: 0x0400399F RID: 14751
		public double CurrentPassWeight;
	}
}
