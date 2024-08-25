using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000AB0 RID: 2736
	public class UIDynamicItemCollection : UIElement
	{
		// Token: 0x060050B4 RID: 20660 RVA: 0x0027DFF4 File Offset: 0x0027C1F4
		public UIDynamicItemCollection()
		{
			if (!true)
			{
			}
			base..ctor();
			this.HAlign = (float)16128;
			this.UpdateSize();
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x0027E01C File Offset: 0x0027C21C
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			List<int> itemIdsToLoadTexturesFor;
			do
			{
				if (!true)
				{
				}
				int itemsPerLine = this._itemsPerLine;
				List<int> itemIdsAvailableToShow = this._itemIdsAvailableToShow;
				if (this._itemsPerLine == 0)
				{
				}
				if (this.<IsMouseHovering>k__BackingField)
				{
					Vector2 mouseScreen = Main.MouseScreen;
					bool ignoreMouseInterface = PlayerInput.IgnoreMouseInterface;
					Item item = this._item;
					if (this._item == null)
					{
					}
					Player localPlayer = Main.LocalPlayer;
					int num = 1;
					localPlayer.mouseInterface = num != 0;
				}
				int size = this._itemIdsToLoadTexturesFor._size;
				itemIdsToLoadTexturesFor = this._itemIdsToLoadTexturesFor;
				if (itemIdsToLoadTexturesFor == null)
				{
				}
			}
			while (itemIdsToLoadTexturesFor._syncRoot != null);
			if ("Only TraceListeners can be added to a TraceListenerCollection." == null)
			{
			}
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x0027E0B8 File Offset: 0x0027C2B8
		private Rectangle GetItemSlotHitbox(int startX, int startY, int startItemIndex, int i)
		{
			/*
An exception occurred when decompiling this method (060050B6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.GameContent.UI.Elements.UIDynamicItemCollection::GetItemSlotHitbox(System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(UIDynamicItemCollection::_itemsPerLine, ldloc:UIDynamicItemCollection(this)))
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

		// Token: 0x060050B7 RID: 20663 RVA: 0x0027E0D4 File Offset: 0x0027C2D4
		private void GetGridParameters([Out] int startX, [Out] int startY, [Out] int startItemIndex, [Out] int endItemIndex)
		{
			float x = this._dimensions.X;
			UIElement <Parent>k__BackingField = this.<Parent>k__BackingField;
			int itemsPerLine = this._itemsPerLine;
			startX.m_value = itemsPerLine;
			startY.m_value = startX;
			int size = this._itemIdsAvailableToShow._size;
			endItemIndex.m_value = size;
			if (size == 0)
			{
			}
			int num = Math.Min(0, startX);
			int itemsPerLine2 = this._itemsPerLine;
			startItemIndex.m_value = size;
			int itemsPerLine3 = this._itemsPerLine;
			endItemIndex.m_value = size;
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x0027E150 File Offset: 0x0027C350
		public override void Recalculate()
		{
			base.Recalculate();
			this.UpdateSize();
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x0027E16C File Offset: 0x0027C36C
		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			if (this.<IsMouseHovering>k__BackingField)
			{
				Main.LocalPlayer.mouseInterface = true;
			}
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x0027E198 File Offset: 0x0027C398
		public void SetContentsToShow(List<int> itemIdsToShow)
		{
			List<int> itemIdsAvailableToShow = this._itemIdsAvailableToShow;
			int version = itemIdsAvailableToShow._version;
			itemIdsAvailableToShow._syncRoot = version;
			List<int> itemIdsToLoadTexturesFor = this._itemIdsToLoadTexturesFor;
			int version2 = itemIdsToLoadTexturesFor._version;
			itemIdsToLoadTexturesFor._syncRoot = version2;
			List<int> itemIdsToLoadTexturesFor2 = this._itemIdsToLoadTexturesFor;
			this.UpdateSize();
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x0027E1E0 File Offset: 0x0027C3E0
		public int GetItemsPerLine()
		{
			return this._itemsPerLine;
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x000021DB File Offset: 0x000003DB
		public override List<SnapPoint> GetSnapPoints()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x0027E1F4 File Offset: 0x0027C3F4
		public void UpdateSize()
		{
			float x = this._dimensions.X;
			int size = this._itemIdsAvailableToShow._size;
		}

		// Token: 0x04008971 RID: 35185
		private List<int> _itemIdsAvailableToShow;

		// Token: 0x04008972 RID: 35186
		private List<int> _itemIdsToLoadTexturesFor;

		// Token: 0x04008973 RID: 35187
		private int _itemsPerLine;

		// Token: 0x04008974 RID: 35188
		private const int sizePerEntryX = 44;

		// Token: 0x04008975 RID: 35189
		private const int sizePerEntryY = 44;

		// Token: 0x04008976 RID: 35190
		private List<SnapPoint> _dummySnapPoints;

		// Token: 0x04008977 RID: 35191
		private Item _item;
	}
}
