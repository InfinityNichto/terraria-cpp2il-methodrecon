using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.GameInput;
using Terraria.Social.Base;

namespace Terraria.UI
{
	// Token: 0x020006E2 RID: 1762
	public class InGamePopups
	{
		// Token: 0x06003B25 RID: 15141 RVA: 0x0023435C File Offset: 0x0023255C
		public InGamePopups()
		{
		}

		// Token: 0x020006E3 RID: 1763
		public class AchievementUnlockedPopup : IInGameNotification
		{
			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06003B26 RID: 15142 RVA: 0x00234370 File Offset: 0x00232570
			// (set) Token: 0x06003B27 RID: 15143 RVA: 0x00234384 File Offset: 0x00232584
			public bool ShouldBeRemoved
			{
				[CompilerGenerated]
				get
				{
					return this.<ShouldBeRemoved>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06003B28 RID: 15144 RVA: 0x00234394 File Offset: 0x00232594
			// (set) Token: 0x06003B29 RID: 15145 RVA: 0x002343A8 File Offset: 0x002325A8
			public object CreationObject
			{
				[CompilerGenerated]
				get
				{
					return this.<CreationObject>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<CreationObject>k__BackingField = value;
				}
			}

			// Token: 0x06003B2A RID: 15146 RVA: 0x002343BC File Offset: 0x002325BC
			public AchievementUnlockedPopup(Achievement achievement)
			{
				int num = 300;
				this.CreationObject = achievement;
				this._ingameDisplayTimeLeft = num;
				this._theAchievement = achievement;
				string <Value>k__BackingField = achievement.FriendlyName.<Value>k__BackingField;
				this._title = <Value>k__BackingField;
				if (<Value>k__BackingField == null)
				{
				}
				AchievementManager achievements = Main.Achievements;
				string name = achievement.Name;
				int iconIndex = achievements.GetIconIndex(name);
				this._iconIndex = iconIndex;
			}

			// Token: 0x06003B2B RID: 15147 RVA: 0x00234434 File Offset: 0x00232634
			public void Update()
			{
				int ingameDisplayTimeLeft = this._ingameDisplayTimeLeft;
				this._ingameDisplayTimeLeft = ingameDisplayTimeLeft;
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06003B2C RID: 15148 RVA: 0x00234450 File Offset: 0x00232650
			private float Scale
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003B2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.InGamePopups/AchievementUnlockedPopup::get_Scale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(AchievementUnlockedPopup::_ingameDisplayTimeLeft, ldloc:AchievementUnlockedPopup(this)))
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

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x06003B2D RID: 15149 RVA: 0x00234468 File Offset: 0x00232668
			private float Opacity
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003B2D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.InGamePopups/AchievementUnlockedPopup::get_Opacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, callgetter:float32(AchievementUnlockedPopup::get_Scale, ldloc:AchievementUnlockedPopup(this)))
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

			// Token: 0x06003B2E RID: 15150 RVA: 0x0023447C File Offset: 0x0023267C
			public void PushAnchor(Vector2 anchorPosition)
			{
				float height = this._height;
				float scale = this.Scale;
				float y = anchorPosition.Y;
			}

			// Token: 0x06003B2F RID: 15151 RVA: 0x002344A0 File Offset: 0x002326A0
			public void DrawInGame(SpriteBatch sb, Vector2 bottomAnchorPosition)
			{
				float scale = this.Scale;
				string title = this._title;
				float scale2 = this.Scale;
				int width = this._achievementIconFrame.Width;
				int height = this._achievementIconFrame.Height;
				Asset<Texture2D> achievementBorderTexture = this._achievementBorderTexture;
				Asset<Texture2D> achievementBorderTexture2 = this._achievementBorderTexture;
				int width2 = this._achievementIconFrame.Width;
				int height2 = this._achievementIconFrame.Height;
				if (achievementBorderTexture2 == null)
				{
				}
				Rectangle rectangle;
				Vector2 vector = rectangle.Right();
				Vector2 vector2 = rectangle.Left();
				Asset<Texture2D> achievementTexture = this._achievementTexture;
				int height3 = this._achievementIconFrame.Height;
				Asset<Texture2D> achievementBorderTexture3 = this._achievementBorderTexture;
				int height4 = this._achievementIconFrame.Height;
				if (height4 == 0)
				{
				}
				if (height4 == 0 || height4 == 0)
				{
				}
				this._height = (float)height4;
				if (height4 == 0)
				{
				}
				bool mouseLeft = Main.mouseLeft;
				if (height4 == 0)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
				IngameFancyUI.OpenAchievementsAndGoto(this._theAchievement);
			}

			// Token: 0x06003B30 RID: 15152 RVA: 0x002345A0 File Offset: 0x002327A0
			private void OnMouseOver()
			{
				int num = 1;
				if (num == 0)
				{
				}
				bool ignoreMouseInterface = PlayerInput.IgnoreMouseInterface;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				bool mouseLeft = Main.mouseLeft;
				if (num == 0)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
				if (num == 0)
				{
				}
				Main.mouseLeftRelease = false;
				IngameFancyUI.OpenAchievementsAndGoto(this._theAchievement);
				int num2 = 1;
				this.<ShouldBeRemoved>k__BackingField = num2 != 0;
			}

			// Token: 0x06003B31 RID: 15153 RVA: 0x00234600 File Offset: 0x00232800
			public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, int gamepadPointLocalIndexTouse)
			{
				if (!true)
				{
				}
			}

			// Token: 0x04007AF4 RID: 31476
			private Achievement _theAchievement;

			// Token: 0x04007AF5 RID: 31477
			private Asset<Texture2D> _achievementTexture;

			// Token: 0x04007AF6 RID: 31478
			private Asset<Texture2D> _achievementBorderTexture;

			// Token: 0x04007AF7 RID: 31479
			private const int _iconSize = 64;

			// Token: 0x04007AF8 RID: 31480
			private const int _iconSizeWithSpace = 66;

			// Token: 0x04007AF9 RID: 31481
			private const int _iconsPerRow = 8;

			// Token: 0x04007AFA RID: 31482
			private int _iconIndex;

			// Token: 0x04007AFB RID: 31483
			private Rectangle _achievementIconFrame;

			// Token: 0x04007AFC RID: 31484
			private string _title;

			// Token: 0x04007AFD RID: 31485
			private float _height;

			// Token: 0x04007AFE RID: 31486
			private int _ingameDisplayTimeLeft;

			// Token: 0x04007AFF RID: 31487
			[CompilerGenerated]
			private bool <ShouldBeRemoved>k__BackingField;

			// Token: 0x04007B00 RID: 31488
			[CompilerGenerated]
			private object <CreationObject>k__BackingField;
		}

		// Token: 0x020006E4 RID: 1764
		public class PlayerWantsToJoinGamePopup : IInGameNotification
		{
			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06003B32 RID: 15154 RVA: 0x00234610 File Offset: 0x00232810
			private float Scale
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003B32)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.InGamePopups/PlayerWantsToJoinGamePopup::get_Scale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PlayerWantsToJoinGamePopup::_timeLeft, ldloc:PlayerWantsToJoinGamePopup(this)))
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

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x06003B33 RID: 15155 RVA: 0x00234628 File Offset: 0x00232828
			private float Opacity
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003B33)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.InGamePopups/PlayerWantsToJoinGamePopup::get_Opacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, callgetter:float32(PlayerWantsToJoinGamePopup::get_Scale, ldloc:PlayerWantsToJoinGamePopup(this)))
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

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x06003B34 RID: 15156 RVA: 0x0023463C File Offset: 0x0023283C
			// (set) Token: 0x06003B35 RID: 15157 RVA: 0x00234650 File Offset: 0x00232850
			public object CreationObject
			{
				[CompilerGenerated]
				get
				{
					return this.<CreationObject>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<CreationObject>k__BackingField = value;
				}
			}

			// Token: 0x06003B36 RID: 15158 RVA: 0x00234664 File Offset: 0x00232864
			public PlayerWantsToJoinGamePopup(UserJoinToServerRequest request)
			{
				int num = 1800;
				this._request = request;
				this.CreationObject = request;
				this._timeLeft = num;
				if (num == 0)
				{
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x06003B37 RID: 15159 RVA: 0x002346A8 File Offset: 0x002328A8
			public bool ShouldBeRemoved
			{
				get
				{
					/*
An exception occurred when decompiling this method (06003B37)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.InGamePopups/PlayerWantsToJoinGamePopup::get_ShouldBeRemoved()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(PlayerWantsToJoinGamePopup::_timeLeft, ldloc:PlayerWantsToJoinGamePopup(this)))
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

			// Token: 0x06003B38 RID: 15160 RVA: 0x002346BC File Offset: 0x002328BC
			public void Update()
			{
				int timeLeft = this._timeLeft;
				this._timeLeft = timeLeft;
			}

			// Token: 0x06003B39 RID: 15161 RVA: 0x002346D8 File Offset: 0x002328D8
			public void DrawInGame(SpriteBatch spriteBatch, Vector2 bottomAnchorPosition)
			{
				float scale = this.Scale;
				UserJoinToServerRequest request = this._request;
				UserJoinToServerRequest request2 = this._request;
				string <UserDisplayName>k__BackingField = request2.<UserDisplayName>k__BackingField;
				string <UserFullIdentifier>k__BackingField = request2.<UserFullIdentifier>k__BackingField;
				float scale2 = this.Scale;
				if (17000 == 0)
				{
				}
				Rectangle rectangle;
				if (rectangle == null)
				{
				}
				Vector2 mouseScreen = Main.MouseScreen;
			}

			// Token: 0x06003B3A RID: 15162 RVA: 0x002347B4 File Offset: 0x002329B4
			private void OnMouseOver(bool reject = false)
			{
				int num = 1;
				if (num == 0)
				{
				}
				bool ignoreMouseInterface = PlayerInput.IgnoreMouseInterface;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				bool mouseLeft = Main.mouseLeft;
				if (num == 0)
				{
				}
				bool mouseLeftRelease = Main.mouseLeftRelease;
				if (num == 0)
				{
				}
				Main.mouseLeftRelease = false;
				UserJoinToServerRequest request = this._request;
				request.Reject();
			}

			// Token: 0x06003B3B RID: 15163 RVA: 0x00234818 File Offset: 0x00232A18
			public void PushAnchor(Vector2 positionAnchorBottom)
			{
				float scale = this.Scale;
				float y = positionAnchorBottom.Y;
			}

			// Token: 0x06003B3C RID: 15164 RVA: 0x00234834 File Offset: 0x00232A34
			public void DrawInNotificationsArea(SpriteBatch spriteBatch, Rectangle area, int gamepadPointLocalIndexTouse)
			{
				UserJoinToServerRequest request = this._request;
				string <UserDisplayName>k__BackingField = this._request.<UserDisplayName>k__BackingField;
				if (<UserDisplayName>k__BackingField == null)
				{
				}
				if (<UserDisplayName>k__BackingField == null)
				{
				}
				string <UserFullIdentifier>k__BackingField = this._request.<UserFullIdentifier>k__BackingField;
				if (<UserDisplayName>k__BackingField == null)
				{
				}
				Vector2 mouseScreen = Main.MouseScreen;
			}

			// Token: 0x04007B01 RID: 31489
			private int _timeLeft;

			// Token: 0x04007B02 RID: 31490
			private const int _timeLeftMax = 1800;

			// Token: 0x04007B03 RID: 31491
			private string _displayTextWithoutTime;

			// Token: 0x04007B04 RID: 31492
			private UserJoinToServerRequest _request;

			// Token: 0x04007B05 RID: 31493
			[CompilerGenerated]
			private object <CreationObject>k__BackingField;
		}
	}
}
