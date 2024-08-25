using System;
using System.IO;
using Cpp2IlInjected;
using Terraria.Chat.Commands;

namespace Terraria.Chat
{
	// Token: 0x02000797 RID: 1943
	public struct ChatCommandId
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x00240D70 File Offset: 0x0023EF70
		private ChatCommandId(string name)
		{
			this._name = name;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x000021DB File Offset: 0x000003DB
		public static ChatCommandId FromType<T>() where T : IChatCommand
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x00240D84 File Offset: 0x0023EF84
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x000021DB File Offset: 0x000003DB
		public static ChatCommandId Deserialize(BinaryReader reader)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00240D94 File Offset: 0x0023EF94
		public int GetMaxSerializedSize()
		{
			/*
An exception occurred when decompiling this method (06003F95)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Chat.ChatCommandId::GetMaxSerializedSize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_UTF8))
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

		// Token: 0x04007DC1 RID: 32193
		private readonly string _name;
	}
}
