using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Terraria.Localization
{
	// Token: 0x02000559 RID: 1369
	public class LocalizedText
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600333F RID: 13119 RVA: 0x001FEF48 File Offset: 0x001FD148
		// (set) Token: 0x06003340 RID: 13120 RVA: 0x001FEF5C File Offset: 0x001FD15C
		public string Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x001FEF70 File Offset: 0x001FD170
		internal LocalizedText(string key, string text)
		{
			this.Key = key;
			this.Value = text;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x001FEF94 File Offset: 0x001FD194
		internal void SetValue(string text)
		{
			this.<Value>k__BackingField = text;
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x001FEFA8 File Offset: 0x001FD1A8
		public string FormatWith(object obj)
		{
			string text = this.<Value>k__BackingField;
			if (!true)
			{
			}
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
			if (!true)
			{
			}
			string text2;
			return text2;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x001FEFCC File Offset: 0x001FD1CC
		public StringBuilder FormatWith(object obj, StringBuilder sb)
		{
			int num = 1;
			string text = this.<Value>k__BackingField;
			StringBuilder stringBuilder = sb.Append(text);
			if (num == 0)
			{
			}
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
			while (properties == null)
			{
			}
			StringBuilder stringBuilder2;
			return stringBuilder2;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x001FF024 File Offset: 0x001FD224
		public bool CanFormatWith(object obj)
		{
			PropertyDescriptorCollection properties;
			IEnumerator enumerator;
			Group group;
			do
			{
				if (!true)
				{
				}
				properties = TypeDescriptor.GetProperties(obj);
				string text = this.<Value>k__BackingField;
				MatchCollection matchCollection;
				enumerator = matchCollection.GetEnumerator();
				if (properties == null || properties == null)
				{
					goto IL_003C;
				}
			}
			while (group.<Length>k__BackingField == 0);
			if (properties != null)
			{
			}
			Group group2;
			int <Length>k__BackingField = group2.<Length>k__BackingField;
			IL_003C:
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
				throw new InvalidCastException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x001FF09C File Offset: 0x001FD29C
		public NetworkText ToNetworkText()
		{
			string key = this.Key;
			if (!true)
			{
			}
			NetworkText networkText;
			return networkText;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x001FF0B4 File Offset: 0x001FD2B4
		public NetworkText ToNetworkText(params object[] substitutions)
		{
			string key = this.Key;
			if (!true)
			{
			}
			return NetworkText.FromKey(key, substitutions);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000021DB File Offset: 0x000003DB
		public static explicit operator string(LocalizedText text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x001FF0D4 File Offset: 0x001FD2D4
		public string Format(object arg0)
		{
			return string.Format(this.<Value>k__BackingField, arg0);
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x001FF0F0 File Offset: 0x001FD2F0
		public string Format(object arg0, object arg1)
		{
			return string.Format(this.<Value>k__BackingField, arg0, arg1);
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x001FF10C File Offset: 0x001FD30C
		public string Format(object arg0, object arg1, object arg2)
		{
			return string.Format(this.<Value>k__BackingField, arg0, arg1, arg2);
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x001FF128 File Offset: 0x001FD328
		public string Format(params object[] args)
		{
			return string.Format(this.<Value>k__BackingField, args);
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x001FF144 File Offset: 0x001FD344
		public override string ToString()
		{
			return this.<Value>k__BackingField;
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x001FF158 File Offset: 0x001FD358
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedText()
		{
		}

		// Token: 0x04003C24 RID: 15396
		public static readonly LocalizedText Empty;

		// Token: 0x04003C25 RID: 15397
		private static Regex _substitutionRegex;

		// Token: 0x04003C26 RID: 15398
		public readonly string Key;

		// Token: 0x04003C27 RID: 15399
		[CompilerGenerated]
		private string <Value>k__BackingField;

		// Token: 0x0200055A RID: 1370
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600334F RID: 13135 RVA: 0x001FF168 File Offset: 0x001FD368
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06003350 RID: 13136 RVA: 0x001FF17C File Offset: 0x001FD37C
			internal string <FormatWith>b__0(Match match)
			{
				/*
An exception occurred when decompiling this method (06003350)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Terraria.Localization.LocalizedText/<>c__DisplayClass9_0::<FormatWith>b__0(System.Text.RegularExpressions.Match)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:object(var_2_1C, ldfld:object('<>c__DisplayClass9_0'::obj, ldloc:'<>c__DisplayClass9_0'(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

			// Token: 0x04003C28 RID: 15400
			public PropertyDescriptorCollection properties;

			// Token: 0x04003C29 RID: 15401
			public object obj;
		}
	}
}
