using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Items;
using Terraria.GameContent.UI;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x020003EE RID: 1006
	public class Item : Entity
	{
		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x00072900 File Offset: 0x00070B00
		public string Name
		{
			get
			{
				string nameOverride = this._nameOverride;
				if (nameOverride != null)
				{
					return nameOverride;
				}
				return Lang.GetItemNameValue(this.type);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00072924 File Offset: 0x00070B24
		public string HoverName
		{
			get
			{
				string text = this.AffixName();
				int num = this.stack;
				string text2;
				return text + " (" + text2 + ")";
			}
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00072954 File Offset: 0x00070B54
		public static void StartCachingType(int t)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00072964 File Offset: 0x00070B64
		public static void DropCache(IEntitySource reason, Vector2 pos, Vector2 spread, int t, bool stopCaching = true)
		{
			if (!true)
			{
			}
			if (32640 == 0)
			{
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetNPCSource_FromThis()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000021DB File Offset: 0x000003DB
		public IEntitySource GetItemSource_Misc(int itemSourceId)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0007297C File Offset: 0x00070B7C
		public bool PaintOrCoating
		{
			get
			{
				return this.paint == 0 || true;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00072994 File Offset: 0x00070B94
		public bool FitsAccessoryVanitySlot
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000729A4 File Offset: 0x00070BA4
		public int OriginalRarity
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Item::get_OriginalRarity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(Item::type, ldloc:Item(this)))
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x000729BC File Offset: 0x00070BBC
		public int OriginalDamage
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B02)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Item::get_OriginalDamage()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(Item::type, ldloc:Item(this)))
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x000729D4 File Offset: 0x00070BD4
		public int OriginalDefense
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B03)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Item::get_OriginalDefense()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_09, ldfld:int32(Item::type, ldloc:Item(this)))
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

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000729EC File Offset: 0x00070BEC
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x00072A00 File Offset: 0x00070C00
		public ItemVariant Variant
		{
			[CompilerGenerated]
			get
			{
				return this.<Variant>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Variant>k__BackingField = value;
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00072A14 File Offset: 0x00070C14
		public void Reset()
		{
			int num = 16256;
			this.position = num;
			if (this == null)
			{
			}
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00072A34 File Offset: 0x00070C34
		public override string ToString()
		{
			string name = this.Name;
			int num = this.netID;
			int num2 = this.stack;
			string text;
			return text;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00072A58 File Offset: 0x00070C58
		private bool CanHavePrefixes()
		{
			if (this.type != 0)
			{
				int num = this.maxStack;
				int num2 = this.damage;
				return true;
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00072A80 File Offset: 0x00070C80
		public bool Prefix(int prefixWeWant)
		{
			/*
An exception occurred when decompiling this method (06001B09)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::Prefix(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_006F:
	stfld:int32(Item::damage, ldloc:Item(this), ldloc:int64[exp:int32](var_8))
	stloc:int32(var_16_7D, ldfld:int32(Item::useAnimation, ldloc:Item(this)))
	stfld:int32(Item::useAnimation, ldloc:Item(this), ldloc:int64[exp:int32](var_8))
	stloc:int32(var_17_8D, ldfld:int32(Item::useTime, ldloc:Item(this)))
	stfld:int32(Item::useTime, ldloc:Item(this), ldloc:int64[exp:int32](var_8))
	stloc:int32(var_18_9D, ldfld:int32(Item::reuseDelay, ldloc:Item(this)))
	stfld:int32(Item::reuseDelay, ldloc:Item(this), ldloc:int64[exp:int32](var_8))
	stloc:int32(var_19_AD, ldfld:int32(Item::mana, ldloc:Item(this)))
	stfld:int32(Item::mana, ldloc:Item(this), ldloc:int64[exp:int32](var_8))
	stloc:float32(var_20_BD, ldfld:float32(Item::knockBack, ldloc:Item(this)))
	stloc:float32(var_21_C5, ldfld:float32(Item::scale, ldloc:Item(this)))
	stloc:float32(var_22_CD, ldfld:float32(Item::shootSpeed, ldloc:Item(this)))
	stloc:int32(var_23_D5, ldfld:int32(Item::crit, ldloc:Item(this)))
	stfld:float32(Item::knockBack, ldloc:Item(this), ldloc:float32(var_20_BD))
	stfld:float32(Item::scale, ldloc:Item(this), ldloc:float32(var_21_C5))
	stfld:float32(Item::shootSpeed, ldloc:Item(this), ldloc:float32(var_22_CD))
	stfld:int32(Item::crit, ldloc:Item(this), ldloc:int32(var_23_D5))
	stloc:int32(var_24_FD, ldfld:int32(Item::rare, ldloc:Item(this)))
	stloc:int32(var_25_105, ldfld:int32(Item::rare, ldloc:Item(this)))
	stloc:int32(var_26_10D, ldfld:int32(Item::rare, ldloc:Item(this)))
	stloc:int32(var_27_115, ldfld:int32(Item::rare, ldloc:Item(this)))
	stfld:int32(Item::rare, ldloc:Item(this), ldloc:int32(var_27_115))
	stloc:int32(var_28_121, ldc.i4:int32(11))
	stfld:int32(Item::rare, ldloc:Item(this), ldloc:int32(var_28_121))
	stloc:int32(var_29_131, ldfld:int32(Item::value, ldloc:Item(this)))
	stloc:int32(var_30_138, ldc.i4:int32(32640))
	stfld:uint8(Item::prefix, ldloc:Item(this), ldloc:int64[exp:uint8](var_12))
	stfld:int32(Item::value, ldloc:Item(this), ldloc:int32(var_30_138))
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

		// Token: 0x06001B0A RID: 6922 RVA: 0x00072BDC File Offset: 0x00070DDC
		public bool CanRollPrefix(int prefix)
		{
			if (this.type == 0)
			{
				return;
			}
			int num = this.maxStack;
			int num2 = this.damage;
			if (!this.accessory || this.GetRollablePrefixes() != null)
			{
				return;
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00072C18 File Offset: 0x00070E18
		public bool CanApplyPrefix(int prefix)
		{
			bool flag = this.CanRollPrefix(prefix);
			bool flag2;
			return flag2;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00072C30 File Offset: 0x00070E30
		private bool TryGetPrefixStatMultipliersForItem(int rolledPrefix, [Out] float dmg, [Out] float kb, [Out] float spd, [Out] float size, [Out] float shtspd, [Out] float mcst, [Out] int crt)
		{
			/*
An exception occurred when decompiling this method (06001B0C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::TryGetPrefixStatMultipliersForItem(System.Int32,System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_010C:
	stloc:int32(var_19_112, ldfld:int32(Item::mana, ldloc:Item(this)))
	stloc:float32(var_20_11A, ldfld:float32(Item::knockBack, ldloc:Item(this)))
	stloc:int32(var_23_127, ldc.i4:int32(52429))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_14_DE), ldloc:int32(var_23_127))
	stloc:int32(var_24_137, ldc.i4:int32(13107))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_14_DE), ldloc:int32(var_24_137))
	stloc:int32(var_25_147, ldc.i4:int32(26214))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_16_F2), ldloc:int32(var_25_147))
	stloc:int32(var_26_157, ldc.i4:int32(52429))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_14_DE), ldloc:int32(var_26_157))
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

		// Token: 0x06001B0D RID: 6925 RVA: 0x00072DA0 File Offset: 0x00070FA0
		public int[] GetRollablePrefixes()
		{
			/*
An exception occurred when decompiling this method (06001B0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Terraria.Item::GetRollablePrefixes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:bool(var_1_1A, call:bool(Item::IsAPrefixableAccessory, ldloc:Item(this)))
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

		// Token: 0x06001B0E RID: 6926 RVA: 0x00072DCC File Offset: 0x00070FCC
		private bool RollAPrefix(UnifiedRandom random, int rolledPrefix)
		{
			while (this.GetRollablePrefixes() == null)
			{
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00072DE4 File Offset: 0x00070FE4
		public bool IsAPrefixableAccessory()
		{
			/*
An exception occurred when decompiling this method (06001B0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::IsAPrefixableAccessory()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	brtrue(IL_0000, ldloc:bool(var_0))
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

		// Token: 0x06001B10 RID: 6928 RVA: 0x00072E08 File Offset: 0x00071008
		public string AffixName()
		{
			if (!true)
			{
			}
			byte b = this.prefix;
			return this.Name;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00072E30 File Offset: 0x00071030
		public void RebuildTooltip()
		{
			int num = this.type;
			ItemTooltip tooltip = Lang.GetTooltip(this.netID);
			this.ToolTip = tooltip;
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00072E58 File Offset: 0x00071058
		public Rectangle getRect()
		{
			/*
An exception occurred when decompiling this method (06001B12)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Rectangle Terraria.Item::getRect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, ldfld:float32(Vector2::X, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Item[exp:Entity](this))))
	stloc:float32(var_1_17, ldfld:float32(Vector2::Y, ldfld:Vector2[exp:valuetype Microsoft.Xna.Framework.Vector2&](Entity::position, ldloc:Item[exp:Entity](this))))
	stloc:int32(var_2_1E, ldfld:int32(Entity::width, ldloc:Item[exp:Entity](this)))
	stloc:bool(var_3_25, ldfld:bool(Entity::wet, ldloc:Item[exp:Entity](this)))
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

		// Token: 0x06001B13 RID: 6931 RVA: 0x00072E8C File Offset: 0x0007108C
		public bool checkMat()
		{
			/*
An exception occurred when decompiling this method (06001B13)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::checkMat()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:int64(var_17_67, ldc.i4:int64(0))
	stfld:bool(Item::material, ldloc:Item(this), ldloc:int64[exp:bool](var_17_67))
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

		// Token: 0x06001B14 RID: 6932 RVA: 0x00072F0C File Offset: 0x0007110C
		public void netDefaults(int type)
		{
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00072F1C File Offset: 0x0007111C
		public static int BannerToItem(int banner)
		{
			return 5352;
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00072F50 File Offset: 0x00071150
		public static int NPCtoBanner(int i)
		{
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00072F60 File Offset: 0x00071160
		public static int BannerToNPC(int i)
		{
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00072F70 File Offset: 0x00071170
		public bool FitsAmmoSlot()
		{
			if (this.type != 0)
			{
				int num = this.ammo;
				int num2 = this.bait;
			}
			bool flag = this.notAmmo;
			if (flag)
			{
			}
			return true;
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00072FA8 File Offset: 0x000711A8
		public bool CanFillEmptyAmmoSlot()
		{
			/*
An exception occurred when decompiling this method (06001B19)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::CanFillEmptyAmmoSlot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:int32(var_2_1F, ldfld:int32(Item::type, ldloc:Item(this)))
	stloc:bool(var_4_28, ldfld:bool(Item::notAmmo, ldloc:Item(this)))
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

		// Token: 0x06001B1A RID: 6938 RVA: 0x00072FE0 File Offset: 0x000711E0
		public void SetDefaults1(int type)
		{
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00080430 File Offset: 0x0007E630
		public void SetDefaults2(int type)
		{
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0008A484 File Offset: 0x00088684
		public void SetDefaults3(int type)
		{
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000919B8 File Offset: 0x0008FBB8
		public void DefaultToQuestFish()
		{
			this.questItem = true;
			this.maxStack = 1;
			this.uniqueStack = true;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000919DC File Offset: 0x0008FBDC
		public void SetDefaults4(int type)
		{
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0009C6BC File Offset: 0x0009A8BC
		public void DefaultToGolfBall(int projid)
		{
			this.shoot = projid;
			this.useStyle = 1;
			this.shootSpeed = (float)16704;
			this.maxStack = 1;
			if (16704 == 0)
			{
			}
			this.noUseGraphic = 257 != 0;
			this.UseSound = 16704;
			this.accessory = true;
			if (16704 == 0)
			{
			}
			this.rare = 2;
			this.value = 10000;
			this.hasVanityEffects = true;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0009C730 File Offset: 0x0009A930
		public void SetDefaults5(int type)
		{
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000A5838 File Offset: 0x000A3A38
		public void DefaultToSolution(int projectileId)
		{
			int num = 1;
			this.shoot = num;
			if (num == 0)
			{
			}
			this.ammo = num;
			if (num == 0)
			{
			}
			int num2 = 1500;
			int num3 = 3;
			this.value = num2;
			this.rare = num3;
			int num4 = 1;
			this.consumable = num4 != 0;
			this.maxStack = num2;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000A5884 File Offset: 0x000A3A84
		public void DefaultToWhip(int projectileId, int dmg, float kb, float shootspeed, int animationTotalTime = 30)
		{
			this.useAnimation = animationTotalTime;
			this.stack = animationTotalTime;
			this.useStyle = 1;
			this.width = (int)kb;
			this.shoot = projectileId;
			if (!true)
			{
			}
			this.summon = true;
			this.noUseGraphic = 257 != 0;
			this.damage = dmg;
			this.UseSound = 1;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000A58DC File Offset: 0x000A3ADC
		public void DefaultTokite(int projId)
		{
			this.width = (int)2.8E-44f;
			long num = 0L;
			this.DefaultToThrownWeapon(projId, 30, 2.8E-44f, num != 0L);
			this.noUseGraphic = true;
			this.maxStack = 1;
			this.rare = 1;
			this.value = 20000;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000A5928 File Offset: 0x000A3B28
		public void ChangeItemType(int to)
		{
			bool flag = this.favorited;
			this.favorited = flag;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000A5944 File Offset: 0x000A3B44
		public void DefaultToVanitypet(int projId, int buffID)
		{
			this.useStyle = 1;
			this.rare = 3;
			this.noMelee = true;
			this.buffType = buffID;
			this.value = 34464;
			this.shoot = projId;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x000A5980 File Offset: 0x000A3B80
		public bool IsACoin
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001B26)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::get_IsACoin()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::type, ldloc:Item(this)))
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

		// Token: 0x06001B27 RID: 6951 RVA: 0x000A5994 File Offset: 0x000A3B94
		public static bool IsAGolfingItem(Item item)
		{
			for (;;)
			{
				int num = 1;
				if (num == 0)
				{
				}
				if (num != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000A59AC File Offset: 0x000A3BAC
		private void DefaultToSeaShell()
		{
			this.useStyle = 1;
			this.autoReuse = true;
			int num = this.type;
			this.consumable = true;
			this.createTile = 324;
			this.placeStyle = 4;
			if (4 == 0)
			{
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000A5A14 File Offset: 0x000A3C14
		public void DefaultToCapturedCritter(short npcIdToSpawnOnUse)
		{
			this.useStyle = 1;
			this.autoReuse = 257 != 0;
			if (257 == 0)
			{
			}
			this.consumable = true;
			this.noUseGraphic = true;
			this.maxStack = 257;
			this.makeNPC = npcIdToSpawnOnUse;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000A5A5C File Offset: 0x000A3C5C
		public void DefaultToStaff(int projType, float pushForwardSpeed, int singleShotTime, int manaPerShot)
		{
			this.useAnimation = singleShotTime;
			this.stack = singleShotTime;
			this.shoot = projType;
			this.mana = manaPerShot;
			this.autoReuse = true;
			this.useStyle = 5;
			this.noMelee = true;
			this.magic = true;
			this.width = (int)pushForwardSpeed;
			if (!true)
			{
			}
			this.UseSound = 1;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000A5AB4 File Offset: 0x000A3CB4
		public void DefaultToSpear(int projType, float pushForwardSpeed, int animationTime)
		{
			this.useStyle = 5;
			if (5 == 0)
			{
			}
			this.shoot = projType;
			this.noUseGraphic = 257 != 0;
			this.melee = true;
			this.UseSound = 5;
			this.useAnimation = animationTime;
			this.stack = animationTime;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000A5AFC File Offset: 0x000A3CFC
		private void SetFoodDefaults(int type)
		{
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000A6168 File Offset: 0x000A4368
		public void DefaultToMount(int mount)
		{
			this.mountType = mount;
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000A617C File Offset: 0x000A437C
		public void DefaultToPlaceableWall(ushort wallToPlace)
		{
			this.useStyle = 1;
			this.autoReuse = 257 != 0;
			if (257 == 0)
			{
			}
			this.consumable = true;
			this.maxStack = 257;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x000A61B4 File Offset: 0x000A43B4
		public void SetWeaponValues(int dmg, float knockback, int bonusCritChance = 0)
		{
			this.damage = dmg;
			this.crit = bonusCritChance;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000A61D0 File Offset: 0x000A43D0
		public void DefaultToBow(int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			if (!true)
			{
			}
			this.useStyle = 5;
			this.useAnimation = singleShotTime;
			this.stack = singleShotTime;
			this.shoot = 1;
			this.noMelee = true;
			this.ranged = true;
			this.useAmmo = 1;
			if (!true)
			{
			}
			this.UseSound = 1;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000A621C File Offset: 0x000A441C
		public void DefaultToMagicWeapon(int projType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			this.useAnimation = singleShotTime;
			this.stack = singleShotTime;
			this.shoot = projType;
			this.useStyle = 5;
			this.noMelee = true;
			this.magic = true;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000A6254 File Offset: 0x000A4454
		public void DefaultToRangedWeapon(int baseProjType, int ammoID, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			this.useAnimation = singleShotTime;
			this.stack = singleShotTime;
			this.shoot = baseProjType;
			this.useAmmo = ammoID;
			this.useStyle = 5;
			this.noMelee = true;
			this.ranged = true;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000A6294 File Offset: 0x000A4494
		public void DefaultToThrownWeapon(int baseProjType, int singleShotTime, float shotVelocity, bool hasAutoReuse = false)
		{
			this.useAnimation = singleShotTime;
			this.stack = singleShotTime;
			this.shoot = baseProjType;
			this.useStyle = 1;
			this.noMelee = true;
			this.ranged = true;
			this.consumable = true;
			if (!true)
			{
			}
			this.maxStack = 1;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000A62DC File Offset: 0x000A44DC
		private void DefaultToTorch(int tileStyleToPlace, bool allowWaterPlacement = false)
		{
			this.flame = true;
			this.holdStyle = 1;
			this.noWet = true;
			this.autoReuse = true;
			if (!true)
			{
			}
			this.createTile = 4;
			this.placeStyle = tileStyleToPlace;
			this.consumable = true;
			this.value = 60;
			this.useStyle = 1;
			this.useTurn = true;
			this.maxStack = 1;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000A633C File Offset: 0x000A453C
		public void DefaultToPlaceableTile(int tileIDToPlace, int tileStyleToPlace = 0)
		{
			this.DefaultToPlaceableTile((ushort)tileIDToPlace, tileStyleToPlace);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000A6354 File Offset: 0x000A4554
		public void DefaultToPlaceableTile(ushort tileIDToPlace, int tileStyleToPlace = 0)
		{
			this.placeStyle = tileStyleToPlace;
			this.createTile = 1;
			this.useStyle = 1;
			if (!true)
			{
			}
			this.useTurn = true;
			this.maxStack = 1;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000A6388 File Offset: 0x000A4588
		public void MakeUsableWithChlorophyteExtractinator()
		{
			this.useStyle = 1;
			this.chlorophyteExtractinatorConsumable = true;
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000A63A4 File Offset: 0x000A45A4
		public void DefaultToGolfClub(int newwidth, int newheight)
		{
			this.width = newwidth;
			this.wet = newheight != 0;
			this.channel = true;
			this.holdStyle = (byte)2052;
			this.noMelee = true;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000A63D8 File Offset: 0x000A45D8
		public void DefaultToLawnMower(int newwidth, int newheight)
		{
			this.width = newwidth;
			this.wet = newheight != 0;
			this.holdStyle = (byte)2817;
			if (2817 == 0)
			{
			}
			this.autoReuse = true;
			this.UseSound = 2817;
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000A6418 File Offset: 0x000A4618
		public void DefaultToFood(int newwidth, int newheight, int foodbuff, int foodbuffduration, bool useGulpSound = false, int animationTime = 17)
		{
			if (!true)
			{
			}
			this.useStyle = (byte)1016;
			this.useTurn = true;
			this.UseSound = 1;
			this.useAnimation = animationTime;
			this.stack = animationTime;
			if (!true)
			{
			}
			this.consumable = true;
			this.width = newwidth;
			this.wet = newheight != 0;
			this.buffType = foodbuff;
			this.buffTime = foodbuffduration;
			this.rare = 1;
			this.maxStack = 1;
			this.value = 2000;
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000A6494 File Offset: 0x000A4694
		public void DefaultToHealingPotion(int newwidth, int newheight, int healingAmount, int animationTime = 17)
		{
			if (!true)
			{
			}
			this.useStyle = 9;
			this.useTurn = true;
			this.useAnimation = animationTime;
			this.stack = animationTime;
			this.UseSound = 1;
			if (!true)
			{
			}
			this.width = newwidth;
			this.wet = newheight != 0;
			this.rare = 1;
			this.value = 2000;
			this.potion = 257 != 0;
			this.maxStack = 1;
			this.healLife = healingAmount;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000A6508 File Offset: 0x000A4708
		public void SetShopValues(ItemRarityColor rarity, int coinValue)
		{
			this.rare = (int)rarity;
			this.value = coinValue;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000A6524 File Offset: 0x000A4724
		public void DefaultToHeadgear(int newwidth, int newheight, int helmetArtID)
		{
			this.width = newwidth;
			this.wet = newheight != 0;
			this.headSlot = helmetArtID;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000A6548 File Offset: 0x000A4748
		public void DefaultToAccessory(int newwidth = 24, int newheight = 24)
		{
			this.width = newwidth;
			this.wet = newheight != 0;
			this.accessory = true;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000A656C File Offset: 0x000A476C
		public void DefaultToGuitar(int newwidth = 24, int newheight = 24)
		{
			this.width = newwidth;
			this.wet = newheight != 0;
			this.autoReuse = true;
			this.holdStyle = (byte)3077;
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x000A659C File Offset: 0x000A479C
		public void DefaultToMusicBox(int style)
		{
			this.createTile = 139;
			this.placeStyle = style;
			this.useStyle = 1;
			this.useTurn = true;
			this.rare = 4;
			this.value = 34464;
			this.accessory = true;
			this.hasVanityEffects = true;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000A65EC File Offset: 0x000A47EC
		public void SetDefaults(int Type = 0)
		{
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000A65FC File Offset: 0x000A47FC
		public void SetDefaults(int Type, bool noMatCheck = false, [Optional] ItemVariant variant)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000A6A18 File Offset: 0x000A4C18
		public void OnCreated(ItemCreationContext context)
		{
			int num = this.type;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000A6A30 File Offset: 0x000A4C30
		public void ResetStats(int Type)
		{
			int num = 65535;
			int num2 = 1;
			this.makeNPC = (short)num;
			this.active = num2 != 0;
			if (num == 0)
			{
			}
			int num3 = 16256;
			int num4 = 65535;
			this.glowMask = (short)num4;
			this.scale = (float)num3;
			this.handOnSlot = (sbyte)num4;
			this.neckSlot = (sbyte)num4;
			this.type = Type;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x000A6A88 File Offset: 0x000A4C88
		public Color GetAlphaFaded(Color newColor)
		{
			int num = this.alpha;
			Color color;
			return color;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x000A6AA0 File Offset: 0x000A4CA0
		public Color GetAlpha(Color newColor)
		{
			/*
An exception occurred when decompiling this method (06001B46)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.Item::GetAlpha(Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00C0:
	stloc:int32(var_28_C6, ldfld:int32(Item::alpha, ldloc:Item(this)))
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

		// Token: 0x06001B47 RID: 6983 RVA: 0x000A6B94 File Offset: 0x000A4D94
		public Color GetColor(Color newColor)
		{
			byte g = this.color.G;
			byte r = this.color.R;
			byte b = this.color.B;
			Color color = this.color;
			Color color2;
			return color2;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000A6BD0 File Offset: 0x000A4DD0
		public static bool MechSpawn(float x, float y, int type)
		{
			/*
An exception occurred when decompiling this method (06001B48)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::MechSpawn(System.Single,System.Single,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001B49 RID: 6985 RVA: 0x000021DB File Offset: 0x000003DB
		public static int buyPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000021DB File Offset: 0x000003DB
		public static int sellPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000A6BEC File Offset: 0x000A4DEC
		public bool CanShimmer()
		{
			for (;;)
			{
				bool flag = ShimmerTransforms.IsItemTransformLocked(this.GetShimmerEquivalentType());
				int num = this.type;
				int num2;
				if (5364 == 0)
				{
					num2 = this.type;
				}
				if (num2 != 0)
				{
				}
				int num3 = this.type;
				int num4 = this.createTile;
				if (num4 == 0)
				{
				}
				int num5 = this.FindDecraftAmount();
				if (num4 == 0)
				{
				}
				if (num4 != 0)
				{
					return;
				}
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000A6C4C File Offset: 0x000A4E4C
		private void Shimmering()
		{
			bool flag = this.CanShimmer();
			long num = 0L;
			Vector2 center = base.Center;
			float y = this.position.Y;
			if (15744 == 0)
			{
			}
			long num2 = 0L;
			bool flag2 = WorldGen.InWorld(0, (int)num, (int)num2);
			if (15744 == 0)
			{
			}
			Tile tile;
			byte liquid = tile.liquid;
			Tile tile2;
			bool flag3 = tile2.shimmer();
			int num3 = this.playerIndexTheItemIsReservedFor;
			int myPlayer = Main.myPlayer;
			if (this.playerIndexTheItemIsReservedFor == 0)
			{
			}
			float num4 = this.shimmerTime;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000A6CF8 File Offset: 0x000A4EF8
		private int FindDecraftAmount()
		{
			/*
An exception occurred when decompiling this method (06001B4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Item::FindDecraftAmount()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_01, ldc.i4:int32(1))
	stloc:int32(var_1_0D, call:int32(ShimmerTransforms::GetDecraftingRecipeIndex, call:int32(Item::GetShimmerEquivalentType, ldloc:Item(this))))
	stloc:int32(var_2_14, ldfld:int32(Item::stack, ldloc:Item(this)))
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

		// Token: 0x06001B4E RID: 6990 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		private int GetShimmerEquivalentType()
		{
			/*
An exception occurred when decompiling this method (06001B4E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Item::GetShimmerEquivalentType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x06001B4F RID: 6991 RVA: 0x000A6D2C File Offset: 0x000A4F2C
		private void GetShimmered()
		{
			int decraftingRecipeIndex = ShimmerTransforms.GetDecraftingRecipeIndex(this.GetShimmerEquivalentType());
			int num = this.stack;
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x000A7100 File Offset: 0x000A5300
		public static void ShimmerEffect(Vector2 shimmerPositon)
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x000A7130 File Offset: 0x000A5330
		public void FixAgainstExploit()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			int num2 = this.stack;
			int num3 = this.pick;
			this.stack = num3;
			byte b = this.prefix;
			if (b != 0)
			{
				bool flag = this.CanRollPrefix((int)b);
				if (this.prefix != 0)
				{
					long num4 = 0L;
					this.Refresh(num4 != 0L);
					return;
				}
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x000A7184 File Offset: 0x000A5384
		public void UpdateItem(int i)
		{
			this.whoAmI = i;
			bool netHost = Main.NetHost;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000A75F8 File Offset: 0x000A57F8
		private void DespawnIfMeetingConditions(int i)
		{
			if (this.type == 0)
			{
			}
			if (!this.shimmered && !this.beingGrabbed)
			{
				float x = this.position.X;
				float y = this.position.Y;
				int width = this.width;
				bool wet = this.wet;
				float x2 = this.velocity.X;
				float y2 = this.velocity.Y;
				float x3 = this.velocity.X;
				float y3 = this.velocity.Y;
				float x4 = this.position.X;
				float y4 = this.position.Y;
				bool netHost = Main.NetHost;
			}
			int num = this.type;
			int num2 = 4143;
			int num3 = this.timeSinceItemSpawned;
			float x5 = this.position.X;
			float y5 = this.position.Y;
			int width2 = this.width;
			bool wet2 = this.wet;
			float x6 = this.velocity.X;
			float y6 = this.velocity.Y;
			if (num3 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool netHost2 = Main.NetHost;
			int num4 = this.type;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
				if (num4 == 0)
				{
				}
				Vector2 center = base.Center;
				Vector2 center2 = base.Center;
				return;
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000A7764 File Offset: 0x000A5964
		public void TryCombiningIntoNearbyItems(int i)
		{
			int num = this.type;
			int num2 = this.type;
			int num3 = this.playerIndexTheItemIsReservedFor;
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000A77B4 File Offset: 0x000A59B4
		public FlexibleTileWand GetFlexibleTileWand()
		{
			int num = this.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x000A77E8 File Offset: 0x000A59E8
		private void CheckLavaDeath(int i)
		{
			if (this.type == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			int num = this.stack;
			float x = this.position.X;
			float y = this.position.Y;
			bool netHost = Main.NetHost;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x000A7870 File Offset: 0x000A5A70
		private void MoveInWorld(float gravity, float maxFallSpeed, Vector2 wetVelocity, int i)
		{
			long num;
			if (!this.shimmered)
			{
				float x = this.velocity.X;
				num = -1717986919L;
				this.velocity.X = x;
				return;
			}
			if (this.active)
			{
				int width = this.width;
				Vector2 center = base.Center;
				Vector2 center2 = base.Center;
				Vector2 center3 = base.Center;
				Vector2 center4 = base.Center;
				float x2 = this.velocity.X;
				this.velocity.X = x2;
				return;
			}
			float x3 = this.velocity.X;
			float y = this.velocity.Y;
			this.velocity.Y = y;
			float x4 = this.position.X;
			float y2 = this.position.Y;
			int width2 = this.width;
			bool wet = this.wet;
			int num2 = 1;
			this.lavaWet = num2 != 0;
			float x5 = this.position.X;
			float y3 = this.position.Y;
			int width3 = this.width;
			bool wet2 = this.wet;
			if (num2 == 0)
			{
			}
			int num3;
			if (num != 0L)
			{
				num3 = 1;
				this.honeyWet = num3 != 0;
			}
			if (num3 == 0)
			{
			}
			bool wet3 = this.wet;
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x000A7EB0 File Offset: 0x000A60B0
		private void GetPickedUpByMonsters_Special(int i)
		{
			int num = this.type;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				Rectangle hitbox = base.Hitbox;
				if (num == 0)
				{
				}
				Rectangle rectangle;
				bool flag = rectangle.Intersects(rectangle);
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000A7EF0 File Offset: 0x000A60F0
		private void GetPickedUpByMonsters_Money(int i)
		{
			float x = this.position.X;
			float y = this.position.Y;
			int width = this.width;
			bool wet = this.wet;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000A7FC0 File Offset: 0x000A61C0
		private void CombineWithNearbyItems(int myItemIndex)
		{
			int num = this.stack;
			int num2 = this.pick;
			bool flag = this.CanCombineStackInWorld();
			int num3;
			if (num != 0)
			{
				num3 = 30;
				return;
			}
			int num8;
			if (num3 != 0)
			{
				int num4 = this.type;
				bool flag2 = this.shimmered;
				int num5 = this.playerIndexTheItemIsReservedFor;
				int width = this.width;
				bool wet = this.wet;
				float x = this.position.X;
				float y = this.position.Y;
				if (width == 0)
				{
				}
				float x2 = this.velocity.X;
				float y2 = this.velocity.Y;
				this.velocity.X = x2;
				this.velocity.Y = y2;
				int num6 = this.stack;
				int num7 = this.pick;
				num8 = this.stack;
				this.stack = num6;
				if (num6 == 0)
				{
				}
				if (num6 != 0)
				{
					int num9 = this.playerIndexTheItemIsReservedFor;
					if (num6 == 0)
					{
					}
					int myPlayer = Main.myPlayer;
				}
				if (num6 == 0)
				{
				}
				bool netHost = Main.NetHost;
				if (this.playerIndexTheItemIsReservedFor == 0)
				{
				}
				return;
			}
			while (num8 != 0)
			{
			}
			while (num8 != 0)
			{
			}
			while (num8 != 0)
			{
			}
			while (num8 != 0)
			{
			}
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000A80E8 File Offset: 0x000A62E8
		public bool CanCombineStackInWorld()
		{
			/*
An exception occurred when decompiling this method (06001B5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::CanCombineStackInWorld()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	brtrue(IL_0013, ldloc:int32[exp:bool](var_0_06))
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

		// Token: 0x06001B5C RID: 7004 RVA: 0x000A810C File Offset: 0x000A630C
		private void UpdateItem_VisualEffects()
		{
			int num = this.type;
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x000A846C File Offset: 0x000A666C
		public static Rectangle GetDrawHitbox(int type, Player user)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int num3 = num2.m_value;
			return 42183576;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000A84A0 File Offset: 0x000A66A0
		public static int NewItem(Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000A84B4 File Offset: 0x000A66B4
		public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000A84C8 File Offset: 0x000A66C8
		public static int NewItem(IEntitySource source, Vector2 pos, Vector2 randomBox, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000A84DC File Offset: 0x000A66DC
		public static int NewItem(IEntitySource source, Vector2 pos, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int prefixGiven = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			if (!true)
			{
			}
			int num;
			return num;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000A84F0 File Offset: 0x000A66F0
		public static int NewItem(IEntitySource source, int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false, bool reverseLookup = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1734;
			int num3 = 1735;
			if (num2 == 0)
			{
			}
			if (1867 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			bool logicHost = Main.LogicHost;
			int num4;
			return num4;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000A859C File Offset: 0x000A679C
		private static int PickAnItemSlotToSpawnItemOn(bool reverseLookup, int nextItem)
		{
			/*
An exception occurred when decompiling this method (06001B63)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.Item::PickAnItemSlotToSpawnItemOn(System.Boolean,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002D:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_05))
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

		// Token: 0x06001B64 RID: 7012 RVA: 0x000A85D8 File Offset: 0x000A67D8
		public void FindOwner(int whoAmI, bool ignoreDistance = true)
		{
			if (!true)
			{
			}
			float num = this.shimmerTime;
			if (this.keepTime == 0)
			{
			}
			if (!true)
			{
			}
			if (!this.instanced)
			{
				int num2 = this.type;
				int num3 = 255;
				this.playerIndexTheItemIsReservedFor = num3;
				int num4 = this.ownIgnore;
				return;
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000A876C File Offset: 0x000A696C
		public Item Clone()
		{
			if (base.MemberwiseClone() != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000A8788 File Offset: 0x000A6988
		public Item clientClone(Item cloneDestination)
		{
			int num = this.netID;
			cloneDestination.netID = num;
			int num2 = this.type;
			cloneDestination.type = num2;
			int num3 = this.stack;
			cloneDestination.stack = num3;
			byte b = this.prefix;
			cloneDestination.prefix = b;
			byte b2 = this.holdStyle;
			cloneDestination.holdStyle = b2;
			byte b3 = this.useStyle;
			cloneDestination.useStyle = b3;
			short num4 = this.glowMask;
			cloneDestination.glowMask = num4;
			int num5 = this.damage;
			cloneDestination.damage = num5;
			int num6 = this.alpha;
			cloneDestination.alpha = num6;
			bool flag = this.noUseGraphic;
			cloneDestination.noUseGraphic = flag;
			bool flag2 = this.noWet;
			cloneDestination.noWet = flag2;
			bool flag3 = this.ranged;
			cloneDestination.ranged = flag3;
			float num7 = this.scale;
			cloneDestination.scale = num7;
			Color color = this.color;
			cloneDestination.color = color;
			bool flag4 = this.flame;
			cloneDestination.flame = flag4;
			int num8 = this.shoot;
			cloneDestination.shoot = num8;
			float num9 = this.shootSpeed;
			cloneDestination.shootSpeed = num9;
			float num10 = this.knockBack;
			cloneDestination.knockBack = num10;
			return cloneDestination;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000A88B0 File Offset: 0x000A6AB0
		public Item DeepClone()
		{
			if (base.MemberwiseClone() != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000A88CC File Offset: 0x000A6ACC
		public bool IsTheSameAs(Item compareItem)
		{
			/*
An exception occurred when decompiling this method (06001B68)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Item::IsTheSameAs(Terraria.Item)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Item::netID, ldloc:Item(this)))
	stloc:int32(var_1_0D, ldfld:int32(Item::netID, ldloc:Item(compareItem)))
	stloc:int32(var_2_14, ldfld:int32(Item::type, ldloc:Item(this)))
	stloc:int32(var_3_1B, ldfld:int32(Item::type, ldloc:Item(compareItem)))
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

		// Token: 0x06001B69 RID: 7017 RVA: 0x000A88F8 File Offset: 0x000A6AF8
		public bool IsNotTheSameAs(Item compareItem)
		{
			int num = this.netID;
			int num2 = compareItem.netID;
			int num3 = this.stack;
			int num4 = compareItem.stack;
			byte b = this.prefix;
			byte b2 = compareItem.prefix;
			return true;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x000A8934 File Offset: 0x000A6B34
		public void SetNameOverride(string name)
		{
			this._nameOverride = name;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000A8948 File Offset: 0x000A6B48
		public void ClearNameOverride()
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x000A8958 File Offset: 0x000A6B58
		public bool IsAir
		{
			get
			{
				int num = this.type;
				int num2 = this.stack;
				return true;
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000A8974 File Offset: 0x000A6B74
		public void TurnToAir(bool fullReset = false)
		{
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000A8984 File Offset: 0x000A6B84
		public void OnPurchase(Item item)
		{
			if (item.shopCustomPrice != null)
			{
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000A899C File Offset: 0x000A6B9C
		public int GetStoreValue()
		{
			if (this.shopCustomPrice != null)
			{
			}
			return this.value;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000A89B8 File Offset: 0x000A6BB8
		public void Serialize(BinaryWriter writer, ItemSerializationContext context)
		{
			if (context != ItemSerializationContext.SavingAndLoading)
			{
				return;
			}
			int num = this.netID;
			int num2 = this.stack;
			byte b = this.prefix;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000A89E0 File Offset: 0x000A6BE0
		public void DeserializeFrom(BinaryReader reader, ItemSerializationContext context)
		{
			if (context == ItemSerializationContext.SavingAndLoading)
			{
				this.stack = reader;
			}
			int num = this.type;
			this.mountType = num;
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000A8A08 File Offset: 0x000A6C08
		public bool IsCurrency
		{
			get
			{
				int num = this.type;
				return CustomCurrencyManager.IsCustomCurrency(this);
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000A8A24 File Offset: 0x000A6C24
		public void ResetPrefix()
		{
			if (this.prefix != 0)
			{
				long num = 0L;
				this.Refresh(num != 0L);
				return;
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000A8A44 File Offset: 0x000A6C44
		public void Refresh(bool onlyIfVariantChanged = true)
		{
			int num = this.type;
			int num2 = this.stack;
			ItemVariant itemVariant = ItemVariants.SelectVariant(num);
			ItemVariant itemVariant2 = this.<Variant>k__BackingField;
			int num3 = this.stack;
			int num4 = this.netID;
			bool flag = this.favorited;
			byte b = this.prefix;
			this.netDefaults(num4);
			bool flag2 = this.Prefix((int)b);
			this.stack = num3;
			this.favorited = flag;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000021DB File Offset: 0x000003DB
		public bool CanBeQuickUsed
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000A8AB0 File Offset: 0x000A6CB0
		public Item()
		{
			int num = 1;
			int num2 = 65535;
			this.fishingPole = num;
			this.hairDye = (short)num2;
			int num3 = 16256;
			this.ownIgnore = num;
			this.scale = (float)num3;
			num.m_value = num3;
			int num4 = 255;
			this.playerIndexTheItemIsReservedFor = num4;
			if (num4 == 0)
			{
			}
			base..ctor();
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x000A8B04 File Offset: 0x000A6D04
		// Note: this type is marked as 'beforefieldinit'.
		static Item()
		{
			if (9999 == 0)
			{
			}
		}

		// Token: 0x04002831 RID: 10289
		public static int numberOfNewItems;

		// Token: 0x04002832 RID: 10290
		private string _nameOverride;

		// Token: 0x04002833 RID: 10291
		public const int luckPotionDuration1 = 18000;

		// Token: 0x04002834 RID: 10292
		public const int luckPotionDuration2 = 36000;

		// Token: 0x04002835 RID: 10293
		public const int luckPotionDuration3 = 54000;

		// Token: 0x04002836 RID: 10294
		public const int flaskTime = 72000;

		// Token: 0x04002837 RID: 10295
		public const int copper = 1;

		// Token: 0x04002838 RID: 10296
		public const int silver = 100;

		// Token: 0x04002839 RID: 10297
		public const int gold = 10000;

		// Token: 0x0400283A RID: 10298
		public const int platinum = 1000000;

		// Token: 0x0400283B RID: 10299
		public const int goldCritterRarityColor = 3;

		// Token: 0x0400283C RID: 10300
		private static readonly int shadowOrbPrice;

		// Token: 0x0400283D RID: 10301
		private static readonly int dungeonPrice;

		// Token: 0x0400283E RID: 10302
		private static readonly int queenBeePrice;

		// Token: 0x0400283F RID: 10303
		private static readonly int hellPrice;

		// Token: 0x04002840 RID: 10304
		private static readonly int eclipsePrice;

		// Token: 0x04002841 RID: 10305
		private static readonly int eclipsePostPlanteraPrice;

		// Token: 0x04002842 RID: 10306
		private static readonly int eclipseMothronPrice;

		// Token: 0x04002843 RID: 10307
		public static int CommonMaxStack;

		// Token: 0x04002844 RID: 10308
		public static int[] cachedItemSpawnsByType;

		// Token: 0x04002845 RID: 10309
		public static int potionDelay;

		// Token: 0x04002846 RID: 10310
		public static int restorationDelay;

		// Token: 0x04002847 RID: 10311
		public static int mushroomDelay;

		// Token: 0x04002848 RID: 10312
		public static int[] headType;

		// Token: 0x04002849 RID: 10313
		public static int[] bodyType;

		// Token: 0x0400284A RID: 10314
		public static int[] legType;

		// Token: 0x0400284B RID: 10315
		public static bool[] staff;

		// Token: 0x0400284C RID: 10316
		public static bool[] claw;

		// Token: 0x0400284D RID: 10317
		public bool questItem;

		// Token: 0x0400284E RID: 10318
		public bool flame;

		// Token: 0x0400284F RID: 10319
		public bool mech;

		// Token: 0x04002850 RID: 10320
		public bool beingGrabbed;

		// Token: 0x04002851 RID: 10321
		public bool wornArmor;

		// Token: 0x04002852 RID: 10322
		public bool expertOnly;

		// Token: 0x04002853 RID: 10323
		public bool expert;

		// Token: 0x04002854 RID: 10324
		public bool isAShopItem;

		// Token: 0x04002855 RID: 10325
		public bool instanced;

		// Token: 0x04002856 RID: 10326
		public bool favorited;

		// Token: 0x04002857 RID: 10327
		public bool channel;

		// Token: 0x04002858 RID: 10328
		public bool accessory;

		// Token: 0x04002859 RID: 10329
		public bool potion;

		// Token: 0x0400285A RID: 10330
		public bool consumable;

		// Token: 0x0400285B RID: 10331
		public bool autoReuse;

		// Token: 0x0400285C RID: 10332
		public bool useTurn;

		// Token: 0x0400285D RID: 10333
		public bool notAmmo;

		// Token: 0x0400285E RID: 10334
		public bool buyOnce;

		// Token: 0x0400285F RID: 10335
		public bool noUseGraphic;

		// Token: 0x04002860 RID: 10336
		public bool noMelee;

		// Token: 0x04002861 RID: 10337
		public bool buy;

		// Token: 0x04002862 RID: 10338
		public bool reforge;

		// Token: 0x04002863 RID: 10339
		public bool social;

		// Token: 0x04002864 RID: 10340
		public bool vanity;

		// Token: 0x04002865 RID: 10341
		public bool material;

		// Token: 0x04002866 RID: 10342
		public bool noWet;

		// Token: 0x04002867 RID: 10343
		public bool cartTrack;

		// Token: 0x04002868 RID: 10344
		public bool uniqueStack;

		// Token: 0x04002869 RID: 10345
		public bool DD2Summon;

		// Token: 0x0400286A RID: 10346
		public bool melee;

		// Token: 0x0400286B RID: 10347
		public bool magic;

		// Token: 0x0400286C RID: 10348
		public bool ranged;

		// Token: 0x0400286D RID: 10349
		public bool summon;

		// Token: 0x0400286E RID: 10350
		public bool sentry;

		// Token: 0x0400286F RID: 10351
		public bool newAndShiny;

		// Token: 0x04002870 RID: 10352
		public bool canBePlacedInVanityRegardlessOfConditions;

		// Token: 0x04002871 RID: 10353
		private bool frozen;

		// Token: 0x04002872 RID: 10354
		private byte frozenCount;

		// Token: 0x04002873 RID: 10355
		public int noGrabDelay;

		// Token: 0x04002874 RID: 10356
		public int timeSinceItemSpawned;

		// Token: 0x04002875 RID: 10357
		public int tileWand;

		// Token: 0x04002876 RID: 10358
		public int tooltipContext;

		// Token: 0x04002877 RID: 10359
		public byte dye;

		// Token: 0x04002878 RID: 10360
		public int fishingPole;

		// Token: 0x04002879 RID: 10361
		public int bait;

		// Token: 0x0400287A RID: 10362
		public const int coinGrabRange = 350;

		// Token: 0x0400287B RID: 10363
		public const int manaGrabRange = 300;

		// Token: 0x0400287C RID: 10364
		public const int lifeGrabRange = 250;

		// Token: 0x0400287D RID: 10365
		public const int treasureGrabRange = 150;

		// Token: 0x0400287E RID: 10366
		public short makeNPC;

		// Token: 0x0400287F RID: 10367
		public short hairDye;

		// Token: 0x04002880 RID: 10368
		public byte paint;

		// Token: 0x04002881 RID: 10369
		public byte paintCoating;

		// Token: 0x04002882 RID: 10370
		public int ownIgnore;

		// Token: 0x04002883 RID: 10371
		public int ownTime;

		// Token: 0x04002884 RID: 10372
		public int keepTime;

		// Token: 0x04002885 RID: 10373
		public int timeLeftInWhichTheItemCannotBeTakenByEnemies;

		// Token: 0x04002886 RID: 10374
		public int type;

		// Token: 0x04002887 RID: 10375
		public byte holdStyle;

		// Token: 0x04002888 RID: 10376
		public byte useStyle;

		// Token: 0x04002889 RID: 10377
		public int useAnimation;

		// Token: 0x0400288A RID: 10378
		public int useTime;

		// Token: 0x0400288B RID: 10379
		public int stack;

		// Token: 0x0400288C RID: 10380
		public int maxStack;

		// Token: 0x0400288D RID: 10381
		public int pick;

		// Token: 0x0400288E RID: 10382
		public int axe;

		// Token: 0x0400288F RID: 10383
		public int hammer;

		// Token: 0x04002890 RID: 10384
		public int tileBoost;

		// Token: 0x04002891 RID: 10385
		public int createTile;

		// Token: 0x04002892 RID: 10386
		public int createWall;

		// Token: 0x04002893 RID: 10387
		public int placeStyle;

		// Token: 0x04002894 RID: 10388
		public int damage;

		// Token: 0x04002895 RID: 10389
		public float knockBack;

		// Token: 0x04002896 RID: 10390
		public int healLife;

		// Token: 0x04002897 RID: 10391
		public int healMana;

		// Token: 0x04002898 RID: 10392
		public Color color;

		// Token: 0x04002899 RID: 10393
		public int alpha;

		// Token: 0x0400289A RID: 10394
		public short glowMask;

		// Token: 0x0400289B RID: 10395
		public float scale;

		// Token: 0x0400289C RID: 10396
		public LegacySoundStyle UseSound;

		// Token: 0x0400289D RID: 10397
		public int defense;

		// Token: 0x0400289E RID: 10398
		public int headSlot;

		// Token: 0x0400289F RID: 10399
		public int bodySlot;

		// Token: 0x040028A0 RID: 10400
		public int legSlot;

		// Token: 0x040028A1 RID: 10401
		public sbyte handOnSlot;

		// Token: 0x040028A2 RID: 10402
		public sbyte handOffSlot;

		// Token: 0x040028A3 RID: 10403
		public sbyte backSlot;

		// Token: 0x040028A4 RID: 10404
		public sbyte frontSlot;

		// Token: 0x040028A5 RID: 10405
		public sbyte shoeSlot;

		// Token: 0x040028A6 RID: 10406
		public sbyte waistSlot;

		// Token: 0x040028A7 RID: 10407
		public sbyte wingSlot;

		// Token: 0x040028A8 RID: 10408
		public sbyte shieldSlot;

		// Token: 0x040028A9 RID: 10409
		public sbyte neckSlot;

		// Token: 0x040028AA RID: 10410
		public sbyte faceSlot;

		// Token: 0x040028AB RID: 10411
		public sbyte balloonSlot;

		// Token: 0x040028AC RID: 10412
		public sbyte beardSlot;

		// Token: 0x040028AD RID: 10413
		public int stringColor;

		// Token: 0x040028AE RID: 10414
		public ItemTooltip ToolTip;

		// Token: 0x040028AF RID: 10415
		public string BestiaryNotes;

		// Token: 0x040028B0 RID: 10416
		public int playerIndexTheItemIsReservedFor;

		// Token: 0x040028B1 RID: 10417
		public int rare;

		// Token: 0x040028B2 RID: 10418
		[CompilerGenerated]
		private ItemVariant <Variant>k__BackingField;

		// Token: 0x040028B3 RID: 10419
		public int shoot;

		// Token: 0x040028B4 RID: 10420
		public float shootSpeed;

		// Token: 0x040028B5 RID: 10421
		public int ammo;

		// Token: 0x040028B6 RID: 10422
		public int useAmmo;

		// Token: 0x040028B7 RID: 10423
		public int lifeRegen;

		// Token: 0x040028B8 RID: 10424
		public int manaIncrease;

		// Token: 0x040028B9 RID: 10425
		public int mana;

		// Token: 0x040028BA RID: 10426
		public int timeSinceTheItemHasBeenReservedForSomeone;

		// Token: 0x040028BB RID: 10427
		public int value;

		// Token: 0x040028BC RID: 10428
		public int buffType;

		// Token: 0x040028BD RID: 10429
		public int buffTime;

		// Token: 0x040028BE RID: 10430
		public int mountType;

		// Token: 0x040028BF RID: 10431
		public int shopSpecialCurrency;

		// Token: 0x040028C0 RID: 10432
		public int? shopCustomPrice;

		// Token: 0x040028C1 RID: 10433
		public bool shootsEveryUse;

		// Token: 0x040028C2 RID: 10434
		public bool chlorophyteExtractinatorConsumable;

		// Token: 0x040028C3 RID: 10435
		public int netID;

		// Token: 0x040028C4 RID: 10436
		public int crit;

		// Token: 0x040028C5 RID: 10437
		public byte prefix;

		// Token: 0x040028C6 RID: 10438
		public int reuseDelay;

		// Token: 0x040028C7 RID: 10439
		[Old("This is used to allow items to be discerned as vanity even if they didn't have visual slots to poll against")]
		public bool hasVanityEffects;

		// Token: 0x040028C8 RID: 10440
		private const int foodWidth = 22;

		// Token: 0x040028C9 RID: 10441
		private const int foodHeight = 22;

		// Token: 0x040028CA RID: 10442
		public const int WALL_PLACEMENT_USETIME = 7;

		// Token: 0x040028CB RID: 10443
		public bool shimmered;

		// Token: 0x040028CC RID: 10444
		public float shimmerTime;
	}
}
