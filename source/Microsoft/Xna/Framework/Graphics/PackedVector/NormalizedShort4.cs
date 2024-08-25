using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003BD RID: 957
	public struct NormalizedShort4 : IPackedVector<ulong>, IPackedVector, IEquatable<NormalizedShort4>
	{
		// Token: 0x060019E3 RID: 6627 RVA: 0x0006B99C File Offset: 0x00069B9C
		public NormalizedShort4(Vector4 vector)
		{
			ulong num;
			this.short4Packed = num;
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0006B9B0 File Offset: 0x00069BB0
		public NormalizedShort4(float x, float y, float z, float w)
		{
			ulong num = NormalizedShort4.PackInFour(x, y, z, w);
			this.short4Packed = num;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0006B9D0 File Offset: 0x00069BD0
		public static bool operator !=(NormalizedShort4 a, NormalizedShort4 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0006B9E0 File Offset: 0x00069BE0
		public static bool operator ==(NormalizedShort4 a, NormalizedShort4 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0006B9F0 File Offset: 0x00069BF0
		[CLSCompliant(false)]
		public ulong PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.short4Packed = value;
			}
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0006BA04 File Offset: 0x00069C04
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0006BA18 File Offset: 0x00069C18
		public bool Equals(NormalizedShort4 other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0006BA28 File Offset: 0x00069C28
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0006BA38 File Offset: 0x00069C38
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0006BA48 File Offset: 0x00069C48
		private static ulong PackInFour(float vectorX, float vectorY, float vectorZ, float vectorW)
		{
			/*
An exception occurred when decompiling this method (060019ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt64 Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4::PackInFour(System.Single,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0A, call:float32(MathHelper::Clamp, ldloc:float32(vectorX), ldloc:float32(vectorX), ldloc:float32(vectorZ)))
	stloc:float32(var_3_15, call:float32(MathHelper::Clamp, ldloc:float32(var_1_0A), ldloc:float32(vectorX), ldloc:float32(vectorZ)))
	stloc:float32(var_5_21, call:float32(MathHelper::Clamp, ldloc:float32(vectorY), ldloc:float32(vectorX), ldloc:float32(vectorZ)))
	stloc:float32(var_7_2E, call:float32(MathHelper::Clamp, ldloc:float32(vectorZ), ldloc:float32(vectorX), ldloc:float32(vectorZ)))
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

		// Token: 0x060019EE RID: 6638 RVA: 0x0006BA84 File Offset: 0x00069C84
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ulong num;
			this.short4Packed = num;
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040027A7 RID: 10151
		private ulong short4Packed;
	}
}
