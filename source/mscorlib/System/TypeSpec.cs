using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

namespace System
{
	// Token: 0x0200019E RID: 414
	internal class TypeSpec
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00021C24 File Offset: 0x0001FE24
		internal bool HasModifiers
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FD6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.TypeSpec::get_HasModifiers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.List`1<class System.ModifierSpec>(var_0_06, ldfld:class System.Collections.Generic.List`1<class System.ModifierSpec>(TypeSpec::modifier_spec, ldloc:TypeSpec(this)))
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

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00021C38 File Offset: 0x0001FE38
		private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			long num;
			do
			{
				TypeIdentifier typeIdentifier = this.name;
				if (this.nested != null)
				{
				}
				if (this.generic_params == null)
				{
					goto IL_0086;
				}
				int size = this.generic_params._size;
				num = 0L;
			}
			while (num == 0L);
			if (this.generic_params._size != 0)
			{
				List<TypeSpec> list = this.generic_params;
				if (num == 0L)
				{
				}
				StringBuilder stringBuilder2;
				string text;
				StringBuilder stringBuilder = stringBuilder2.Append(text);
				int num2 = 93;
				StringBuilder stringBuilder3 = stringBuilder.Append((char)num2);
			}
			List<TypeSpec> list2 = this.generic_params;
			if (num == 0L)
			{
			}
			int size2 = this.generic_params._size;
			IL_0086:
			string text2 = this.assembly_name;
			string text3 = this.assembly_name;
			StringBuilder stringBuilder5;
			StringBuilder stringBuilder4 = stringBuilder5.Append(text3);
			throw new OutOfMemoryException();
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		private StringBuilder GetModifierString(StringBuilder sb)
		{
			if (this.modifier_spec != null)
			{
			}
			if (this.is_byref)
			{
			}
			return sb;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00021D28 File Offset: 0x0001FF28
		internal string DisplayFullName
		{
			get
			{
				string text;
				if (this.display_fullname == null)
				{
					this.display_fullname = text;
				}
				return text;
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00021D48 File Offset: 0x0001FF48
		internal static TypeSpec Parse(string typeName)
		{
			TypeSpec typeSpec;
			return typeSpec;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00021D58 File Offset: 0x0001FF58
		internal static string UnescapeInternalName(string displayName)
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00021D6C File Offset: 0x0001FF6C
		internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, StackCrawlMark stackMark)
		{
			int num = 1;
			string text;
			if (typeResolver == null && assemblyResolver == null)
			{
				if (this.display_fullname == null)
				{
					this.display_fullname = text;
				}
				if (num == 0)
				{
				}
			}
			string text2 = this.assembly_name;
			string text4;
			if (text2 != null)
			{
				if (assemblyResolver != null)
				{
				}
				Assembly assembly = Assembly.Load(text2);
				string text3 = this.assembly_name;
				text4 = "Could not resolve assembly '" + text3 + "'";
			}
			int stringLength = text4._stringLength;
			int value = stringLength.m_value;
			if (text != null)
			{
			}
			if (text4._stringLength == 0)
			{
				return "Could not resolve type '";
			}
			long num2;
			if (num2 == 0L)
			{
				return "Could not resolve type '";
			}
			string text5;
			int stringLength2 = text5._stringLength;
			throw new OutOfMemoryException();
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00021E5C File Offset: 0x0002005C
		private void AddName(string type_name)
		{
			if (this.name != null)
			{
				if (this.nested == null)
				{
				}
				TypeIdentifier typeIdentifier = TypeIdentifiers.FromDisplay(type_name);
				return;
			}
			TypeIdentifier typeIdentifier2 = TypeIdentifiers.FromDisplay(type_name);
			this.name = typeIdentifier2;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00021E90 File Offset: 0x00020090
		private void AddModifier(ModifierSpec md)
		{
			if (this.modifier_spec == null)
			{
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00021EA8 File Offset: 0x000200A8
		private static void SkipSpace(string name, int pos)
		{
			int stringLength = name._stringLength;
			char c;
			bool flag = char.IsWhiteSpace(c);
			int stringLength2 = name._stringLength;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00021ECC File Offset: 0x000200CC
		private static void BoundCheck(int idx, string s)
		{
			int stringLength = s._stringLength;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00021EE0 File Offset: 0x000200E0
		private static TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			TypeIdentifier typeIdentifier;
			return typeIdentifier;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00021EF0 File Offset: 0x000200F0
		private static TypeSpec Parse(string name, int p, bool is_recurse, bool allow_aqn)
		{
			if (-2147483648 == 0)
			{
				string text2;
				string text = text2.Trim();
				TypeSpec typeSpec;
				return typeSpec;
			}
			return "Can't have a byref of a byref";
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00021FD4 File Offset: 0x000201D4
		public TypeSpec()
		{
		}

		// Token: 0x04000885 RID: 2181
		private TypeIdentifier name;

		// Token: 0x04000886 RID: 2182
		private string assembly_name;

		// Token: 0x04000887 RID: 2183
		private List<TypeIdentifier> nested;

		// Token: 0x04000888 RID: 2184
		private List<TypeSpec> generic_params;

		// Token: 0x04000889 RID: 2185
		private List<ModifierSpec> modifier_spec;

		// Token: 0x0400088A RID: 2186
		private bool is_byref;

		// Token: 0x0400088B RID: 2187
		private string display_fullname;

		// Token: 0x0200019F RID: 415
		[Flags]
		internal enum DisplayNameFormat
		{
			// Token: 0x0400088D RID: 2189
			Default = 0,
			// Token: 0x0400088E RID: 2190
			WANT_ASSEMBLY = 1,
			// Token: 0x0400088F RID: 2191
			NO_MODIFIERS = 2
		}
	}
}
