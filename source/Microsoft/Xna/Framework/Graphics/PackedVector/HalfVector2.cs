using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector
{
	// Token: 0x020003B6 RID: 950
	public struct HalfVector2 : IPackedVector<uint>, IPackedVector, IEquatable<HalfVector2>
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x0006B574 File Offset: 0x00069774
		public HalfVector2(float x, float y)
		{
			ushort num2;
			ushort num = HalfTypeHelper.Convert((int)num2);
			this.packedValue = (uint)num2;
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0006B590 File Offset: 0x00069790
		public HalfVector2(Vector2 vector)
		{
			ushort num2;
			ushort num = HalfTypeHelper.Convert((int)num2);
			this.packedValue = (uint)num2;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0006B5AC File Offset: 0x000697AC
		void IPackedVector.PackFromVector4(Vector4 vector)
		{
			ushort num2;
			ushort num = HalfTypeHelper.Convert((int)num2);
			this.packedValue = (uint)num2;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0006B5C8 File Offset: 0x000697C8
		private static uint PackHelper(float vectorX, float vectorY)
		{
			/*
An exception occurred when decompiling this method (0600199E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector2::PackHelper(System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint16(var_1_06, call:uint16(HalfTypeHelper::Convert, ldloc:uint16[exp:int32](var_0)))
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

		// Token: 0x0600199F RID: 6559 RVA: 0x0006B5DC File Offset: 0x000697DC
		public Vector2 ToVector2()
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0006B5EC File Offset: 0x000697EC
		Vector4 IPackedVector.ToVector4()
		{
			Vector4 vector;
			return vector;
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0006B5FC File Offset: 0x000697FC
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

		// Token: 0x060019A3 RID: 6563 RVA: 0x0006B610 File Offset: 0x00069810
		public override string ToString()
		{
			string text;
			return text;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0006B620 File Offset: 0x00069820
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0006B630 File Offset: 0x00069830
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0006B644 File Offset: 0x00069844
		public bool Equals(HalfVector2 other)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0006B654 File Offset: 0x00069854
		public static bool operator ==(HalfVector2 a, HalfVector2 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0006B664 File Offset: 0x00069864
		public static bool operator !=(HalfVector2 a, HalfVector2 b)
		{
			bool flag;
			return flag;
		}

		// Token: 0x040027A2 RID: 10146
		private uint packedValue;
	}
}
