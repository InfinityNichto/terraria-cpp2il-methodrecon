using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x0200073E RID: 1854
	public struct FlameLashDrawer
	{
		// Token: 0x06003D2E RID: 15662 RVA: 0x0023891C File Offset: 0x00236B1C
		public void Draw(Projectile proj)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00238994 File Offset: 0x00236B94
		private void StripColors(float progressOnStrip, [Out] Color col)
		{
			if (!true)
			{
			}
			Color color;
			col.A = color;
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x002389B0 File Offset: 0x00236BB0
		private float StripWidth(float progressOnStrip)
		{
			/*
An exception occurred when decompiling this method (06003D30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.Graphics.FlameLashDrawer::StripWidth(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:float32(var_3_0D, call:float32(MathHelper::Lerp, ldloc:float32(var_1), ldloc:float32(progressOnStrip), ldloc:float32(var_1)))
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

		// Token: 0x06003D31 RID: 15665 RVA: 0x002389CC File Offset: 0x00236BCC
		// Note: this type is marked as 'beforefieldinit'.
		static FlameLashDrawer()
		{
		}

		// Token: 0x04007C1C RID: 31772
		private static VertexStrip _vertexStrip;

		// Token: 0x04007C1D RID: 31773
		private float transitToDark;
	}
}
