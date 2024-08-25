using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.Modules;

namespace Terraria.ObjectData
{
	// Token: 0x02000545 RID: 1349
	public class TileObjectData
	{
		// Token: 0x0600326C RID: 12908 RVA: 0x001F9BE8 File Offset: 0x001F7DE8
		public TileObjectData([Optional] TileObjectData copyFrom)
		{
			if (copyFrom != null)
			{
				this.CopyFrom(copyFrom);
				return;
			}
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x001F9C08 File Offset: 0x001F7E08
		public void CopyFrom(TileObjectData copy)
		{
			if (copy != null)
			{
				bool usesCustomCanPlace = copy._usesCustomCanPlace;
				this._usesCustomCanPlace = usesCustomCanPlace;
				TileObjectAlternatesModule alternates = copy._alternates;
				this._alternates = alternates;
				TileObjectBaseModule tileObjectBase = copy._tileObjectBase;
				this._tileObjectBase = tileObjectBase;
				AnchorTypesModule anchorTiles = copy._anchorTiles;
				this._anchorTiles = anchorTiles;
				LiquidPlacementModule liquidPlacement = copy._liquidPlacement;
				this._liquidPlacement = liquidPlacement;
				TileObjectCoordinatesModule tileObjectCoords = copy._tileObjectCoords;
				this._tileObjectCoords = tileObjectCoords;
			}
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x001F9C70 File Offset: 0x001F7E70
		public void FullCopyFrom(ushort tileType)
		{
			TileObjectData tileObjectData;
			this.FullCopyFrom(tileObjectData);
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x001F9C84 File Offset: 0x001F7E84
		public void FullCopyFrom(TileObjectData copy)
		{
			if (copy != null)
			{
				bool usesCustomCanPlace = copy._usesCustomCanPlace;
				this._usesCustomCanPlace = usesCustomCanPlace;
				TileObjectAlternatesModule alternates = copy._alternates;
				this._alternates = alternates;
				TileObjectBaseModule tileObjectBase = copy._tileObjectBase;
				this._tileObjectBase = tileObjectBase;
				AnchorTypesModule anchorTiles = copy._anchorTiles;
				this._anchorTiles = anchorTiles;
				LiquidPlacementModule liquidPlacement = copy._liquidPlacement;
				this._liquidPlacement = liquidPlacement;
				TileObjectCoordinatesModule tileObjectCoords = copy._tileObjectCoords;
				this._tileObjectCoords = tileObjectCoords;
				TileObjectSubTilesModule subTiles = copy._subTiles;
				this._hasOwnSubTiles = true;
			}
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x001F9CFC File Offset: 0x001F7EFC
		private void SetupBaseObject()
		{
			this._hasOwnAlternates = true;
			this._hasOwnAnchor = true;
			long num = 0L;
			this.AnchorWall = num != 0L;
			this._hasOwnAnchorTiles = true;
			long num2 = 0L;
			this._hasOwnLiquidDeath = true;
			this.WaterDeath = num2 != 0L;
			long num3 = 0L;
			this.LavaDeath = num3 != 0L;
			this._hasOwnLiquidPlacement = true;
			this.LavaPlacement = LiquidPlacement.NotAllowed;
			this._hasOwnPlacementHooks = true;
			this._hasOwnTileObjectBase = true;
			this.Width = 1;
			this.Height = 1;
			long num4 = 0L;
			this.RandomStyleRange = (int)num4;
			long num5 = 0L;
			this.FlattenAnchors = num5 != 0L;
			this._hasOwnTileObjectCoords = true;
			long num6 = 0L;
			this.CoordinateWidth = (int)num6;
			long num7 = 0L;
			this.CoordinatePadding = (int)num7;
			long num8 = 0L;
			this._hasOwnTileObjectDraw = true;
			this.DrawYOffset = (int)num8;
			long num9 = 0L;
			this.DrawFlipHorizontal = num9 != 0L;
			long num10 = 0L;
			this.DrawFlipVertical = num10 != 0L;
			long num11 = 0L;
			this.DrawStepDown = (int)num11;
			long num12 = 0L;
			this._hasOwnTileObjectStyle = true;
			this.Style = (int)num12;
			long num13 = 0L;
			this.StyleHorizontal = num13 != 0L;
			long num14 = 0L;
			this.StyleWrapLimit = (int)num14;
			this.StyleMultiplier = 1;
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x001F9E00 File Offset: 0x001F8000
		private void Calculate()
		{
			TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
			if (tileObjectCoords.calculated)
			{
				return;
			}
			int num = 1;
			tileObjectCoords.calculated = num != 0;
			int width = tileObjectCoords.width;
			int padding = tileObjectCoords.padding;
			TileObjectBaseModule tileObjectBase = this._tileObjectBase;
			if (tileObjectBase == null)
			{
				return;
			}
			TileObjectCoordinatesModule tileObjectCoords2 = this._tileObjectCoords;
			int width2 = tileObjectBase.width;
			tileObjectCoords.styleWidth = width2;
			int[] heights = tileObjectCoords2.heights;
			int padding2 = tileObjectCoords2.padding;
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x001F9EA4 File Offset: 0x001F80A4
		private void WriteCheck()
		{
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x001F9EB4 File Offset: 0x001F80B4
		private void LockWrites()
		{
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06003274 RID: 12916 RVA: 0x001F9EC4 File Offset: 0x001F80C4
		// (set) Token: 0x06003275 RID: 12917 RVA: 0x001F9ED8 File Offset: 0x001F80D8
		private bool LinkedAlternates
		{
			get
			{
				return this._linkedAlternates;
			}
			set
			{
				if (!this._hasOwnAlternates)
				{
					this._hasOwnAlternates = true;
					TileObjectAlternatesModule alternates = this._alternates;
				}
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06003276 RID: 12918 RVA: 0x001F9EFC File Offset: 0x001F80FC
		// (set) Token: 0x06003277 RID: 12919 RVA: 0x001F9F10 File Offset: 0x001F8110
		public bool UsesCustomCanPlace
		{
			get
			{
				return this._usesCustomCanPlace;
			}
			set
			{
				this.WriteCheck();
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x001F9F24 File Offset: 0x001F8124
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x001F9F38 File Offset: 0x001F8138
		private List<TileObjectData> Alternates
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003278)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.ObjectData.TileObjectData> Terraria.ObjectData.TileObjectData::get_Alternates()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectAlternatesModule[exp:bool](TileObjectData::_alternates, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (this._hasOwnAlternates)
				{
					TileObjectAlternatesModule alternates = this._alternates;
					return;
				}
				this._hasOwnAlternates = true;
				TileObjectAlternatesModule alternates2 = this._alternates;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x001F9F64 File Offset: 0x001F8164
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x001F9F94 File Offset: 0x001F8194
		public AnchorData AnchorTop
		{
			get
			{
				AnchorDataModule anchor = this._anchor;
				if (anchor != null)
				{
					AnchorData top = anchor.top;
					int checkStart = anchor.top.checkStart;
					return top;
				}
				AnchorData anchorData;
				return anchorData;
			}
			set
			{
				bool hasOwnAnchor = this._hasOwnAnchor;
				AnchorDataModule anchor = this._anchor;
				if (!hasOwnAnchor)
				{
					AnchorData top = anchor.top;
					int checkStart = anchor.top.checkStart;
					int num = 1;
					this._hasOwnAnchor = num != 0;
					AnchorDataModule anchor2 = this._anchor;
					if (anchor2 != null)
					{
						int checkStart2 = anchor2.top.checkStart;
						AnchorData top2 = anchor2.top;
						int checkStart3 = anchor2.bottom.checkStart;
						int checkStart4 = anchor2.left.checkStart;
						AnchorData left = anchor2.left;
						int checkStart5 = anchor2.right.checkStart;
						bool wall = anchor2.wall;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x001FA064 File Offset: 0x001F8264
		// (set) Token: 0x0600327D RID: 12925 RVA: 0x001FA088 File Offset: 0x001F8288
		public AnchorData AnchorBottom
		{
			get
			{
				AnchorDataModule anchor = this._anchor;
				if (anchor != null)
				{
					int checkStart = anchor.bottom.checkStart;
				}
				AnchorData anchorData;
				return anchorData;
			}
			set
			{
				bool hasOwnAnchor = this._hasOwnAnchor;
				AnchorDataModule anchor = this._anchor;
				if (!hasOwnAnchor)
				{
					int checkStart = anchor.bottom.checkStart;
					int num = 1;
					this._hasOwnAnchor = num != 0;
					AnchorDataModule anchor2 = this._anchor;
					if (anchor2 != null)
					{
						int checkStart2 = anchor2.top.checkStart;
						AnchorData top = anchor2.top;
						int checkStart3 = anchor2.bottom.checkStart;
						int checkStart4 = anchor2.left.checkStart;
						AnchorData left = anchor2.left;
						int checkStart5 = anchor2.right.checkStart;
						bool wall = anchor2.wall;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x001FA14C File Offset: 0x001F834C
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x001FA17C File Offset: 0x001F837C
		public AnchorData AnchorLeft
		{
			get
			{
				AnchorDataModule anchor = this._anchor;
				if (anchor != null)
				{
					AnchorData left = anchor.left;
					int checkStart = anchor.left.checkStart;
					return left;
				}
				AnchorData anchorData;
				return anchorData;
			}
			set
			{
				bool hasOwnAnchor = this._hasOwnAnchor;
				AnchorDataModule anchor = this._anchor;
				if (!hasOwnAnchor)
				{
					AnchorData left = anchor.left;
					int checkStart = anchor.left.checkStart;
					int num = 1;
					this._hasOwnAnchor = num != 0;
					AnchorDataModule anchor2 = this._anchor;
					if (anchor2 != null)
					{
						int checkStart2 = anchor2.top.checkStart;
						AnchorData top = anchor2.top;
						int checkStart3 = anchor2.bottom.checkStart;
						int checkStart4 = anchor2.left.checkStart;
						AnchorData left2 = anchor2.left;
						int checkStart5 = anchor2.right.checkStart;
						bool wall = anchor2.wall;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x001FA24C File Offset: 0x001F844C
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x001FA270 File Offset: 0x001F8470
		public AnchorData AnchorRight
		{
			get
			{
				AnchorDataModule anchor = this._anchor;
				if (anchor != null)
				{
					int checkStart = anchor.right.checkStart;
				}
				AnchorData anchorData;
				return anchorData;
			}
			set
			{
				bool hasOwnAnchor = this._hasOwnAnchor;
				AnchorDataModule anchor = this._anchor;
				if (!hasOwnAnchor)
				{
					int checkStart = anchor.right.checkStart;
					int num = 1;
					this._hasOwnAnchor = num != 0;
					AnchorDataModule anchor2 = this._anchor;
					if (anchor2 != null)
					{
						int checkStart2 = anchor2.top.checkStart;
						AnchorData top = anchor2.top;
						int checkStart3 = anchor2.bottom.checkStart;
						int checkStart4 = anchor2.left.checkStart;
						AnchorData left = anchor2.left;
						int checkStart5 = anchor2.right.checkStart;
						bool wall = anchor2.wall;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x001FA334 File Offset: 0x001F8534
		// (set) Token: 0x06003283 RID: 12931 RVA: 0x001FA348 File Offset: 0x001F8548
		public bool AnchorWall
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003282)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::get_AnchorWall()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:AnchorDataModule[exp:bool](TileObjectData::_anchor, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnAnchor = this._hasOwnAnchor;
				AnchorDataModule anchor = this._anchor;
				if (!hasOwnAnchor)
				{
					bool wall = anchor.wall;
					int num = 1;
					this._hasOwnAnchor = num != 0;
					if (anchor != null)
					{
						int checkStart = anchor.top.checkStart;
						AnchorData top = anchor.top;
						int checkStart2 = anchor.bottom.checkStart;
						int checkStart3 = anchor.left.checkStart;
						AnchorData left = anchor.left;
						int checkStart4 = anchor.right.checkStart;
						bool wall2 = anchor.wall;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x001FA3F8 File Offset: 0x001F85F8
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x001FA40C File Offset: 0x001F860C
		public int[] AnchorValidTiles
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003284)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.ObjectData.TileObjectData::get_AnchorValidTiles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:AnchorTypesModule[exp:bool](TileObjectData::_anchorTiles, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnAnchorTiles = this._hasOwnAnchorTiles;
				AnchorTypesModule anchorTiles = this._anchorTiles;
				if (!hasOwnAnchorTiles)
				{
					int[] tileValid = anchorTiles.tileValid;
					bool flag = value.deepCompare(tileValid);
					int num = 1;
					this._hasOwnAnchorTiles = num != 0;
					AnchorTypesModule anchorTiles2 = this._anchorTiles;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					if (value == null)
					{
						return;
					}
					object obj;
					if (obj != null && obj == null)
					{
						return;
					}
					List<TileObjectData> data = this._alternates.data;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x001FA49C File Offset: 0x001F869C
		// (set) Token: 0x06003287 RID: 12935 RVA: 0x001FA4B0 File Offset: 0x001F86B0
		public int[] AnchorInvalidTiles
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003286)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.ObjectData.TileObjectData::get_AnchorInvalidTiles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:AnchorTypesModule[exp:bool](TileObjectData::_anchorTiles, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnAnchorTiles = this._hasOwnAnchorTiles;
				AnchorTypesModule anchorTiles = this._anchorTiles;
				if (!hasOwnAnchorTiles)
				{
					int[] tileInvalid = anchorTiles.tileInvalid;
					bool flag = value.deepCompare(tileInvalid);
					int num = 1;
					this._hasOwnAnchorTiles = num != 0;
					AnchorTypesModule anchorTiles2 = this._anchorTiles;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					if (value == null)
					{
						return;
					}
					object obj;
					if (obj != null && obj == null)
					{
						return;
					}
					List<TileObjectData> data = this._alternates.data;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x001FA540 File Offset: 0x001F8740
		// (set) Token: 0x06003289 RID: 12937 RVA: 0x001FA554 File Offset: 0x001F8754
		public int[] AnchorAlternateTiles
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003288)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.ObjectData.TileObjectData::get_AnchorAlternateTiles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:AnchorTypesModule[exp:bool](TileObjectData::_anchorTiles, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnAnchorTiles = this._hasOwnAnchorTiles;
				AnchorTypesModule anchorTiles = this._anchorTiles;
				if (!hasOwnAnchorTiles)
				{
					int[] tileInvalid = anchorTiles.tileInvalid;
					bool flag = value.deepCompare(tileInvalid);
					int num = 1;
					this._hasOwnAnchorTiles = num != 0;
					AnchorTypesModule anchorTiles2 = this._anchorTiles;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					if (value == null)
					{
						return;
					}
					object obj;
					if (obj != null && obj == null)
					{
						return;
					}
					List<TileObjectData> data = this._alternates.data;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x001FA5E4 File Offset: 0x001F87E4
		// (set) Token: 0x0600328B RID: 12939 RVA: 0x001FA5F8 File Offset: 0x001F87F8
		public int[] AnchorValidWalls
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600328A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.ObjectData.TileObjectData::get_AnchorValidWalls()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:AnchorTypesModule[exp:bool](TileObjectData::_anchorTiles, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (this._hasOwnAnchorTiles)
				{
					AnchorTypesModule anchorTiles = this._anchorTiles;
					return;
				}
				int num = 1;
				this._hasOwnAnchorTiles = num != 0;
				AnchorTypesModule anchorTiles2 = this._anchorTiles;
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					if (value == null)
					{
						return;
					}
					object obj;
					if (obj != null && obj == null)
					{
						return;
					}
					List<TileObjectData> data = this._alternates.data;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x0600328C RID: 12940 RVA: 0x001FA674 File Offset: 0x001F8874
		// (set) Token: 0x0600328D RID: 12941 RVA: 0x001FA688 File Offset: 0x001F8888
		public bool WaterDeath
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600328C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::get_WaterDeath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LiquidDeathModule[exp:bool](TileObjectData::_liquidDeath, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnLiquidDeath = this._hasOwnLiquidDeath;
				LiquidDeathModule liquidDeath = this._liquidDeath;
				if (!hasOwnLiquidDeath)
				{
					bool water = liquidDeath.water;
					int num = 1;
					this._hasOwnLiquidDeath = num != 0;
					if (liquidDeath != null)
					{
						bool water2 = liquidDeath.water;
						bool lava = liquidDeath.lava;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x001FA6FC File Offset: 0x001F88FC
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x001FA710 File Offset: 0x001F8910
		public bool LavaDeath
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600328E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::get_LavaDeath()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LiquidDeathModule[exp:bool](TileObjectData::_liquidDeath, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnLiquidDeath = this._hasOwnLiquidDeath;
				LiquidDeathModule liquidDeath = this._liquidDeath;
				if (!hasOwnLiquidDeath)
				{
					bool lava = liquidDeath.lava;
					int num = 1;
					this._hasOwnLiquidDeath = num != 0;
					if (liquidDeath != null)
					{
						bool water = liquidDeath.water;
						bool lava2 = liquidDeath.lava;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x001FA784 File Offset: 0x001F8984
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x001FA798 File Offset: 0x001F8998
		public LiquidPlacement WaterPlacement
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003290)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Enums.LiquidPlacement Terraria.ObjectData.TileObjectData::get_WaterPlacement()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LiquidPlacementModule[exp:bool](TileObjectData::_liquidPlacement, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnLiquidPlacement = this._hasOwnLiquidPlacement;
				LiquidPlacementModule liquidPlacement = this._liquidPlacement;
				if (!hasOwnLiquidPlacement)
				{
					LiquidPlacement water = liquidPlacement.water;
					int num = 1;
					this._hasOwnLiquidPlacement = num != 0;
					if (liquidPlacement != null)
					{
						int value__ = liquidPlacement.water.value__;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x001FA808 File Offset: 0x001F8A08
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x001FA81C File Offset: 0x001F8A1C
		public LiquidPlacement LavaPlacement
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003292)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Enums.LiquidPlacement Terraria.ObjectData.TileObjectData::get_LavaPlacement()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:LiquidPlacementModule[exp:bool](TileObjectData::_liquidPlacement, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnLiquidPlacement = this._hasOwnLiquidPlacement;
				LiquidPlacementModule liquidPlacement = this._liquidPlacement;
				if (!hasOwnLiquidPlacement)
				{
					LiquidPlacement lava = liquidPlacement.lava;
					int num = 1;
					this._hasOwnLiquidPlacement = num != 0;
					if (liquidPlacement != null)
					{
						int value__ = liquidPlacement.water.value__;
						return;
					}
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x001FA88C File Offset: 0x001F8A8C
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x001FA8C8 File Offset: 0x001F8AC8
		public PlacementHook HookCheckIfCanPlace
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003294)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.PlacementHook Terraria.ObjectData.TileObjectData::get_HookCheckIfCanPlace()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stfld:class [mscorlib]System.Func`7<int32, int32, int32, int32, int32, int32, int32>(PlacementHook::hook, ldloc:PlacementHook[exp:valuetype Terraria.DataStructures.PlacementHook&](var_0), ldloc:class [mscorlib]System.Func`7<int32, int32, int32, int32, int32, int32, int32>(var_3))
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
			set
			{
				if (this._hasOwnPlacementHooks)
				{
					TilePlacementHooksModule placementHooks = this._placementHooks;
					return;
				}
				this._hasOwnPlacementHooks = true;
				TilePlacementHooksModule placementHooks2 = this._placementHooks;
				if (placementHooks2 != null)
				{
					bool processedCoordinates = placementHooks2.check.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook = placementHooks2.check.hook;
					bool processedCoordinates2 = placementHooks2.postPlaceEveryone.processedCoordinates;
					bool processedCoordinates3 = placementHooks2.postPlaceMyPlayer.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook2 = placementHooks2.postPlaceMyPlayer.hook;
					bool processedCoordinates4 = placementHooks2.placeOverride.processedCoordinates;
					return;
				}
				bool processedCoordinates5 = value.processedCoordinates;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x001FA94C File Offset: 0x001F8B4C
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x001FA978 File Offset: 0x001F8B78
		public PlacementHook HookPostPlaceEveryone
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003296)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.PlacementHook Terraria.ObjectData.TileObjectData::get_HookPostPlaceEveryone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_2_15, ldfld:bool(PlacementHook::processedCoordinates, ldfld:PlacementHook[exp:valuetype Terraria.DataStructures.PlacementHook&](TilePlacementHooksModule::postPlaceEveryone, ldloc:TilePlacementHooksModule(var_1_06))))
	stfld:bool(PlacementHook::processedCoordinates, ldloc:PlacementHook[exp:valuetype Terraria.DataStructures.PlacementHook&](var_0), ldloc:bool(var_2_15))
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
			set
			{
				if (this._hasOwnPlacementHooks)
				{
					TilePlacementHooksModule placementHooks = this._placementHooks;
					return;
				}
				this._hasOwnPlacementHooks = true;
				TilePlacementHooksModule placementHooks2 = this._placementHooks;
				if (placementHooks2 != null)
				{
					bool processedCoordinates = placementHooks2.check.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook = placementHooks2.check.hook;
					bool processedCoordinates2 = placementHooks2.postPlaceEveryone.processedCoordinates;
					bool processedCoordinates3 = placementHooks2.postPlaceMyPlayer.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook2 = placementHooks2.postPlaceMyPlayer.hook;
					bool processedCoordinates4 = placementHooks2.placeOverride.processedCoordinates;
					return;
				}
				bool processedCoordinates5 = value.processedCoordinates;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x001FA9FC File Offset: 0x001F8BFC
		// (set) Token: 0x06003299 RID: 12953 RVA: 0x001FAA38 File Offset: 0x001F8C38
		public PlacementHook HookPostPlaceMyPlayer
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003298)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.PlacementHook Terraria.ObjectData.TileObjectData::get_HookPostPlaceMyPlayer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0029:
	stfld:class [mscorlib]System.Func`7<int32, int32, int32, int32, int32, int32, int32>(PlacementHook::hook, ldloc:PlacementHook[exp:valuetype Terraria.DataStructures.PlacementHook&](var_0), ldloc:class [mscorlib]System.Func`7<int32, int32, int32, int32, int32, int32, int32>(var_3))
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
			set
			{
				if (this._hasOwnPlacementHooks)
				{
					TilePlacementHooksModule placementHooks = this._placementHooks;
					return;
				}
				this._hasOwnPlacementHooks = true;
				TilePlacementHooksModule placementHooks2 = this._placementHooks;
				if (placementHooks2 != null)
				{
					bool processedCoordinates = placementHooks2.check.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook = placementHooks2.check.hook;
					bool processedCoordinates2 = placementHooks2.postPlaceEveryone.processedCoordinates;
					bool processedCoordinates3 = placementHooks2.postPlaceMyPlayer.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook2 = placementHooks2.postPlaceMyPlayer.hook;
					bool processedCoordinates4 = placementHooks2.placeOverride.processedCoordinates;
					return;
				}
				bool processedCoordinates5 = value.processedCoordinates;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600329A RID: 12954 RVA: 0x001FAABC File Offset: 0x001F8CBC
		// (set) Token: 0x0600329B RID: 12955 RVA: 0x001FAAE8 File Offset: 0x001F8CE8
		public PlacementHook HookPlaceOverride
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600329A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.DataStructures.PlacementHook Terraria.ObjectData.TileObjectData::get_HookPlaceOverride()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_2_15, ldfld:bool(PlacementHook::processedCoordinates, ldfld:PlacementHook[exp:valuetype Terraria.DataStructures.PlacementHook&](TilePlacementHooksModule::placeOverride, ldloc:TilePlacementHooksModule(var_1_06))))
	stfld:bool(PlacementHook::processedCoordinates, ldloc:PlacementHook[exp:valuetype Terraria.DataStructures.PlacementHook&](var_0), ldloc:bool(var_2_15))
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
			set
			{
				if (this._hasOwnPlacementHooks)
				{
					TilePlacementHooksModule placementHooks = this._placementHooks;
					return;
				}
				this._hasOwnPlacementHooks = true;
				TilePlacementHooksModule placementHooks2 = this._placementHooks;
				if (placementHooks2 != null)
				{
					bool processedCoordinates = placementHooks2.check.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook = placementHooks2.check.hook;
					bool processedCoordinates2 = placementHooks2.postPlaceEveryone.processedCoordinates;
					bool processedCoordinates3 = placementHooks2.postPlaceMyPlayer.processedCoordinates;
					Func<int, int, int, int, int, int, int> hook2 = placementHooks2.postPlaceMyPlayer.hook;
					bool processedCoordinates4 = placementHooks2.placeOverride.processedCoordinates;
					return;
				}
				bool processedCoordinates5 = value.processedCoordinates;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600329C RID: 12956 RVA: 0x001FAB6C File Offset: 0x001F8D6C
		// (set) Token: 0x0600329D RID: 12957 RVA: 0x001FAB80 File Offset: 0x001F8D80
		private List<TileObjectData> SubTiles
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600329C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Terraria.ObjectData.TileObjectData> Terraria.ObjectData.TileObjectData::get_SubTiles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectSubTilesModule[exp:bool](TileObjectData::_subTiles, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (this._hasOwnSubTiles)
				{
					TileObjectSubTilesModule subTiles = this._subTiles;
					return;
				}
				this._hasOwnSubTiles = true;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x001FABA4 File Offset: 0x001F8DA4
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x001FABC4 File Offset: 0x001F8DC4
		public int DrawYOffset
		{
			get
			{
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				while (tileObjectDraw == null)
				{
				}
				return tileObjectDraw.yOffset;
			}
			set
			{
				bool hasOwnTileObjectDraw = this._hasOwnTileObjectDraw;
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				if (!hasOwnTileObjectDraw)
				{
					int yOffset = tileObjectDraw.yOffset;
					int num = 1;
					this._hasOwnTileObjectDraw = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x001FAC24 File Offset: 0x001F8E24
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x001FAC44 File Offset: 0x001F8E44
		public int DrawXOffset
		{
			get
			{
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				while (tileObjectDraw == null)
				{
				}
				return tileObjectDraw.xOffset;
			}
			set
			{
				bool hasOwnTileObjectDraw = this._hasOwnTileObjectDraw;
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				if (!hasOwnTileObjectDraw)
				{
					int xOffset = tileObjectDraw.xOffset;
					int num = 1;
					this._hasOwnTileObjectDraw = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x001FACA4 File Offset: 0x001F8EA4
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x001FACC4 File Offset: 0x001F8EC4
		public bool DrawFlipHorizontal
		{
			get
			{
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				while (tileObjectDraw == null)
				{
				}
				return tileObjectDraw.flipHorizontal;
			}
			set
			{
				bool hasOwnTileObjectDraw = this._hasOwnTileObjectDraw;
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				if (!hasOwnTileObjectDraw)
				{
					bool flipHorizontal = tileObjectDraw.flipHorizontal;
					int num = 1;
					this._hasOwnTileObjectDraw = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x001FAD24 File Offset: 0x001F8F24
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x001FAD44 File Offset: 0x001F8F44
		public bool DrawFlipVertical
		{
			get
			{
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				while (tileObjectDraw == null)
				{
				}
				return tileObjectDraw.flipVertical;
			}
			set
			{
				bool hasOwnTileObjectDraw = this._hasOwnTileObjectDraw;
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				if (!hasOwnTileObjectDraw)
				{
					bool flipVertical = tileObjectDraw.flipVertical;
					int num = 1;
					this._hasOwnTileObjectDraw = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x001FADA4 File Offset: 0x001F8FA4
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x001FADC4 File Offset: 0x001F8FC4
		public int DrawStepDown
		{
			get
			{
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				while (tileObjectDraw == null)
				{
				}
				return tileObjectDraw.stepDown;
			}
			set
			{
				bool hasOwnTileObjectDraw = this._hasOwnTileObjectDraw;
				TileObjectDrawModule tileObjectDraw = this._tileObjectDraw;
				if (!hasOwnTileObjectDraw)
				{
					int stepDown = tileObjectDraw.stepDown;
					int num = 1;
					this._hasOwnTileObjectDraw = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x001FAE24 File Offset: 0x001F9024
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x001FAE44 File Offset: 0x001F9044
		public bool StyleHorizontal
		{
			get
			{
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				while (tileObjectStyle == null)
				{
				}
				return tileObjectStyle.horizontal;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					bool horizontal = tileObjectStyle.horizontal;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x001FAEA4 File Offset: 0x001F90A4
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x001FAEB8 File Offset: 0x001F90B8
		public int Style
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_Style()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					int style = tileObjectStyle.style;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x001FAF18 File Offset: 0x001F9118
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x001FAF2C File Offset: 0x001F912C
		public int StyleWrapLimit
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032AC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_StyleWrapLimit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					int styleWrapLimit = tileObjectStyle.styleWrapLimit;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x001FAF8C File Offset: 0x001F918C
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x001FAFA0 File Offset: 0x001F91A0
		public int? StyleWrapLimitVisualOverride
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032AE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> Terraria.ObjectData.TileObjectData::get_StyleWrapLimitVisualOverride()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					int? styleWrapLimitVisualOverride = tileObjectStyle.styleWrapLimitVisualOverride;
					int? styleLineSkipVisualoverride = tileObjectStyle.styleLineSkipVisualoverride;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x001FB008 File Offset: 0x001F9208
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x001FB01C File Offset: 0x001F921C
		public int? styleLineSkipVisualOverride
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032B0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> Terraria.ObjectData.TileObjectData::get_styleLineSkipVisualOverride()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					int? styleLineSkipVisualoverride = tileObjectStyle.styleLineSkipVisualoverride;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x001FB07C File Offset: 0x001F927C
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x001FB090 File Offset: 0x001F9290
		public int StyleLineSkip
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_StyleLineSkip()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					int styleLineSkip = tileObjectStyle.styleLineSkip;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x001FB0F0 File Offset: 0x001F92F0
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x001FB104 File Offset: 0x001F9304
		public int StyleMultiplier
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_StyleMultiplier()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectStyle = this._hasOwnTileObjectStyle;
				TileObjectStyleModule tileObjectStyle = this._tileObjectStyle;
				if (!hasOwnTileObjectStyle)
				{
					int styleMultiplier = tileObjectStyle.styleMultiplier;
					int num = 1;
					this._hasOwnTileObjectStyle = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					return;
				}
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x001FB164 File Offset: 0x001F9364
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x001FB178 File Offset: 0x001F9378
		public int Width
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_Width()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectBaseModule[exp:bool](TileObjectData::_tileObjectBase, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (this._hasOwnTileObjectBase)
				{
					this._tileObjectBase.width = value;
					if (this._linkedAlternates)
					{
						int size = this._alternates.data._size;
						int size2 = this._alternates.data._size;
						return;
					}
				}
				else
				{
					int width = this._tileObjectBase.width;
				}
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x001FB1F8 File Offset: 0x001F93F8
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x001FB20C File Offset: 0x001F940C
		public int Height
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_Height()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectBaseModule[exp:bool](TileObjectData::_tileObjectBase, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				if (this._hasOwnTileObjectBase)
				{
					this._tileObjectBase.height = value;
					if (this._linkedAlternates)
					{
						int size = this._alternates.data._size;
						int size2 = this._alternates.data._size;
						return;
					}
				}
				else
				{
					int height = this._tileObjectBase.height;
				}
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x001FB28C File Offset: 0x001F948C
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x001FB2AC File Offset: 0x001F94AC
		public Point16 Origin
		{
			get
			{
				TileObjectBaseModule tileObjectBase = this._tileObjectBase;
				if (tileObjectBase != null)
				{
					return tileObjectBase.origin;
				}
				Point16 point;
				return point;
			}
			set
			{
				bool hasOwnTileObjectBase = this._hasOwnTileObjectBase;
				TileObjectBaseModule tileObjectBase = this._tileObjectBase;
				if (!hasOwnTileObjectBase)
				{
					bool flag = tileObjectBase.origin == value;
					int num = 1;
					this._hasOwnTileObjectBase = num != 0;
					TileObjectBaseModule tileObjectBase2 = this._tileObjectBase;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x001FB318 File Offset: 0x001F9518
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x001FB32C File Offset: 0x001F952C
		public TileObjectDirection Direction
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032BC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Enums.TileObjectDirection Terraria.ObjectData.TileObjectData::get_Direction()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectBaseModule[exp:bool](TileObjectData::_tileObjectBase, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectBase = this._hasOwnTileObjectBase;
				TileObjectBaseModule tileObjectBase = this._tileObjectBase;
				if (!hasOwnTileObjectBase)
				{
					TileObjectDirection direction = tileObjectBase.direction;
					int num = 1;
					this._hasOwnTileObjectBase = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x001FB38C File Offset: 0x001F958C
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x001FB3A0 File Offset: 0x001F95A0
		public int RandomStyleRange
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_RandomStyleRange()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectBaseModule[exp:bool](TileObjectData::_tileObjectBase, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectBase = this._hasOwnTileObjectBase;
				TileObjectBaseModule tileObjectBase = this._tileObjectBase;
				if (!hasOwnTileObjectBase)
				{
					int randomRange = tileObjectBase.randomRange;
					int num = 1;
					this._hasOwnTileObjectBase = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x001FB400 File Offset: 0x001F9600
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x001FB414 File Offset: 0x001F9614
		public int[] SpecificRandomStyles
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.ObjectData.TileObjectData::get_SpecificRandomStyles()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectBaseModule[exp:bool](TileObjectData::_tileObjectBase, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectBase = this._hasOwnTileObjectBase;
				TileObjectBaseModule tileObjectBase = this._tileObjectBase;
				if (!hasOwnTileObjectBase)
				{
					int[] specificRandomStyles = tileObjectBase.specificRandomStyles;
					int num = 1;
					this._hasOwnTileObjectBase = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x001FB474 File Offset: 0x001F9674
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x001FB488 File Offset: 0x001F9688
		public bool FlattenAnchors
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::get_FlattenAnchors()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectBaseModule[exp:bool](TileObjectData::_tileObjectBase, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectBase = this._hasOwnTileObjectBase;
				TileObjectBaseModule tileObjectBase = this._tileObjectBase;
				if (!hasOwnTileObjectBase)
				{
					bool flattenAnchors = tileObjectBase.flattenAnchors;
					int num = 1;
					this._hasOwnTileObjectBase = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x001FB4E8 File Offset: 0x001F96E8
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x001FB4FC File Offset: 0x001F96FC
		public int[] CoordinateHeights
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.ObjectData.TileObjectData::get_CoordinateHeights()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectCoordinatesModule[exp:bool](TileObjectData::_tileObjectCoords, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectCoords = this._hasOwnTileObjectCoords;
				TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
				if (hasOwnTileObjectCoords)
				{
					tileObjectCoords.heights = value;
					return;
				}
				int[] heights = tileObjectCoords.heights;
				bool flag = value.deepCompare(heights);
				int num = 1;
				this._hasOwnTileObjectCoords = num != 0;
				TileObjectCoordinatesModule tileObjectCoords2 = this._tileObjectCoords;
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					if (value == null)
					{
						return;
					}
					object obj;
					if (obj != null && obj == null)
					{
						return;
					}
					List<TileObjectData> data = this._alternates.data;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x001FB594 File Offset: 0x001F9794
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x001FB5A8 File Offset: 0x001F97A8
		public int CoordinateWidth
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_CoordinateWidth()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectCoordinatesModule[exp:bool](TileObjectData::_tileObjectCoords, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectCoords = this._hasOwnTileObjectCoords;
				TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
				if (!hasOwnTileObjectCoords)
				{
					int width = tileObjectCoords.width;
					int num = 1;
					this._hasOwnTileObjectCoords = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x001FB608 File Offset: 0x001F9808
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x001FB61C File Offset: 0x001F981C
		public int CoordinatePadding
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_CoordinatePadding()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectCoordinatesModule[exp:bool](TileObjectData::_tileObjectCoords, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectCoords = this._hasOwnTileObjectCoords;
				TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
				if (!hasOwnTileObjectCoords)
				{
					int padding = tileObjectCoords.padding;
					int num = 1;
					this._hasOwnTileObjectCoords = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x001FB67C File Offset: 0x001F987C
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x001FB69C File Offset: 0x001F989C
		public Point16 CoordinatePaddingFix
		{
			get
			{
				TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
				if (tileObjectCoords != null)
				{
					return tileObjectCoords.paddingFix;
				}
				Point16 point;
				return point;
			}
			set
			{
				bool hasOwnTileObjectCoords = this._hasOwnTileObjectCoords;
				TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
				if (!hasOwnTileObjectCoords)
				{
					bool flag = tileObjectCoords.paddingFix == value;
					int num = 1;
					this._hasOwnTileObjectCoords = num != 0;
					TileObjectCoordinatesModule tileObjectCoords2 = this._tileObjectCoords;
				}
				TileObjectCoordinatesModule tileObjectCoords3 = this._tileObjectCoords;
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x001FB710 File Offset: 0x001F9910
		public int CoordinateFullWidth
		{
			get
			{
				if (this._tileObjectCoords == null)
				{
				}
				this.Calculate();
				return this._tileObjectCoords.styleWidth;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060032CD RID: 13005 RVA: 0x001FB738 File Offset: 0x001F9938
		public int CoordinateFullHeight
		{
			get
			{
				if (this._tileObjectCoords == null)
				{
				}
				this.Calculate();
				return this._tileObjectCoords.styleHeight;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x001FB760 File Offset: 0x001F9960
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x001FB774 File Offset: 0x001F9974
		public int DrawStyleOffset
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032CE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_DrawStyleOffset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectCoordinatesModule[exp:bool](TileObjectData::_tileObjectCoords, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
			set
			{
				bool hasOwnTileObjectCoords = this._hasOwnTileObjectCoords;
				TileObjectCoordinatesModule tileObjectCoords = this._tileObjectCoords;
				if (!hasOwnTileObjectCoords)
				{
					int drawStyleOffset = tileObjectCoords.drawStyleOffset;
					int num = 1;
					this._hasOwnTileObjectCoords = num != 0;
				}
				if (this._linkedAlternates)
				{
					int size = this._alternates.data._size;
					int size2 = this._alternates.data._size;
				}
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x001FB7D4 File Offset: 0x001F99D4
		public bool LiquidPlace(Tile checkTile)
		{
			int num = 1;
			if (this._liquidPlacement == null)
			{
				if (num != 0)
				{
					if (this._liquidPlacement != null)
					{
						goto IL_0042;
					}
					if (this._liquidPlacement == null)
					{
					}
					if (this._liquidPlacement != null)
					{
						goto IL_003A;
					}
				}
				if (this._liquidPlacement == null)
				{
				}
				if (this._liquidPlacement != null)
				{
					goto IL_0042;
				}
			}
			IL_003A:
			if (this._liquidPlacement != null)
			{
				return;
			}
			IL_0042:
			if (this._liquidPlacement == null)
			{
				return;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060032D1 RID: 13009 RVA: 0x001FB834 File Offset: 0x001F9A34
		public int AlternatesCount
		{
			get
			{
				/*
An exception occurred when decompiling this method (060032D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::get_AlternatesCount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:TileObjectAlternatesModule[exp:bool](TileObjectData::_alternates, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x001FB848 File Offset: 0x001F9A48
		public bool isValidTileAnchor(int type)
		{
			AnchorTypesModule anchorTiles = this._anchorTiles;
			if (anchorTiles == null)
			{
				return;
			}
			int[] tileValid = anchorTiles.tileValid;
			if (tileValid != null)
			{
				return;
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x001FB874 File Offset: 0x001F9A74
		public bool isValidWallAnchor(int type)
		{
			AnchorTypesModule anchorTiles = this._anchorTiles;
			if (anchorTiles == null || anchorTiles.wallValid != null)
			{
				return;
			}
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x001FB898 File Offset: 0x001F9A98
		public bool isValidAlternateAnchor(int type)
		{
			AnchorTypesModule anchorTiles = this._anchorTiles;
			if (anchorTiles == null || anchorTiles.tileAlternates != null)
			{
				return;
			}
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x001FB8BC File Offset: 0x001F9ABC
		public int CalculatePlacementStyle(int style, int alternate, int random)
		{
			/*
An exception occurred when decompiling this method (060032D5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.ObjectData.TileObjectData::CalculatePlacementStyle(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	brtrue(IL_0000, ldfld:TileObjectStyleModule[exp:bool](TileObjectData::_tileObjectStyle, ldloc:TileObjectData(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x001FB8D8 File Offset: 0x001F9AD8
		private static void addBaseTile([Out] TileObjectData baseTile)
		{
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x001FB8E8 File Offset: 0x001F9AE8
		private static void addTile(int tileType)
		{
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x001FB8F8 File Offset: 0x001F9AF8
		private static void addSubTile(params int[] styles)
		{
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x001FB90C File Offset: 0x001F9B0C
		private static void addSubTile(int style)
		{
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x001FB920 File Offset: 0x001F9B20
		private static void addAlternate(int baseStyle)
		{
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x001FB934 File Offset: 0x001F9B34
		public static void Initialize()
		{
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x000021DB File Offset: 0x000003DB
		public static bool CustomPlace(int type, int style)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x001FDCAC File Offset: 0x001FBEAC
		public static bool CheckLiquidPlacement(int type, int style, Tile checkTile)
		{
			TileObjectData tileObjectData;
			if (tileObjectData != null)
			{
				bool flag;
				return flag;
			}
			bool flag2;
			return flag2;
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x001FDCC0 File Offset: 0x001FBEC0
		public static bool LiquidPlace(int type, Tile checkTile)
		{
			int num = 1;
			if (num == 0 || num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x001FDCE0 File Offset: 0x001FBEE0
		public static bool CheckWaterDeath(int type, int style)
		{
			/*
An exception occurred when decompiling this method (060032DF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::CheckWaterDeath(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x001FDD0C File Offset: 0x001FBF0C
		public static bool CheckWaterDeath(Tile checkTile)
		{
			/*
An exception occurred when decompiling this method (060032E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::CheckWaterDeath(Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x001FDD2C File Offset: 0x001FBF2C
		public static bool CheckLavaDeath(int type, int style)
		{
			/*
An exception occurred when decompiling this method (060032E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::CheckLavaDeath(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x001FDD58 File Offset: 0x001FBF58
		public static bool CheckLavaDeath(Tile checkTile)
		{
			/*
An exception occurred when decompiling this method (060032E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.ObjectData.TileObjectData::CheckLavaDeath(Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x001FDD78 File Offset: 0x001FBF78
		public static int PlatformFrameWidth()
		{
			int num;
			return num;
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x001FDD88 File Offset: 0x001FBF88
		public static TileObjectData GetTileData(int type, int style, int alternate = 0)
		{
			return "Function called with a bad type argument";
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x001FDD9C File Offset: 0x001FBF9C
		public static TileObjectData GetTileData(Tile getTile)
		{
			for (;;)
			{
				int num = 1;
				int num2 = 1;
				if (num == 0)
				{
				}
				if (num2 != 0)
				{
					int num3 = 1;
					if (true)
					{
						int num4 = 1;
						if (num3 == 0)
						{
						}
						if (num4 == 0 && true)
						{
							break;
						}
					}
				}
			}
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x001FDDF0 File Offset: 0x001FBFF0
		public static void SyncObjectPlacement(int tileX, int tileY, int type, int style, int dir)
		{
			if (!true)
			{
			}
			long num = 0L;
			TileObjectData tileData = TileObjectData.GetTileData(type, style, (int)num);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x001FDE0C File Offset: 0x001FC00C
		public static bool CallPostPlacementPlayerHook(int tileX, int tileY, int type, int style, int dir, int alternate, TileObject data)
		{
			TileObjectData tileData;
			do
			{
				tileData = TileObjectData.GetTileData(tileY, type, tileY);
			}
			while (tileData == null);
			TilePlacementHooksModule placementHooks = tileData._placementHooks;
			if (placementHooks != null && placementHooks.postPlaceMyPlayer != null)
			{
				bool processedCoordinates = placementHooks.postPlaceMyPlayer.processedCoordinates;
				int badReturn = placementHooks.postPlaceMyPlayer.badReturn;
				Point16 origin = tileData.Origin;
				Point16 origin2 = tileData.Origin;
				return;
			}
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x001FDE64 File Offset: 0x001FC064
		public static void OriginToTopLeft(int type, int style, Point16 baseCoords)
		{
			long num = 0L;
			TileObjectData tileData = TileObjectData.GetTileData(type, style, (int)num);
			if (tileData != null)
			{
				Point16 origin = tileData.Origin;
				Point16 origin2 = tileData.Origin;
			}
		}

		// Token: 0x04003BA4 RID: 15268
		private TileObjectData _parent;

		// Token: 0x04003BA5 RID: 15269
		private bool _linkedAlternates;

		// Token: 0x04003BA6 RID: 15270
		private bool _usesCustomCanPlace;

		// Token: 0x04003BA7 RID: 15271
		private TileObjectAlternatesModule _alternates;

		// Token: 0x04003BA8 RID: 15272
		private AnchorDataModule _anchor;

		// Token: 0x04003BA9 RID: 15273
		private AnchorTypesModule _anchorTiles;

		// Token: 0x04003BAA RID: 15274
		private LiquidDeathModule _liquidDeath;

		// Token: 0x04003BAB RID: 15275
		private LiquidPlacementModule _liquidPlacement;

		// Token: 0x04003BAC RID: 15276
		private TilePlacementHooksModule _placementHooks;

		// Token: 0x04003BAD RID: 15277
		private TileObjectSubTilesModule _subTiles;

		// Token: 0x04003BAE RID: 15278
		private TileObjectDrawModule _tileObjectDraw;

		// Token: 0x04003BAF RID: 15279
		private TileObjectStyleModule _tileObjectStyle;

		// Token: 0x04003BB0 RID: 15280
		private TileObjectBaseModule _tileObjectBase;

		// Token: 0x04003BB1 RID: 15281
		private TileObjectCoordinatesModule _tileObjectCoords;

		// Token: 0x04003BB2 RID: 15282
		private bool _hasOwnAlternates;

		// Token: 0x04003BB3 RID: 15283
		private bool _hasOwnAnchor;

		// Token: 0x04003BB4 RID: 15284
		private bool _hasOwnAnchorTiles;

		// Token: 0x04003BB5 RID: 15285
		private bool _hasOwnLiquidDeath;

		// Token: 0x04003BB6 RID: 15286
		private bool _hasOwnLiquidPlacement;

		// Token: 0x04003BB7 RID: 15287
		private bool _hasOwnPlacementHooks;

		// Token: 0x04003BB8 RID: 15288
		private bool _hasOwnSubTiles;

		// Token: 0x04003BB9 RID: 15289
		private bool _hasOwnTileObjectBase;

		// Token: 0x04003BBA RID: 15290
		private bool _hasOwnTileObjectDraw;

		// Token: 0x04003BBB RID: 15291
		private bool _hasOwnTileObjectStyle;

		// Token: 0x04003BBC RID: 15292
		private bool _hasOwnTileObjectCoords;

		// Token: 0x04003BBD RID: 15293
		private static List<TileObjectData> _data;

		// Token: 0x04003BBE RID: 15294
		private static TileObjectData _baseObject;

		// Token: 0x04003BBF RID: 15295
		private static bool readOnlyData;

		// Token: 0x04003BC0 RID: 15296
		private static TileObjectData newTile;

		// Token: 0x04003BC1 RID: 15297
		private static TileObjectData newSubTile;

		// Token: 0x04003BC2 RID: 15298
		private static TileObjectData newAlternate;

		// Token: 0x04003BC3 RID: 15299
		private static TileObjectData StyleSwitch;

		// Token: 0x04003BC4 RID: 15300
		private static TileObjectData StyleTorch;

		// Token: 0x04003BC5 RID: 15301
		private static TileObjectData Style4x2;

		// Token: 0x04003BC6 RID: 15302
		private static TileObjectData Style2x2;

		// Token: 0x04003BC7 RID: 15303
		private static TileObjectData Style1x2;

		// Token: 0x04003BC8 RID: 15304
		private static TileObjectData Style1x1;

		// Token: 0x04003BC9 RID: 15305
		private static TileObjectData StyleAlch;

		// Token: 0x04003BCA RID: 15306
		private static TileObjectData StyleDye;

		// Token: 0x04003BCB RID: 15307
		private static TileObjectData Style2x1;

		// Token: 0x04003BCC RID: 15308
		private static TileObjectData Style6x3;

		// Token: 0x04003BCD RID: 15309
		private static TileObjectData StyleSmallCage;

		// Token: 0x04003BCE RID: 15310
		private static TileObjectData StyleOnTable1x1;

		// Token: 0x04003BCF RID: 15311
		private static TileObjectData Style1x2Top;

		// Token: 0x04003BD0 RID: 15312
		private static TileObjectData Style1xX;

		// Token: 0x04003BD1 RID: 15313
		private static TileObjectData Style2xX;

		// Token: 0x04003BD2 RID: 15314
		private static TileObjectData Style3x2;

		// Token: 0x04003BD3 RID: 15315
		private static TileObjectData Style3x3;

		// Token: 0x04003BD4 RID: 15316
		private static TileObjectData Style3x4;

		// Token: 0x04003BD5 RID: 15317
		private static TileObjectData Style5x4;

		// Token: 0x04003BD6 RID: 15318
		private static TileObjectData Style3x3Wall;
	}
}
