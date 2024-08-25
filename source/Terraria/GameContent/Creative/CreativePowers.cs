using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.Net;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000A36 RID: 2614
	public class CreativePowers
	{
		// Token: 0x06004CA9 RID: 19625 RVA: 0x00272274 File Offset: 0x00270474
		public CreativePowers()
		{
		}

		// Token: 0x02000A37 RID: 2615
		public abstract class APerPlayerTogglePower : ICreativePower, IOnPlayerJoining
		{
			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06004CAA RID: 19626 RVA: 0x00272288 File Offset: 0x00270488
			// (set) Token: 0x06004CAB RID: 19627 RVA: 0x0027229C File Offset: 0x0027049C
			public ushort PowerId
			{
				[CompilerGenerated]
				get
				{
					return this.<PowerId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PowerId>k__BackingField = value;
				}
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06004CAC RID: 19628 RVA: 0x002722B0 File Offset: 0x002704B0
			// (set) Token: 0x06004CAD RID: 19629 RVA: 0x002722C4 File Offset: 0x002704C4
			public string ServerConfigName
			{
				[CompilerGenerated]
				get
				{
					return this.<ServerConfigName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ServerConfigName>k__BackingField = value;
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06004CAE RID: 19630 RVA: 0x002722D8 File Offset: 0x002704D8
			// (set) Token: 0x06004CAF RID: 19631 RVA: 0x002722EC File Offset: 0x002704EC
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<CurrentPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<CurrentPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06004CB0 RID: 19632 RVA: 0x00272300 File Offset: 0x00270500
			// (set) Token: 0x06004CB1 RID: 19633 RVA: 0x00272314 File Offset: 0x00270514
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<DefaultPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DefaultPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x06004CB2 RID: 19634 RVA: 0x00272328 File Offset: 0x00270528
			public bool IsEnabledForPlayer(int playerIndex)
			{
				int num = 1;
				bool[] perPlayerIsEnabled = this._perPlayerIsEnabled;
				if (num == 0)
				{
				}
				bool[] perPlayerIsEnabled2 = this._perPlayerIsEnabled;
				bool flag;
				return flag;
			}

			// Token: 0x06004CB3 RID: 19635 RVA: 0x0027234C File Offset: 0x0027054C
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				this.Deserialize_SyncEveryone(reader, userId);
			}

			// Token: 0x06004CB4 RID: 19636 RVA: 0x0027237C File Offset: 0x0027057C
			private void Deserialize_SyncEveryone(BinaryReader reader, int userId)
			{
				int num = 1;
				bool[] perPlayerIsEnabled = this._perPlayerIsEnabled;
				if (num == 0)
				{
				}
				if (32640 == 0)
				{
				}
				bool netHost = Main.NetHost;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, userId);
				int myPlayer = Main.myPlayer;
				bool[] perPlayerIsEnabled2 = this._perPlayerIsEnabled;
				long num2 = 0L;
				this.SetEnabledState(43134976, num2 != 0L);
			}

			// Token: 0x06004CB5 RID: 19637 RVA: 0x002723D8 File Offset: 0x002705D8
			public void SetEnabledState(int playerIndex, bool state)
			{
				if (this._perPlayerIsEnabled == null)
				{
				}
				bool netHost = Main.NetHost;
				ushort num = this.<PowerId>k__BackingField;
				int num2 = 3;
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num, num2).Writer;
			}

			// Token: 0x06004CB6 RID: 19638 RVA: 0x0027240C File Offset: 0x0027060C
			public void DebugCall()
			{
				this.RequestUse();
			}

			// Token: 0x06004CB7 RID: 19639 RVA: 0x00272420 File Offset: 0x00270620
			internal void RequestUse()
			{
				int num = 1;
				ushort num2 = this.<PowerId>k__BackingField;
				if (num == 0)
				{
				}
				int num3 = 1;
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num2, num3).Writer;
				int myPlayer = Main.myPlayer;
				bool[] perPlayerIsEnabled = this._perPlayerIsEnabled;
				int myPlayer2 = Main.myPlayer;
			}

			// Token: 0x06004CB8 RID: 19640 RVA: 0x00272464 File Offset: 0x00270664
			public void Reset()
			{
				bool[] perPlayerIsEnabled = this._perPlayerIsEnabled;
				bool defaultToggleState = this._defaultToggleState;
				perPlayerIsEnabled.m_value = defaultToggleState;
			}

			// Token: 0x06004CB9 RID: 19641 RVA: 0x00272488 File Offset: 0x00270688
			public void OnPlayerJoining(int playerIndex)
			{
				int num = 1;
				bool[] perPlayerIsEnabled = this._perPlayerIsEnabled;
				if (num == 0)
				{
				}
				int num2 = 32640;
				ushort num3 = this.<PowerId>k__BackingField;
				if (num2 == 0)
				{
				}
				long num4 = 0L;
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num3, playerIndex).Writer;
				BitsByte bitsByte = 0;
				long num5 = 0L;
				bool[] perPlayerIsEnabled2 = this._perPlayerIsEnabled;
				bitsByte[(int)num5] = num4 != 0L;
			}

			// Token: 0x06004CBA RID: 19642 RVA: 0x000021DB File Offset: 0x000003DB
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004CBB RID: 19643 RVA: 0x002724EC File Offset: 0x002706EC
			private void button_OnUpdate(UIElement affectedElement)
			{
				int num = 1;
				bool[] perPlayerIsEnabled = this._perPlayerIsEnabled;
				if (num == 0)
				{
				}
				int myPlayer = Main.myPlayer;
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string powerNameKey = this._powerNameKey;
					string text;
					string textValue = Language.GetTextValue(text);
					string text2 = this._powerNameKey + "_Description";
					string powerNameKey2 = this._powerNameKey;
					string text3 = powerNameKey2 + "_Unlock";
					CreativePowersHelper.AddPermissionTextIfNeeded(this, "_Unlock");
					if (powerNameKey2 == null)
					{
					}
				}
			}

			// Token: 0x06004CBC RID: 19644 RVA: 0x00272560 File Offset: 0x00270760
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				int myPlayer = Main.myPlayer;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, myPlayer);
				this.RequestUse();
			}

			// Token: 0x06004CBD RID: 19645
			public abstract bool GetIsUnlocked();

			// Token: 0x06004CBE RID: 19646 RVA: 0x00272584 File Offset: 0x00270784
			protected APerPlayerTogglePower()
			{
			}

			// Token: 0x0400866A RID: 34410
			[CompilerGenerated]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400866B RID: 34411
			[CompilerGenerated]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400866C RID: 34412
			[CompilerGenerated]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400866D RID: 34413
			[CompilerGenerated]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400866E RID: 34414
			internal string _powerNameKey;

			// Token: 0x0400866F RID: 34415
			internal Point _iconLocation;

			// Token: 0x04008670 RID: 34416
			internal bool _defaultToggleState;

			// Token: 0x04008671 RID: 34417
			private bool[] _perPlayerIsEnabled;

			// Token: 0x02000A38 RID: 2616
			private enum SubMessageType : byte
			{
				// Token: 0x04008673 RID: 34419
				SyncEveryone,
				// Token: 0x04008674 RID: 34420
				SyncOnePlayer
			}
		}

		// Token: 0x02000A39 RID: 2617
		public abstract class APerPlayerSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
		{
			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x06004CBF RID: 19647 RVA: 0x00272598 File Offset: 0x00270798
			// (set) Token: 0x06004CC0 RID: 19648 RVA: 0x002725AC File Offset: 0x002707AC
			public ushort PowerId
			{
				[CompilerGenerated]
				get
				{
					return this.<PowerId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PowerId>k__BackingField = value;
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x002725C0 File Offset: 0x002707C0
			// (set) Token: 0x06004CC2 RID: 19650 RVA: 0x002725D4 File Offset: 0x002707D4
			public string ServerConfigName
			{
				[CompilerGenerated]
				get
				{
					return this.<ServerConfigName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ServerConfigName>k__BackingField = value;
				}
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x06004CC3 RID: 19651 RVA: 0x002725E8 File Offset: 0x002707E8
			// (set) Token: 0x06004CC4 RID: 19652 RVA: 0x002725FC File Offset: 0x002707FC
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<CurrentPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<CurrentPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06004CC5 RID: 19653 RVA: 0x00272610 File Offset: 0x00270810
			// (set) Token: 0x06004CC6 RID: 19654 RVA: 0x00272624 File Offset: 0x00270824
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<DefaultPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DefaultPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x06004CC7 RID: 19655 RVA: 0x00272638 File Offset: 0x00270838
			public bool GetRemappedSliderValueFor(int playerIndex, [Out] float value)
			{
				/*
An exception occurred when decompiling this method (06004CC7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Creative.CreativePowers/APerPlayerSliderPower::GetRemappedSliderValueFor(System.Int32,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:float32[](var_2_12, ldfld:float32[](APerPlayerSliderPower::_cachePerPlayer, ldloc:APerPlayerSliderPower(this)))
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

			// Token: 0x06004CC8 RID: 19656
			public abstract float RemapSliderValueToPowerValue(float sliderValue);

			// Token: 0x06004CC9 RID: 19657 RVA: 0x0027265C File Offset: 0x0027085C
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				bool netHost = Main.NetHost;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, userId);
				if (this._cachePerPlayer == null)
				{
				}
				int myPlayer = Main.myPlayer;
			}

			// Token: 0x06004CCA RID: 19658
			internal abstract void UpdateInfoFromSliderValueCache();

			// Token: 0x06004CCB RID: 19659 RVA: 0x000021DB File Offset: 0x000003DB
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004CCC RID: 19660 RVA: 0x0027268C File Offset: 0x0027088C
			public void DebugCall()
			{
				ushort num = this.<PowerId>k__BackingField;
				if (!true)
				{
				}
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num, 5).Writer;
				int myPlayer = Main.myPlayer;
			}

			// Token: 0x06004CCD RID: 19661
			public abstract UIElement ProvideSlider();

			// Token: 0x06004CCE RID: 19662 RVA: 0x002726B8 File Offset: 0x002708B8
			internal float GetSliderValue()
			{
				/*
An exception occurred when decompiling this method (06004CCE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Creative.CreativePowers/APerPlayerSliderPower::GetSliderValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(Main::get_NetClientOnly))
	brtrue(IL_0000, logicnot:bool(ldfld:bool(APerPlayerSliderPower::_needsToCommitChange, ldloc:APerPlayerSliderPower(this))))
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

			// Token: 0x06004CCF RID: 19663 RVA: 0x002726D8 File Offset: 0x002708D8
			internal void SetValueKeyboard(float value)
			{
				if (this._needsToCommitChange)
				{
					float currentTargetValue = this._currentTargetValue;
					return;
				}
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
				int myPlayer = Main.myPlayer;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, myPlayer);
				this._needsToCommitChange = true;
			}

			// Token: 0x06004CD0 RID: 19664 RVA: 0x00272714 File Offset: 0x00270914
			internal void SetValueGamepad()
			{
				float sliderValue = this.GetSliderValue();
			}

			// Token: 0x06004CD1 RID: 19665 RVA: 0x00272728 File Offset: 0x00270928
			public void PushChangeAndSetSlider(float value)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, myPlayer);
				float num;
				this.PushChange(num);
			}

			// Token: 0x06004CD2 RID: 19666 RVA: 0x00272754 File Offset: 0x00270954
			public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
			{
				if (!true)
				{
				}
				UIImageFramed iconImage = CreativePowersHelper.GetIconImage(this._iconLocation);
				GroupOptionButton groupOptionButton;
				groupOptionButton.Append(iconImage);
				return groupOptionButton;
			}

			// Token: 0x06004CD3 RID: 19667 RVA: 0x00272778 File Offset: 0x00270978
			private void categoryButton_OnUpdate(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					return;
				}
				this.AttemptPushingChange();
			}

			// Token: 0x06004CD4 RID: 19668 RVA: 0x002727D8 File Offset: 0x002709D8
			public void AttemptPushingChange()
			{
				if (this._needsToCommitChange)
				{
					DateTime utcNow = DateTime.UtcNow;
					DateTime nextTimeWeCanPush = this._nextTimeWeCanPush;
					int num = utcNow.CompareTo(nextTimeWeCanPush);
					float currentTargetValue = this._currentTargetValue;
				}
			}

			// Token: 0x06004CD5 RID: 19669 RVA: 0x0027280C File Offset: 0x00270A0C
			internal void PushChange(float newSliderValue)
			{
				if (!true)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				this._nextTimeWeCanPush = utcNow;
				ushort num = this.<PowerId>k__BackingField;
				if (!true)
				{
				}
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num, 5).Writer;
				int myPlayer = Main.myPlayer;
			}

			// Token: 0x06004CD6 RID: 19670 RVA: 0x0027284C File Offset: 0x00270A4C
			public virtual void Reset()
			{
				float[] cachePerPlayer = this._cachePerPlayer;
				float[] cachePerPlayer2 = this._cachePerPlayer;
			}

			// Token: 0x06004CD7 RID: 19671 RVA: 0x0027286C File Offset: 0x00270A6C
			public virtual void ResetForPlayer(int playerIndex)
			{
				float[] cachePerPlayer = this._cachePerPlayer;
				float sliderDefaultValue = this._sliderDefaultValue;
				if (cachePerPlayer == null)
				{
				}
				int myPlayer = Main.myPlayer;
				float sliderDefaultValue2 = this._sliderDefaultValue;
				this._sliderCurrentValueCache = sliderDefaultValue2;
				this._currentTargetValue = sliderDefaultValue2;
			}

			// Token: 0x06004CD8 RID: 19672 RVA: 0x002728A8 File Offset: 0x00270AA8
			public void OnPlayerJoining(int playerIndex)
			{
			}

			// Token: 0x06004CD9 RID: 19673
			public abstract bool GetIsUnlocked();

			// Token: 0x06004CDA RID: 19674 RVA: 0x002728B8 File Offset: 0x00270AB8
			protected APerPlayerSliderPower()
			{
				if (!true)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				this._nextTimeWeCanPush = utcNow;
				base..ctor();
			}

			// Token: 0x04008675 RID: 34421
			[CompilerGenerated]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008676 RID: 34422
			[CompilerGenerated]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008677 RID: 34423
			[CompilerGenerated]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008678 RID: 34424
			[CompilerGenerated]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008679 RID: 34425
			internal Point _iconLocation;

			// Token: 0x0400867A RID: 34426
			internal float _sliderCurrentValueCache;

			// Token: 0x0400867B RID: 34427
			internal string _powerNameKey;

			// Token: 0x0400867C RID: 34428
			internal float[] _cachePerPlayer;

			// Token: 0x0400867D RID: 34429
			internal float _sliderDefaultValue;

			// Token: 0x0400867E RID: 34430
			private float _currentTargetValue;

			// Token: 0x0400867F RID: 34431
			private bool _needsToCommitChange;

			// Token: 0x04008680 RID: 34432
			private DateTime _nextTimeWeCanPush;
		}

		// Token: 0x02000A3A RID: 2618
		public abstract class ASharedButtonPower : ICreativePower
		{
			// Token: 0x17000883 RID: 2179
			// (get) Token: 0x06004CDB RID: 19675 RVA: 0x002728E0 File Offset: 0x00270AE0
			// (set) Token: 0x06004CDC RID: 19676 RVA: 0x002728F4 File Offset: 0x00270AF4
			public ushort PowerId
			{
				[CompilerGenerated]
				get
				{
					return this.<PowerId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PowerId>k__BackingField = value;
				}
			}

			// Token: 0x17000884 RID: 2180
			// (get) Token: 0x06004CDD RID: 19677 RVA: 0x00272908 File Offset: 0x00270B08
			// (set) Token: 0x06004CDE RID: 19678 RVA: 0x0027291C File Offset: 0x00270B1C
			public string ServerConfigName
			{
				[CompilerGenerated]
				get
				{
					return this.<ServerConfigName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ServerConfigName>k__BackingField = value;
				}
			}

			// Token: 0x17000885 RID: 2181
			// (get) Token: 0x06004CDF RID: 19679 RVA: 0x00272930 File Offset: 0x00270B30
			// (set) Token: 0x06004CE0 RID: 19680 RVA: 0x00272944 File Offset: 0x00270B44
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<CurrentPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<CurrentPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x00272958 File Offset: 0x00270B58
			// (set) Token: 0x06004CE2 RID: 19682 RVA: 0x0027296C File Offset: 0x00270B6C
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<DefaultPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DefaultPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x06004CE3 RID: 19683 RVA: 0x00272980 File Offset: 0x00270B80
			public ASharedButtonPower()
			{
			}

			// Token: 0x06004CE4 RID: 19684 RVA: 0x00272994 File Offset: 0x00270B94
			public void RequestUse()
			{
				ushort num = this.<PowerId>k__BackingField;
				if (!true)
				{
				}
				long num2 = 0L;
				NetPacket netPacket = NetCreativePowersModule.PreparePacket(num, (int)num2);
				if (!true)
				{
				}
			}

			// Token: 0x06004CE5 RID: 19685 RVA: 0x002729B8 File Offset: 0x00270BB8
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				if (!true)
				{
				}
				bool netHost = Main.NetHost;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, userId);
			}

			// Token: 0x06004CE6 RID: 19686
			internal abstract void UsePower();

			// Token: 0x06004CE7 RID: 19687
			internal abstract void OnCreation();

			// Token: 0x06004CE8 RID: 19688 RVA: 0x000021DB File Offset: 0x000003DB
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004CE9 RID: 19689 RVA: 0x002729DC File Offset: 0x00270BDC
			private void button_OnUpdate(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string textValue = Language.GetTextValue(this._powerNameKey);
					string descriptionKey = this._descriptionKey;
					string powerNameKey = this._powerNameKey;
					string text = powerNameKey + "_Unlock";
					CreativePowersHelper.AddPermissionTextIfNeeded(this, "_Unlock");
					if (powerNameKey == null)
					{
					}
				}
			}

			// Token: 0x06004CEA RID: 19690 RVA: 0x00272A28 File Offset: 0x00270C28
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, myPlayer);
				this.RequestUse();
			}

			// Token: 0x06004CEB RID: 19691
			public abstract bool GetIsUnlocked();

			// Token: 0x04008681 RID: 34433
			[CompilerGenerated]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008682 RID: 34434
			[CompilerGenerated]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x04008683 RID: 34435
			[CompilerGenerated]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008684 RID: 34436
			[CompilerGenerated]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008685 RID: 34437
			internal Point _iconLocation;

			// Token: 0x04008686 RID: 34438
			internal string _powerNameKey;

			// Token: 0x04008687 RID: 34439
			internal string _descriptionKey;
		}

		// Token: 0x02000A3B RID: 2619
		public abstract class ASharedTogglePower : ICreativePower, IOnPlayerJoining
		{
			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06004CEC RID: 19692 RVA: 0x00272A50 File Offset: 0x00270C50
			// (set) Token: 0x06004CED RID: 19693 RVA: 0x00272A64 File Offset: 0x00270C64
			public ushort PowerId
			{
				[CompilerGenerated]
				get
				{
					return this.<PowerId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PowerId>k__BackingField = value;
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06004CEE RID: 19694 RVA: 0x00272A78 File Offset: 0x00270C78
			// (set) Token: 0x06004CEF RID: 19695 RVA: 0x00272A8C File Offset: 0x00270C8C
			public string ServerConfigName
			{
				[CompilerGenerated]
				get
				{
					return this.<ServerConfigName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ServerConfigName>k__BackingField = value;
				}
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x00272AA0 File Offset: 0x00270CA0
			// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x00272AB4 File Offset: 0x00270CB4
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<CurrentPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<CurrentPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x00272AC8 File Offset: 0x00270CC8
			// (set) Token: 0x06004CF3 RID: 19699 RVA: 0x00272ADC File Offset: 0x00270CDC
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<DefaultPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DefaultPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x00272AF0 File Offset: 0x00270CF0
			// (set) Token: 0x06004CF5 RID: 19701 RVA: 0x00272B04 File Offset: 0x00270D04
			public bool Enabled
			{
				[CompilerGenerated]
				get
				{
					return this.<Enabled>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06004CF6 RID: 19702 RVA: 0x00272B14 File Offset: 0x00270D14
			public void SetPowerInfo(bool enabled)
			{
			}

			// Token: 0x06004CF7 RID: 19703 RVA: 0x00272B24 File Offset: 0x00270D24
			public void Reset()
			{
			}

			// Token: 0x06004CF8 RID: 19704 RVA: 0x00272B34 File Offset: 0x00270D34
			public void OnPlayerJoining(int playerIndex)
			{
				ushort num = this.<PowerId>k__BackingField;
				if (!true)
				{
				}
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num, 1).Writer;
				bool flag = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004CF9 RID: 19705 RVA: 0x00272B60 File Offset: 0x00270D60
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				bool netHost = Main.NetHost;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, userId);
				bool netHost2 = Main.NetHost;
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(this.<PowerId>k__BackingField, 1).Writer;
				bool flag2 = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004CFA RID: 19706 RVA: 0x00272BA4 File Offset: 0x00270DA4
			public void RequestUse()
			{
				ushort num = this.<PowerId>k__BackingField;
				if (!true)
				{
				}
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num, 1).Writer;
				bool flag = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004CFB RID: 19707 RVA: 0x000021DB File Offset: 0x000003DB
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004CFC RID: 19708 RVA: 0x00272BD0 File Offset: 0x00270DD0
			private void button_OnUpdate(UIElement affectedElement)
			{
				bool flag = this.<Enabled>k__BackingField;
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string text;
					string textValue = Language.GetTextValue(text);
					CreativePowersHelper.AddPermissionTextIfNeeded(this, "_Unlock");
				}
			}

			// Token: 0x06004CFD RID: 19709 RVA: 0x00272C00 File Offset: 0x00270E00
			private void button_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, myPlayer);
				this.RequestUse();
			}

			// Token: 0x06004CFE RID: 19710
			internal abstract void CustomizeButton(UIElement button);

			// Token: 0x06004CFF RID: 19711
			internal abstract string GetButtonTextKey();

			// Token: 0x06004D00 RID: 19712
			public abstract bool GetIsUnlocked();

			// Token: 0x06004D01 RID: 19713 RVA: 0x00272C28 File Offset: 0x00270E28
			protected ASharedTogglePower()
			{
			}

			// Token: 0x04008688 RID: 34440
			[CompilerGenerated]
			private ushort <PowerId>k__BackingField;

			// Token: 0x04008689 RID: 34441
			[CompilerGenerated]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400868A RID: 34442
			[CompilerGenerated]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x0400868B RID: 34443
			[CompilerGenerated]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x0400868C RID: 34444
			[CompilerGenerated]
			private bool <Enabled>k__BackingField;
		}

		// Token: 0x02000A3C RID: 2620
		public abstract class ASharedSliderPower : ICreativePower, IOnPlayerJoining, IProvideSliderElement, IPowerSubcategoryElement
		{
			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06004D02 RID: 19714 RVA: 0x00272C3C File Offset: 0x00270E3C
			// (set) Token: 0x06004D03 RID: 19715 RVA: 0x00272C50 File Offset: 0x00270E50
			public ushort PowerId
			{
				[CompilerGenerated]
				get
				{
					return this.<PowerId>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<PowerId>k__BackingField = value;
				}
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06004D04 RID: 19716 RVA: 0x00272C64 File Offset: 0x00270E64
			// (set) Token: 0x06004D05 RID: 19717 RVA: 0x00272C78 File Offset: 0x00270E78
			public string ServerConfigName
			{
				[CompilerGenerated]
				get
				{
					return this.<ServerConfigName>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ServerConfigName>k__BackingField = value;
				}
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06004D06 RID: 19718 RVA: 0x00272C8C File Offset: 0x00270E8C
			// (set) Token: 0x06004D07 RID: 19719 RVA: 0x00272CA0 File Offset: 0x00270EA0
			public PowerPermissionLevel CurrentPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<CurrentPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<CurrentPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06004D08 RID: 19720 RVA: 0x00272CB4 File Offset: 0x00270EB4
			// (set) Token: 0x06004D09 RID: 19721 RVA: 0x00272CC8 File Offset: 0x00270EC8
			public PowerPermissionLevel DefaultPermissionLevel
			{
				[CompilerGenerated]
				get
				{
					return this.<DefaultPermissionLevel>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<DefaultPermissionLevel>k__BackingField = value;
				}
			}

			// Token: 0x06004D0A RID: 19722 RVA: 0x00272CDC File Offset: 0x00270EDC
			public void DeserializeNetMessage(BinaryReader reader, int userId)
			{
				bool netHost = Main.NetHost;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, userId);
				bool netHost2 = Main.NetHost;
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(this.<PowerId>k__BackingField, 4).Writer;
			}

			// Token: 0x06004D0B RID: 19723
			internal abstract void UpdateInfoFromSliderValueCache();

			// Token: 0x06004D0C RID: 19724 RVA: 0x000021DB File Offset: 0x000003DB
			public void ProvidePowerButtons(CreativePowerUIElementRequestInfo info, List<UIElement> elements)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004D0D RID: 19725 RVA: 0x00272D18 File Offset: 0x00270F18
			public void DebugCall()
			{
				ushort num = this.<PowerId>k__BackingField;
				if (!true)
				{
				}
				BinaryWriter writer = NetCreativePowersModule.PreparePacket(num, 4).Writer;
			}

			// Token: 0x06004D0E RID: 19726
			public abstract UIElement ProvideSlider();

			// Token: 0x06004D0F RID: 19727 RVA: 0x00272D3C File Offset: 0x00270F3C
			internal float GetSliderValue()
			{
				/*
An exception occurred when decompiling this method (06004D0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Creative.CreativePowers/ASharedSliderPower::GetSliderValue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, callgetter:bool(Main::get_NetClientOnly))
	stloc:bool(var_2_11, ldfld:bool(ASharedSliderPower::_needsToCommitChange, ldloc:ASharedSliderPower(this)))
	stloc:float32(var_3_18, ldfld:float32(ASharedSliderPower::_currentTargetValue, ldloc:ASharedSliderPower(this)))
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

			// Token: 0x06004D10 RID: 19728 RVA: 0x00272D64 File Offset: 0x00270F64
			internal virtual float GetSliderValueInner()
			{
				/*
An exception occurred when decompiling this method (06004D10)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Creative.CreativePowers/ASharedSliderPower::GetSliderValueInner()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(ASharedSliderPower::_sliderCurrentValueCache, ldloc:ASharedSliderPower(this)))
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

			// Token: 0x06004D11 RID: 19729 RVA: 0x00272D78 File Offset: 0x00270F78
			internal void SetValueKeyboard(float value)
			{
				if (this._needsToCommitChange)
				{
					float currentTargetValue = this._currentTargetValue;
					return;
				}
				this.SetValueKeyboardForced(value);
			}

			// Token: 0x06004D12 RID: 19730 RVA: 0x00272DA0 File Offset: 0x00270FA0
			internal void SetValueKeyboardForced(float value)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag = CreativePowersHelper.IsAvailableForPlayer(this, myPlayer);
				this._needsToCommitChange = true;
			}

			// Token: 0x06004D13 RID: 19731 RVA: 0x00272DC8 File Offset: 0x00270FC8
			internal void SetValueGamepad()
			{
				float sliderValue = this.GetSliderValue();
			}

			// Token: 0x06004D14 RID: 19732 RVA: 0x00272DDC File Offset: 0x00270FDC
			public GroupOptionButton<int> GetOptionButton(CreativePowerUIElementRequestInfo info, int optionIndex, int currentOptionIndex)
			{
				if (!true)
				{
				}
				UIImageFramed iconImage = CreativePowersHelper.GetIconImage(this._iconLocation);
				GroupOptionButton groupOptionButton;
				groupOptionButton.Append(iconImage);
				return groupOptionButton;
			}

			// Token: 0x06004D15 RID: 19733 RVA: 0x00272E00 File Offset: 0x00271000
			private void categoryButton_OnUpdate(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					return;
				}
				this.AttemptPushingChange();
			}

			// Token: 0x06004D16 RID: 19734 RVA: 0x00272E60 File Offset: 0x00271060
			public void AttemptPushingChange()
			{
				bool needsToCommitChange = this._needsToCommitChange;
				if (needsToCommitChange)
				{
					if (!needsToCommitChange)
					{
					}
					DateTime utcNow = DateTime.UtcNow;
					DateTime nextTimeWeCanPush = this._nextTimeWeCanPush;
					int num = utcNow.CompareTo(nextTimeWeCanPush);
					float currentTargetValue = this._currentTargetValue;
					this._sliderCurrentValueCache = currentTargetValue;
					if (currentTargetValue == null)
					{
					}
					DateTime utcNow2 = DateTime.UtcNow;
					this._nextTimeWeCanPush = utcNow2;
					ushort num2 = this.<PowerId>k__BackingField;
					if (currentTargetValue == null)
					{
					}
					BinaryWriter writer = NetCreativePowersModule.PreparePacket(num2, 4).Writer;
					float currentTargetValue2 = this._currentTargetValue;
				}
			}

			// Token: 0x06004D17 RID: 19735 RVA: 0x00272EDC File Offset: 0x002710DC
			public virtual void Reset()
			{
			}

			// Token: 0x06004D18 RID: 19736 RVA: 0x00272EEC File Offset: 0x002710EC
			public void OnPlayerJoining(int playerIndex)
			{
				if (this._syncToJoiningPlayers)
				{
					BinaryWriter writer = NetCreativePowersModule.PreparePacket(this.<PowerId>k__BackingField, 4).Writer;
					float sliderCurrentValueCache = this._sliderCurrentValueCache;
				}
			}

			// Token: 0x06004D19 RID: 19737
			public abstract bool GetIsUnlocked();

			// Token: 0x06004D1A RID: 19738 RVA: 0x00272F1C File Offset: 0x0027111C
			protected ASharedSliderPower()
			{
				if (!true)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				this._nextTimeWeCanPush = utcNow;
				base..ctor();
			}

			// Token: 0x0400868D RID: 34445
			[CompilerGenerated]
			private ushort <PowerId>k__BackingField;

			// Token: 0x0400868E RID: 34446
			[CompilerGenerated]
			private string <ServerConfigName>k__BackingField;

			// Token: 0x0400868F RID: 34447
			[CompilerGenerated]
			private PowerPermissionLevel <CurrentPermissionLevel>k__BackingField;

			// Token: 0x04008690 RID: 34448
			[CompilerGenerated]
			private PowerPermissionLevel <DefaultPermissionLevel>k__BackingField;

			// Token: 0x04008691 RID: 34449
			internal Point _iconLocation;

			// Token: 0x04008692 RID: 34450
			internal float _sliderCurrentValueCache;

			// Token: 0x04008693 RID: 34451
			internal string _powerNameKey;

			// Token: 0x04008694 RID: 34452
			internal bool _syncToJoiningPlayers = true;

			// Token: 0x04008695 RID: 34453
			internal float _currentTargetValue;

			// Token: 0x04008696 RID: 34454
			private bool _needsToCommitChange;

			// Token: 0x04008697 RID: 34455
			private DateTime _nextTimeWeCanPush;
		}

		// Token: 0x02000A3D RID: 2621
		public class GodmodePower : CreativePowers.APerPlayerTogglePower, IPersistentPerPlayerContent
		{
			// Token: 0x06004D1B RID: 19739 RVA: 0x00272F48 File Offset: 0x00271148
			public GodmodePower()
			{
				this._powerNameKey = "CreativePowers.Godmode";
				if ("CreativePowers.Godmode" == null)
				{
				}
				this._iconLocation = "CreativePowers.Godmode";
			}

			// Token: 0x06004D1C RID: 19740 RVA: 0x00272F78 File Offset: 0x00271178
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D1D RID: 19741 RVA: 0x00272F88 File Offset: 0x00271188
			public void Save(Player player, BinaryWriter writer)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag = base.IsEnabledForPlayer(myPlayer);
			}

			// Token: 0x06004D1E RID: 19742 RVA: 0x00272FA8 File Offset: 0x002711A8
			public void ResetDataForNewPlayer(Player player)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
				bool defaultToggleState = this._defaultToggleState;
				savedPerPlayerFieldsThatArentInThePlayerClass.godmodePowerEnabled = defaultToggleState;
			}

			// Token: 0x06004D1F RID: 19743 RVA: 0x00272FCC File Offset: 0x002711CC
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
			}

			// Token: 0x06004D20 RID: 19744 RVA: 0x00272FE0 File Offset: 0x002711E0
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
				int whoAmI = player.whoAmI;
				bool godmodePowerEnabled = savedPerPlayerFieldsThatArentInThePlayerClass.godmodePowerEnabled;
				bool flag = base.IsEnabledForPlayer(whoAmI);
			}
		}

		// Token: 0x02000A3E RID: 2622
		public class FarPlacementRangePower : CreativePowers.APerPlayerTogglePower, IPersistentPerPlayerContent
		{
			// Token: 0x06004D21 RID: 19745 RVA: 0x00273014 File Offset: 0x00271214
			public FarPlacementRangePower()
			{
				this._powerNameKey = "CreativePowers.InfinitePlacementRange";
				if ("CreativePowers.InfinitePlacementRange" == null)
				{
				}
				this._iconLocation = "CreativePowers.InfinitePlacementRange";
				DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
				DrPlatform.DrPlatformType currentPlatform2 = DrPlatform.CurrentPlatform;
			}

			// Token: 0x06004D22 RID: 19746 RVA: 0x0027306C File Offset: 0x0027126C
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D23 RID: 19747 RVA: 0x0027307C File Offset: 0x0027127C
			public void Save(Player player, BinaryWriter writer)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				bool flag = base.IsEnabledForPlayer(myPlayer);
			}

			// Token: 0x06004D24 RID: 19748 RVA: 0x0027309C File Offset: 0x0027129C
			public void ResetDataForNewPlayer(Player player)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
				bool defaultToggleState = this._defaultToggleState;
				savedPerPlayerFieldsThatArentInThePlayerClass.farPlacementRangePowerEnabled = defaultToggleState;
			}

			// Token: 0x06004D25 RID: 19749 RVA: 0x002730C0 File Offset: 0x002712C0
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
			}

			// Token: 0x06004D26 RID: 19750 RVA: 0x002730D4 File Offset: 0x002712D4
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
				int whoAmI = player.whoAmI;
				bool farPlacementRangePowerEnabled = savedPerPlayerFieldsThatArentInThePlayerClass.farPlacementRangePowerEnabled;
				bool flag = base.IsEnabledForPlayer(whoAmI);
			}
		}

		// Token: 0x02000A3F RID: 2623
		public class StartDayImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x06004D27 RID: 19751 RVA: 0x00273108 File Offset: 0x00271308
			internal override void UsePower()
			{
				if (!true)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
			}

			// Token: 0x06004D28 RID: 19752 RVA: 0x0027312C File Offset: 0x0027132C
			internal override void OnCreation()
			{
				this._powerNameKey = "CreativePowers.StartDayImmediately";
				string text = "CreativePowers.StartDayImmediately" + "_Description";
				this._descriptionKey = text;
				if (!true)
				{
				}
				this._iconLocation = 1;
			}

			// Token: 0x06004D29 RID: 19753 RVA: 0x00273168 File Offset: 0x00271368
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D2A RID: 19754 RVA: 0x00273178 File Offset: 0x00271378
			public StartDayImmediately()
			{
			}
		}

		// Token: 0x02000A40 RID: 2624
		public class StartNightImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x06004D2B RID: 19755 RVA: 0x0027318C File Offset: 0x0027138C
			internal override void UsePower()
			{
				if (!true)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
			}

			// Token: 0x06004D2C RID: 19756 RVA: 0x002731B4 File Offset: 0x002713B4
			internal override void OnCreation()
			{
				this._powerNameKey = "CreativePowers.StartNightImmediately";
				string text = "CreativePowers.StartNightImmediately" + "_Description";
				this._descriptionKey = text;
				if (!true)
				{
				}
				this._iconLocation = 1;
			}

			// Token: 0x06004D2D RID: 19757 RVA: 0x002731F0 File Offset: 0x002713F0
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D2E RID: 19758 RVA: 0x00273200 File Offset: 0x00271400
			public StartNightImmediately()
			{
			}
		}

		// Token: 0x02000A41 RID: 2625
		public class StartNoonImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x06004D2F RID: 19759 RVA: 0x00273214 File Offset: 0x00271414
			internal override void UsePower()
			{
				if (!true)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
			}

			// Token: 0x06004D30 RID: 19760 RVA: 0x0027323C File Offset: 0x0027143C
			internal override void OnCreation()
			{
				this._powerNameKey = "CreativePowers.StartNoonImmediately";
				string text = "CreativePowers.StartNoonImmediately" + "_Description";
				this._descriptionKey = text;
				if (!true)
				{
				}
				this._iconLocation = 1;
			}

			// Token: 0x06004D31 RID: 19761 RVA: 0x00273278 File Offset: 0x00271478
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D32 RID: 19762 RVA: 0x00273288 File Offset: 0x00271488
			public StartNoonImmediately()
			{
			}
		}

		// Token: 0x02000A42 RID: 2626
		public class StartMidnightImmediately : CreativePowers.ASharedButtonPower
		{
			// Token: 0x06004D33 RID: 19763 RVA: 0x0027329C File Offset: 0x0027149C
			internal override void UsePower()
			{
				if (!true)
				{
				}
				bool netClientOnly = Main.NetClientOnly;
			}

			// Token: 0x06004D34 RID: 19764 RVA: 0x002732C8 File Offset: 0x002714C8
			internal override void OnCreation()
			{
				this._powerNameKey = "CreativePowers.StartMidnightImmediately";
				string text = "CreativePowers.StartMidnightImmediately" + "_Description";
				this._descriptionKey = text;
				if (!true)
				{
				}
				this._iconLocation = 1;
			}

			// Token: 0x06004D35 RID: 19765 RVA: 0x00273304 File Offset: 0x00271504
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D36 RID: 19766 RVA: 0x00273314 File Offset: 0x00271514
			public StartMidnightImmediately()
			{
			}
		}

		// Token: 0x02000A43 RID: 2627
		public class ModifyTimeRate : CreativePowers.ASharedSliderPower, IPersistentPerWorldContent
		{
			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06004D37 RID: 19767 RVA: 0x00273328 File Offset: 0x00271528
			// (set) Token: 0x06004D38 RID: 19768 RVA: 0x0027333C File Offset: 0x0027153C
			public int TargetTimeRate
			{
				[CompilerGenerated]
				get
				{
					return this.<TargetTimeRate>k__BackingField;
				}
				[CompilerGenerated]
				private set
				{
					this.<TargetTimeRate>k__BackingField = value;
				}
			}

			// Token: 0x06004D39 RID: 19769 RVA: 0x00273350 File Offset: 0x00271550
			public ModifyTimeRate()
			{
				this._powerNameKey = "CreativePowers.ModifyTimeRate";
				if ("CreativePowers.ModifyTimeRate" == null)
				{
				}
				this._iconLocation = "CreativePowers.ModifyTimeRate";
			}

			// Token: 0x06004D3A RID: 19770 RVA: 0x00273380 File Offset: 0x00271580
			public override void Reset()
			{
				this.<TargetTimeRate>k__BackingField = 1;
			}

			// Token: 0x06004D3B RID: 19771 RVA: 0x00273394 File Offset: 0x00271594
			internal override void UpdateInfoFromSliderValueCache()
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
				if (!true)
				{
				}
				if (!true)
				{
				}
			}

			// Token: 0x06004D3C RID: 19772 RVA: 0x002733BC File Offset: 0x002715BC
			public override UIElement ProvideSlider()
			{
			}

			// Token: 0x06004D3D RID: 19773 RVA: 0x002733D4 File Offset: 0x002715D4
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D3E RID: 19774 RVA: 0x002733E4 File Offset: 0x002715E4
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D3F RID: 19775 RVA: 0x002733F4 File Offset: 0x002715F4
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D40 RID: 19776 RVA: 0x00273404 File Offset: 0x00271604
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D41 RID: 19777 RVA: 0x00273418 File Offset: 0x00271618
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D42 RID: 19778 RVA: 0x0027342C File Offset: 0x0027162C
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D43 RID: 19779 RVA: 0x0027343C File Offset: 0x0027163C
			public void Save(BinaryWriter writer)
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
			}

			// Token: 0x06004D44 RID: 19780 RVA: 0x00273450 File Offset: 0x00271650
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D45 RID: 19781 RVA: 0x00273460 File Offset: 0x00271660
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D46 RID: 19782 RVA: 0x00273470 File Offset: 0x00271670
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					int num = this.<TargetTimeRate>k__BackingField;
					string text2;
					string text = "x" + text2;
					CreativePowersHelper.AddPermissionTextIfNeeded(this, text2);
				}
			}

			// Token: 0x04008698 RID: 34456
			[CompilerGenerated]
			private int <TargetTimeRate>k__BackingField;
		}

		// Token: 0x02000A44 RID: 2628
		public class DifficultySliderPower : CreativePowers.ASharedSliderPower, IPersistentPerWorldContent
		{
			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06004D47 RID: 19783 RVA: 0x002734A0 File Offset: 0x002716A0
			// (set) Token: 0x06004D48 RID: 19784 RVA: 0x002734B4 File Offset: 0x002716B4
			public float StrengthMultiplierToGiveNPCs
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (06004D47)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Creative.CreativePowers/DifficultySliderPower::get_StrengthMultiplierToGiveNPCs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(DifficultySliderPower::<StrengthMultiplierToGiveNPCs>k__BackingField, ldloc:DifficultySliderPower(this)))
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
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06004D49 RID: 19785 RVA: 0x002734C4 File Offset: 0x002716C4
			public DifficultySliderPower()
			{
				this._powerNameKey = "CreativePowers.DifficultySlider";
				if ("CreativePowers.DifficultySlider" == null)
				{
				}
				this._iconLocation = "CreativePowers.DifficultySlider";
			}

			// Token: 0x06004D4A RID: 19786 RVA: 0x002734F4 File Offset: 0x002716F4
			public override void Reset()
			{
			}

			// Token: 0x06004D4B RID: 19787 RVA: 0x00273504 File Offset: 0x00271704
			internal override void UpdateInfoFromSliderValueCache()
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
				if (!true)
				{
				}
			}

			// Token: 0x06004D4C RID: 19788 RVA: 0x00273520 File Offset: 0x00271720
			public override UIElement ProvideSlider()
			{
			}

			// Token: 0x06004D4D RID: 19789 RVA: 0x00273530 File Offset: 0x00271730
			private void Click_Master(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D4E RID: 19790 RVA: 0x00273540 File Offset: 0x00271740
			private void Click_Expert(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D4F RID: 19791 RVA: 0x00273550 File Offset: 0x00271750
			private void Click_Normal(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D50 RID: 19792 RVA: 0x00273560 File Offset: 0x00271760
			private void Click_Journey(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D51 RID: 19793 RVA: 0x00273570 File Offset: 0x00271770
			private static void AddIndication(UIPanel panel, float yAnchor, string indicationText, string iconImagePath, UIElement.ElementEvent updateEvent, UIElement.MouseEvent clickEvent)
			{
				if (!true)
				{
				}
			}

			// Token: 0x06004D52 RID: 19794 RVA: 0x00273590 File Offset: 0x00271790
			private static void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D53 RID: 19795 RVA: 0x002735A0 File Offset: 0x002717A0
			private static void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D54 RID: 19796 RVA: 0x002735B0 File Offset: 0x002717B0
			private void MouseOver_Journey(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string textValue = Language.GetTextValue("UI.Creative");
				}
			}

			// Token: 0x06004D55 RID: 19797 RVA: 0x002735D0 File Offset: 0x002717D0
			private void MouseOver_Normal(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string textValue = Language.GetTextValue("UI.Normal");
				}
			}

			// Token: 0x06004D56 RID: 19798 RVA: 0x002735F0 File Offset: 0x002717F0
			private void MouseOver_Expert(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string textValue = Language.GetTextValue("UI.Expert");
				}
			}

			// Token: 0x06004D57 RID: 19799 RVA: 0x00273610 File Offset: 0x00271810
			private void MouseOver_Master(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					string textValue = Language.GetTextValue("UI.Master");
				}
			}

			// Token: 0x06004D58 RID: 19800 RVA: 0x00273630 File Offset: 0x00271830
			private void UpdateSliderColorAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					float num = this.<StrengthMultiplierToGiveNPCs>k__BackingField;
					string text2;
					string text = "x" + text2;
					if (num == null)
					{
					}
					CreativePowersHelper.AddPermissionTextIfNeeded(this, text2);
				}
				bool masterMode = Main.masterMode;
			}

			// Token: 0x06004D59 RID: 19801 RVA: 0x002736A4 File Offset: 0x002718A4
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D5A RID: 19802 RVA: 0x002736B4 File Offset: 0x002718B4
			public void Save(BinaryWriter writer)
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
			}

			// Token: 0x06004D5B RID: 19803 RVA: 0x002736C8 File Offset: 0x002718C8
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D5C RID: 19804 RVA: 0x002736D8 File Offset: 0x002718D8
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x04008699 RID: 34457
			[CompilerGenerated]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}

		// Token: 0x02000A45 RID: 2629
		public class ModifyWindDirectionAndStrength : CreativePowers.ASharedSliderPower
		{
			// Token: 0x06004D5D RID: 19805 RVA: 0x002736E8 File Offset: 0x002718E8
			public ModifyWindDirectionAndStrength()
			{
				this._powerNameKey = "CreativePowers.ModifyWindDirectionAndStrength";
				if ("CreativePowers.ModifyWindDirectionAndStrength" == null)
				{
				}
				this._iconLocation = "CreativePowers.ModifyWindDirectionAndStrength";
			}

			// Token: 0x06004D5E RID: 19806 RVA: 0x00273718 File Offset: 0x00271918
			internal override void UpdateInfoFromSliderValueCache()
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
			}

			// Token: 0x06004D5F RID: 19807 RVA: 0x00273730 File Offset: 0x00271930
			internal override float GetSliderValueInner()
			{
				if (!true)
				{
					return;
				}
			}

			// Token: 0x06004D60 RID: 19808 RVA: 0x00273744 File Offset: 0x00271944
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D61 RID: 19809 RVA: 0x00273754 File Offset: 0x00271954
			public override UIElement ProvideSlider()
			{
				/*
An exception occurred when decompiling this method (06004D61)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Creative.CreativePowers/ModifyWindDirectionAndStrength::ProvideSlider()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LocalizedText(var_2_0C, call:LocalizedText(Language::GetText, ldstr:string("CreativePowers.WindWest")))
	stloc:LocalizedText(var_4_19, call:LocalizedText(Language::GetText, ldstr:string("CreativePowers.WindEast")))
	stloc:LocalizedText(var_6_28, call:LocalizedText(Language::GetText, ldstr:string("CreativePowers.WindNone")))
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

			// Token: 0x06004D62 RID: 19810 RVA: 0x00273790 File Offset: 0x00271990
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D63 RID: 19811 RVA: 0x002737A0 File Offset: 0x002719A0
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D64 RID: 19812 RVA: 0x002737B0 File Offset: 0x002719B0
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D65 RID: 19813 RVA: 0x002737C0 File Offset: 0x002719C0
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D66 RID: 19814 RVA: 0x002737D4 File Offset: 0x002719D4
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D67 RID: 19815 RVA: 0x002737E8 File Offset: 0x002719E8
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				bool <IsMouseHovering>k__BackingField = affectedElement.<IsMouseHovering>k__BackingField;
				if (<IsMouseHovering>k__BackingField)
				{
					if (!<IsMouseHovering>k__BackingField)
					{
					}
					return;
				}
			}
		}

		// Token: 0x02000A46 RID: 2630
		public class ModifyRainPower : CreativePowers.ASharedSliderPower
		{
			// Token: 0x06004D68 RID: 19816 RVA: 0x00273824 File Offset: 0x00271A24
			public ModifyRainPower()
			{
				this._powerNameKey = "CreativePowers.ModifyRainPower";
				if ("CreativePowers.ModifyRainPower" == null)
				{
				}
				this._iconLocation = "CreativePowers.ModifyRainPower";
			}

			// Token: 0x06004D69 RID: 19817 RVA: 0x00273854 File Offset: 0x00271A54
			internal override void UpdateInfoFromSliderValueCache()
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
				if (!true)
				{
				}
				Main.StopRain();
			}

			// Token: 0x06004D6A RID: 19818 RVA: 0x0027388C File Offset: 0x00271A8C
			internal override float GetSliderValueInner()
			{
				/*
An exception occurred when decompiling this method (06004D6A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Creative.CreativePowers/ModifyRainPower::GetSliderValueInner()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

			// Token: 0x06004D6B RID: 19819 RVA: 0x0027389C File Offset: 0x00271A9C
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D6C RID: 19820 RVA: 0x002738AC File Offset: 0x00271AAC
			public override UIElement ProvideSlider()
			{
				/*
An exception occurred when decompiling this method (06004D6C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.UIElement Terraria.GameContent.Creative.CreativePowers/ModifyRainPower::ProvideSlider()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LocalizedText(var_2_0C, call:LocalizedText(Language::GetText, ldstr:string("CreativePowers.WeatherMonsoon")))
	stloc:LocalizedText(var_4_19, call:LocalizedText(Language::GetText, ldstr:string("CreativePowers.WeatherClearSky")))
	stloc:LocalizedText(var_6_28, call:LocalizedText(Language::GetText, ldstr:string("CreativePowers.WeatherDrizzle")))
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

			// Token: 0x06004D6D RID: 19821 RVA: 0x002738E8 File Offset: 0x00271AE8
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D6E RID: 19822 RVA: 0x002738F8 File Offset: 0x00271AF8
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D6F RID: 19823 RVA: 0x00273908 File Offset: 0x00271B08
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D70 RID: 19824 RVA: 0x00273918 File Offset: 0x00271B18
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D71 RID: 19825 RVA: 0x0027392C File Offset: 0x00271B2C
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D72 RID: 19826 RVA: 0x00273940 File Offset: 0x00271B40
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				bool <IsMouseHovering>k__BackingField = affectedElement.<IsMouseHovering>k__BackingField;
				if (<IsMouseHovering>k__BackingField)
				{
					if (!<IsMouseHovering>k__BackingField)
					{
					}
					CreativePowersHelper.AddPermissionTextIfNeeded(this, "P0");
				}
			}
		}

		// Token: 0x02000A47 RID: 2631
		public class FreezeTime : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x06004D73 RID: 19827 RVA: 0x00273968 File Offset: 0x00271B68
			internal override void CustomizeButton(UIElement button)
			{
				if (!true)
				{
				}
				UIImageFramed uiimageFramed;
				button.Append(uiimageFramed);
			}

			// Token: 0x06004D74 RID: 19828 RVA: 0x00273980 File Offset: 0x00271B80
			internal override string GetButtonTextKey()
			{
				return "CreativePowers.FreezeTime";
			}

			// Token: 0x06004D75 RID: 19829 RVA: 0x00273994 File Offset: 0x00271B94
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D76 RID: 19830 RVA: 0x002739A4 File Offset: 0x00271BA4
			public void Save(BinaryWriter writer)
			{
				bool <Enabled>k__BackingField = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004D77 RID: 19831 RVA: 0x002739B8 File Offset: 0x00271BB8
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				this.<Enabled>k__BackingField = reader != null;
			}

			// Token: 0x06004D78 RID: 19832 RVA: 0x002739CC File Offset: 0x00271BCC
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D79 RID: 19833 RVA: 0x002739DC File Offset: 0x00271BDC
			public FreezeTime()
			{
			}
		}

		// Token: 0x02000A48 RID: 2632
		public class FreezeWindDirectionAndStrength : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x06004D7A RID: 19834 RVA: 0x002739F0 File Offset: 0x00271BF0
			internal override void CustomizeButton(UIElement button)
			{
				if (!true)
				{
				}
				UIImageFramed uiimageFramed;
				button.Append(uiimageFramed);
			}

			// Token: 0x06004D7B RID: 19835 RVA: 0x00273A08 File Offset: 0x00271C08
			internal override string GetButtonTextKey()
			{
				return "CreativePowers.FreezeWindDirectionAndStrength";
			}

			// Token: 0x06004D7C RID: 19836 RVA: 0x00273A1C File Offset: 0x00271C1C
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D7D RID: 19837 RVA: 0x00273A2C File Offset: 0x00271C2C
			public void Save(BinaryWriter writer)
			{
				bool <Enabled>k__BackingField = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004D7E RID: 19838 RVA: 0x00273A40 File Offset: 0x00271C40
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				this.<Enabled>k__BackingField = reader != null;
			}

			// Token: 0x06004D7F RID: 19839 RVA: 0x00273A54 File Offset: 0x00271C54
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D80 RID: 19840 RVA: 0x00273A64 File Offset: 0x00271C64
			public FreezeWindDirectionAndStrength()
			{
			}
		}

		// Token: 0x02000A49 RID: 2633
		public class FreezeRainPower : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x06004D81 RID: 19841 RVA: 0x00273A78 File Offset: 0x00271C78
			internal override void CustomizeButton(UIElement button)
			{
				if (!true)
				{
				}
				UIImageFramed uiimageFramed;
				button.Append(uiimageFramed);
			}

			// Token: 0x06004D82 RID: 19842 RVA: 0x00273A90 File Offset: 0x00271C90
			internal override string GetButtonTextKey()
			{
				return "CreativePowers.FreezeRainPower";
			}

			// Token: 0x06004D83 RID: 19843 RVA: 0x00273AA4 File Offset: 0x00271CA4
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D84 RID: 19844 RVA: 0x00273AB4 File Offset: 0x00271CB4
			public void Save(BinaryWriter writer)
			{
				bool <Enabled>k__BackingField = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004D85 RID: 19845 RVA: 0x00273AC8 File Offset: 0x00271CC8
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				this.<Enabled>k__BackingField = reader != null;
			}

			// Token: 0x06004D86 RID: 19846 RVA: 0x00273ADC File Offset: 0x00271CDC
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D87 RID: 19847 RVA: 0x00273AEC File Offset: 0x00271CEC
			public FreezeRainPower()
			{
			}
		}

		// Token: 0x02000A4A RID: 2634
		public class StopBiomeSpreadPower : CreativePowers.ASharedTogglePower, IPersistentPerWorldContent
		{
			// Token: 0x06004D88 RID: 19848 RVA: 0x00273B00 File Offset: 0x00271D00
			internal override void CustomizeButton(UIElement button)
			{
				if (!true)
				{
				}
				UIImageFramed uiimageFramed;
				button.Append(uiimageFramed);
			}

			// Token: 0x06004D89 RID: 19849 RVA: 0x00273B18 File Offset: 0x00271D18
			internal override string GetButtonTextKey()
			{
				return "CreativePowers.StopBiomeSpread";
			}

			// Token: 0x06004D8A RID: 19850 RVA: 0x00273B2C File Offset: 0x00271D2C
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D8B RID: 19851 RVA: 0x00273B3C File Offset: 0x00271D3C
			public void Save(BinaryWriter writer)
			{
				bool <Enabled>k__BackingField = this.<Enabled>k__BackingField;
			}

			// Token: 0x06004D8C RID: 19852 RVA: 0x00273B50 File Offset: 0x00271D50
			public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				this.<Enabled>k__BackingField = reader != null;
			}

			// Token: 0x06004D8D RID: 19853 RVA: 0x00273B64 File Offset: 0x00271D64
			public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
			}

			// Token: 0x06004D8E RID: 19854 RVA: 0x00273B74 File Offset: 0x00271D74
			public StopBiomeSpreadPower()
			{
			}
		}

		// Token: 0x02000A4B RID: 2635
		public class SpawnRateSliderPerPlayerPower : CreativePowers.APerPlayerSliderPower, IPersistentPerPlayerContent
		{
			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06004D8F RID: 19855 RVA: 0x00273B88 File Offset: 0x00271D88
			// (set) Token: 0x06004D90 RID: 19856 RVA: 0x00273B9C File Offset: 0x00271D9C
			public float StrengthMultiplierToGiveNPCs
			{
				[CompilerGenerated]
				get
				{
					/*
An exception occurred when decompiling this method (06004D8F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Creative.CreativePowers/SpawnRateSliderPerPlayerPower::get_StrengthMultiplierToGiveNPCs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SpawnRateSliderPerPlayerPower::<StrengthMultiplierToGiveNPCs>k__BackingField, ldloc:SpawnRateSliderPerPlayerPower(this)))
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
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06004D91 RID: 19857 RVA: 0x00273BAC File Offset: 0x00271DAC
			public SpawnRateSliderPerPlayerPower()
			{
				this._sliderDefaultValue = (float)16128;
				this._powerNameKey = "CreativePowers.NPCSpawnRateSlider";
				if ("CreativePowers.NPCSpawnRateSlider" == null)
				{
				}
				this._iconLocation = "CreativePowers.NPCSpawnRateSlider";
			}

			// Token: 0x06004D92 RID: 19858 RVA: 0x00273BE8 File Offset: 0x00271DE8
			public bool GetShouldDisableSpawnsFor(int playerIndex)
			{
				/*
An exception occurred when decompiling this method (06004D92)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Creative.CreativePowers/SpawnRateSliderPerPlayerPower::GetShouldDisableSpawnsFor(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:int32(var_3_13, callgetter:int32(Main::get_myPlayer))
	stloc:float32(var_4_1A, ldfld:float32(APerPlayerSliderPower::_sliderCurrentValueCache, ldloc:SpawnRateSliderPerPlayerPower[exp:APerPlayerSliderPower](this)))
	stloc:float32[](var_6_25, ldfld:float32[](APerPlayerSliderPower::_cachePerPlayer, ldloc:SpawnRateSliderPerPlayerPower[exp:APerPlayerSliderPower](this)))
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

			// Token: 0x06004D93 RID: 19859 RVA: 0x00273C1C File Offset: 0x00271E1C
			internal override void UpdateInfoFromSliderValueCache()
			{
			}

			// Token: 0x06004D94 RID: 19860 RVA: 0x00273C2C File Offset: 0x00271E2C
			public override float RemapSliderValueToPowerValue(float sliderValue)
			{
				if (!true)
				{
				}
				return float.Epsilon;
			}

			// Token: 0x06004D95 RID: 19861 RVA: 0x00273C48 File Offset: 0x00271E48
			public override UIElement ProvideSlider()
			{
			}

			// Token: 0x06004D96 RID: 19862 RVA: 0x00273C60 File Offset: 0x00271E60
			private void Button_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D97 RID: 19863 RVA: 0x00273C74 File Offset: 0x00271E74
			private void Button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
			{
				if (listeningElement != null)
				{
				}
			}

			// Token: 0x06004D98 RID: 19864 RVA: 0x00273C88 File Offset: 0x00271E88
			private void topText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D99 RID: 19865 RVA: 0x00273C98 File Offset: 0x00271E98
			private void middleText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D9A RID: 19866 RVA: 0x00273CA8 File Offset: 0x00271EA8
			private void bottomText_OnClick(UIMouseEvent evt, UIElement listeningElement)
			{
			}

			// Token: 0x06004D9B RID: 19867 RVA: 0x00273CB8 File Offset: 0x00271EB8
			private void UpdateSliderAndShowMultiplierMouseOver(UIElement affectedElement)
			{
				if (affectedElement.<IsMouseHovering>k__BackingField)
				{
					float sliderValue = base.GetSliderValue();
					string text2;
					string text = "x" + text2;
					int myPlayer = Main.myPlayer;
					bool shouldDisableSpawnsFor = this.GetShouldDisableSpawnsFor(myPlayer);
					string textValue = Language.GetTextValue(this._powerNameKey + "EnemySpawnsDisabled");
					if ("EnemySpawnsDisabled" == null)
					{
					}
					if ("EnemySpawnsDisabled" == null)
					{
					}
				}
			}

			// Token: 0x06004D9C RID: 19868 RVA: 0x00273D18 File Offset: 0x00271F18
			public override bool GetIsUnlocked()
			{
				return true;
			}

			// Token: 0x06004D9D RID: 19869 RVA: 0x00273D28 File Offset: 0x00271F28
			public void Save(Player player, BinaryWriter writer)
			{
				float sliderCurrentValueCache = this._sliderCurrentValueCache;
			}

			// Token: 0x06004D9E RID: 19870 RVA: 0x00273D3C File Offset: 0x00271F3C
			public void ResetDataForNewPlayer(Player player)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
				float sliderDefaultValue = this._sliderDefaultValue;
				savedPerPlayerFieldsThatArentInThePlayerClass.spawnRatePowerSliderValue = sliderDefaultValue;
			}

			// Token: 0x06004D9F RID: 19871 RVA: 0x00273D60 File Offset: 0x00271F60
			public void Load(Player player, BinaryReader reader, int gameVersionSaveWasMadeOn)
			{
				Player.SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass = player.savedPerPlayerFieldsThatArentInThePlayerClass;
			}

			// Token: 0x06004DA0 RID: 19872 RVA: 0x00273D74 File Offset: 0x00271F74
			public void ApplyLoadedDataToOutOfPlayerFields(Player player)
			{
				float spawnRatePowerSliderValue = player.savedPerPlayerFieldsThatArentInThePlayerClass.spawnRatePowerSliderValue;
			}

			// Token: 0x0400869A RID: 34458
			[CompilerGenerated]
			private float <StrengthMultiplierToGiveNPCs>k__BackingField;
		}
	}
}
