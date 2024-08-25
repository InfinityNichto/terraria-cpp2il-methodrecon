using System;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x02000525 RID: 1317
	public class DiscordJoinToServerRequest : UserJoinToServerRequest, IEquatable<DiscordJoinToServerRequest>
	{
		// Token: 0x060031A9 RID: 12713 RVA: 0x001F8BA4 File Offset: 0x001F6DA4
		public DiscordJoinToServerRequest(string userDisplayName, string fullIdentifier, int durationInSeconds = 30)
		{
			this.<UserDisplayName>k__BackingField = userDisplayName;
			this.<UserFullIdentifier>k__BackingField = fullIdentifier;
			if (!true)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime;
			this._expirationTime = dateTime;
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x001F8BD8 File Offset: 0x001F6DD8
		public override bool IsValid()
		{
			/*
An exception occurred when decompiling this method (060031AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Social.Discord.DiscordJoinToServerRequest::IsValid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:DateTime(var_2_11, callgetter:DateTime(DateTime::get_UtcNow))
	stloc:int32(var_3_19, call:int32(DateTime::Compare, ldloc:DateTime(var_0_06), ldloc:DateTime(var_2_11)))
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

		// Token: 0x060031AB RID: 12715 RVA: 0x001F8C00 File Offset: 0x001F6E00
		public override string GetUserWrapperText()
		{
			if (!true)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan timeSpan;
			string text = timeSpan.Seconds.ToString();
			return "{DisplayName} wants to join you! (" + text + ")\n{FullId}";
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x001F8C34 File Offset: 0x001F6E34
		public bool Equals(DiscordJoinToServerRequest other)
		{
			string <UserFullIdentifier>k__BackingField = other.<UserFullIdentifier>k__BackingField;
			string <UserFullIdentifier>k__BackingField2 = this.<UserFullIdentifier>k__BackingField;
			return <UserFullIdentifier>k__BackingField == <UserFullIdentifier>k__BackingField2;
		}

		// Token: 0x04003B58 RID: 15192
		private DateTime _expirationTime;
	}
}
