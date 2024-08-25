using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004ED RID: 1261
	public class WorldGenRange
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x001F68D4 File Offset: 0x001F4AD4
		public int ScaledMinimum
		{
			get
			{
				int minimum = this.Minimum;
				return this.ScaleValue(minimum);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x001F68F0 File Offset: 0x001F4AF0
		public int ScaledMaximum
		{
			get
			{
				int maximum = this.Maximum;
				return this.ScaleValue(maximum);
			}
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x001F690C File Offset: 0x001F4B0C
		public WorldGenRange(int minimum, int maximum)
		{
			this.Minimum = minimum;
			this.ScaleWith = (WorldGenRange.ScalingMode)maximum;
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x001F6930 File Offset: 0x001F4B30
		public int GetRandom(UnifiedRandom random)
		{
			int minimum = this.Minimum;
			int num = this.ScaleValue(minimum);
			int maximum = this.Maximum;
			int num2 = this.ScaleValue(maximum);
			int num3;
			return num3;
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x001F6960 File Offset: 0x001F4B60
		private int ScaleValue(int value)
		{
			/*
An exception occurred when decompiling this method (06003092)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldBuilding.WorldGenRange::ScaleValue(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	brtrue(IL_0000, ldloc:ScalingMode[exp:bool](var_0_06))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
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

		// Token: 0x06003093 RID: 12435 RVA: 0x001F697C File Offset: 0x001F4B7C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldGenRange()
		{
		}

		// Token: 0x04003A9C RID: 15004
		public static readonly WorldGenRange Empty;

		// Token: 0x04003A9D RID: 15005
		[JsonProperty("Min")]
		public readonly int Minimum;

		// Token: 0x04003A9E RID: 15006
		[JsonProperty("Max")]
		public readonly int Maximum;

		// Token: 0x04003A9F RID: 15007
		[JsonConverter(typeof(StringEnumConverter))]
		[JsonProperty]
		public readonly WorldGenRange.ScalingMode ScaleWith;

		// Token: 0x020004EE RID: 1262
		public enum ScalingMode
		{
			// Token: 0x04003AA1 RID: 15009
			None,
			// Token: 0x04003AA2 RID: 15010
			WorldArea,
			// Token: 0x04003AA3 RID: 15011
			WorldWidth
		}
	}
}
