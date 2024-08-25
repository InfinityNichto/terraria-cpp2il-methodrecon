using System;
using System.IO;

namespace Terraria.DataStructures
{
	// Token: 0x0200061B RID: 1563
	public class CachedBuffer
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x00211948 File Offset: 0x0020FB48
		public int Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (060035C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.CachedBuffer::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](CachedBuffer::Data, ldloc:CachedBuffer(this)))
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
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x0021195C File Offset: 0x0020FB5C
		public bool IsActive
		{
			get
			{
				return this._isActive;
			}
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00211970 File Offset: 0x0020FB70
		public CachedBuffer(byte[] data)
		{
			this.Data = data;
			MemoryStream memoryStream = this._memoryStream;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00211998 File Offset: 0x0020FB98
		internal CachedBuffer Activate()
		{
			MemoryStream memoryStream = this._memoryStream;
			this._isActive = true;
			return this;
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x002119B4 File Offset: 0x0020FBB4
		public void Recycle()
		{
			if (true)
			{
				return;
			}
		}

		// Token: 0x0400769A RID: 30362
		public readonly byte[] Data;

		// Token: 0x0400769B RID: 30363
		public readonly BinaryWriter Writer;

		// Token: 0x0400769C RID: 30364
		public readonly BinaryReader Reader;

		// Token: 0x0400769D RID: 30365
		private readonly MemoryStream _memoryStream;

		// Token: 0x0400769E RID: 30366
		private bool _isActive = true;
	}
}
