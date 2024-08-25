using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000677 RID: 1655
	public struct SpriteFrame
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x00221498 File Offset: 0x0021F698
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x002214AC File Offset: 0x0021F6AC
		public byte CurrentColumn
		{
			get
			{
				return this._currentColumn;
			}
			set
			{
				this._currentColumn = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x002214C0 File Offset: 0x0021F6C0
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x002214D4 File Offset: 0x0021F6D4
		public byte CurrentRow
		{
			get
			{
				return this._currentRow;
			}
			set
			{
				this._currentRow = value;
			}
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x002214E8 File Offset: 0x0021F6E8
		public SpriteFrame(byte columns, byte rows)
		{
			this.ColumnCount = columns;
			this.RowCount = rows;
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00221504 File Offset: 0x0021F704
		public SpriteFrame(byte columns, byte rows, byte currentColumn, byte currentRow)
		{
			this._currentColumn = currentColumn;
			this._currentRow = currentRow;
			this.ColumnCount = columns;
			this.RowCount = rows;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00221530 File Offset: 0x0021F730
		public SpriteFrame With(byte columnToUse, byte rowToUse)
		{
			/*
An exception occurred when decompiling this method (0600373F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.SpriteFrame Terraria.DataStructures.SpriteFrame::With(System.Byte,System.Byte)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(SpriteFrame::ColumnCount, ldloc:valuetype Terraria.DataStructures.SpriteFrame&(this)))
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

		// Token: 0x06003740 RID: 14144 RVA: 0x00221544 File Offset: 0x0021F744
		public Rectangle GetSourceRectangle(Texture2D texture)
		{
			/*
An exception occurred when decompiling this method (06003740)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.DataStructures.SpriteFrame::GetSourceRectangle(Microsoft.Xna.Framework.Graphics.Texture2D)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8(var_0_06, ldfld:uint8(SpriteFrame::ColumnCount, ldloc:valuetype Terraria.DataStructures.SpriteFrame&(this)))
	stloc:int32(var_1_0D, ldfld:int32(Texture2D::Width, ldloc:Texture2D(texture)))
	stloc:int32(var_2_14, ldfld:int32(Texture2D::ArraySize, ldloc:Texture2D(texture)))
	stloc:uint8(var_3_1B, ldfld:uint8(SpriteFrame::RowCount, ldloc:valuetype Terraria.DataStructures.SpriteFrame&(this)))
	stloc:uint8(var_4_22, ldfld:uint8(SpriteFrame::_currentColumn, ldloc:valuetype Terraria.DataStructures.SpriteFrame&(this)))
	stloc:uint8(var_5_2A, ldfld:uint8(SpriteFrame::_currentRow, ldloc:valuetype Terraria.DataStructures.SpriteFrame&(this)))
	stloc:int32(var_6_32, ldfld:int32(SpriteFrame::PaddingY, ldloc:valuetype Terraria.DataStructures.SpriteFrame&(this)))
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

		// Token: 0x0400782C RID: 30764
		public int PaddingX;

		// Token: 0x0400782D RID: 30765
		public int PaddingY;

		// Token: 0x0400782E RID: 30766
		private byte _currentColumn;

		// Token: 0x0400782F RID: 30767
		private byte _currentRow;

		// Token: 0x04007830 RID: 30768
		public readonly byte ColumnCount;

		// Token: 0x04007831 RID: 30769
		public readonly byte RowCount;
	}
}
