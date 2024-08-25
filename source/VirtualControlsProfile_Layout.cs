using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Terraria.Localization;

// Token: 0x0200024C RID: 588
[JsonObject(MemberSerialization.OptIn)]
[Serializable]
public class VirtualControlsProfile_Layout
{
	// Token: 0x06000D3D RID: 3389 RVA: 0x0003F5A4 File Offset: 0x0003D7A4
	public bool HasProfileMapping()
	{
		/*
An exception occurred when decompiling this method (06000D3D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean VirtualControlsProfile_Layout::HasProfileMapping()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ContolType(var_0_0B, ldfld:ContolType(VirtualControlsBinding_Layout::Action, ldfld:class VirtualControlsBinding_Layout[][exp:VirtualControlsBinding_Layout](VirtualControlsProfile_Layout::Controls, ldloc:VirtualControlsProfile_Layout(this))))
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

	// Token: 0x06000D3E RID: 3390 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
	public string GetDisplayName(float maxWidth = 800f)
	{
		bool flag = string.IsNullOrEmpty(this.EditedName);
		string id = this.Id;
		string textValue = Language.GetTextValue("VCProfileName." + id);
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(textValue);
		string text = textValue + "...";
		long num = 0L;
		SpriteFont spriteFont2;
		Vector2 vector2 = spriteFont2.MeasureString(text);
		int stringLength = textValue._stringLength;
		long num2 = 0L;
		return textValue.Substring((int)num2, (int)num);
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0003F644 File Offset: 0x0003D844
	public VirtualControlsHardwareConfiguration_Layout HardwareConfig
	{
		get
		{
			VirtualControlsHardwareConfiguration_Layout cachedHardware = this._cachedHardware;
			if (cachedHardware != null)
			{
				string id = cachedHardware.Id;
				string hardware = this.Hardware;
				bool flag = id != hardware;
			}
			string hardware2 = this.Hardware;
			VirtualControlsHardwareConfiguration_Layout virtualControlsHardwareConfiguration_Layout;
			this._cachedHardware = virtualControlsHardwareConfiguration_Layout;
			return virtualControlsHardwareConfiguration_Layout;
		}
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x0003F68C File Offset: 0x0003D88C
	public void Copy(VirtualControlsProfile_Layout other)
	{
		string editedName = other.EditedName;
		this.EditedName = editedName;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType action = other.Controls.Action;
		VirtualControlsBinding_Layout[] controls = other.Controls;
		VirtualControlsBinding_Layout[] controls2 = this.Controls;
		VirtualControlsHardwareConfigurationMapping_Layout.ContolType action2 = controls.Action;
		string slotId = controls.SlotId;
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
	public bool IsSame(VirtualControlsProfile_Layout other)
	{
		/*
An exception occurred when decompiling this method (06000D41)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean VirtualControlsProfile_Layout::IsSame(VirtualControlsProfile_Layout)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(VirtualControlsProfile_Layout::EditedName, ldloc:VirtualControlsProfile_Layout(this)))
	stloc:string(var_1_0D, ldfld:string(VirtualControlsProfile_Layout::EditedName, ldloc:VirtualControlsProfile_Layout(other)))
	stloc:bool(var_2_15, call:bool(string::op_Inequality, ldloc:string(var_0_06), ldloc:string(var_1_0D)))
	stloc:class VirtualControlsBinding_Layout[](var_3_1C, ldfld:class VirtualControlsBinding_Layout[](VirtualControlsProfile_Layout::Controls, ldloc:VirtualControlsProfile_Layout(this)))
	stloc:class VirtualControlsBinding_Layout[](var_4_23, ldfld:class VirtualControlsBinding_Layout[](VirtualControlsProfile_Layout::Controls, ldloc:VirtualControlsProfile_Layout(other)))
	stloc:ContolType(var_5_2B, ldfld:ContolType(VirtualControlsBinding_Layout::Action, ldloc:class VirtualControlsBinding_Layout[][exp:VirtualControlsBinding_Layout](var_3_1C)))
	stloc:ContolType(var_6_34, ldfld:ContolType(VirtualControlsBinding_Layout::Action, ldloc:class VirtualControlsBinding_Layout[][exp:VirtualControlsBinding_Layout](var_4_23)))
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

	// Token: 0x06000D42 RID: 3394 RVA: 0x0003F724 File Offset: 0x0003D924
	public VirtualControlsProfile_Layout()
	{
	}

	// Token: 0x0400184E RID: 6222
	[JsonProperty]
	public string Id;

	// Token: 0x0400184F RID: 6223
	[JsonProperty]
	public string EditedName;

	// Token: 0x04001850 RID: 6224
	[JsonProperty]
	public string Hardware;

	// Token: 0x04001851 RID: 6225
	private VirtualControlsHardwareConfiguration_Layout _cachedHardware;

	// Token: 0x04001852 RID: 6226
	[JsonProperty]
	public VirtualControlsBinding_Layout[] Controls;
}
