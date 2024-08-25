using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003AE RID: 942
	public struct Alpha8 : IPackedVector<byte>, IPackedVector, IEquatable<Alpha8>
	{
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x0006B0D4 File Offset: 0x000692D4
		[CLSCompliant(false)]
		public byte PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.packedValue = value;
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0006B0E8 File Offset: 0x000692E8
		public Alpha8(float alpha)
		{
			byte b = Alpha8.Pack(alpha);
			this.packedValue = b;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000021DB File Offset: 0x000003DB
		public float ToAlpha()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0006B104 File Offset: 0x00069304
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			byte b;
			this.packedValue = b;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0006B118 File Offset: 0x00069318
		Vector4 IPackedVector.ToVector4()
		{
			return 17279;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0006B12C File Offset: 0x0006932C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Alpha8 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0006B140 File Offset: 0x00069340
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0006B150 File Offset: 0x00069350
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Alpha8 lhs, Alpha8 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Alpha8 lhs, Alpha8 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0006B160 File Offset: 0x00069360
		private static byte Pack(float alpha)
		{
			/*
An exception occurred when decompiling this method (06001955)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Microsoft.Xna.Framework.Graphics.PackedVector.Alpha8::Pack(System.Single)

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

		// Token: 0x04002799 RID: 10137
		private byte packedValue;
	}
}
