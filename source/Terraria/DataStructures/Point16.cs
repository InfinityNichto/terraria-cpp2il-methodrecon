using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000649 RID: 1609
	public struct Point16
	{
		// Token: 0x060036DC RID: 14044 RVA: 0x00220B60 File Offset: 0x0021ED60
		public Point16(Point point)
		{
			this.X = point;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00220B74 File Offset: 0x0021ED74
		public Point16(int X, int Y)
		{
			this.X = (short)X;
			this.Y = (short)Y;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00220B90 File Offset: 0x0021ED90
		public Point16(short X, short Y)
		{
			this.X = X;
			this.Y = Y;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x000021DB File Offset: 0x000003DB
		public static Point16 Max(int firstX, int firstY, int secondX, int secondY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00220BAC File Offset: 0x0021EDAC
		public Point16 Max(int compareX, int compareY)
		{
			return ref this;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00220BBC File Offset: 0x0021EDBC
		public Point16 Max(Point16 compareTo)
		{
			return ref this;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator ==(Point16 first, Point16 second)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool operator !=(Point16 first, Point16 second)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00220BCC File Offset: 0x0021EDCC
		public override bool Equals(object obj)
		{
			short y = this.Y;
			throw new InvalidCastException();
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00220BE8 File Offset: 0x0021EDE8
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (060036E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.Point16::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int16(var_0_06, ldfld:int16(Point16::Y, ldloc:valuetype Terraria.DataStructures.Point16&(this)))
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

		// Token: 0x060036E6 RID: 14054 RVA: 0x00220BFC File Offset: 0x0021EDFC
		public override string ToString()
		{
			short y = this.Y;
			string text;
			return text;
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00220C14 File Offset: 0x0021EE14
		// Note: this type is marked as 'beforefieldinit'.
		static Point16()
		{
		}

		// Token: 0x040077EE RID: 30702
		public readonly short X;

		// Token: 0x040077EF RID: 30703
		public readonly short Y;

		// Token: 0x040077F0 RID: 30704
		public static Point16 Zero;

		// Token: 0x040077F1 RID: 30705
		public static Point16 NegativeOne;
	}
}
