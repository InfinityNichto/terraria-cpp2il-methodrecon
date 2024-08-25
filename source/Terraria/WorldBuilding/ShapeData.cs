using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004E5 RID: 1253
	public class ShapeData
	{
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x001F61D8 File Offset: 0x001F43D8
		public int Count
		{
			get
			{
				return this._points._count;
			}
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x001F61F0 File Offset: 0x001F43F0
		public ShapeData()
		{
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x001F6204 File Offset: 0x001F4404
		public ShapeData(ShapeData original)
		{
			HashSet<Point16> points = original._points;
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x001F6220 File Offset: 0x001F4420
		public void Add(int x, int y)
		{
			HashSet<Point16> points = this._points;
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x001F6234 File Offset: 0x001F4434
		public void Remove(int x, int y)
		{
			HashSet<Point16> points = this._points;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x001F6248 File Offset: 0x001F4448
		public HashSet<Point16> GetData()
		{
			return this._points;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x001F625C File Offset: 0x001F445C
		public void Clear()
		{
			HashSet<Point16> points = this._points;
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x001F6270 File Offset: 0x001F4470
		public bool Contains(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06003061)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldBuilding.ShapeData::Contains(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [System.Core]System.Collections.Generic.HashSet`1<valuetype Terraria.DataStructures.Point16>(var_0_06, ldfld:class [System.Core]System.Collections.Generic.HashSet`1<valuetype Terraria.DataStructures.Point16>(ShapeData::_points, ldloc:ShapeData(this)))
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

		// Token: 0x06003062 RID: 12386 RVA: 0x001F6284 File Offset: 0x001F4484
		public void Add(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
		{
			HashSet<Point16> points = shapeData._points;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x001F62AC File Offset: 0x001F44AC
		public void Subtract(ShapeData shapeData, Point localOrigin, Point remoteOrigin)
		{
			HashSet<Point16> points = shapeData._points;
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x001F62D4 File Offset: 0x001F44D4
		public static Rectangle GetBounds(Point origin, params ShapeData[] shapes)
		{
			int num = Math.Min(Math.Max(0, -1073741824), -1073741824);
			int num2 = Math.Max(43147264, -1073741824);
			int num3 = Math.Min(43147264, -1073741824);
			throw new OutOfMemoryException();
		}

		// Token: 0x04003A80 RID: 14976
		private HashSet<Point16> _points;
	}
}
