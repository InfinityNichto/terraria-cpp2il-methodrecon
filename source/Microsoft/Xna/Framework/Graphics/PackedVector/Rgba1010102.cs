using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003BF RID: 959
	public struct Rgba1010102 : IPackedVector<uint>, IPackedVector, IEquatable<Rgba1010102>
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x0006BB58 File Offset: 0x00069D58
		[CLSCompliant(false)]
		public uint PackedValue
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

		// Token: 0x06001A00 RID: 6656 RVA: 0x0006BB6C File Offset: 0x00069D6C
		public Rgba1010102(float x, float y, float z, float w)
		{
			uint num = Rgba1010102.Pack(x, y, z, w);
			this.packedValue = num;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0006BB8C File Offset: 0x00069D8C
		public Rgba1010102(Vector4 vector)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector4 ToVector4()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0006BBA0 File Offset: 0x00069DA0
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			uint num;
			this.packedValue = num;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0006BBB4 File Offset: 0x00069DB4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Rgba1010102 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0006BBC8 File Offset: 0x00069DC8
		public override string ToString()
		{
			return this.ToVector4().ToString();
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0006BBE0 File Offset: 0x00069DE0
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Rgba1010102 lhs, Rgba1010102 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Rgba1010102 lhs, Rgba1010102 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0006BBF0 File Offset: 0x00069DF0
		private static uint Pack(float x, float y, float z, float w)
		{
			/*
An exception occurred when decompiling this method (06001A0A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Microsoft.Xna.Framework.Graphics.PackedVector.Rgba1010102::Pack(System.Single,System.Single,System.Single,System.Single)

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

		// Token: 0x040027A9 RID: 10153
		private uint packedValue;
	}
}
