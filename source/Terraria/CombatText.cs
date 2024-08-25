using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	// Token: 0x02000427 RID: 1063
	public class CombatText
	{
		// Token: 0x060027AD RID: 10157 RVA: 0x0018E004 File Offset: 0x0018C204
		public static int NewText(Rectangle location, Color color, int amount, bool dramatic = false, bool dot = false)
		{
			int num;
			return num;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x0018E014 File Offset: 0x0018C214
		public static int NewText(Rectangle location, Color color, string text, bool dramatic = false, bool dot = false)
		{
			/*
An exception occurred when decompiling this method (060027AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.CombatText::NewText(Microsoft.Xna.Framework.Rectangle,Microsoft.Xna.Framework.Graphics.Color,System.String,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001E:
	stloc:int32(var_9_29, callgetter:int32(Main::get_myPlayer))
	brtrue(IL_0000, ldc.i4:int32[exp:bool](60))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0018E050 File Offset: 0x0018C250
		public static void clearAll()
		{
			if (!true)
			{
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x000021DB File Offset: 0x000003DB
		public static float TargetScale
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x0018E068 File Offset: 0x0018C268
		public void Update()
		{
			if (this.active)
			{
				float num = this.alpha;
				int num2 = this.alphaDir;
				this.alpha = num;
				int num3 = 1;
				this.alphaDir = num3;
				return;
			}
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x0018E178 File Offset: 0x0018C378
		public static void UpdateCombatText()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x0018E190 File Offset: 0x0018C390
		public CombatText()
		{
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x0018E1C0 File Offset: 0x0018C3C0
		// Note: this type is marked as 'beforefieldinit'.
		static CombatText()
		{
		}

		// Token: 0x040033BE RID: 13246
		public static readonly Color DamagedFriendly;

		// Token: 0x040033BF RID: 13247
		public static readonly Color DamagedFriendlyCrit;

		// Token: 0x040033C0 RID: 13248
		public static readonly Color DamagedHostile;

		// Token: 0x040033C1 RID: 13249
		public static readonly Color DamagedHostileCrit;

		// Token: 0x040033C2 RID: 13250
		public static readonly Color OthersDamagedHostile;

		// Token: 0x040033C3 RID: 13251
		public static readonly Color OthersDamagedHostileCrit;

		// Token: 0x040033C4 RID: 13252
		public static readonly Color HealLife;

		// Token: 0x040033C5 RID: 13253
		public static readonly Color HealMana;

		// Token: 0x040033C6 RID: 13254
		public static readonly Color LifeRegen;

		// Token: 0x040033C7 RID: 13255
		public static readonly Color LifeRegenNegative;

		// Token: 0x040033C8 RID: 13256
		public Vector2 position;

		// Token: 0x040033C9 RID: 13257
		public Vector2 velocity;

		// Token: 0x040033CA RID: 13258
		public float alpha;

		// Token: 0x040033CB RID: 13259
		public int alphaDir = 1;

		// Token: 0x040033CC RID: 13260
		public string text = "";

		// Token: 0x040033CD RID: 13261
		public float scale = (float)16256;

		// Token: 0x040033CE RID: 13262
		public float rotation;

		// Token: 0x040033CF RID: 13263
		public Color color;

		// Token: 0x040033D0 RID: 13264
		public bool active;

		// Token: 0x040033D1 RID: 13265
		public int lifeTime;

		// Token: 0x040033D2 RID: 13266
		public bool crit;

		// Token: 0x040033D3 RID: 13267
		public bool dot;
	}
}
