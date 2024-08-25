using System;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020003CD RID: 973
	public class Cue
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x0006C9BC File Offset: 0x0006ABBC
		public Cue(SoundEffect musicSource)
		{
			musicSource.Definition.Priority = 100;
			SoundEffectInstance soundEffectInstance = musicSource.CreateInstance();
			this._audioInstance = soundEffectInstance;
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0006C9EC File Offset: 0x0006ABEC
		public bool IsPaused
		{
			get
			{
				return this._paused;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0006CA00 File Offset: 0x0006AC00
		public bool IsPlaying
		{
			get
			{
				return !this._paused || true;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0006CA18 File Offset: 0x0006AC18
		public bool IsStopped
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A6A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Audio.Cue::get_IsStopped()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SoundEffectInstance(var_0_06, ldfld:SoundEffectInstance(Cue::_audioInstance, ldloc:Cue(this)))
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

		// Token: 0x06001A6B RID: 6763 RVA: 0x0006CA2C File Offset: 0x0006AC2C
		public void Play()
		{
			SoundEffectInstance audioInstance = this._audioInstance;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0006CA40 File Offset: 0x0006AC40
		public void Pause()
		{
			SoundEffectInstance audioInstance = this._audioInstance;
			this._paused = true;
			SoundInstance playingInstance = audioInstance._playingInstance;
			if (playingInstance != null)
			{
				float currentPosition = playingInstance.CurrentPosition;
				SoundEffectInstance audioInstance2 = this._audioInstance;
				return;
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0006CA74 File Offset: 0x0006AC74
		public void Resume()
		{
			SoundEffectInstance audioInstance = this._audioInstance;
			if (this._audioInstance._playingInstance != null)
			{
				float pausedTime = this._pausedTime;
			}
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0006CA9C File Offset: 0x0006AC9C
		public void Stop(AudioStopOptions option)
		{
			SoundEffectInstance audioInstance = this._audioInstance;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
		public void SetVariable(string id, float value)
		{
			this._audioInstance.Volume = value;
		}

		// Token: 0x040027D8 RID: 10200
		private bool _paused;

		// Token: 0x040027D9 RID: 10201
		private float _pausedTime;

		// Token: 0x040027DA RID: 10202
		private SoundEffectInstance _audioInstance;

		// Token: 0x040027DB RID: 10203
		private SoundEffect _effect;
	}
}
