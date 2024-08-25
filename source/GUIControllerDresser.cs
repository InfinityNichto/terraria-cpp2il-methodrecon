using System;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x020000C2 RID: 194
public class GUIControllerDresser : GUIPageContentController
{
	// Token: 0x060004BC RID: 1212 RVA: 0x0000EB54 File Offset: 0x0000CD54
	public GUIControllerDresser()
		: base(GUIPageIcons.Category.Dresser)
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x0000EB70 File Offset: 0x0000CD70
	public override void Activate()
	{
		if (!true)
		{
		}
		if (Main.selClothes != 0)
		{
			return;
		}
		int num;
		this.Item = num;
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x0000EB94 File Offset: 0x0000CD94
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		/*
An exception occurred when decompiling this method (060004BE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling GUIControllerItem GUIControllerDresser::Navigate(Microsoft.Xna.Framework.Vector2)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0064:
	stloc:int32(var_10_6C, callgetter:int32(Main::get_selClothes))
	stloc:int32(var_11_74, ldfld:int32(GUIControllerDresser::Item, ldloc:GUIControllerDresser(this)))
	stloc:int32(var_12_78, ldc.i4:int32(9))
	stfld:Controls(GUIControllerDresser::selectedControl, ldloc:GUIControllerDresser(this), ldloc:int32[exp:Controls](var_12_78))
	stloc:int32(var_13_84, ldc.i4:int32(9))
	stfld:Controls(GUIControllerDresser::selectedControl, ldloc:GUIControllerDresser(this), ldloc:int32[exp:Controls](var_13_84))
	stloc:int32(var_14_94, ldfld:int32(GUIControllerDresser::Item, ldloc:GUIControllerDresser(this)))
	stloc:int32(var_15_9C, ldfld:int32(GUIControllerDresser::Item, ldloc:GUIControllerDresser(this)))
	stfld:int32(GUIControllerDresser::Item, ldloc:GUIControllerDresser(this), ldloc:int32(var_15_9C))
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

	// Token: 0x060004BF RID: 1215 RVA: 0x0000EC48 File Offset: 0x0000CE48
	public override Rectangle GetSelectedItemRegion()
	{
		Rectangle rectangle;
		ControlAnchor.SetGridItemRegion(rectangle);
		GUIControllerDresser.Controls controls = this.selectedControl;
		return rectangle;
	}

	// Token: 0x0400044B RID: 1099
	public GUIControllerDresser.Controls selectedControl = GUIControllerDresser.Controls.Element;

	// Token: 0x0400044C RID: 1100
	public int Item;

	// Token: 0x020000C3 RID: 195
	public enum Controls
	{
		// Token: 0x0400044E RID: 1102
		Style,
		// Token: 0x0400044F RID: 1103
		Skin,
		// Token: 0x04000450 RID: 1104
		Eyes,
		// Token: 0x04000451 RID: 1105
		Shirt,
		// Token: 0x04000452 RID: 1106
		Undershirt,
		// Token: 0x04000453 RID: 1107
		Pants,
		// Token: 0x04000454 RID: 1108
		Shoes,
		// Token: 0x04000455 RID: 1109
		Element,
		// Token: 0x04000456 RID: 1110
		Back,
		// Token: 0x04000457 RID: 1111
		Change
	}
}
