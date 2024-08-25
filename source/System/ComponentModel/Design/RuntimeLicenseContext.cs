using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace System.ComponentModel.Design
{
	// Token: 0x0200040A RID: 1034
	internal class RuntimeLicenseContext : LicenseContext
	{
		// Token: 0x06001C02 RID: 7170 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
		private string GetLocalPath(string fileName)
		{
			string text;
			string text2;
			return text + text2;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0004CEBC File Offset: 0x0004B0BC
		public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			Hashtable hashtable = this.savedLicenseKeys;
			if (hashtable != null)
			{
				if (hashtable != null)
				{
					goto IL_0070;
				}
				if (this.savedLicenseKeys == null)
				{
				}
			}
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Stream stream;
			if (stream == null)
			{
				string text;
				string fileName = Path.GetFileName(text);
				string text2 = fileName + ".licenses";
				if (assemblies != null)
				{
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					return fileName;
				}
				goto IL_0078;
			}
			else
			{
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string text2;
				string text3 = text2.ToUpper(invariantCulture2);
			}
			IL_0070:
			if (this.savedLicenseKeys != null)
			{
			}
			IL_0078:
			CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
			if (invariantCulture3 != null)
			{
				string text4 = ".licenses" + ".exe.licenses";
				if (invariantCulture3 != null)
				{
					string text5 = ".licenses" + ".dll.licenses";
					if (invariantCulture3 != null)
					{
					}
				}
			}
			while (assemblies != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0004CF88 File Offset: 0x0004B188
		private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name)
		{
			/*
An exception occurred when decompiling this method (06001C04)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.ComponentModel.Design.RuntimeLicenseContext::CaseInsensitiveManifestResourceStreamLookup(System.Reflection.Assembly,System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	brtrue(IL_0000, logicnot:bool(ldloc:CultureInfo[exp:bool](var_1_0A)))
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

		// Token: 0x06001C05 RID: 7173 RVA: 0x0004CFAC File Offset: 0x0004B1AC
		public RuntimeLicenseContext()
		{
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0004CFC0 File Offset: 0x0004B1C0
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeLicenseContext()
		{
		}

		// Token: 0x0400138C RID: 5004
		private static global::System.Diagnostics.TraceSwitch s_runtimeLicenseContextSwitch;

		// Token: 0x0400138D RID: 5005
		internal Hashtable savedLicenseKeys;
	}
}
