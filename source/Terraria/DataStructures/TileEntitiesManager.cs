using System;
using System.Collections.Generic;

namespace Terraria.DataStructures
{
	// Token: 0x0200067D RID: 1661
	public class TileEntitiesManager
	{
		// Token: 0x0600374B RID: 14155 RVA: 0x00221668 File Offset: 0x0021F868
		private int AssignNewID()
		{
			return this._nextEntityID;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0022167C File Offset: 0x0021F87C
		private bool InvalidEntityID(int id)
		{
			int nextEntityID = this._nextEntityID;
			return true;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00221694 File Offset: 0x0021F894
		public void RegisterAll()
		{
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x002216A4 File Offset: 0x0021F8A4
		public void Register(TileEntity entity)
		{
			int num = 1;
			int nextEntityID = this._nextEntityID;
			Dictionary<int, TileEntity> types = this._types;
			this._nextEntityID = num;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x002216C8 File Offset: 0x0021F8C8
		public bool CheckValidTile(int id, int x, int y)
		{
			/*
An exception occurred when decompiling this method (0600374F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.DataStructures.TileEntitiesManager::CheckValidTile(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TileEntitiesManager::_nextEntityID, ldloc:TileEntitiesManager(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.DataStructures.TileEntity>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.DataStructures.TileEntity>(TileEntitiesManager::_types, ldloc:TileEntitiesManager(this)))
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

		// Token: 0x06003750 RID: 14160 RVA: 0x002216E4 File Offset: 0x0021F8E4
		public void NetPlaceEntity(int id, int x, int y)
		{
			int nextEntityID = this._nextEntityID;
			Dictionary<int, TileEntity> types = this._types;
			Dictionary<int, TileEntity> types2 = this._types;
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00221708 File Offset: 0x0021F908
		public TileEntity GenerateInstance(int id)
		{
			/*
An exception occurred when decompiling this method (06003751)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.TileEntity Terraria.DataStructures.TileEntitiesManager::GenerateInstance(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(TileEntitiesManager::_nextEntityID, ldloc:TileEntitiesManager(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.DataStructures.TileEntity>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<int32, class Terraria.DataStructures.TileEntity>(TileEntitiesManager::_types, ldloc:TileEntitiesManager(this)))
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

		// Token: 0x06003752 RID: 14162 RVA: 0x00221724 File Offset: 0x0021F924
		public TileEntitiesManager()
		{
		}

		// Token: 0x04007874 RID: 30836
		private int _nextEntityID;

		// Token: 0x04007875 RID: 30837
		private Dictionary<int, TileEntity> _types;
	}
}
