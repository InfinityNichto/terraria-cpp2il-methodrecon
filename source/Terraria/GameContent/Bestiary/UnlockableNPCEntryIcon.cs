using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000943 RID: 2371
	public class UnlockableNPCEntryIcon : IEntryIcon
	{
		// Token: 0x0600479B RID: 18331 RVA: 0x0025ED5C File Offset: 0x0025CF5C
		public UnlockableNPCEntryIcon(int npcNetId, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, [Optional] string overrideNameKey)
		{
			this._npcNetId = npcNetId;
			int npcNetId2 = this._npcNetId;
			float[] ai4 = this._npcCache.ai;
			this._overrideNameKey = overrideNameKey;
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x0025ED94 File Offset: 0x0025CF94
		public IEntryIcon CreateClone()
		{
			/*
An exception occurred when decompiling this method (0600479C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Bestiary.IEntryIcon Terraria.GameContent.Bestiary.UnlockableNPCEntryIcon::CreateClone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(UnlockableNPCEntryIcon::_npcNetId, ldloc:UnlockableNPCEntryIcon(this)))
	stloc:string(var_1_0D, ldfld:string(UnlockableNPCEntryIcon::_overrideNameKey, ldloc:UnlockableNPCEntryIcon(this)))
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

		// Token: 0x0600479D RID: 18333 RVA: 0x0025EDB0 File Offset: 0x0025CFB0
		public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int npcNetId = this._npcNetId;
			NPC npcCache = this._npcCache;
			npcCache.rotation = (float)num;
			npcCache.scale = (float)num;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x0025EE98 File Offset: 0x0025D098
		private void UpdatePosition(EntryIconDrawSettings settings)
		{
			if (this._npcCache.noGravity)
			{
				Point point;
				Vector2 vector = point.ToVector2();
				float x = this._positionOffsetCache.X;
				float y = this._positionOffsetCache.Y;
				return;
			}
			float x2 = this._positionOffsetCache.X;
			float y2 = this._positionOffsetCache.Y;
			NPC npcCache = this._npcCache;
			float x3 = npcCache.position.X;
			float y3 = npcCache.position.Y;
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x0025EF24 File Offset: 0x0025D124
		private void AdjustSpecialSpawnRulesForVisuals(EntryIconDrawSettings settings)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int npcNetId = this._npcNetId;
			float[] ai;
			if (num == 0)
			{
				NPC npcCache = this._npcCache;
				float x = npcCache.position.X;
				float y = npcCache.position.Y;
				float rotation = npcCache.rotation;
				if (npcCache == null)
				{
				}
				ai = this._npcCache.ai;
			}
			int num2 = this.lastFrameVisualsUpdated;
			if (ai == null)
			{
			}
			if (ai == null)
			{
			}
			int npcNetId2 = this._npcNetId;
			NPC npcCache2 = this._npcCache;
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x0025F034 File Offset: 0x0025D234
		private void SimulateFirstHover(float velocity)
		{
			if (this._firstUpdateDone)
			{
				return;
			}
			NPC npcCache = this._npcCache;
			this._firstUpdateDone = true;
			npcCache.SetFrameSize();
			NPC npcCache2 = this._npcCache;
			int direction = npcCache2.direction;
			npcCache2.velocity.X = (float)direction;
			npcCache2.FindFrame();
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x0025F080 File Offset: 0x0025D280
		public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
		{
			Asset<Texture2D> customTexture = this._customTexture;
			if (customTexture != null)
			{
				Vector2 center = this._npcCache.Center;
				if (customTexture == null)
				{
				}
				Asset<Texture2D> customTexture2 = this._customTexture;
				if (customTexture == null)
				{
				}
				Vector2 vector = Utils.Size(customTexture2);
				if (customTexture == null)
				{
				}
				float scale = this._npcCache.scale;
				return;
			}
			bool townNPC = this._npcCache.townNPC;
			if (townNPC)
			{
				NPC npcCache;
				if (!townNPC)
				{
					npcCache = this._npcCache;
				}
				int type = npcCache.type;
				if (npcCache == null)
				{
				}
				NPC npcCache2 = this._npcCache;
				if (townNPC)
				{
				}
				return;
			}
			bool behindTiles = this._npcCache.behindTiles;
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x0025F128 File Offset: 0x0025D328
		public string GetHoverText(BestiaryUICollectionInfo providedInfo)
		{
			string npcnameValue = Lang.GetNPCNameValue(this._npcCache.netID);
			bool flag = string.IsNullOrWhiteSpace(this._overrideNameKey);
			return Language.GetTextValue(this._overrideNameKey);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x000021DB File Offset: 0x000003DB
		public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400836E RID: 33646
		private int lastFrameVisualsUpdated;

		// Token: 0x0400836F RID: 33647
		private int _npcNetId;

		// Token: 0x04008370 RID: 33648
		private NPC _npcCache;

		// Token: 0x04008371 RID: 33649
		private bool _firstUpdateDone;

		// Token: 0x04008372 RID: 33650
		private Asset<Texture2D> _customTexture;

		// Token: 0x04008373 RID: 33651
		private Vector2 _positionOffsetCache;

		// Token: 0x04008374 RID: 33652
		private string _overrideNameKey;
	}
}
