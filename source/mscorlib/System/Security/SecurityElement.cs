using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Security
{
	// Token: 0x0200029A RID: 666
	[ComVisible(true)]
	[Serializable]
	public sealed class SecurityElement
	{
		// Token: 0x06001700 RID: 5888 RVA: 0x0003077C File Offset: 0x0002E97C
		public SecurityElement(string tag)
		{
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0003078C File Offset: 0x0002E98C
		public SecurityElement(string tag, string text)
		{
			/*
An exception occurred when decompiling this method (06001701)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.SecurityElement::.ctor(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001F:
	stloc:string(var_1_29, call:string(Locale::GetText, ldstr:string("Invalid XML string")))
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x000307C4 File Offset: 0x0002E9C4
		public Hashtable Attributes
		{
			get
			{
				long num;
				if (this.attributes != null)
				{
					ArrayList arrayList = this.attributes;
					if (arrayList != null)
					{
					}
					object[] items = arrayList._items;
					int size = arrayList._size;
					num = 0L;
					if (arrayList != null)
					{
					}
				}
				if (num == 0L)
				{
					throw new InvalidCastException();
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00030818 File Offset: 0x0002EA18
		public ArrayList Children
		{
			get
			{
				return this.children;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0003082C File Offset: 0x0002EA2C
		public string Tag
		{
			get
			{
				return this.tag;
			}
		}

		// Token: 0x17000254 RID: 596
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x00030840 File Offset: 0x0002EA40
		public string Text
		{
			set
			{
				if (value != null)
				{
					if (!true)
					{
					}
					bool flag = SecurityElement.IsValidText(value);
				}
				if (!true)
				{
				}
				string text = SecurityElement.Unescape(value);
				this.text = text;
			}
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00030884 File Offset: 0x0002EA84
		public void AddAttribute(string name, string value)
		{
			/*
An exception occurred when decompiling this method (06001706)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.SecurityElement::AddAttribute(System.String,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0019:
	stloc:string(var_1_1F, call:string(Locale::GetText, ldloc:string(var_0)))
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

		// Token: 0x06001707 RID: 5895 RVA: 0x000308B0 File Offset: 0x0002EAB0
		public void AddChild(SecurityElement child)
		{
			while (child == null)
			{
			}
			if (this.children == null)
			{
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000308C8 File Offset: 0x0002EAC8
		public string Attribute(string name)
		{
			SecurityElement.SecurityAttribute attribute;
			for (;;)
			{
				if (name != null)
				{
					attribute = this.GetAttribute(name);
					if (attribute != null)
					{
						break;
					}
				}
			}
			return attribute._value;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000308EC File Offset: 0x0002EAEC
		public static string Escape(string str)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00030900 File Offset: 0x0002EB00
		private static string Unescape(string str)
		{
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00030910 File Offset: 0x0002EB10
		public static bool IsValidAttributeName(string name)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00030924 File Offset: 0x0002EB24
		public static bool IsValidAttributeValue(string value)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00030938 File Offset: 0x0002EB38
		public static bool IsValidTag(string tag)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0003094C File Offset: 0x0002EB4C
		public static bool IsValidText(string text)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00030960 File Offset: 0x0002EB60
		public SecurityElement SearchForChildByTag(string tag)
		{
			while (tag == null)
			{
			}
			if (this.children != null)
			{
				ArrayList arrayList = this.children;
				if (arrayList != null)
				{
				}
				int size = arrayList._size;
				ArrayList arrayList2 = this.children;
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x0003099C File Offset: 0x0002EB9C
		public string SearchForTextOfTag(string tag)
		{
			while (tag == null)
			{
			}
			bool flag = this.tag == tag;
			return this.text;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000309E4 File Offset: 0x0002EBE4
		private void ToXml(StringBuilder s, int level)
		{
			string text = this.tag;
			if (this.attributes != null)
			{
				ArrayList arrayList = this.attributes;
				ArrayList arrayList2 = this.attributes;
				if (arrayList2 != null)
				{
				}
				object[] items = arrayList2._items;
				StringBuilder stringBuilder2;
				StringBuilder stringBuilder = stringBuilder2.Append("=\"");
				int size = arrayList2._size;
				string text2;
				StringBuilder stringBuilder3 = stringBuilder.Append(text2).Append("\"");
				ArrayList arrayList3 = this.attributes;
				string newLine = Environment.NewLine;
				ArrayList arrayList4 = this.attributes;
			}
			if (this.text != null)
			{
			}
			ArrayList arrayList5 = this.children;
			if (arrayList5 == null || arrayList5 == null)
			{
				return;
			}
			string text3 = SecurityElement.Escape(this.text);
			StringBuilder stringBuilder5;
			StringBuilder stringBuilder4 = stringBuilder5.Append(text3);
			if (this.children != null)
			{
				string newLine2 = Environment.NewLine;
				ArrayList arrayList6 = this.children;
				return;
			}
			string text4 = this.tag;
			StringBuilder stringBuilder7;
			StringBuilder stringBuilder6 = stringBuilder7.Append(text4).Append(">");
			string newLine3 = Environment.NewLine;
			StringBuilder stringBuilder8 = stringBuilder6.Append(newLine3);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00030B28 File Offset: 0x0002ED28
		internal SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			ArrayList arrayList = this.attributes;
			if (arrayList != null)
			{
				if (arrayList != null)
				{
				}
				object[] items = arrayList._items;
				long num = 0L;
				if (arrayList != null)
				{
				}
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x17000255 RID: 597
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x00030B70 File Offset: 0x0002ED70
		internal string m_strText
		{
			set
			{
				this.text = value;
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00030B84 File Offset: 0x0002ED84
		internal string SearchForTextOfLocalName(string strLocalName)
		{
			if (strLocalName != null)
			{
				string text = this.tag;
				if (text != null)
				{
					bool flag = text.Equals(strLocalName);
					string text2 = this.tag;
					string text3 = ":" + strLocalName;
					string text4 = this.text;
					if (":" == null)
					{
					}
					return SecurityElement.Unescape(text4);
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00030BF0 File Offset: 0x0002EDF0
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityElement()
		{
		}

		// Token: 0x04000BA6 RID: 2982
		private string text;

		// Token: 0x04000BA7 RID: 2983
		private string tag;

		// Token: 0x04000BA8 RID: 2984
		private ArrayList attributes;

		// Token: 0x04000BA9 RID: 2985
		private ArrayList children;

		// Token: 0x04000BAA RID: 2986
		private static readonly char[] invalid_tag_chars;

		// Token: 0x04000BAB RID: 2987
		private static readonly char[] invalid_text_chars;

		// Token: 0x04000BAC RID: 2988
		private static readonly char[] invalid_attr_name_chars;

		// Token: 0x04000BAD RID: 2989
		private static readonly char[] invalid_attr_value_chars;

		// Token: 0x04000BAE RID: 2990
		private static readonly char[] invalid_chars;

		// Token: 0x0200029B RID: 667
		internal class SecurityAttribute
		{
			// Token: 0x06001717 RID: 5911 RVA: 0x00030C00 File Offset: 0x0002EE00
			public SecurityAttribute(string name, string value)
			{
				if (!true)
				{
				}
				bool flag = SecurityElement.IsValidAttributeName(name);
				if (!true)
				{
				}
				bool flag2 = SecurityElement.IsValidAttributeValue(value);
				this._name = name;
				if (!true)
				{
				}
				string text = SecurityElement.Unescape(value);
				this._value = text;
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x06001718 RID: 5912 RVA: 0x00030C64 File Offset: 0x0002EE64
			public string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x06001719 RID: 5913 RVA: 0x00030C78 File Offset: 0x0002EE78
			public string Value
			{
				get
				{
					return this._value;
				}
			}

			// Token: 0x04000BAF RID: 2991
			private string _name;

			// Token: 0x04000BB0 RID: 2992
			private string _value;
		}
	}
}
