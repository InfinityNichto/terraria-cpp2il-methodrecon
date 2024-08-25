using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;

namespace Terraria.UI.Chat
{
	// Token: 0x0200072D RID: 1837
	public static class ChatManager
	{
		// Token: 0x06003CC7 RID: 15559 RVA: 0x0023741C File Offset: 0x0023561C
		public static Color WaveColor(Color color)
		{
			/*
An exception occurred when decompiling this method (06003CC7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.UI.Chat.ChatManager::WaveColor(Microsoft.Xna.Framework.Graphics.Color)

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

		// Token: 0x06003CC8 RID: 15560 RVA: 0x0023742C File Offset: 0x0023562C
		public static void ConvertNormalSnippets(TextSnippet[] snippets)
		{
			string textOriginal = snippets.TextOriginal;
			Type type;
			Type type2;
			bool flag = type == type2;
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00237454 File Offset: 0x00235654
		public static void Register<T>(params string[] names) where T : ITagHandler, new()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x00237468 File Offset: 0x00235668
		private static ITagHandler GetHandler(string tagName)
		{
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x00237478 File Offset: 0x00235678
		public static TextSnippet[] ParseMessage(string text, Color baseColor, float maxWidth = -1f)
		{
			if (!true)
			{
			}
			MatchCollection matchCollection;
			IEnumerator enumerator = matchCollection.GetEnumerator();
			if (enumerator != null)
			{
			}
			Group group;
			string value = group.Value;
			Group group2;
			string value2 = group2.Value;
			Group group3;
			string value3 = group3.Value;
			if (ChatManager.GetHandler(value) != null)
			{
			}
			long num = 0L;
			int num2 = 6;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x002374EC File Offset: 0x002356EC
		public static bool AddChatText(SpriteFont font, string text, Vector2 baseScale)
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			return true;
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00237508 File Offset: 0x00235708
		public static Vector2 GetStringSize(SpriteFont font, string text, Vector2 baseScale, float maxWidth = -1f)
		{
			/*
An exception occurred when decompiling this method (06003CCD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.UI.Chat.ChatManager::GetStringSize(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Vector2(var_1_0C, call:Vector2(ChatManager::GetStringSize, ldloc:SpriteFont(font), ldloc:class Terraria.UI.Chat.TextSnippet[](var_0), ldloc:Vector2(baseScale), ldloc:float32(maxWidth)))
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

		// Token: 0x06003CCE RID: 15566 RVA: 0x00237524 File Offset: 0x00235724
		public static Vector2 GetStringSize(SpriteFont font, TextSnippet[] snippets, Vector2 baseScale, float maxWidth = -1f)
		{
			/*
An exception occurred when decompiling this method (06003CCE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.UI.Chat.ChatManager::GetStringSize(Microsoft.Xna.Framework.Graphics.SpriteFont,Terraria.UI.Chat.TextSnippet[],Microsoft.Xna.Framework.Vector2,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00E3:
	stloc:int32(var_72_E9, ldfld:int32(SpriteFont::<LineSpacing>k__BackingField, ldloc:SpriteFont(font)))
	stloc:float32(var_74_F7, call:float32(Math::Max, ldloc:float32(var_71), ldloc:float32(var_61)))
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

		// Token: 0x06003CCF RID: 15567 RVA: 0x0023762C File Offset: 0x0023582C
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00237648 File Offset: 0x00235848
		public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, [Out] int hoveredSnippet, float maxWidth, bool ignoreColors = false, int maxLines = 100)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			Vector2 vector = font.MeasureString(" ");
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			string textOriginal = snippets.TextOriginal;
			bool flag;
			if (!flag)
			{
			}
			float num2 = Math.Max(rotation, rotation);
			Vector2 vector2 = font.MeasureString(" ");
			if (" " == null)
			{
			}
			return " ";
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00237798 File Offset: 0x00235998
		public static Vector2 DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, TextSnippet[] snippets, Vector2 position, float rotation, Vector2 origin, Vector2 baseScale, [Out] int hoveredSnippet, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			/*
An exception occurred when decompiling this method (06003CD1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.UI.Chat.ChatManager::DrawColorCodedStringWithShadow(Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Graphics.SpriteFont,Terraria.UI.Chat.TextSnippet[],Microsoft.Xna.Framework.Vector2,System.Single,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Int32,System.Single,System.Single,System.Int32)

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

		// Token: 0x06003CD2 RID: 15570 RVA: 0x002377A8 File Offset: 0x002359A8
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x002377C4 File Offset: 0x002359C4
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x002377E0 File Offset: 0x002359E0
		public static void DrawColorCodedStringShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x002377FC File Offset: 0x002359FC
		public static void DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
			Vector2 vector = font.MeasureString(" ");
			int stringLength = text._stringLength;
			if (" " == null)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			char c = text[(int)num];
			char c2 = text[(int)num];
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x002378F4 File Offset: 0x00235AF4
		public static void DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false, int maxLines = 100)
		{
			Vector2 vector = font.MeasureString(" ");
			int stringLength = text._stringLength;
			if (" " == null)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			char c = text[(int)num];
			char c2 = text[(int)num];
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x002379EC File Offset: 0x00235BEC
		public static Vector2 DrawColorCodedString(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			Vector2 vector = font.MeasureString(" ");
			int length = text.Length;
			long num = 0L;
			long num2 = 0L;
			char c = text[(int)num2];
			char c2 = text[(int)num2];
			int <LineSpacing>k__BackingField = font.<LineSpacing>k__BackingField;
			if (num2 == 0L)
			{
			}
			float num3 = Math.Max(maxWidth, maxWidth);
			if (num2 == 0L)
			{
			}
			Vector2 vector2 = font.MeasureString(text, (int)num, (int)num);
			if (num2 == 0L)
			{
			}
			float num4 = Math.Max(rotation, rotation);
			char c3 = text[(int)num2];
			int <LineSpacing>k__BackingField2 = font.<LineSpacing>k__BackingField;
			if (num2 == 0L)
			{
			}
			float num5 = Math.Max(num3, maxWidth);
			Vector2 vector3 = font.MeasureString(text, (int)num2, (int)num);
			int <LineSpacing>k__BackingField3 = font.<LineSpacing>k__BackingField;
			if (num2 == 0L)
			{
			}
			float num6 = Math.Max(num5, maxWidth);
			if (num2 == 0L)
			{
			}
			Vector2 vector4 = font.MeasureString(text, (int)num2, (int)num2);
			if (num2 == 0L)
			{
			}
			float num7 = Math.Max(num4, rotation);
			if (num2 == 0L)
			{
				return;
			}
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x00237ACC File Offset: 0x00235CCC
		public static Vector2 DrawColorCodedString(Vector2[] offsets, SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, bool ignoreColors = false)
		{
			/*
An exception occurred when decompiling this method (06003CD8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Terraria.UI.Chat.ChatManager::DrawColorCodedString(Microsoft.Xna.Framework.Vector2[],Microsoft.Xna.Framework.Graphics.SpriteBatch,Microsoft.Xna.Framework.Graphics.SpriteFont,System.Text.StringBuilder,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.Color,System.Single,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,System.Single,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0093:
	stloc:float32(var_22_9F, call:float32(Math::Max, ldloc:float32(var_18_7B), ldloc:float32(maxWidth)))
	stloc:Vector2(var_25_AD, call:Vector2(SpriteFont::MeasureString, ldloc:SpriteFont(font), ldloc:StringBuilder(text), ldloc:int64[exp:int32](var_3_16), ldloc:int64[exp:int32](var_3_16)))
	stloc:float32(var_27_BB, call:float32(Math::Max, ldloc:float32(var_14_5C), ldloc:float32(rotation)))
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

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00237B98 File Offset: 0x00235D98
		public static void DrawColorCodedStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			TextSnippet[] array;
			ChatManager.ConvertNormalSnippets(array);
			if (!true)
			{
			}
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00237BB8 File Offset: 0x00235DB8
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x00237BD0 File Offset: 0x00235DD0
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, string text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f, int maxLines = 100)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00237BE8 File Offset: 0x00235DE8
		public static void DrawStringWithShadow(SpriteBatch spriteBatch, SpriteFont font, StringBuilder text, Vector2 position, Color baseColor, float rotation, Vector2 origin, Vector2 baseScale, float maxWidth = -1f, float spread = 2f)
		{
			if (!true)
			{
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00237C00 File Offset: 0x00235E00
		// Note: this type is marked as 'beforefieldinit'.
		static ChatManager()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x04007BE6 RID: 31718
		public static readonly ChatCommandProcessor Commands;

		// Token: 0x04007BE7 RID: 31719
		private static ConcurrentDictionary<string, ITagHandler> _handlers;

		// Token: 0x04007BE8 RID: 31720
		private static Vector2[] ShadowDirectionsScaled;

		// Token: 0x04007BE9 RID: 31721
		public static readonly Vector2[] ShadowDirections;

		// Token: 0x04007BEA RID: 31722
		public static bool AllowColon;

		// Token: 0x04007BEB RID: 31723
		public static SpriteBatch overloadedSpriteBatch;

		// Token: 0x0200072E RID: 1838
		public static class Regexes
		{
			// Token: 0x06003CDE RID: 15582 RVA: 0x00237C20 File Offset: 0x00235E20
			// Note: this type is marked as 'beforefieldinit'.
			static Regexes()
			{
			}

			// Token: 0x04007BEC RID: 31724
			public static readonly Regex Format;
		}
	}
}
