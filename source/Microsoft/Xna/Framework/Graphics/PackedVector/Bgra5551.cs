using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B1 RID: 945
	public struct Bgra5551 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra5551>
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001972 RID: 6514 RVA: 0x0006B334 File Offset: 0x00069534
		[CLSCompliant(false)]
		public ushort PackedValue
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

		// Token: 0x06001973 RID: 6515 RVA: 0x0006B348 File Offset: 0x00069548
		public Bgra5551(float x, float y, float z, float w)
		{
			ushort num = Bgra5551.Pack(x, y, z, w);
			this.packedValue = num;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0006B368 File Offset: 0x00069568
		public Bgra5551(Vector4 vector)
		{
			ushort num;
			this.packedValue = num;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0006B37C File Offset: 0x0006957C
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ushort num;
			this.packedValue = num;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0006B390 File Offset: 0x00069590
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Bgra5551 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0006B3A4 File Offset: 0x000695A4
		public override string ToString()
		{
			return this.ToVector4().ToString();
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0006B3BC File Offset: 0x000695BC
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Bgra5551 lhs, Bgra5551 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Bgra5551 lhs, Bgra5551 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0006B3CC File Offset: 0x000695CC
		private static ushort Pack(float x, float y, float z, float w)
		{
			/*
An exception occurred when decompiling this method (0600197D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 Microsoft.Xna.Framework.Graphics.PackedVector.Bgra5551::Pack(System.Single,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:float32(var_3_18, call:float32(MathHelper::Clamp, ldloc:float32(y), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_5_24, call:float32(MathHelper::Clamp, ldloc:float32(z), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_7_31, call:float32(MathHelper::Clamp, ldloc:float32(z), ldloc:float32(y), ldloc:float32(z)))
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

		// Token: 0x0400279C RID: 10140
		private ushort packedValue;
	}
}
