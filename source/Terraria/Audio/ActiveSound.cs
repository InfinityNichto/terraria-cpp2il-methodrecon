using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace Terraria.Audio
{
	// Token: 0x02000683 RID: 1667
	public class ActiveSound
	{
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x002220E4 File Offset: 0x002202E4
		// (set) Token: 0x060037AA RID: 14250 RVA: 0x002220F8 File Offset: 0x002202F8
		public SoundEffectInstance Sound
		{
			[CompilerGenerated]
			get
			{
				return this.<Sound>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Sound>k__BackingField = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x0022210C File Offset: 0x0022030C
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x00222120 File Offset: 0x00220320
		public SoundStyle Style
		{
			[CompilerGenerated]
			get
			{
				return this.<Style>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Style>k__BackingField = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x00222134 File Offset: 0x00220334
		public bool IsPlaying
		{
			get
			{
				/*
An exception occurred when decompiling this method (060037AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Audio.ActiveSound::get_IsPlaying()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:SoundEffectInstance(var_0_06, ldfld:SoundEffectInstance(ActiveSound::<Sound>k__BackingField, ldloc:ActiveSound(this)))
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

		// Token: 0x060037AE RID: 14254 RVA: 0x00222148 File Offset: 0x00220348
		public ActiveSound(SoundStyle style, Vector2 position)
		{
			this.Volume = (float)16256;
			float pitchVariance = style._pitchVariance;
			this.Style = style;
			this.Pitch = pitchVariance;
			this.Play();
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00222184 File Offset: 0x00220384
		public ActiveSound(SoundStyle style)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this.Volume = (float)16256;
			float pitchVariance = style._pitchVariance;
			this.IsGlobal = true;
			this.Style = style;
			this.Pitch = pitchVariance;
			this.Play();
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x002221CC File Offset: 0x002203CC
		public ActiveSound(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition condition)
		{
			this.Volume = (float)16256;
			float pitchVariance = style._pitchVariance;
			this.Style = style;
			this.Pitch = pitchVariance;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x00222200 File Offset: 0x00220400
		private void Play()
		{
			SoundStyle soundStyle = this.<Style>k__BackingField;
			SoundEffectInstance soundEffectInstance;
			float pitch = soundEffectInstance._pitch;
			float randomPitch = this.<Style>k__BackingField.GetRandomPitch();
			soundEffectInstance.Pitch = randomPitch;
			float pitch2 = soundEffectInstance._pitch;
			this.Pitch = pitch2;
			SoundInstanceGarbageCollector.Track(soundEffectInstance);
			this.<Sound>k__BackingField = soundEffectInstance;
			this.Update();
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00222254 File Offset: 0x00220454
		private void PlayLooped(ActiveSound.LoopedPlayCondition condition)
		{
			SoundStyle soundStyle = this.<Style>k__BackingField;
			SoundEffectInstance soundEffectInstance;
			float pitch = soundEffectInstance._pitch;
			float randomPitch = this.<Style>k__BackingField.GetRandomPitch();
			soundEffectInstance.Pitch = randomPitch;
			float pitch2 = soundEffectInstance._pitch;
			this.Pitch = pitch2;
			this.Condition = condition;
			SoundInstanceGarbageCollector.Track(soundEffectInstance);
			this.<Sound>k__BackingField = soundEffectInstance;
			this.Update();
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x002222AC File Offset: 0x002204AC
		public void Stop()
		{
			if (this.<Sound>k__BackingField != null)
			{
				return;
			}
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x002222C4 File Offset: 0x002204C4
		public void Pause()
		{
			SoundEffectInstance soundEffectInstance = this.<Sound>k__BackingField;
			if (soundEffectInstance == null || soundEffectInstance != null)
			{
				return;
			}
			SoundEffectInstance soundEffectInstance2 = this.<Sound>k__BackingField;
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x002222E8 File Offset: 0x002204E8
		public void Resume()
		{
			if (this.<Sound>k__BackingField != null)
			{
				SoundEffectInstance soundEffectInstance = this.<Sound>k__BackingField;
				return;
			}
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x00222308 File Offset: 0x00220508
		public void Update()
		{
			if (this.<Sound>k__BackingField != null)
			{
				ActiveSound.LoopedPlayCondition condition = this.Condition;
				if (condition != null)
				{
					IntPtr invoke_impl = condition.invoke_impl;
					IntPtr method_code = condition.method_code;
					IntPtr method = condition.method;
				}
				return;
			}
		}

		// Token: 0x040078A1 RID: 30881
		[CompilerGenerated]
		private SoundEffectInstance <Sound>k__BackingField;

		// Token: 0x040078A2 RID: 30882
		public readonly bool IsGlobal;

		// Token: 0x040078A3 RID: 30883
		public Vector2 Position;

		// Token: 0x040078A4 RID: 30884
		public float Volume;

		// Token: 0x040078A5 RID: 30885
		public float Pitch;

		// Token: 0x040078A6 RID: 30886
		[CompilerGenerated]
		private SoundStyle <Style>k__BackingField;

		// Token: 0x040078A7 RID: 30887
		public ActiveSound.LoopedPlayCondition Condition;

		// Token: 0x02000684 RID: 1668
		public sealed class LoopedPlayCondition : MulticastDelegate
		{
			// Token: 0x060037B7 RID: 14263 RVA: 0x00222444 File Offset: 0x00220644
			public LoopedPlayCondition(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060037B8 RID: 14264 RVA: 0x00222498 File Offset: 0x00220698
			public bool Invoke()
			{
				/*
An exception occurred when decompiling this method (060037B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Audio.ActiveSound/LoopedPlayCondition::Invoke()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:LoopedPlayCondition[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:LoopedPlayCondition[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:LoopedPlayCondition[exp:Delegate](this)))
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

			// Token: 0x060037B9 RID: 14265 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060037BA RID: 14266 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
