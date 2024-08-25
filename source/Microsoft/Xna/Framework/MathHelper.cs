using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000329 RID: 809
	public static class MathHelper
	{
		// Token: 0x0600129D RID: 4765 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Barycentric(float value1, float value2, float value3, float amount1, float amount2)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000021DB File Offset: 0x000003DB
		public static float CatmullRom(float value1, float value2, float value3, float value4, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Clamp(float value, float min, float max)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0005A23C File Offset: 0x0005843C
		public static float Distance(float value1, float value2)
		{
			/*
An exception occurred when decompiling this method (060012A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.MathHelper::Distance(System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060012A1 RID: 4769 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Hermite(float value1, float tangent1, float value2, float tangent2, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000021DB File Offset: 0x000003DB
		public static float Lerp(float value1, float value2, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0005A24C File Offset: 0x0005844C
		public static float Max(float value1, float value2)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0005A260 File Offset: 0x00058460
		public static float Min(float value1, float value2)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000021DB File Offset: 0x000003DB
		public static float SmoothStep(float value1, float value2, float amount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000021DB File Offset: 0x000003DB
		public static float ToDegrees(float radians)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000021DB File Offset: 0x000003DB
		public static float ToRadians(float degrees)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0005A274 File Offset: 0x00058474
		public static float WrapAngle(float angle)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0400224B RID: 8779
		public const float E = 2.7182817f;

		// Token: 0x0400224C RID: 8780
		public const float Log10E = 0.4342945f;

		// Token: 0x0400224D RID: 8781
		public const float Log2E = 1.442695f;

		// Token: 0x0400224E RID: 8782
		public const float Pi = 3.1415927f;

		// Token: 0x0400224F RID: 8783
		public const float PiOver2 = 1.5707964f;

		// Token: 0x04002250 RID: 8784
		public const float PiOver4 = 0.7853982f;

		// Token: 0x04002251 RID: 8785
		public const float TwoPi = 6.2831855f;
	}
}
