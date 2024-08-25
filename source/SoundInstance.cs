using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000052 RID: 82
public class SoundInstance
{
	// Token: 0x060001AF RID: 431 RVA: 0x00004E18 File Offset: 0x00003018
	public SoundInstance(SoundChannel channel, SoundDefinition definition, float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
		this.Definition = definition;
		AudioClip randomClip = definition.GetRandomClip();
		this.Clip = randomClip;
		this._channel = channel;
		SoundChannel channel2;
		if (channel._currentSound != null)
		{
			channel2 = this._channel;
		}
		channel._currentSound = this;
		channel2.AudioSource.clip = randomClip;
		SoundChannel channel3 = this._channel;
		SoundGroup group = definition.Group;
		AudioSource audioSource = channel3.AudioSource;
		if (group != null)
		{
			AudioMixerGroup mixerGroup = group.MixerGroup;
			return;
		}
		this._channel.AudioSource.time = volume;
		this._channel.AudioSource.Play();
		this._channel.AudioSource.panStereo = pan;
		this._channel.AudioSource.pitch = pitch;
		SoundChannel channel4 = this._channel;
		long num = 0L;
		channel4.AudioSource.volume = volume;
		this._channel.AudioSource.loop = num != 0L;
		SoundChannel channel5 = this._channel;
		int priority = definition.Priority;
		channel5.AudioSource.priority = (int)num;
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00004F5C File Offset: 0x0000315C
	public void Restart()
	{
		SoundChannel channel = this._channel;
		if (channel != null)
		{
			AudioSource audioSource = channel.AudioSource;
			float length = this.Clip.length;
			SoundChannel channel2 = this._channel;
			channel2.AudioSource.time = length;
			if (channel2 == null)
			{
			}
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)length);
			DateTime dateTime = utcNow + timeSpan;
			this.FinishTime = dateTime;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060001B1 RID: 433 RVA: 0x00004FC8 File Offset: 0x000031C8
	// (set) Token: 0x060001B2 RID: 434 RVA: 0x00004FF8 File Offset: 0x000031F8
	public float CurrentPosition
	{
		get
		{
			/*
An exception occurred when decompiling this method (060001B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single SoundInstance::get_CurrentPosition()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:AudioSource(var_1_10, ldfld:AudioSource(SoundChannel::AudioSource, ldloc:SoundChannel(var_0_06)))
	stloc:float32(var_3_21, callgetter:float32(AudioSource::get_time, ldfld:AudioSource(SoundChannel::AudioSource, ldfld:SoundChannel(SoundInstance::_channel, ldloc:SoundInstance(this)))))
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
			SoundChannel channel = this._channel;
			if (channel != null)
			{
				AudioSource audioSource = channel.AudioSource;
				float length = this.Clip.length;
				SoundChannel channel2 = this._channel;
				channel2.AudioSource.time = value;
				if (channel2 == null)
				{
				}
				DateTime utcNow = DateTime.UtcNow;
				TimeSpan timeSpan = TimeSpan.FromSeconds((double)value);
				DateTime dateTime = utcNow + timeSpan;
				this.FinishTime = dateTime;
			}
		}
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00005064 File Offset: 0x00003264
	public void SetVolume(float volume)
	{
		SoundChannel channel = this._channel;
		if (channel != null)
		{
			AudioSource audioSource = channel.AudioSource;
			this._channel.AudioSource.volume = volume;
			return;
		}
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00005094 File Offset: 0x00003294
	public void SetPan(float pan)
	{
		SoundChannel channel = this._channel;
		if (channel != null)
		{
			AudioSource audioSource = channel.AudioSource;
			this._channel.AudioSource.panStereo = pan;
			return;
		}
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x000050C4 File Offset: 0x000032C4
	public void SetPitch(float pitch)
	{
		SoundChannel channel = this._channel;
		if (channel != null)
		{
			AudioSource audioSource = channel.AudioSource;
			this._channel.AudioSource.pitch = pitch;
			return;
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x000050F4 File Offset: 0x000032F4
	public void Stop()
	{
		if (!true)
		{
		}
		DateTime utcNow = DateTime.UtcNow;
		SoundChannel channel = this._channel;
		this.FinishTime = utcNow;
		if (channel != null)
		{
			AudioSource audioSource = channel.AudioSource;
			this._channel.AudioSource.Stop();
			return;
		}
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00005138 File Offset: 0x00003338
	public void StartFade(float fadeTarget, DateTime fadeStart, DateTime targetTime)
	{
		DateTime finishTime = this.FinishTime;
		if (!true)
		{
		}
		DateTime utcNow = DateTime.UtcNow;
		bool flag = finishTime > utcNow;
		SoundChannel channel = this._channel;
		this._fadeStart = fadeStart;
		this._fadeEnd = targetTime;
		float volume = channel.AudioSource.volume;
		DateTime fadeEnd = this._fadeEnd;
		DateTime finishTime2 = this.FinishTime;
		if (channel == null)
		{
		}
		bool flag2 = fadeEnd > finishTime2;
		DateTime finishTime3 = this.FinishTime;
		this._fadeEnd = finishTime3;
		this._fading = true;
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x000051BC File Offset: 0x000033BC
	public bool UpdateFade()
	{
		/*
An exception occurred when decompiling this method (060001B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean SoundInstance::UpdateFade()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00CB:
	stloc:bool(var_21_D1, ldfld:bool(SoundInstance::_fading, ldloc:SoundInstance(this)))
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

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000529C File Offset: 0x0000349C
	// (set) Token: 0x060001BA RID: 442 RVA: 0x000052B0 File Offset: 0x000034B0
	public SoundChannel Channel
	{
		get
		{
			return this._channel;
		}
		set
		{
			this._channel = value;
		}
	}

	// Token: 0x04000127 RID: 295
	public readonly AudioClip Clip;

	// Token: 0x04000128 RID: 296
	public readonly SoundDefinition Definition;

	// Token: 0x04000129 RID: 297
	public DateTime FinishTime;

	// Token: 0x0400012A RID: 298
	private bool _fading;

	// Token: 0x0400012B RID: 299
	private DateTime _fadeStart;

	// Token: 0x0400012C RID: 300
	private DateTime _fadeEnd;

	// Token: 0x0400012D RID: 301
	private float _fadeStartVol;

	// Token: 0x0400012E RID: 302
	private float _fadeEndVol;

	// Token: 0x0400012F RID: 303
	private SoundChannel _channel;
}
