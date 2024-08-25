using System;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000304 RID: 772
public class DistortionRenderTargetManager : MonoBehaviour
{
	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00057724 File Offset: 0x00055924
	public static DistortionRenderTargetManager Instance
	{
		get
		{
			/*
An exception occurred when decompiling this method (060011E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling DistortionRenderTargetManager DistortionRenderTargetManager::get_Instance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DistortionRenderTargetManager(var_1_19, call:DistortionRenderTargetManager(GameObject::GetComponent, call:GameObject(GameObjectExtensions::FindInChildren, call:GameObject(GameObject::Find, ldstr:string("TerrariaGame")), ldstr:string("DistortionRenderTargetCamera"))))
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

	// Token: 0x060011E5 RID: 4581 RVA: 0x0005774C File Offset: 0x0005594C
	private void InitialiseCamera()
	{
		int num = 1;
		Camera component = base.gameObject.GetComponent<Camera>();
		this.cameraObject = component;
		if (num == 0)
		{
		}
		Camera camera = this.cameraObject;
		RenderTexture distortionTarget = this.DistortionTarget;
		camera.targetTexture = distortionTarget;
		RenderTexture distortionTarget2 = this.DistortionTarget;
		RenderTexture distortionTargetSwap = this.DistortionTargetSwap;
		Transform transform = this.cameraObject.transform;
		Camera camera2 = this.cameraObject;
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x000577B8 File Offset: 0x000559B8
	public void ClearRenderTarget()
	{
		this.EndRenderTarget();
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x000577CC File Offset: 0x000559CC
	public void SwapTargets()
	{
		RenderTexture distortionTarget = this.DistortionTarget;
		if (!true)
		{
		}
		this.InitialiseCamera();
		Microsoft.Xna.Framework.Graphics.Texture2D gameDistortionTarget = this.GameDistortionTarget;
		RenderTexture distortionTarget2 = this.DistortionTarget;
		RenderTexture distortionTargetSwap = this.DistortionTargetSwap;
		Camera camera = this.cameraObject;
		this.DistortionTarget = distortionTargetSwap;
		this.DistortionTargetSwap = distortionTarget2;
		this.GameDistortionTarget = gameDistortionTarget;
		camera.targetTexture = distortionTargetSwap;
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00057828 File Offset: 0x00055A28
	public void BeginRenderTarget(bool clear, float clearValue)
	{
		RenderTexture distortionTarget = this.DistortionTarget;
		if (!true)
		{
		}
		this.InitialiseCamera();
		Camera camera = this.cameraObject;
		Camera camera2 = this.cameraObject;
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x0005786C File Offset: 0x00055A6C
	public void EndRenderTarget()
	{
		if (!true)
		{
		}
		GeometryBufferInstance.EndBuffer();
		this.cameraObject.Render();
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00057890 File Offset: 0x00055A90
	public DistortionRenderTargetManager()
	{
	}

	// Token: 0x0400216A RID: 8554
	public static DistortionRenderTargetManager _instance;

	// Token: 0x0400216B RID: 8555
	private Camera cameraObject;

	// Token: 0x0400216C RID: 8556
	public RenderTexture DistortionTarget;

	// Token: 0x0400216D RID: 8557
	public RenderTexture DistortionTargetSwap;

	// Token: 0x0400216E RID: 8558
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTarget;

	// Token: 0x0400216F RID: 8559
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTargetSwap;
}
