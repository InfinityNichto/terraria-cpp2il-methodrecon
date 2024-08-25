using System;
using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
	// Token: 0x02000686 RID: 1670
	public class CustomSoundStyle : SoundStyle
	{
		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x00222514 File Offset: 0x00220714
		public override bool IsTrackable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00222524 File Offset: 0x00220724
		public CustomSoundStyle(SoundEffect soundEffect, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
		{
			if (!true)
			{
			}
			base..ctor(volume, pitchVariance, type);
			if (soundEffect == null || soundEffect != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x0022254C File Offset: 0x0022074C
		public CustomSoundStyle(SoundEffect[] soundEffects, SoundType type = SoundType.Sound, float volume = 1f, float pitchVariance = 0f)
		{
			if (!true)
			{
			}
			base..ctor(volume, pitchVariance, type);
			this._soundEffects = soundEffects;
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00222570 File Offset: 0x00220770
		public override SoundEffect GetRandomSound()
		{
			/*
An exception occurred when decompiling this method (060037C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Audio.SoundEffect Terraria.Audio.CustomSoundStyle::GetRandomSound()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:SoundDefinition(var_2_17, ldfld:SoundDefinition(SoundEffect::Definition, ldfld:class Microsoft.Xna.Framework.Audio.SoundEffect[][exp:SoundEffect](CustomSoundStyle::_soundEffects, ldloc:CustomSoundStyle(this))))
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

		// Token: 0x060037C1 RID: 14273 RVA: 0x00222594 File Offset: 0x00220794
		// Note: this type is marked as 'beforefieldinit'.
		static CustomSoundStyle()
		{
		}

		// Token: 0x040078AA RID: 30890
		private static readonly UnifiedRandom Random;

		// Token: 0x040078AB RID: 30891
		private readonly SoundEffect[] _soundEffects;
	}
}
