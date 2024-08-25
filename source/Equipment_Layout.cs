using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x020001D2 RID: 466
public class Equipment_Layout : PageControllerLayoutDefinition<Equipment_Layout>
{
	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000C01 RID: 3073 RVA: 0x000021DB File Offset: 0x000003DB
	public Button_Layout DisplaySetBonus
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000C02 RID: 3074 RVA: 0x000021DB File Offset: 0x000003DB
	public String_Layout DisplaySetBonusText
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0003BC98 File Offset: 0x00039E98
	public TransactionButton_Layout InfoToggleCollapsed
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C03)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TransactionButton_Layout Equipment_Layout::get_InfoToggleCollapsed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_2_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
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

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0003BCAC File Offset: 0x00039EAC
	public TransactionButton_Layout InfoToggleExpanded
	{
		get
		{
			/*
An exception occurred when decompiling this method (06000C04)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TransactionButton_Layout Equipment_Layout::get_InfoToggleExpanded()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_2_07, callgetter:bool(ControllerActionManager::get_AnyControllerConnected))
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

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000C05 RID: 3077 RVA: 0x000021DB File Offset: 0x000003DB
	public TransactionButton_Layout LoadoutToggle
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000C06 RID: 3078 RVA: 0x000021DB File Offset: 0x000003DB
	public ItemGrid_Layout DisplayInfoAccessories
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000021DB File Offset: 0x000003DB
	public ItemGrid_Layout DisplayLoadouts
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0003BCC0 File Offset: 0x00039EC0
	public Equipment_Layout()
	{
		int num = 16256;
		this.InfoAccVisScale = (float)num;
		this.InfoAccessoriesIconScale = (float)num;
		this.LoadoutBackingColour = num;
		this.LoadoutBackingHighlightColour = num;
		this.ExtraDyeBackingColour = num;
		this.ExtraVanityAccBackingColour = num;
		this.DisabledAccessoryBackingColor = num;
		this.DisabledVanityAccessoryBackingColor = num;
		this.DisabledDyeAccessoryBackingColor = num;
		base..ctor();
	}

	// Token: 0x04001055 RID: 4181
	public float AmourScale;

	// Token: 0x04001056 RID: 4182
	public float ArmourHighlightScale;

	// Token: 0x04001057 RID: 4183
	public ItemGrid_Layout ArmourDye;

	// Token: 0x04001058 RID: 4184
	public ItemGrid_Layout ArmourVanity;

	// Token: 0x04001059 RID: 4185
	public ItemGrid_Layout Armor;

	// Token: 0x0400105A RID: 4186
	public Microsoft.Xna.Framework.Vector2 ArmorCollapsePosition;

	// Token: 0x0400105B RID: 4187
	public float AccessoryScale = 0f;

	// Token: 0x0400105C RID: 4188
	public float AccessoryHighlightScale;

	// Token: 0x0400105D RID: 4189
	public ItemGrid_Layout AccessoryDye;

	// Token: 0x0400105E RID: 4190
	public ItemGrid_Layout AccessoryVanity;

	// Token: 0x0400105F RID: 4191
	public ItemGrid_Layout Accessory;

	// Token: 0x04001060 RID: 4192
	public Microsoft.Xna.Framework.Vector2 AccessoryCollapsePosition;

	// Token: 0x04001061 RID: 4193
	public ItemGrid_Layout AccessoryExtra;

	// Token: 0x04001062 RID: 4194
	public ItemGrid_Layout AccessoryVanityExtra;

	// Token: 0x04001063 RID: 4195
	public ItemGrid_Layout AccessoryDyeExtra;

	// Token: 0x04001064 RID: 4196
	public Microsoft.Xna.Framework.Vector2 AccessoryExtraCollapsePosition;

	// Token: 0x04001065 RID: 4197
	public float QuickSlotScale = 0f;

	// Token: 0x04001066 RID: 4198
	public float QuickHighlightScale;

	// Token: 0x04001067 RID: 4199
	public ItemGrid_Layout QuickSlotDye;

	// Token: 0x04001068 RID: 4200
	public ItemGrid_Layout QuickSlot;

	// Token: 0x04001069 RID: 4201
	public Microsoft.Xna.Framework.Vector2 QuickSlotCollapsePosition;

	// Token: 0x0400106A RID: 4202
	public String_Layout Title;

	// Token: 0x0400106B RID: 4203
	public String_Layout ArmourTitle;

	// Token: 0x0400106C RID: 4204
	public String_Layout AccessoryTitle;

	// Token: 0x0400106D RID: 4205
	public String_Layout QuickSlotTitle;

	// Token: 0x0400106E RID: 4206
	public Button_Layout SetBonus;

	// Token: 0x0400106F RID: 4207
	public String_Layout SetBonusText;

	// Token: 0x04001070 RID: 4208
	public Button_Layout SetBonus_Horizontal;

	// Token: 0x04001071 RID: 4209
	public String_Layout SetBonusText_Horizontal;

	// Token: 0x04001072 RID: 4210
	public AnimationCurve ItemDragPulseScale;

	// Token: 0x04001073 RID: 4211
	public TransactionButton_Layout UnequipButton;

	// Token: 0x04001074 RID: 4212
	public TransactionButton_Layout HideShowButton;

	// Token: 0x04001075 RID: 4213
	public HideShowIcons HideShowIcons;

	// Token: 0x04001076 RID: 4214
	public TransactionButton_Layout ExpandButton;

	// Token: 0x04001077 RID: 4215
	public TransactionButton_Layout CollapseButton;

	// Token: 0x04001078 RID: 4216
	public Microsoft.Xna.Framework.Vector2 VisibilityOffset;

	// Token: 0x04001079 RID: 4217
	public Microsoft.Xna.Framework.Graphics.Color VisibilityColour;

	// Token: 0x0400107A RID: 4218
	public Microsoft.Xna.Framework.Vector2 MinecartOffset;

	// Token: 0x0400107B RID: 4219
	public Microsoft.Xna.Framework.Graphics.Color MinecartColour;

	// Token: 0x0400107C RID: 4220
	public TransactionButton_Layout InfoToggleControllerButtonCollapsed;

	// Token: 0x0400107D RID: 4221
	public TransactionButton_Layout InfoToggleControllerButtonExpanded;

	// Token: 0x0400107E RID: 4222
	public TransactionButton_Layout InfoToggleButtonCollapsed;

	// Token: 0x0400107F RID: 4223
	public TransactionButton_Layout InfoToggleButtonExpanded;

	// Token: 0x04001080 RID: 4224
	public TransactionButton_Layout InfoToggleButtonCollapsed_Horizontal;

	// Token: 0x04001081 RID: 4225
	public TransactionButton_Layout InfoToggleButtonExpanded_Horizontal;

	// Token: 0x04001082 RID: 4226
	public Panel_Layout InfoAccessoriesBacking;

	// Token: 0x04001083 RID: 4227
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingTLOffset;

	// Token: 0x04001084 RID: 4228
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingBROffset;

	// Token: 0x04001085 RID: 4229
	public ItemGrid_Layout InfoAccessories;

	// Token: 0x04001086 RID: 4230
	public ItemGrid_Layout InfoAccessories_Horizontal;

	// Token: 0x04001087 RID: 4231
	public TransactionButton_Layout LoadoutToggleButton;

	// Token: 0x04001088 RID: 4232
	public TransactionButton_Layout LoadoutToggleButton_Horizontal;

	// Token: 0x04001089 RID: 4233
	public float InfoAccessoriesScale;

	// Token: 0x0400108A RID: 4234
	public Microsoft.Xna.Framework.Graphics.Color InfoAccNormal;

	// Token: 0x0400108B RID: 4235
	public Microsoft.Xna.Framework.Graphics.Color InfoAccDisabled;

	// Token: 0x0400108C RID: 4236
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingColour;

	// Token: 0x0400108D RID: 4237
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingHighlightColour;

	// Token: 0x0400108E RID: 4238
	public Microsoft.Xna.Framework.Graphics.Color InfoAccVisColour;

	// Token: 0x0400108F RID: 4239
	public float InfoAccVisScale;

	// Token: 0x04001090 RID: 4240
	public Texture_Layout InfoAccBackingTexture;

	// Token: 0x04001091 RID: 4241
	public Microsoft.Xna.Framework.Vector2 InfoAccVisOffset;

	// Token: 0x04001092 RID: 4242
	public float InfoAccessoriesIconScale;

	// Token: 0x04001093 RID: 4243
	public ItemGrid_Layout Loadouts;

	// Token: 0x04001094 RID: 4244
	public ItemGrid_Layout Loadouts_Horizontal;

	// Token: 0x04001095 RID: 4245
	public Panel_Layout LoadoutBacking;

	// Token: 0x04001096 RID: 4246
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingTLOffset;

	// Token: 0x04001097 RID: 4247
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingBROffset;

	// Token: 0x04001098 RID: 4248
	public float LoadoutScale;

	// Token: 0x04001099 RID: 4249
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingColour;

	// Token: 0x0400109A RID: 4250
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingHighlightColour;

	// Token: 0x0400109B RID: 4251
	public Texture_Layout LoadoutBackingTexture;

	// Token: 0x0400109C RID: 4252
	public float LoadoutIconScale;

	// Token: 0x0400109D RID: 4253
	public Microsoft.Xna.Framework.Graphics.Color ExtraDyeBackingColour;

	// Token: 0x0400109E RID: 4254
	public Microsoft.Xna.Framework.Graphics.Color ExtraVanityAccBackingColour;

	// Token: 0x0400109F RID: 4255
	public Microsoft.Xna.Framework.Graphics.Color ExtraAccBackingColour;

	// Token: 0x040010A0 RID: 4256
	public Texture_Layout DisabledAccessoryBacking;

	// Token: 0x040010A1 RID: 4257
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingColor;

	// Token: 0x040010A2 RID: 4258
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingIconColor;

	// Token: 0x040010A3 RID: 4259
	public Texture_Layout DisabledVanityAccessoryBacking;

	// Token: 0x040010A4 RID: 4260
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingColor;

	// Token: 0x040010A5 RID: 4261
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingIconColor;

	// Token: 0x040010A6 RID: 4262
	public Texture_Layout DisabledDyeAccessoryBacking;

	// Token: 0x040010A7 RID: 4263
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingColor;

	// Token: 0x040010A8 RID: 4264
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingIconColor;
}
