using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000050 RID: 80
public class SoundDefinition
{
	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x00004D58 File Offset: 0x00002F58
	public float MaxLength
	{
		get
		{
			/*
An exception occurred when decompiling this method (060001A8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single SoundDefinition::get_MaxLength()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SoundDefinition::_maxLength, ldloc:SoundDefinition(this)))
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

	// Token: 0x060001A9 RID: 425 RVA: 0x00004D6C File Offset: 0x00002F6C
	public SoundInstance Play(float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
		int size = this._variations._size;
		SoundChannel soundChannel;
		if (soundChannel != null)
		{
			float volumeScale = this.VolumeScale;
			return;
		}
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00004D90 File Offset: 0x00002F90
	public AudioClip GetRandomClip()
	{
		/*
An exception occurred when decompiling this method (060001AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling UnityEngine.AudioClip SoundDefinition::GetRandomClip()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class [UnityEngine.AudioModule]UnityEngine.AudioClip>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.List`1<class [UnityEngine.AudioModule]UnityEngine.AudioClip>(SoundDefinition::_variations, ldloc:SoundDefinition(this)))
	stloc:int64(var_1_08, ldc.i4:int64(0))
	stloc:int32(var_2_0F, ldfld:int32(List`1::_size, ldloc:class [mscorlib]System.Collections.Generic.List`1<class [UnityEngine.AudioModule]UnityEngine.AudioClip>[exp:List`1](var_0_06)))
	stloc:int32(var_3_17, call:int32(Random::Range, ldloc:int64[exp:int32](var_1_08), ldloc:int32(var_2_0F)))
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

	// Token: 0x060001AB RID: 427 RVA: 0x000021DB File Offset: 0x000003DB
	public void AddVariation(AudioClip clip)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00004DB4 File Offset: 0x00002FB4
	public SoundDefinition()
	{
	}

	// Token: 0x0400011E RID: 286
	public string Id;

	// Token: 0x0400011F RID: 287
	public SoundGroup Group;

	// Token: 0x04000120 RID: 288
	public int Priority;

	// Token: 0x04000121 RID: 289
	public float VolumeScale = (float)16256;

	// Token: 0x04000122 RID: 290
	private float _maxLength;

	// Token: 0x04000123 RID: 291
	private List<AudioClip> _variations;
}
