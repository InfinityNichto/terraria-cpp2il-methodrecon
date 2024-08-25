using System;
using System.Collections;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x02000489 RID: 1161
	public class WorldSections
	{
		// Token: 0x06002F77 RID: 12151 RVA: 0x001F3EFC File Offset: 0x001F20FC
		public WorldSections(int numSectionsX, int numSectionsY)
		{
			this.width = numSectionsX;
			this.data = numSectionsY;
			int num = this.width;
			BitsByte[] array = this.data;
			this.mapSectionsLeft = num;
			this.prevFrame = 50504;
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x001F3F40 File Offset: 0x001F2140
		public bool AnyUnfinishedSections
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002F78)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldSections::get_AnyUnfinishedSections()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WorldSections::frameSectionsLeft, ldloc:WorldSections(this)))
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x001F3F54 File Offset: 0x001F2154
		public bool AnyNeedRefresh
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002F79)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.WorldSections::get_AnyNeedRefresh()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WorldSections::_sectionsNeedingRefresh, ldloc:WorldSections(this)))
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x001F3F68 File Offset: 0x001F2168
		public int TotalMapSections
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002F7A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldSections::get_TotalMapSections()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WorldSections::width, ldloc:WorldSections(this)))
	stloc:valuetype Terraria.BitsByte[](var_1_0D, ldfld:valuetype Terraria.BitsByte[](WorldSections::data, ldloc:WorldSections(this)))
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

		// Token: 0x06002F7B RID: 12155 RVA: 0x001F3F84 File Offset: 0x001F2184
		public void SetSectionAsRefreshed(int x, int y)
		{
			int num = this.width;
			BitsByte[] array = this.data;
			int num2 = this.width;
			BitsByte[] array2 = this.data;
			int sectionsNeedingRefresh = this._sectionsNeedingRefresh;
			this._sectionsNeedingRefresh = sectionsNeedingRefresh;
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x001F3FC8 File Offset: 0x001F21C8
		public bool SectionNeedsRefresh(int x, int y)
		{
			int num = this.width;
			int num2 = this.height;
			BitsByte[] array = this.data;
			bool flag;
			return flag;
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x001F3FF4 File Offset: 0x001F21F4
		public void SetAllFramedSectionsAsNeedingRefresh()
		{
			BitsByte[] array = this.data;
			BitsByte[] array2 = this.data;
			int sectionsNeedingRefresh = this._sectionsNeedingRefresh;
			this._sectionsNeedingRefresh = sectionsNeedingRefresh;
			BitsByte[] array3 = this.data;
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x001F4030 File Offset: 0x001F2230
		public bool SectionLoaded(int x, int y)
		{
			int num = this.width;
			int num2 = this.height;
			BitsByte[] array = this.data;
			bool flag;
			return flag;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x001F405C File Offset: 0x001F225C
		public bool SectionFramed(int x, int y)
		{
			int num = this.width;
			int num2 = this.height;
			BitsByte[] array = this.data;
			bool flag;
			return flag;
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x001F4088 File Offset: 0x001F2288
		public bool MapSectionDrawn(int x, int y)
		{
			int num = this.width;
			int num2 = this.height;
			BitsByte[] array = this.data;
			bool flag;
			return flag;
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x001F40B4 File Offset: 0x001F22B4
		public void ClearMapDraw()
		{
			BitsByte[] array = this.data;
			BitsByte[] array2 = this.data;
			int num = 50504;
			BitsByte[] array3 = this.data;
			this.mapSectionsLeft = num;
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x001F40EC File Offset: 0x001F22EC
		public void SetSectionFramed(int x, int y)
		{
			int num = this.width;
			int num2 = this.height;
			BitsByte[] array = this.data;
			int num3 = this.width;
			BitsByte[] array2 = this.data;
			int num4 = this.frameSectionsLeft;
			this.frameSectionsLeft = num4;
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x001F413C File Offset: 0x001F233C
		public void SetSectionLoaded(int x, int y)
		{
			int num = this.width;
			int num2 = this.height;
			BitsByte[] array = this.data;
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x001F4160 File Offset: 0x001F2360
		private void SetSectionLoaded(BitsByte section)
		{
			long num = 0L;
			bool flag = section[(int)num];
			int num2 = 1;
			bool flag2 = section[num2];
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x001F41A4 File Offset: 0x001F23A4
		public void SetAllSectionsLoaded()
		{
			BitsByte[] array = this.data;
			BitsByte[] array2 = this.data;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x001F41C0 File Offset: 0x001F23C0
		public void SetTilesLoaded(int startX, int startY, int endXInclusive, int endYInclusive)
		{
			if (!true)
			{
			}
			int sectionX = Netplay.GetSectionX(startX);
			int sectionY = Netplay.GetSectionY(startY);
			int sectionX2 = Netplay.GetSectionX(endXInclusive);
			int sectionY2 = Netplay.GetSectionY(endYInclusive);
			this.SetSectionLoaded(sectionX, sectionY);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x001F41F8 File Offset: 0x001F23F8
		public bool GetNextMapDraw(Vector2 playerPos, [Out] int x, [Out] int y)
		{
			int num = this.mapSectionsLeft;
			Vector2 centerPos = this.prevMap.centerPos;
			if (15744 == 0)
			{
			}
			int num2 = 32640;
			int sectionY = Netplay.GetSectionY(Netplay.GetSectionX(-1073741824));
			int sectionY2 = Netplay.GetSectionY(Netplay.GetSectionX(sectionY));
			playerPos.X = (float)num2;
			x.m_value = num2;
			long num3 = 0L;
			playerPos.X = (float)num2;
			x.m_value = num2;
			long num4 = 0L;
			playerPos.X = (float)num3;
			x.m_value = sectionY;
			if (num4 == 0L)
			{
			}
			playerPos.X = (float)num3;
			x.m_value = sectionY;
			bool flag;
			return flag;
		}

		// Token: 0x04003960 RID: 14688
		public const int BitIndex_SectionLoaded = 0;

		// Token: 0x04003961 RID: 14689
		public const int BitIndex_SectionFramed = 1;

		// Token: 0x04003962 RID: 14690
		public const int BitIndex_SectionMapDrawn = 2;

		// Token: 0x04003963 RID: 14691
		public const int BitIndex_SectionNeedsRefresh = 3;

		// Token: 0x04003964 RID: 14692
		private int width;

		// Token: 0x04003965 RID: 14693
		private int height;

		// Token: 0x04003966 RID: 14694
		private BitsByte[] data;

		// Token: 0x04003967 RID: 14695
		public int mapSectionsLeft;

		// Token: 0x04003968 RID: 14696
		public int frameSectionsLeft;

		// Token: 0x04003969 RID: 14697
		private int _sectionsNeedingRefresh;

		// Token: 0x0400396A RID: 14698
		public IEnumerator CurrentMapSection;

		// Token: 0x0400396B RID: 14699
		private WorldSections.IterationState prevFrame;

		// Token: 0x0400396C RID: 14700
		private WorldSections.IterationState prevMap;

		// Token: 0x0200048A RID: 1162
		private struct IterationState
		{
			// Token: 0x06002F88 RID: 12168 RVA: 0x001F42CC File Offset: 0x001F24CC
			public void Reset()
			{
				this.centerPos = 50504;
			}

			// Token: 0x0400396D RID: 14701
			public Vector2 centerPos;

			// Token: 0x0400396E RID: 14702
			public int X;

			// Token: 0x0400396F RID: 14703
			public int Y;

			// Token: 0x04003970 RID: 14704
			public int leg;

			// Token: 0x04003971 RID: 14705
			public int xDir;

			// Token: 0x04003972 RID: 14706
			public int yDir;
		}
	}
}
