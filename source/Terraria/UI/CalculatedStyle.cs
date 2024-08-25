using System;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x020006DB RID: 1755
	public struct CalculatedStyle
	{
		// Token: 0x06003AF3 RID: 15091 RVA: 0x00233408 File Offset: 0x00231608
		public CalculatedStyle(float x, float y, float width, float height)
		{
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00233418 File Offset: 0x00231618
		public Rectangle ToRectangle()
		{
			/*
An exception occurred when decompiling this method (06003AF4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.UI.CalculatedStyle::ToRectangle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(CalculatedStyle::X, ldloc:valuetype Terraria.UI.CalculatedStyle&(this)))
	stloc:float32(var_1_0D, ldfld:float32(CalculatedStyle::Y, ldloc:valuetype Terraria.UI.CalculatedStyle&(this)))
	stloc:float32(var_2_14, ldfld:float32(CalculatedStyle::Width, ldloc:valuetype Terraria.UI.CalculatedStyle&(this)))
	stloc:float32(var_3_1B, ldfld:float32(CalculatedStyle::Height, ldloc:valuetype Terraria.UI.CalculatedStyle&(this)))
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

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00233440 File Offset: 0x00231640
		public Vector2 Position()
		{
			float x = this.X;
			float y = this.Y;
			Vector2 vector;
			return vector;
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x0023345C File Offset: 0x0023165C
		public Vector2 Center()
		{
			float width = this.Width;
			float height = this.Height;
			float x = this.X;
			float y = this.Y;
			Vector2 vector;
			return vector;
		}

		// Token: 0x04007ADC RID: 31452
		public float X;

		// Token: 0x04007ADD RID: 31453
		public float Y;

		// Token: 0x04007ADE RID: 31454
		public float Width;

		// Token: 0x04007ADF RID: 31455
		public float Height;
	}
}
