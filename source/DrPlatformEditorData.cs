using System;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class DrPlatformEditorData : MonoBehaviour
{
	// Token: 0x0600014D RID: 333 RVA: 0x00004384 File Offset: 0x00002584
	private void Awake()
	{
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600014E RID: 334 RVA: 0x00004394 File Offset: 0x00002594
	// (set) Token: 0x0600014F RID: 335 RVA: 0x000043C0 File Offset: 0x000025C0
	public DrEditorProfile ActiveProfile
	{
		get
		{
			/*
An exception occurred when decompiling this method (0600014E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling DrEditorProfile DrPlatformEditorData::get_ActiveProfile()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_15, ldfld:string(DrEditorProfile::RootFolder, ldfld:class DrEditorProfile[][exp:DrEditorProfile](DrPlatformEditorData::EditorProfiles, ldloc:DrPlatformEditorData(this))))
	stfld:DrEditorProfile(DrPlatformEditorData::_activeProfile, ldloc:DrPlatformEditorData(this), ldloc:bool[exp:DrEditorProfile](var_0_06))
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
			this._activeProfile = value;
		}
	}

	// Token: 0x06000150 RID: 336 RVA: 0x000043D4 File Offset: 0x000025D4
	public DrPlatformEditorData()
	{
	}

	// Token: 0x040000DF RID: 223
	public static DrPlatformEditorData Instance;

	// Token: 0x040000E0 RID: 224
	public bool ForcePlatform;

	// Token: 0x040000E1 RID: 225
	public DrPlatform.DrPlatformType ForcedPlatform;

	// Token: 0x040000E2 RID: 226
	public bool ForceSKU;

	// Token: 0x040000E3 RID: 227
	public DrPlatform.DrSKUType ForcedSKU;

	// Token: 0x040000E4 RID: 228
	public bool EditorHasMultiplayerPermission;

	// Token: 0x040000E5 RID: 229
	public bool EditorHasChatPermission;

	// Token: 0x040000E6 RID: 230
	public bool EditorHasUGCPermission;

	// Token: 0x040000E7 RID: 231
	public bool EditorHasPlatformFriends;

	// Token: 0x040000E8 RID: 232
	public bool EditorForceControllerDisconnected;

	// Token: 0x040000E9 RID: 233
	public bool EditorForceSplitScreenProfile;

	// Token: 0x040000EA RID: 234
	public bool EditorSwitchedDocked;

	// Token: 0x040000EB RID: 235
	public bool EditorIsTrial;

	// Token: 0x040000EC RID: 236
	public bool EditorSwitchJoyCon;

	// Token: 0x040000ED RID: 237
	public bool EditorMouseAsTouch;

	// Token: 0x040000EE RID: 238
	public bool EditorIsChromebook;

	// Token: 0x040000EF RID: 239
	public bool UseProfiles;

	// Token: 0x040000F0 RID: 240
	public bool ValidateSetup;

	// Token: 0x040000F1 RID: 241
	private bool _firstProfileAccess = true;

	// Token: 0x040000F2 RID: 242
	private DrEditorProfile _activeProfile;

	// Token: 0x040000F3 RID: 243
	public int InitialEditorProfile;

	// Token: 0x040000F4 RID: 244
	public DrEditorProfile[] EditorProfiles;
}
