using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	// Token: 0x0200041C RID: 1052
	public class PopupText
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0014B91C File Offset: 0x00149B1C
		public bool notActuallyAnItem
		{
			get
			{
				return this.npcNetID == 0 || true;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x0014B934 File Offset: 0x00149B34
		public static float TargetScale
		{
			get
			{
				/*
An exception occurred when decompiling this method (060025F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.PopupText::get_TargetScale()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x0014B948 File Offset: 0x00149B48
		public static void ClearSonarText()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			PopupText[] popupText = Main.popupText;
			PopupText[] popupText2 = Main.popupText;
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x0014B970 File Offset: 0x00149B70
		public static void ResetText(PopupText text)
		{
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x0014B980 File Offset: 0x00149B80
		public static int NewText(AdvancedPopupRequest request, Vector2 position)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool showItemText = Main.showItemText;
			if (num == 0)
			{
			}
			return 43143168;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x0014B9D4 File Offset: 0x00149BD4
		public static int NewText(PopupTextContext context, int npcNetID, Vector2 position, bool stay5TimesLonger)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool showItemText = Main.showItemText;
			int num2;
			if (context != PopupTextContext.RegularItemPickup)
			{
				if (num == 0)
				{
				}
				bool netHostOnly = Main.NetHostOnly;
				if (num == 0)
				{
				}
				num2 = PopupText.FindNextItemTextSlot();
				PopupText[] popupText = Main.popupText;
				float num3 = popupText.alpha;
				if (popupText == null)
				{
				}
				int num4 = 300;
				if (num4 == 0)
				{
				}
				if (num4 == 0)
				{
				}
			}
			return num2;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x0014BA48 File Offset: 0x00149C48
		public static int NewText(PopupTextContext context, Item newItem, int stack, bool noStack = false, bool longText = false)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool showItemText = Main.showItemText;
			string text;
			if (text != null && num != 0)
			{
				if (num == 0)
				{
				}
				bool netHostOnly = Main.NetHostOnly;
			}
			return stack;
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x0014BBE0 File Offset: 0x00149DE0
		private void AddToCoinValue(long addedValue)
		{
			long num = this.coinValue;
			long num2 = Math.Max(0L, addedValue);
			long num3 = Math.Min(51711L, num2);
			this.coinValue = num3;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0014BC10 File Offset: 0x00149E10
		private static int FindNextItemTextSlot()
		{
			/*
An exception occurred when decompiling this method (060025FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.PopupText::FindNextItemTextSlot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0028:
	stloc:class Terraria.PopupText[](var_8_30, callgetter:class Terraria.PopupText[](Main::get_popupText))
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

		// Token: 0x06002600 RID: 9728 RVA: 0x0014BC50 File Offset: 0x00149E50
		public static void AssignAsSonarText(int sonarTextIndex)
		{
			if (!true)
			{
			}
			PopupText[] popupText = Main.popupText;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0014BC68 File Offset: 0x00149E68
		public static string ValueToName(long coinValue)
		{
			return "Currency.Platinum";
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x0014BD34 File Offset: 0x00149F34
		private void ValueToName()
		{
			long num = this.coinValue;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0014BE18 File Offset: 0x0014A018
		public void Update(int whoAmI)
		{
			if (this.active)
			{
				float targetScale = PopupText.TargetScale;
				float num = this.alpha;
				int num2 = this.alphaDir;
				this.alpha = (float)num2;
				return;
			}
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0014C038 File Offset: 0x0014A238
		public static void UpdateItemText()
		{
			int num = 1;
			if (num == 0)
			{
			}
			PopupText[] popupText = Main.popupText;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				PopupText[] popupText2 = Main.popupText;
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x0014C06C File Offset: 0x0014A26C
		public static void ClearAll()
		{
			if (!true)
			{
			}
			PopupText[] popupText = Main.popupText;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x0014C090 File Offset: 0x0014A290
		public PopupText()
		{
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0014C0B8 File Offset: 0x0014A2B8
		// Note: this type is marked as 'beforefieldinit'.
		static PopupText()
		{
		}

		// Token: 0x040032F5 RID: 13045
		public static int activeTime;

		// Token: 0x040032F6 RID: 13046
		public static int numActive;

		// Token: 0x040032F7 RID: 13047
		public static int sonarText;

		// Token: 0x040032F8 RID: 13048
		public Vector2 position;

		// Token: 0x040032F9 RID: 13049
		public Vector2 velocity;

		// Token: 0x040032FA RID: 13050
		public float alpha;

		// Token: 0x040032FB RID: 13051
		public int alphaDir = 1;

		// Token: 0x040032FC RID: 13052
		public string name;

		// Token: 0x040032FD RID: 13053
		public long stack;

		// Token: 0x040032FE RID: 13054
		public float scale = (float)16256;

		// Token: 0x040032FF RID: 13055
		public float rotation;

		// Token: 0x04003300 RID: 13056
		public Color color;

		// Token: 0x04003301 RID: 13057
		public bool active;

		// Token: 0x04003302 RID: 13058
		public int lifeTime;

		// Token: 0x04003303 RID: 13059
		public bool NoStack;

		// Token: 0x04003304 RID: 13060
		public bool coinText;

		// Token: 0x04003305 RID: 13061
		public long coinValue;

		// Token: 0x04003306 RID: 13062
		public bool expert;

		// Token: 0x04003307 RID: 13063
		public bool master;

		// Token: 0x04003308 RID: 13064
		public bool sonar;

		// Token: 0x04003309 RID: 13065
		public PopupTextContext context;

		// Token: 0x0400330A RID: 13066
		public int npcNetID;

		// Token: 0x0400330B RID: 13067
		public bool freeAdvanced;

		// Token: 0x0400330C RID: 13068
		private Vector2 cachedSize;

		// Token: 0x0400330D RID: 13069
		private string cachedName;

		// Token: 0x0400330E RID: 13070
		private long cachedStack;
	}
}
