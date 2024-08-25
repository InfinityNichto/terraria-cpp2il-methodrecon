using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B0 RID: 944
	public struct Bgra4444 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra4444>
	{
		// Token: 0x06001964 RID: 6500 RVA: 0x0006B25C File Offset: 0x0006945C
		private static ushort Pack(float x, float y, float z, float w)
		{
			/*
An exception occurred when decompiling this method (06001964)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 Microsoft.Xna.Framework.Graphics.PackedVector.Bgra4444::Pack(System.Single,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:float32(var_3_18, call:float32(MathHelper::Clamp, ldloc:float32(x), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_5_24, call:float32(MathHelper::Clamp, ldloc:float32(y), ldloc:float32(y), ldloc:float32(z)))
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

		// Token: 0x06001965 RID: 6501 RVA: 0x0006B29C File Offset: 0x0006949C
		public Bgra4444(float x, float y, float z, float w)
		{
			ushort num = Bgra4444.Pack(x, y, z, w);
			this._packedValue = num;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0006B2BC File Offset: 0x000694BC
		public Bgra4444(Vector4 vector)
		{
			ushort num;
			this._packedValue = num;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001968 RID: 6504 RVA: 0x0006B2D0 File Offset: 0x000694D0
		[CLSCompliant(false)]
		public ushort PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._packedValue = value;
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0006B2E4 File Offset: 0x000694E4
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ushort num;
			this._packedValue = num;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0006B2F8 File Offset: 0x000694F8
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Bgra4444 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0006B30C File Offset: 0x0006950C
		public override string ToString()
		{
			return this.ToVector4().ToString();
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0006B324 File Offset: 0x00069524
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Bgra4444 lhs, Bgra4444 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Bgra4444 lhs, Bgra4444 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400279B RID: 10139
		private ushort _packedValue;
	}
}
