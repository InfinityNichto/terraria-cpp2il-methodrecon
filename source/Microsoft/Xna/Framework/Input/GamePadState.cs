using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000346 RID: 838
	public struct GamePadState
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x000604E4 File Offset: 0x0005E6E4
		public bool IsConnected
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x000604F4 File Offset: 0x0005E6F4
		// (set) Token: 0x06001562 RID: 5474 RVA: 0x00060508 File Offset: 0x0005E708
		public int PacketNumber
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<PacketNumber>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<PacketNumber>k__BackingField = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x0006051C File Offset: 0x0005E71C
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x00060530 File Offset: 0x0005E730
		public GamePadButtons Buttons
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Buttons>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				this.<Buttons>k__BackingField = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x00060544 File Offset: 0x0005E744
		public GamePadDPad DPad
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00060554 File Offset: 0x0005E754
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00060574 File Offset: 0x0005E774
		public GamePadThumbSticks ThumbSticks
		{
			[CompilerGenerated]
			readonly get
			{
				/*
An exception occurred when decompiling this method (06001567)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Input.GamePadThumbSticks Microsoft.Xna.Framework.Input.GamePadState::get_ThumbSticks()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_10, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](GamePadThumbSticks::_right, ldfld:GamePadThumbSticks[exp:valuetype Microsoft.Xna.Framework.Input.GamePadThumbSticks&](GamePadState::<ThumbSticks>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))))
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
			internal set
			{
				float y = value._right.Y;
				this.<ThumbSticks>k__BackingField._right.Y = y;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000605A0 File Offset: 0x0005E7A0
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x000605C4 File Offset: 0x0005E7C4
		public GamePadTriggers Triggers
		{
			[CompilerGenerated]
			readonly get
			{
				/*
An exception occurred when decompiling this method (06001569)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Input.GamePadTriggers Microsoft.Xna.Framework.Input.GamePadState::get_Triggers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(GamePadTriggers::<Left>k__BackingField, ldfld:GamePadTriggers[exp:valuetype Microsoft.Xna.Framework.Input.GamePadTriggers&](GamePadState::<Triggers>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this))))
	stloc:float32(var_1_17, ldfld:float32(GamePadTriggers::<Right>k__BackingField, ldfld:GamePadTriggers[exp:valuetype Microsoft.Xna.Framework.Input.GamePadTriggers&](GamePadState::<Triggers>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this))))
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
			internal set
			{
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000605D4 File Offset: 0x0005E7D4
		public GamePadState(GamePadThumbSticks thumbSticks, GamePadTriggers triggers, GamePadButtons buttons, GamePadDPad dPad)
		{
			float y = thumbSticks._right.Y;
			this.Buttons = triggers;
			this.<ThumbSticks>k__BackingField._right.Y = y;
			this.<IsConnected>k__BackingField = true;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0006060C File Offset: 0x0005E80C
		public GamePadState(Vector2 leftThumbStick, Vector2 rightThumbStick, float leftTrigger, float rightTrigger, Buttons buttons)
		{
			this.<DPad>k__BackingField = leftThumbStick;
			this.<IsConnected>k__BackingField = true;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0006062C File Offset: 0x0005E82C
		private Buttons GetVirtualButtons()
		{
			/*
An exception occurred when decompiling this method (0600156D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Input.Buttons Microsoft.Xna.Framework.Input.GamePadState::GetVirtualButtons()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GamePadButtons(var_0_06, ldfld:GamePadButtons(GamePadState::<Buttons>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))
	stloc:GamePadThumbSticks(var_1_0D, ldfld:GamePadThumbSticks(GamePadState::<ThumbSticks>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))
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

		// Token: 0x0600156E RID: 5486 RVA: 0x00060648 File Offset: 0x0005E848
		public bool IsButtonDown(Buttons button)
		{
			/*
An exception occurred when decompiling this method (0600156E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.GamePadState::IsButtonDown(Microsoft.Xna.Framework.Input.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GamePadButtons(var_0_06, ldfld:GamePadButtons(GamePadState::<Buttons>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))
	stloc:GamePadThumbSticks(var_1_0D, ldfld:GamePadThumbSticks(GamePadState::<ThumbSticks>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))
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

		// Token: 0x0600156F RID: 5487 RVA: 0x00060664 File Offset: 0x0005E864
		public bool IsButtonUp(Buttons button)
		{
			/*
An exception occurred when decompiling this method (0600156F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Input.GamePadState::IsButtonUp(Microsoft.Xna.Framework.Input.Buttons)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:GamePadButtons(var_0_06, ldfld:GamePadButtons(GamePadState::<Buttons>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))
	stloc:GamePadThumbSticks(var_1_0D, ldfld:GamePadThumbSticks(GamePadState::<ThumbSticks>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadState&(this)))
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

		// Token: 0x06001570 RID: 5488 RVA: 0x00060680 File Offset: 0x0005E880
		public static bool operator ==(GamePadState left, GamePadState right)
		{
			int num = left.<PacketNumber>k__BackingField;
			GamePadButtons gamePadButtons = left.<Buttons>k__BackingField;
			ButtonState <Right>k__BackingField = left.<DPad>k__BackingField.<Right>k__BackingField;
			ButtonState <Up>k__BackingField = left.<DPad>k__BackingField.<Up>k__BackingField;
			float y = left.<ThumbSticks>k__BackingField._right.Y;
			float <Left>k__BackingField = left.<Triggers>k__BackingField.<Left>k__BackingField;
			float <Right>k__BackingField2 = left.<Triggers>k__BackingField.<Right>k__BackingField;
			bool flag;
			return flag;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000606E8 File Offset: 0x0005E8E8
		public static bool operator !=(GamePadState left, GamePadState right)
		{
			int value__ = left.<DPad>k__BackingField.<Left>k__BackingField.value__;
			int value__2 = left.<DPad>k__BackingField.<Right>k__BackingField.value__;
			if (left.<Triggers>k__BackingField == null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00060720 File Offset: 0x0005E920
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			GamePadTriggers gamePadTriggers = this.<Triggers>k__BackingField;
			int value__ = this.<DPad>k__BackingField.<Left>k__BackingField.value__;
			int value__2 = this.<DPad>k__BackingField.<Right>k__BackingField.value__;
			if (gamePadTriggers != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00060768 File Offset: 0x0005E968
		public override int GetHashCode()
		{
			float y = this.<ThumbSticks>k__BackingField._right.Y;
			int num = this.<PacketNumber>k__BackingField;
			GamePadDPad gamePadDPad = this.<DPad>k__BackingField;
			GamePadTriggers gamePadTriggers = this.<Triggers>k__BackingField;
			int num2;
			return num2;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000607A0 File Offset: 0x0005E9A0
		public override string ToString()
		{
			if (("[GamePadState: IsConnected=" == null || "[GamePadState: IsConnected=" != null) && ("1" == null || "1" != null) && (", PacketNumber=" == null || ", PacketNumber=" != null))
			{
				int num = this.<PacketNumber>k__BackingField;
				string text;
				if ((text == null || text != null) && (", Buttons=" == null || ", Buttons=" != null))
				{
					GamePadButtons gamePadButtons = this.<Buttons>k__BackingField;
					string text2;
					string text3;
					if ((text2 == null || text2 != null) && (text3 == null || text3 != null) && (", ThumbSticks=" == null || ", ThumbSticks=" != null))
					{
						float y = this.<ThumbSticks>k__BackingField._right.Y;
						string text4;
						if ((text4 == null || text4 != null) && (", Triggers=" == null || ", Triggers=" != null))
						{
							GamePadTriggers gamePadTriggers = this.<Triggers>k__BackingField;
							string text5;
							if ((text5 == null || text5 != null) && ("]" == null || "]" != null))
							{
								string text6;
								return text6;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00060880 File Offset: 0x0005EA80
		// Note: this type is marked as 'beforefieldinit'.
		static GamePadState()
		{
		}

		// Token: 0x04002307 RID: 8967
		public static readonly GamePadState Default;

		// Token: 0x04002308 RID: 8968
		[CompilerGenerated]
		private bool <IsConnected>k__BackingField;

		// Token: 0x04002309 RID: 8969
		[CompilerGenerated]
		private int <PacketNumber>k__BackingField;

		// Token: 0x0400230A RID: 8970
		[CompilerGenerated]
		private GamePadButtons <Buttons>k__BackingField;

		// Token: 0x0400230B RID: 8971
		[CompilerGenerated]
		private GamePadDPad <DPad>k__BackingField;

		// Token: 0x0400230C RID: 8972
		[CompilerGenerated]
		private GamePadThumbSticks <ThumbSticks>k__BackingField;

		// Token: 0x0400230D RID: 8973
		[CompilerGenerated]
		private GamePadTriggers <Triggers>k__BackingField;
	}
}
