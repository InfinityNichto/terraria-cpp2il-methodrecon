using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000345 RID: 837
	public struct GamePadDPad
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x0006037C File Offset: 0x0005E57C
		public ButtonState Down
		{
			[CompilerGenerated]
			readonly get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[CompilerGenerated]
			private set
			{
				this.<Down>k__BackingField = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x00060390 File Offset: 0x0005E590
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x000603A4 File Offset: 0x0005E5A4
		public ButtonState Left
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Left>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Left>k__BackingField = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000603B8 File Offset: 0x0005E5B8
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x000603CC File Offset: 0x0005E5CC
		public ButtonState Right
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Right>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Right>k__BackingField = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000603E0 File Offset: 0x0005E5E0
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x000603F4 File Offset: 0x0005E5F4
		public ButtonState Up
		{
			[CompilerGenerated]
			readonly get
			{
				return this.<Up>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Up>k__BackingField = value;
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00060408 File Offset: 0x0005E608
		public GamePadDPad(ButtonState upValue, ButtonState downValue, ButtonState leftValue, ButtonState rightValue)
		{
			this.Right = rightValue;
			this.<Down>k__BackingField = downValue;
			this.Right = leftValue;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0006042C File Offset: 0x0005E62C
		internal GamePadDPad(Buttons buttons)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00060458 File Offset: 0x0005E658
		public static bool operator ==(GamePadDPad left, GamePadDPad right)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00060468 File Offset: 0x0005E668
		public static bool operator !=(GamePadDPad left, GamePadDPad right)
		{
			return true;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00060478 File Offset: 0x0005E678
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				ButtonState buttonState = this.<Right>k__BackingField;
				return;
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00060490 File Offset: 0x0005E690
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (0600155D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Microsoft.Xna.Framework.Input.GamePadDPad::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ButtonState(var_0_06, ldfld:ButtonState(GamePadDPad::<Down>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadDPad&(this)))
	stloc:ButtonState(var_1_0D, ldfld:ButtonState(GamePadDPad::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadDPad&(this)))
	stloc:ButtonState(var_2_14, ldfld:ButtonState(GamePadDPad::<Right>k__BackingField, ldloc:valuetype Microsoft.Xna.Framework.Input.GamePadDPad&(this)))
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

		// Token: 0x0600155E RID: 5470 RVA: 0x000604B4 File Offset: 0x0005E6B4
		public override string ToString()
		{
			ButtonState buttonState = this.<Left>k__BackingField;
			ButtonState buttonState2 = this.<Up>k__BackingField;
			ButtonState buttonState3 = this.<Right>k__BackingField;
			string text;
			string text2;
			string text3;
			string text4;
			return text + text2 + text3 + text4;
		}

		// Token: 0x04002303 RID: 8963
		[CompilerGenerated]
		private ButtonState <Down>k__BackingField;

		// Token: 0x04002304 RID: 8964
		[CompilerGenerated]
		private ButtonState <Left>k__BackingField;

		// Token: 0x04002305 RID: 8965
		[CompilerGenerated]
		private ButtonState <Right>k__BackingField;

		// Token: 0x04002306 RID: 8966
		[CompilerGenerated]
		private ButtonState <Up>k__BackingField;
	}
}
