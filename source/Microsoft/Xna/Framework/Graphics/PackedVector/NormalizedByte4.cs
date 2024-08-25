using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003BB RID: 955
	public struct NormalizedByte4 : IPackedVector<uint>, IPackedVector, IEquatable<NormalizedByte4>
	{
		// Token: 0x060019C8 RID: 6600 RVA: 0x0006B800 File Offset: 0x00069A00
		public NormalizedByte4(Vector4 vector)
		{
			uint num;
			this._packed = num;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0006B814 File Offset: 0x00069A14
		public NormalizedByte4(float x, float y, float z, float w)
		{
			uint num = NormalizedByte4.Pack(x, y, z, w);
			this._packed = num;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(NormalizedByte4 a, NormalizedByte4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(NormalizedByte4 a, NormalizedByte4 b)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0006B834 File Offset: 0x00069A34
		[CLSCompliant(false)]
		public uint PackedValue
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this._packed = value;
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0006B848 File Offset: 0x00069A48
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(NormalizedByte4 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0006B85C File Offset: 0x00069A5C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0006B86C File Offset: 0x00069A6C
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0006B87C File Offset: 0x00069A7C
		private static uint Pack(float x, float y, float z, float w)
		{
			/*
An exception occurred when decompiling this method (060019D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte4::Pack(System.Single,System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:float32(var_3_18, call:float32(MathHelper::Clamp, ldloc:float32(y), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_5_24, call:float32(MathHelper::Clamp, ldloc:float32(z), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_7_31, call:float32(MathHelper::Clamp, ldloc:float32(w), ldloc:float32(y), ldloc:float32(z)))
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

		// Token: 0x060019D3 RID: 6611 RVA: 0x0006B8BC File Offset: 0x00069ABC
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			uint num;
			this._packed = num;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040027A5 RID: 10149
		private uint _packed;
	}
}
