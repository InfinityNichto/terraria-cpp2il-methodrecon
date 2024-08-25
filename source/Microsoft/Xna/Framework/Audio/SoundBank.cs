using System;
using System.Collections.Generic;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020003CE RID: 974
	public class SoundBank
	{
		// Token: 0x06001A70 RID: 6768 RVA: 0x0006CACC File Offset: 0x0006ACCC
		public SoundBank(AudioEngine engine, string contentPath)
		{
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0006CAE0 File Offset: 0x0006ACE0
		public void LoadMusicId(int musicIndex)
		{
			string text2;
			string text = "Music_" + text2;
			Dictionary<string, Cue> cues = this._cues;
			string text3 = "Music/" + text;
			SoundEffect soundEffect;
			soundEffect.Definition.Priority = 100;
			SoundEffectInstance soundEffectInstance = soundEffect.CreateInstance();
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0006CB24 File Offset: 0x0006AD24
		public Cue GetCue(string cueId)
		{
			/*
An exception occurred when decompiling this method (06001A72)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Audio.Cue Microsoft.Xna.Framework.Audio.SoundBank::GetCue(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Microsoft.Xna.Framework.Audio.Cue>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Microsoft.Xna.Framework.Audio.Cue>(SoundBank::_cues, ldloc:SoundBank(this)))
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

		// Token: 0x040027DC RID: 10204
		private Dictionary<string, Cue> _cues;
	}
}
