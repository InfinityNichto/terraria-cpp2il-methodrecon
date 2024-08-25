using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000A5E RID: 2654
	public class GameTipsDisplay
	{
		// Token: 0x06004E76 RID: 20086 RVA: 0x00276B08 File Offset: 0x00274D08
		public GameTipsDisplay()
		{
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x00276B1C File Offset: 0x00274D1C
		public void Update()
		{
			if (!true)
			{
			}
			List<GameTipsDisplay.GameTip> currentTips = this._currentTips;
			List<GameTipsDisplay.GameTip> currentTips2 = this._currentTips;
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x000021DB File Offset: 0x000003DB
		public void ClearTips()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00276B74 File Offset: 0x00274D74
		public void Draw([Optional] String_Layout layout, float MaxHeight = 0f)
		{
			if (!true)
			{
			}
			int screenHeight = Main.screenHeight;
			int screenHeight2 = Main.screenHeight;
			int screenWidth = Main.screenWidth;
			List<GameTipsDisplay.GameTip> currentTips = this._currentTips;
			while (layout == null)
			{
			}
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x000021DB File Offset: 0x000003DB
		private void AddNewTip(double currentTime)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04008795 RID: 34709
		private LocalizedText[] _tipsDefault;

		// Token: 0x04008796 RID: 34710
		private LocalizedText[] _tipsGamepad;

		// Token: 0x04008797 RID: 34711
		private LocalizedText[] _tipsKeyboard;

		// Token: 0x04008798 RID: 34712
		private readonly List<GameTipsDisplay.GameTip> _currentTips;

		// Token: 0x04008799 RID: 34713
		private LocalizedText _lastTip;

		// Token: 0x0400879A RID: 34714
		private int _lastTipIndex;

		// Token: 0x02000A5F RID: 2655
		private class GameTip
		{
			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06004E7B RID: 20091 RVA: 0x00276C84 File Offset: 0x00274E84
			public string Text
			{
				get
				{
					/*
An exception occurred when decompiling this method (06004E7B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.GameContent.UI.GameTipsDisplay/GameTip::get_Text()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LocalizedText(var_0_06, ldfld:LocalizedText(GameTip::_textKey, ldloc:GameTip(this)))
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

			// Token: 0x06004E7C RID: 20092 RVA: 0x00276C98 File Offset: 0x00274E98
			public bool IsExpired(double currentTime)
			{
				/*
An exception occurred when decompiling this method (06004E7C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.GameTipsDisplay/GameTip::IsExpired(System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(GameTip::Duration, ldloc:GameTip(this)))
	stloc:float64(var_1_0D, ldfld:float64(GameTip::SpawnTime, ldloc:GameTip(this)))
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

			// Token: 0x06004E7D RID: 20093 RVA: 0x00276CB4 File Offset: 0x00274EB4
			public bool IsExpiring(double currentTime)
			{
				/*
An exception occurred when decompiling this method (06004E7D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.GameTipsDisplay/GameTip::IsExpiring(System.Double)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(GameTip::Duration, ldloc:GameTip(this)))
	stloc:float64(var_1_0D, ldfld:float64(GameTip::SpawnTime, ldloc:GameTip(this)))
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

			// Token: 0x06004E7E RID: 20094 RVA: 0x00276CD0 File Offset: 0x00274ED0
			public GameTip(LocalizedText text, double spawnTime)
			{
				this._textKey = text;
				this.Duration = (float)spawnTime;
				object obj;
				string text2 = this._textKey.FormatWith(obj);
				this._formattedText = text2;
			}

			// Token: 0x06004E7F RID: 20095 RVA: 0x00276D08 File Offset: 0x00274F08
			public void Update(double currentTime)
			{
				double spawnTime = this.SpawnTime;
			}

			// Token: 0x0400879B RID: 34715
			private const float APPEAR_FROM = 2.5f;

			// Token: 0x0400879C RID: 34716
			private const float APPEAR_TO = 0.5f;

			// Token: 0x0400879D RID: 34717
			private const float DISAPPEAR_TO = -1.5f;

			// Token: 0x0400879E RID: 34718
			private const float APPEAR_TIME = 0.5f;

			// Token: 0x0400879F RID: 34719
			private const float DISAPPEAR_TIME = 1f;

			// Token: 0x040087A0 RID: 34720
			private const float DURATION = 11.5f;

			// Token: 0x040087A1 RID: 34721
			private LocalizedText _textKey;

			// Token: 0x040087A2 RID: 34722
			private string _formattedText;

			// Token: 0x040087A3 RID: 34723
			public float ScreenAnchorX;

			// Token: 0x040087A4 RID: 34724
			public readonly float Duration;

			// Token: 0x040087A5 RID: 34725
			public readonly double SpawnTime;
		}

		// Token: 0x02000A60 RID: 2656
		[CompilerGenerated]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06004E80 RID: 20096 RVA: 0x00276D28 File Offset: 0x00274F28
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06004E81 RID: 20097 RVA: 0x00276D3C File Offset: 0x00274F3C
			internal bool <Update>b__0(GameTipsDisplay.GameTip x)
			{
				/*
An exception occurred when decompiling this method (06004E81)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.UI.GameTipsDisplay/<>c__DisplayClass8_0::<Update>b__0(Terraria.GameContent.UI.GameTipsDisplay/GameTip)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(GameTip::Duration, ldloc:GameTip(x)))
	stloc:float64(var_1_0D, ldfld:float64(GameTip::SpawnTime, ldloc:GameTip(x)))
	stloc:float64(var_2_14, ldfld:float64('<>c__DisplayClass8_0'::time, ldloc:'<>c__DisplayClass8_0'(this)))
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

			// Token: 0x040087A6 RID: 34726
			public double time;
		}
	}
}
