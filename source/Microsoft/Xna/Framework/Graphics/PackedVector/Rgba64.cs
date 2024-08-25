using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003C0 RID: 960
	public struct Rgba64 : IPackedVector<ulong>, IPackedVector, IEquatable<Rgba64>
	{
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0006BC30 File Offset: 0x00069E30
		[CLSCompliant(false)]
		public ulong PackedValue
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

		// Token: 0x06001A0D RID: 6669 RVA: 0x0006BC44 File Offset: 0x00069E44
		public Rgba64(float x, float y, float z, float w)
		{
			ulong num = Rgba64.Pack(x, y, z, w);
			this.packedValue = num;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0006BC64 File Offset: 0x00069E64
		public Rgba64(Vector4 vector)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0006BC78 File Offset: 0x00069E78
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0006BC8C File Offset: 0x00069E8C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Rgba64 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0006BCA0 File Offset: 0x00069EA0
		public override string ToString()
		{
			return this.ToVector4().ToString();
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0006BCB8 File Offset: 0x00069EB8
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Rgba64 lhs, Rgba64 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Rgba64 lhs, Rgba64 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0006BCC8 File Offset: 0x00069EC8
		private static ulong Pack(float x, float y, float z, float w)
		{
			/*
An exception occurred when decompiling this method (06001A17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt64 Microsoft.Xna.Framework.Graphics.PackedVector.Rgba64::Pack(System.Single,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_0A, call:float32(MathHelper::Clamp, ldloc:float32(x), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_3_15, call:float32(MathHelper::Clamp, ldloc:float32(x), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_5_21, call:float32(MathHelper::Clamp, ldloc:float32(y), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_7_2E, call:float32(MathHelper::Clamp, ldloc:float32(z), ldloc:float32(y), ldloc:float32(z)))
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

		// Token: 0x040027AA RID: 10154
		private ulong packedValue;
	}
}
