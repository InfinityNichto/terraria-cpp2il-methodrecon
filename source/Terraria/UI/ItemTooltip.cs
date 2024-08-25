using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.UI
{
	// Token: 0x02000712 RID: 1810
	public class ItemTooltip
	{
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x002354A4 File Offset: 0x002336A4
		public int Lines
		{
			get
			{
				this.ValidateTooltip();
				if (this._tooltipLines != null)
				{
					return;
				}
			}
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x002354C0 File Offset: 0x002336C0
		private ItemTooltip()
		{
		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x002354D4 File Offset: 0x002336D4
		private ItemTooltip(short id, string key)
		{
			LocalizedText text = Language.GetText(key);
			this._text = text;
			this._id = id;
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x000021DB File Offset: 0x000003DB
		public static ItemTooltip FromLanguageKey(short id, string key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x002354FC File Offset: 0x002336FC
		public string GetLine(int line)
		{
			/*
An exception occurred when decompiling this method (06003BF5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.UI.ItemTooltip::GetLine(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ItemTooltip::ValidateTooltip, ldloc:ItemTooltip(this))
	stloc:string[](var_0_0C, ldfld:string[](ItemTooltip::_tooltipLines, ldloc:ItemTooltip(this)))
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

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00235518 File Offset: 0x00233718
		private void ValidateTooltip()
		{
			ulong validatorKey = this._validatorKey;
			if (!true)
			{
			}
			LocalizedText text = this._text;
			if (text != null)
			{
				string <Value>k__BackingField = text.<Value>k__BackingField;
				short id = this._id;
				return;
			}
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00235570 File Offset: 0x00233770
		public static void AddGlobalProcessor(TooltipProcessor processor)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00235584 File Offset: 0x00233784
		public static void RemoveGlobalProcessor(TooltipProcessor processor)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00235594 File Offset: 0x00233794
		public static void ClearGlobalProcessors()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x002355A8 File Offset: 0x002337A8
		public static void InvalidateTooltips()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x002355B8 File Offset: 0x002337B8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemTooltip()
		{
		}

		// Token: 0x04007B5B RID: 31579
		public static readonly ItemTooltip None;

		// Token: 0x04007B5C RID: 31580
		private static readonly List<TooltipProcessor> _globalProcessors;

		// Token: 0x04007B5D RID: 31581
		private static ulong _globalValidatorKey;

		// Token: 0x04007B5E RID: 31582
		private string[] _tooltipLines;

		// Token: 0x04007B5F RID: 31583
		private ulong _validatorKey;

		// Token: 0x04007B60 RID: 31584
		private readonly LocalizedText _text;

		// Token: 0x04007B61 RID: 31585
		private string _processedText;

		// Token: 0x04007B62 RID: 31586
		private readonly short _id;
	}
}
