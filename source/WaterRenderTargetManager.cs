using System;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000309 RID: 777
public class WaterRenderTargetManager : MonoBehaviour
{
	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06001206 RID: 4614 RVA: 0x00057CE8 File Offset: 0x00055EE8
	public static WaterRenderTargetManager Instance
	{
		get
		{
			/*
An exception occurred when decompiling this method (06001206)

ICSharpCode.Decompiler.DecompilerException: Error decompiling WaterRenderTargetManager WaterRenderTargetManager::get_Instance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:WaterRenderTargetManager(var_1_19, call:WaterRenderTargetManager(GameObject::GetComponent, call:GameObject(GameObjectExtensions::FindInChildren, call:GameObject(GameObject::Find, ldstr:string("TerrariaGame")), ldstr:string("WaterRenderTargetCamera"))))
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

	// Token: 0x06001207 RID: 4615 RVA: 0x00057D10 File Offset: 0x00055F10
	private void InitialiseCamera()
	{
		int num = 1;
		Camera component = base.gameObject.GetComponent<Camera>();
		this.cameraObject = component;
		if (num == 0)
		{
		}
		Camera camera = this.cameraObject;
		RenderTexture renderTarget = this.RenderTarget;
		camera.targetTexture = renderTarget;
		Transform transform = this.cameraObject.transform;
		Camera camera2 = this.cameraObject;
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x00057D6C File Offset: 0x00055F6C
	public void UpdateRenderTarget()
	{
		RenderTexture renderTarget = this.RenderTarget;
		if (!true)
		{
		}
		this.InitialiseCamera();
		this.cameraObject.Render();
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00057D94 File Offset: 0x00055F94
	public WaterRenderTargetManager()
	{
	}

	// Token: 0x04002191 RID: 8593
	public static WaterRenderTargetManager _instance;

	// Token: 0x04002192 RID: 8594
	private Camera cameraObject;

	// Token: 0x04002193 RID: 8595
	public RenderTexture RenderTarget;

	// Token: 0x04002194 RID: 8596
	public Microsoft.Xna.Framework.Graphics.Texture2D GameRenderTarget;
}
