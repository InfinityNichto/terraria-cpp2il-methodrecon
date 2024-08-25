using System;
using System.Threading;

namespace Microsoft.Xna.Framework.Audio
{
	// Token: 0x020003D0 RID: 976
	public class SoundEffectInstance
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0006CBC8 File Offset: 0x0006ADC8
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0006CBDC File Offset: 0x0006ADDC
		public virtual bool IsLooped
		{
			get
			{
				return this._loop;
			}
			set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0006CBEC File Offset: 0x0006ADEC
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0006CC00 File Offset: 0x0006AE00
		public float Pan
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A7C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Audio.SoundEffectInstance::get_Pan()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SoundEffectInstance::_pan, ldloc:SoundEffectInstance(this)))
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
			set
			{
				SoundInstance playingInstance = this._playingInstance;
				if (playingInstance != null)
				{
					playingInstance.SetPan(value);
					return;
				}
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0006CC20 File Offset: 0x0006AE20
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0006CC34 File Offset: 0x0006AE34
		public float Pitch
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A7E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Audio.SoundEffectInstance::get_Pitch()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SoundEffectInstance::_pitch, ldloc:SoundEffectInstance(this)))
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
			set
			{
				SoundInstance playingInstance = this._playingInstance;
				if (playingInstance != null)
				{
					if (!true)
					{
						float pitch = this._pitch;
					}
					playingInstance.SetPitch(value);
					return;
				}
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0006CC60 File Offset: 0x0006AE60
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0006CC74 File Offset: 0x0006AE74
		public float Volume
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A80)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Audio.SoundEffectInstance::get_Volume()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SoundEffectInstance::_volume, ldloc:SoundEffectInstance(this)))
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
			set
			{
				SoundInstance playingInstance = this._playingInstance;
				if (playingInstance != null)
				{
					float volumeScale = this._effect.Definition.VolumeScale;
					playingInstance.SetVolume(value);
					return;
				}
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0006CCA4 File Offset: 0x0006AEA4
		public virtual SoundState State
		{
			get
			{
				SoundInstance playingInstance = this._playingInstance;
				if (playingInstance != null)
				{
					SoundChannel channel = playingInstance._channel;
					if (channel != null)
					{
						SoundInstance currentSound = channel._currentSound;
						DateTime utcNow = DateTime.UtcNow;
						DateTime finishTime = this._playingInstance.FinishTime;
						bool flag = utcNow < finishTime;
					}
				}
				return SoundState.Stopped;
			}
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0006CCF4 File Offset: 0x0006AEF4
		internal SoundEffectInstance(SoundEffect effect)
		{
			this._effect = effect;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0006CD10 File Offset: 0x0006AF10
		public virtual void Play()
		{
			if (this != null)
			{
				Thread currentThread = Thread.CurrentThread;
				return;
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0006CD6C File Offset: 0x0006AF6C
		private static void PlayOnMainThread(object data)
		{
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0006CD7C File Offset: 0x0006AF7C
		private static void StopOnMainThread(object data)
		{
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0006CD8C File Offset: 0x0006AF8C
		public void Restart()
		{
			SoundInstance playingInstance = this._playingInstance;
			if (playingInstance != null)
			{
				playingInstance.Restart();
				return;
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0006CDAC File Offset: 0x0006AFAC
		public virtual void Pause()
		{
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		public virtual void Resume()
		{
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0006CDCC File Offset: 0x0006AFCC
		public virtual void Stop(bool immediate = false)
		{
			Thread currentThread = Thread.CurrentThread;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0006CDF4 File Offset: 0x0006AFF4
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0006CE14 File Offset: 0x0006B014
		public float CurrentPosition
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001A8B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Audio.SoundEffectInstance::get_CurrentPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_1_10, callgetter:float32(SoundInstance::get_CurrentPosition, ldloc:SoundInstance(var_0_06)))
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
			set
			{
				SoundInstance playingInstance = this._playingInstance;
				if (playingInstance != null)
				{
					playingInstance.CurrentPosition = value;
					return;
				}
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0006CE34 File Offset: 0x0006B034
		// Note: this type is marked as 'beforefieldinit'.
		static SoundEffectInstance()
		{
		}

		// Token: 0x040027DF RID: 10207
		internal SoundEffect _effect;

		// Token: 0x040027E0 RID: 10208
		private bool _loop;

		// Token: 0x040027E1 RID: 10209
		private float _pan;

		// Token: 0x040027E2 RID: 10210
		private float _volume;

		// Token: 0x040027E3 RID: 10211
		private float _pitch;

		// Token: 0x040027E4 RID: 10212
		private SoundInstance _playingInstance;

		// Token: 0x040027E5 RID: 10213
		public static float pitchOffset;

		// Token: 0x040027E6 RID: 10214
		public static float pitchScale;
	}
}
