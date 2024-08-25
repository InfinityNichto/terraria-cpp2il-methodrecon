using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000392 RID: 914
	public sealed class SpriteFont
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00068E38 File Offset: 0x00067038
		public SpriteFont.Glyph[] Glyphs
		{
			get
			{
				return this._glyphs;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00068E4C File Offset: 0x0006704C
		public SpriteFont()
		{
			this._defaultGlyphIndex = 1;
			base..ctor();
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00068E68 File Offset: 0x00067068
		public SpriteFont(Texture2D[] textures, SpriteFont.Glyph[] glyphs, int lineSpacing, float spacing, char? defaultCharacter)
		{
			int num = 1;
			this._defaultGlyphIndex = num;
			base..ctor();
			this._textures = textures;
			this.LineSpacing = lineSpacing;
			this._glyphs = glyphs;
			int y = glyphs.Cropping.Y;
			Dictionary<char, int> glyphIndex = this._glyphIndex;
			SpriteFont.Glyph[] glyphs2 = this._glyphs;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00068EB8 File Offset: 0x000670B8
		public Texture2D[] Textures
		{
			get
			{
				return this._textures;
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00068ECC File Offset: 0x000670CC
		public Dictionary<char, SpriteFont.Glyph> GetGlyphs()
		{
			/*
An exception occurred when decompiling this method (0600185F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.Dictionary`2<System.Char,Microsoft.Xna.Framework.Graphics.SpriteFont/Glyph> Microsoft.Xna.Framework.Graphics.SpriteFont::GetGlyphs()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	stloc:int32(var_2_17, ldfld:int32(Rectangle::Y, ldfld:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](Glyph::Cropping, ldloc:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/Glyph[][exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/Glyph&](var_1_08))))
	stloc:int32(var_3_28, ldfld:int32(Rectangle::Y, ldfld:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](Glyph::Cropping, ldfld:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/Glyph[][exp:valuetype Microsoft.Xna.Framework.Graphics.SpriteFont/Glyph&](SpriteFont::_glyphs, ldloc:SpriteFont(this)))))
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00068F04 File Offset: 0x00067104
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x00068F18 File Offset: 0x00067118
		public char? DefaultCharacter
		{
			get
			{
				return this._defaultCharacter;
			}
			set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00068F30 File Offset: 0x00067130
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x00068F44 File Offset: 0x00067144
		public int LineSpacing
		{
			[CompilerGenerated]
			get
			{
				return this.<LineSpacing>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<LineSpacing>k__BackingField = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00068F58 File Offset: 0x00067158
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00068F6C File Offset: 0x0006716C
		public float Spacing
		{
			[CompilerGenerated]
			get
			{
				/*
An exception occurred when decompiling this method (06001864)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.SpriteFont::get_Spacing()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SpriteFont::<Spacing>k__BackingField, ldloc:SpriteFont(this)))
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
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00068F7C File Offset: 0x0006717C
		public Vector2 MeasureString(string text)
		{
			/*
An exception occurred when decompiling this method (06001866)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector2 Microsoft.Xna.Framework.Graphics.SpriteFont::MeasureString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(text)))
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

		// Token: 0x06001867 RID: 6247 RVA: 0x000021DB File Offset: 0x000003DB
		public int GetMaxCharacterIndex(string text, int startIndex, int endIndex, float scale, float maxWidth)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00068F90 File Offset: 0x00067190
		public Vector2 MeasureString(string text, int startIndex, int endIndex)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00068FA0 File Offset: 0x000671A0
		public Vector2 MeasureString(StringBuilder text, int startIndex, int endIndex)
		{
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00068FB0 File Offset: 0x000671B0
		public Vector2 MeasureString(StringBuilder text)
		{
			int length = text.Length;
			Vector2 vector;
			return vector;
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00068FC8 File Offset: 0x000671C8
		internal void MeasureMaxString(SpriteFont.CharacterSource text, [Out] int lastCharacter, float maxWidth, float scale)
		{
			int length = text.Length;
			if (length == 0)
			{
				int num;
				lastCharacter.m_value = num;
				return;
			}
			int num2 = this.<LineSpacing>k__BackingField;
			if (length == 0)
			{
			}
			if (!true)
			{
			}
			SpriteFont.Glyph[] glyphs = this._glyphs;
			if (glyphs != null && glyphs.Cropping.Y != 0)
			{
				return;
			}
			int length2 = text.Length;
			long num3 = 0L;
			char c = text[(int)num3];
			int num4 = this.<LineSpacing>k__BackingField;
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00069070 File Offset: 0x00067270
		internal void MeasureString(SpriteFont.CharacterSource text, [Out] Vector2 size)
		{
			int length;
			for (;;)
			{
				length = text.Length;
				if (length != 0)
				{
					break;
				}
				int num;
				if (num == 0)
				{
				}
				if (num == 0)
				{
					goto Block_3;
				}
			}
			int num2 = this.<LineSpacing>k__BackingField;
			if (length == 0)
			{
			}
			if (!true)
			{
			}
			SpriteFont.Glyph[] glyphs = this._glyphs;
			if (glyphs != null && glyphs.Cropping.Y != 0)
			{
				return;
			}
			int length2 = text.Length;
			long num3 = 0L;
			char c = text[(int)num3];
			int num4 = this.<LineSpacing>k__BackingField;
			int length3 = text.Length;
			return;
			Block_3:
			if (!true)
			{
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00069124 File Offset: 0x00067324
		internal bool TryGetGlyphIndex(char c, [Out] int index)
		{
			/*
An exception occurred when decompiling this method (0600186D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Microsoft.Xna.Framework.Graphics.SpriteFont::TryGetGlyphIndex(System.Char,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](index), ldc.i4:int32(1))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<char, int32>(var_0_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<char, int32>(SpriteFont::_glyphIndex, ldloc:SpriteFont(this)))
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

		// Token: 0x0600186E RID: 6254 RVA: 0x00069140 File Offset: 0x00067340
		public bool HasCharacter(char c)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00069150 File Offset: 0x00067350
		internal int GetGlyphIndexOrDefault(char c)
		{
			return this._defaultGlyphIndex;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00069164 File Offset: 0x00067364
		public string CreateWrappedText(string text, float maxWidth)
		{
			CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
			return this.CreateWrappedText(text, maxWidth, currentCulture);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000021DB File Offset: 0x000003DB
		public string CreateWrappedText(string text, float maxWidth, CultureInfo culture)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00069188 File Offset: 0x00067388
		public SpriteFont.Glyph GetCharacterMetrics(char character)
		{
			int glyphIndexOrDefault = this.GetGlyphIndexOrDefault(character);
			SpriteFont.Glyph[] glyphs = this._glyphs;
			int height = glyphs.Cropping.Height;
			float leftSideBearing = glyphs.LeftSideBearing;
			SpriteFont.Glyph glyph;
			glyph.Character = (char)height;
			glyph.BoundsInTexture.X = (int)leftSideBearing;
			glyph.WidthIncludingBearings = glyphs;
			return glyphs;
		}

		// Token: 0x040026AD RID: 9901
		private readonly SpriteFont.Glyph[] _glyphs;

		// Token: 0x040026AE RID: 9902
		private Dictionary<char, int> _glyphIndex;

		// Token: 0x040026AF RID: 9903
		private char? _defaultCharacter;

		// Token: 0x040026B0 RID: 9904
		private int _defaultGlyphIndex;

		// Token: 0x040026B1 RID: 9905
		private readonly Texture2D[] _textures;

		// Token: 0x040026B2 RID: 9906
		[CompilerGenerated]
		private int <LineSpacing>k__BackingField;

		// Token: 0x040026B3 RID: 9907
		[CompilerGenerated]
		private float <Spacing>k__BackingField;

		// Token: 0x02000393 RID: 915
		internal static class Errors
		{
			// Token: 0x040026B4 RID: 9908
			public const string TextContainsUnresolvableCharacters = "Text contains characters that cannot be resolved by this SpriteFont.";

			// Token: 0x040026B5 RID: 9909
			public const string UnresolvableCharacter = "Character cannot be resolved by this SpriteFont.";
		}

		// Token: 0x02000394 RID: 916
		private class CharComparer : IEqualityComparer<char>
		{
			// Token: 0x06001873 RID: 6259 RVA: 0x000021DB File Offset: 0x000003DB
			public bool Equals(char x, char y)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x000021DB File Offset: 0x000003DB
			public int GetHashCode(char b)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001875 RID: 6261 RVA: 0x000691D4 File Offset: 0x000673D4
			public CharComparer()
			{
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x000691E8 File Offset: 0x000673E8
			// Note: this type is marked as 'beforefieldinit'.
			static CharComparer()
			{
			}

			// Token: 0x040026B6 RID: 9910
			public static readonly SpriteFont.CharComparer Default;
		}

		// Token: 0x02000395 RID: 917
		public struct CharacterSource
		{
			// Token: 0x06001877 RID: 6263 RVA: 0x000691F8 File Offset: 0x000673F8
			public CharacterSource(string s)
			{
				this._string = s;
				int stringLength = s._stringLength;
				this.Length = stringLength;
			}

			// Token: 0x06001878 RID: 6264 RVA: 0x0006921C File Offset: 0x0006741C
			public CharacterSource(string s, int startIndex, int endIndex)
			{
				this._string = s;
				this._stringOffset = startIndex;
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x00069238 File Offset: 0x00067438
			public CharacterSource(StringBuilder builder)
			{
				this._builder = builder;
				int length = builder.Length;
				this.Length = length;
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x0006925C File Offset: 0x0006745C
			public CharacterSource(StringBuilder builder, int startIndex, int endIndex)
			{
				this._stringOffset = startIndex;
				this._builder = builder;
			}

			// Token: 0x17000314 RID: 788
			public char this[int index]
			{
				get
				{
					int stringOffset = this._stringOffset;
					char c;
					return c;
				}
			}

			// Token: 0x040026B7 RID: 9911
			private readonly string _string;

			// Token: 0x040026B8 RID: 9912
			private readonly int _stringOffset;

			// Token: 0x040026B9 RID: 9913
			private readonly StringBuilder _builder;

			// Token: 0x040026BA RID: 9914
			public readonly int Length;
		}

		// Token: 0x02000396 RID: 918
		public struct Glyph
		{
			// Token: 0x0600187C RID: 6268 RVA: 0x00069290 File Offset: 0x00067490
			public override string ToString()
			{
				string text;
				string text2;
				string text3;
				string text4;
				string text5;
				string text6;
				if (("CharacterIndex=" == null || "CharacterIndex=" != null) && (text == null || text != null) && (", Glyph=" == null || ", Glyph=" != null) && (text2 == null || text2 != null) && (", Cropping=" == null || ", Cropping=" != null) && (text3 == null || text3 != null) && (", Kerning=" == null || ", Kerning=" != null) && (text4 == null || text4 != null) && ("," == null || "," != null) && (text5 == null || text5 != null) && ("," == null || "," != null) && (text6 == null || text6 != null))
				{
					string text7;
					return text7;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x0600187D RID: 6269 RVA: 0x00069334 File Offset: 0x00067534
			// Note: this type is marked as 'beforefieldinit'.
			static Glyph()
			{
			}

			// Token: 0x040026BB RID: 9915
			public char Character;

			// Token: 0x040026BC RID: 9916
			public Rectangle BoundsInTexture;

			// Token: 0x040026BD RID: 9917
			public Rectangle Cropping;

			// Token: 0x040026BE RID: 9918
			public float LeftSideBearing;

			// Token: 0x040026BF RID: 9919
			public float RightSideBearing;

			// Token: 0x040026C0 RID: 9920
			public float Width;

			// Token: 0x040026C1 RID: 9921
			public float WidthIncludingBearings;

			// Token: 0x040026C2 RID: 9922
			public byte TexureIndex;

			// Token: 0x040026C3 RID: 9923
			public static readonly SpriteFont.Glyph Empty;
		}

		// Token: 0x02000397 RID: 919
		private struct CharacterRegion
		{
			// Token: 0x0600187E RID: 6270 RVA: 0x00069344 File Offset: 0x00067544
			public CharacterRegion(char start, int startIndex)
			{
				this.Start = start;
				this.End = start;
				this.StartIndex = startIndex;
			}

			// Token: 0x040026C4 RID: 9924
			public char Start;

			// Token: 0x040026C5 RID: 9925
			public char End;

			// Token: 0x040026C6 RID: 9926
			public int StartIndex;
		}
	}
}
