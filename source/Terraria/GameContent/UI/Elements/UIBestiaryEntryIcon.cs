using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000A9F RID: 2719
	public class UIBestiaryEntryIcon : UIElement
	{
		// Token: 0x06005035 RID: 20533 RVA: 0x0027C938 File Offset: 0x0027AB38
		public UIBestiaryEntryIcon(BestiaryEntry entry, bool isPortrait)
		{
			int num = 1;
			if (num == 0)
			{
			}
			base..ctor();
			this._entry = entry;
			int num2 = 1;
			this.IgnoresMouseInteraction = num2 != 0;
			if (num == 0)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			this.OverrideSamplerState = defaultSamplerState;
			this.UseImmediateMode = num2 != 0;
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x0027C9A0 File Offset: 0x0027ABA0
		public override void Update(GameTime gameTime)
		{
			IBestiaryUICollectionInfoProvider uiinfoProvider = this._entry.UIInfoProvider;
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x0027C9FC File Offset: 0x0027ABFC
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			float x = this._dimensions.X;
			BestiaryEntry entry = this._entry;
			BestiaryUICollectionInfo collectionInfo = this._collectionInfo;
			BestiaryEntryUnlockState unlockState = this._collectionInfo.UnlockState;
			IEntryIcon icon = entry.Icon;
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x0027CA80 File Offset: 0x0027AC80
		public string GetHoverText()
		{
			/*
An exception occurred when decompiling this method (06005038)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.GameContent.UI.Elements.UIBestiaryEntryIcon::GetHoverText()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:BestiaryEntry(var_0_06, ldfld:BestiaryEntry(UIBestiaryEntryIcon::_entry, ldloc:UIBestiaryEntryIcon(this)))
	stloc:BestiaryUICollectionInfo(var_1_0D, ldfld:BestiaryUICollectionInfo(UIBestiaryEntryIcon::_collectionInfo, ldloc:UIBestiaryEntryIcon(this)))
	stloc:BestiaryEntryUnlockState(var_2_19, ldfld:BestiaryEntryUnlockState(BestiaryUICollectionInfo::UnlockState, ldfld:BestiaryUICollectionInfo[exp:valuetype Terraria.GameContent.Bestiary.BestiaryUICollectionInfo&](UIBestiaryEntryIcon::_collectionInfo, ldloc:UIBestiaryEntryIcon(this))))
	stloc:IEntryIcon(var_3_20, ldfld:IEntryIcon(BestiaryEntry::Icon, ldloc:BestiaryEntry(var_0_06)))
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

		// Token: 0x04008906 RID: 35078
		private BestiaryEntry _entry;

		// Token: 0x04008907 RID: 35079
		private Asset<Texture2D> _notUnlockedTexture;

		// Token: 0x04008908 RID: 35080
		private bool _isPortrait;

		// Token: 0x04008909 RID: 35081
		public bool ForceHover;

		// Token: 0x0400890A RID: 35082
		private BestiaryUICollectionInfo _collectionInfo;
	}
}
