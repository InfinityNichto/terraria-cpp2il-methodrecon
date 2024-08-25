using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B7 RID: 951
	public struct HalfVector4 : IPackedVector<ulong>, IPackedVector, IEquatable<HalfVector4>
	{
		// Token: 0x060019A9 RID: 6569 RVA: 0x0006B674 File Offset: 0x00069874
		public HalfVector4(float x, float y, float z, float w)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0006B688 File Offset: 0x00069888
		public HalfVector4(Vector4 vector)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0006B69C File Offset: 0x0006989C
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ulong num;
			this.packedValue = num;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0006B6B0 File Offset: 0x000698B0
		private static ulong PackHelper(Vector4 vector)
		{
			/*
An exception occurred when decompiling this method (060019AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt64 Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4::PackHelper(Microsoft.Xna.Framework.Vector4)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16(var_1_10, call:uint16(HalfTypeHelper::Convert, call:uint16[exp:int32](HalfTypeHelper::Convert, call:uint16[exp:int32](HalfTypeHelper::Convert, ldloc:uint16[exp:int32](var_0)))))
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

		// Token: 0x060019AD RID: 6573 RVA: 0x0006B6D0 File Offset: 0x000698D0
		public Vector4 ToVector4()
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0006B6E0 File Offset: 0x000698E0
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

		// Token: 0x060019B0 RID: 6576 RVA: 0x0006B6F4 File Offset: 0x000698F4
		public override string ToString()
		{
			return this.ToVector4().ToString();
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0006B70C File Offset: 0x0006990C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0006B71C File Offset: 0x0006991C
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0006B730 File Offset: 0x00069930
		public bool Equals(HalfVector4 other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0006B740 File Offset: 0x00069940
		public static bool operator ==(HalfVector4 a, HalfVector4 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0006B750 File Offset: 0x00069950
		public static bool operator !=(HalfVector4 a, HalfVector4 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x040027A3 RID: 10147
		private ulong packedValue;
	}
}
