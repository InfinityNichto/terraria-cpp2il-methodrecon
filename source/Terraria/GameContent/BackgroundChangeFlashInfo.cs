using System;

namespace Terraria.GameContent
{
	// Token: 0x02000806 RID: 2054
	public class BackgroundChangeFlashInfo
	{
		// Token: 0x060041CD RID: 16845 RVA: 0x00248A24 File Offset: 0x00246C24
		public void UpdateCache()
		{
			if (!true)
			{
			}
			int[] variations = this._variations;
			long num = 0L;
			this.ValueChanged((int)num);
			int[] variations2 = this._variations;
			this.ValueChanged(1);
			int[] variations3 = this._variations;
			this.ValueChanged(2);
			int[] variations4 = this._variations;
			this.ValueChanged(3);
			int[] variations5 = this._variations;
			this.ValueChanged(4);
			int[] variations6 = this._variations;
			this.ValueChanged(5);
			int[] variations7 = this._variations;
			this.ValueChanged(6);
			int[] variations8 = this._variations;
			this.ValueChanged(7);
			int[] variations9 = this._variations;
			this.ValueChanged(8);
			int[] variations10 = this._variations;
			this.ValueChanged(9);
			int[] variations11 = this._variations;
			this.ValueChanged(10);
			int[] variations12 = this._variations;
			this.ValueChanged(11);
			int[] variations13 = this._variations;
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x00248AFC File Offset: 0x00246CFC
		private void UpdateVariation(int areaId, int newVariationValue)
		{
			int[] variations = this._variations;
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x00248B18 File Offset: 0x00246D18
		private void ValueChanged(int areaId)
		{
			if (!true)
			{
			}
			bool gameMenu = Main.gameMenu;
			float[] flashPower = this._flashPower;
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00248B40 File Offset: 0x00246D40
		public void UpdateFlashValues()
		{
			float[] flashPower = this._flashPower;
			float[] flashPower2 = this._flashPower;
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00248B60 File Offset: 0x00246D60
		public float GetFlashPower(int areaId)
		{
			/*
An exception occurred when decompiling this method (060041D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.BackgroundChangeFlashInfo::GetFlashPower(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32[](var_0_06, ldfld:float32[](BackgroundChangeFlashInfo::_flashPower, ldloc:BackgroundChangeFlashInfo(this)))
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

		// Token: 0x060041D2 RID: 16850 RVA: 0x00248B74 File Offset: 0x00246D74
		public BackgroundChangeFlashInfo()
		{
		}

		// Token: 0x04008098 RID: 32920
		private int[] _variations;

		// Token: 0x04008099 RID: 32921
		private float[] _flashPower;
	}
}
