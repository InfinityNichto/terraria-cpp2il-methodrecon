using System;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004E6 RID: 1254
	public class SimpleStructure : GenStructure
	{
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x001F632C File Offset: 0x001F452C
		public int Width
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x001F6340 File Offset: 0x001F4540
		public int Height
		{
			get
			{
				return this._height;
			}
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x001F6354 File Offset: 0x001F4554
		public SimpleStructure(params string[] data)
		{
			this.ReadData(data);
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x001F6370 File Offset: 0x001F4570
		public SimpleStructure(string data)
		{
			string[] array;
			this.ReadData(array);
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x001F638C File Offset: 0x001F458C
		private void ReadData(string[] lines)
		{
			int num = 1;
			this._height = num;
			int height = this._height;
			int width = this._width;
			int[,] data = this._data;
			int height2 = this._height;
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x001F63C8 File Offset: 0x001F45C8
		public SimpleStructure SetActions(params GenAction[] actions)
		{
			this._actions = actions;
			return this;
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x001F63E0 File Offset: 0x001F45E0
		public SimpleStructure Mirror(bool horizontalMirror, bool verticalMirror)
		{
			return this;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x001F63F0 File Offset: 0x001F45F0
		public override bool Place(Point origin, StructureMap structures)
		{
			/*
An exception occurred when decompiling this method (0600306C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldBuilding.SimpleStructure::Place(Microsoft.Xna.Framework.Point,Terraria.WorldBuilding.StructureMap)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:int32(var_11_4D, ldfld:int32(SimpleStructure::_height, ldloc:SimpleStructure(this)))
	stloc:int32(var_12_55, ldfld:int32(SimpleStructure::_width, ldloc:SimpleStructure(this)))
	stloc:int32(var_14_60, ldfld:int32(SimpleStructure::_height, ldloc:SimpleStructure(this)))
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

		// Token: 0x04003A81 RID: 14977
		private int[,] _data;

		// Token: 0x04003A82 RID: 14978
		private int _width;

		// Token: 0x04003A83 RID: 14979
		private int _height;

		// Token: 0x04003A84 RID: 14980
		private GenAction[] _actions;

		// Token: 0x04003A85 RID: 14981
		private bool _xMirror;

		// Token: 0x04003A86 RID: 14982
		private bool _yMirror;
	}
}
