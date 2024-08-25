using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003AF RID: 943
	public struct Bgr565 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgr565>
	{
		// Token: 0x06001956 RID: 6486 RVA: 0x0006B174 File Offset: 0x00069374
		private static ushort Pack(float x, float y, float z)
		{
			/*
An exception occurred when decompiling this method (06001956)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt16 Microsoft.Xna.Framework.Graphics.PackedVector.Bgr565::Pack(System.Single,System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:float32(var_3_18, call:float32(MathHelper::Clamp, ldloc:float32(y), ldloc:float32(y), ldloc:float32(z)))
	stloc:float32(var_5_24, call:float32(MathHelper::Clamp, ldloc:float32(z), ldloc:float32(y), ldloc:float32(z)))
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

		// Token: 0x06001957 RID: 6487 RVA: 0x0006B1A8 File Offset: 0x000693A8
		public Bgr565(float x, float y, float z)
		{
			ushort num = Bgr565.Pack(x, y, z);
			this._packedValue = num;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0006B1C8 File Offset: 0x000693C8
		public Bgr565(Vector3 vector)
		{
			ushort num;
			this._packedValue = num;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x0006B1DC File Offset: 0x000693DC
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

		// Token: 0x0600195B RID: 6491 RVA: 0x000021DB File Offset: 0x000003DB
		public Vector3 ToVector3()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0006B1F0 File Offset: 0x000693F0
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			this._packedValue = 32640;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0006B208 File Offset: 0x00069408
		Vector4 IPackedVector.ToVector4()
		{
			Vector3 vector = this.ToVector3();
			Vector4 vector2;
			return vector2;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0006B220 File Offset: 0x00069420
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				return;
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000021DB File Offset: 0x000003DB
		public bool Equals(Bgr565 other)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0006B234 File Offset: 0x00069434
		public override string ToString()
		{
			return this.ToVector3().ToString();
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0006B24C File Offset: 0x0006944C
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Bgr565 lhs, Bgr565 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Bgr565 lhs, Bgr565 rhs)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400279A RID: 10138
		private ushort _packedValue;
	}
}
