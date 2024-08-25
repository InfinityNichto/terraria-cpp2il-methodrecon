using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat
{
	// Token: 0x0200072C RID: 1836
	public class ChatMessageContainer
	{
		// Token: 0x06003CBE RID: 15550 RVA: 0x00237348 File Offset: 0x00235548
		public void SetContents(string text, Color color, int widthLimitInPixels)
		{
			this.OriginalText = text;
			this._color = color;
			this._timeLeft = widthLimitInPixels;
			this._timeLeft = 600;
			this.Refresh();
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x0023737C File Offset: 0x0023557C
		public void MarkToNeedRefresh()
		{
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x0023738C File Offset: 0x0023558C
		public void Update()
		{
			int timeLeft = this._timeLeft;
			this._timeLeft = timeLeft;
			this.Refresh();
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x002373B0 File Offset: 0x002355B0
		public TextSnippet[] GetSnippetWithInversedIndex(int snippetIndex)
		{
			/*
An exception occurred when decompiling this method (06003CC1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.UI.Chat.TextSnippet[] Terraria.UI.Chat.ChatMessageContainer::GetSnippetWithInversedIndex(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0B, ldfld:int32(List`1::_size, ldfld:class [mscorlib]System.Collections.Generic.List`1<class Terraria.UI.Chat.TextSnippet[]>[exp:List`1](ChatMessageContainer::_parsedText, ldloc:ChatMessageContainer(this))))
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

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x002373C8 File Offset: 0x002355C8
		public int LineCount
		{
			get
			{
				return this._parsedText._size;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x002373E0 File Offset: 0x002355E0
		public bool CanBeShownWhenChatIsClosed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003CC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.UI.Chat.ChatMessageContainer::get_CanBeShownWhenChatIsClosed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ChatMessageContainer::_timeLeft, ldloc:ChatMessageContainer(this)))
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

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x002373F4 File Offset: 0x002355F4
		public bool Prepared
		{
			get
			{
				return this._prepared;
			}
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x000021DB File Offset: 0x000003DB
		public void Refresh()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00237408 File Offset: 0x00235608
		public ChatMessageContainer()
		{
		}

		// Token: 0x04007BE0 RID: 31712
		public string OriginalText;

		// Token: 0x04007BE1 RID: 31713
		private bool _prepared;

		// Token: 0x04007BE2 RID: 31714
		private List<TextSnippet[]> _parsedText;

		// Token: 0x04007BE3 RID: 31715
		private Color _color;

		// Token: 0x04007BE4 RID: 31716
		private int _widthLimitInPixels;

		// Token: 0x04007BE5 RID: 31717
		private int _timeLeft;
	}
}
