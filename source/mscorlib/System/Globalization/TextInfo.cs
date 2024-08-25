using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005B2 RID: 1458
	[ComVisible(true)]
	[Serializable]
	public class TextInfo : ICloneable, IDeserializationCallback
	{
		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x0006197C File Offset: 0x0005FB7C
		internal static TextInfo Invariant
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002C3D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.TextInfo System.Globalization.TextInfo::get_Invariant()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_1_0C, ldfld:string(CultureData::sRealName, callgetter:CultureData(CultureData::get_Invariant)))
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

		// Token: 0x06002C3E RID: 11326 RVA: 0x00061998 File Offset: 0x0005FB98
		internal TextInfo(CultureData cultureData)
		{
			this.m_cultureData = cultureData;
			string sRealName = cultureData.sRealName;
			this.m_cultureName = sRealName;
			this.m_textInfoName = sRealName;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000619C8 File Offset: 0x0005FBC8
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000619D8 File Offset: 0x0005FBD8
		private void OnDeserialized()
		{
			CultureData cultureData = this.m_cultureData;
			if (cultureData == null)
			{
				if (this.m_cultureName == null)
				{
					if (this.customCultureName == null)
					{
						int win32LangID = this.m_win32LangID;
						if (win32LangID != 0)
						{
							if (cultureData == null)
							{
							}
							string sRealName = CultureInfo.GetCultureInfo(win32LangID).m_cultureData.sRealName;
							return;
						}
					}
					this.m_cultureName = "ar-SA";
				}
				if ("ar-SA" == null)
				{
				}
				CultureData cultureData2 = CultureInfo.GetCultureInfo("ar-SA").m_cultureData;
				this.m_cultureData = cultureData2;
				string sRealName2 = cultureData2.sRealName;
				this.m_textInfoName = sRealName2;
			}
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00061A58 File Offset: 0x0005FC58
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
			this.OnDeserialized();
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00061A6C File Offset: 0x0005FC6C
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			string cultureName = this.m_cultureName;
			this.customCultureName = cultureName;
			if (!true)
			{
			}
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureName);
			this.m_win32LangID = cultureInfo;
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x00061A98 File Offset: 0x0005FC98
		[ComVisible(false)]
		public string CultureName
		{
			get
			{
				return this.m_textInfoName;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00061AAC File Offset: 0x0005FCAC
		[ComVisible(false)]
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x00061AC0 File Offset: 0x0005FCC0
		[ComVisible(false)]
		public virtual object Clone()
		{
			object obj = base.MemberwiseClone();
			if (obj != null)
			{
			}
			return obj;
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00061AE0 File Offset: 0x0005FCE0
		[ComVisible(false)]
		public static TextInfo ReadOnly(TextInfo textInfo)
		{
			if (!true)
			{
				object obj;
				if (obj != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x00061AFC File Offset: 0x0005FCFC
		internal void SetReadOnlyState(bool readOnly)
		{
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x00061B0C File Offset: 0x0005FD0C
		public virtual char ToLower(char c)
		{
			bool isAsciiCasingSameAsInvariant = this.IsAsciiCasingSameAsInvariant;
			return c;
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00061B2C File Offset: 0x0005FD2C
		public virtual string ToLower(string str)
		{
			while (str == null)
			{
			}
			return this.ToLowerInternal(str);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x0000207A File Offset: 0x0000027A
		private static char ToLowerAsciiInvariant(char c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00061B44 File Offset: 0x0005FD44
		public virtual char ToUpper(char c)
		{
			bool isAsciiCasingSameAsInvariant = this.IsAsciiCasingSameAsInvariant;
			return c;
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x00061B64 File Offset: 0x0005FD64
		public virtual string ToUpper(string str)
		{
			while (str == null)
			{
			}
			return this.ToUpperInternal(str);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0000207A File Offset: 0x0000027A
		internal static char ToUpperAsciiInvariant(char c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool IsAscii(char c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x00061B7C File Offset: 0x0005FD7C
		private bool IsAsciiCasingSameAsInvariant
		{
			get
			{
				while (this.m_IsAsciiCasingSameAsInvariant != null)
				{
				}
				return this.m_cultureData.sISO639Language == "az";
			}
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00061BC8 File Offset: 0x0005FDC8
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			string textInfoName = this.m_textInfoName;
			bool flag;
			return flag;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00061BE4 File Offset: 0x0005FDE4
		public override int GetHashCode()
		{
			/*
An exception occurred when decompiling this method (06002C51)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.TextInfo::GetHashCode()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(TextInfo::m_textInfoName, ldloc:TextInfo(this)))
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

		// Token: 0x06002C52 RID: 11346 RVA: 0x00061BF8 File Offset: 0x0005FDF8
		public override string ToString()
		{
			string sRealName = this.m_cultureData.sRealName;
			return "TextInfo - " + sRealName;
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00061C1C File Offset: 0x0005FE1C
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			this.OnDeserialized();
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00061C30 File Offset: 0x0005FE30
		private string ToUpperInternal(string str)
		{
			/*
An exception occurred when decompiling this method (06002C54)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TextInfo::ToUpperInternal(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0026:
	stloc:int32(var_6_2C, ldfld:int32(string::_stringLength, ldloc:string(str)))
	stloc:int32(var_8_37, ldfld:int32(string::_stringLength, ldloc:string(str)))
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

		// Token: 0x06002C55 RID: 11349 RVA: 0x00061C78 File Offset: 0x0005FE78
		private string ToLowerInternal(string str)
		{
			/*
An exception occurred when decompiling this method (06002C55)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Globalization.TextInfo::ToLowerInternal(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0026:
	stloc:int32(var_6_2C, ldfld:int32(string::_stringLength, ldloc:string(str)))
	stloc:int32(var_8_37, ldfld:int32(string::_stringLength, ldloc:string(str)))
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

		// Token: 0x06002C56 RID: 11350 RVA: 0x00061CC0 File Offset: 0x0005FEC0
		private char ToUpperInternal(char c)
		{
			int num = 1;
			bool isInvariantCulture = this.m_cultureData.IsInvariantCulture;
			if (num == 0)
			{
			}
			return c;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x00061D78 File Offset: 0x0005FF78
		private char ToLowerInternal(char c)
		{
			int num = 1;
			bool isInvariantCulture = this.m_cultureData.IsInvariantCulture;
			if (num == 0)
			{
			}
			int num2 = 7838;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			if (22976 == 0)
			{
			}
			if (22750 == 0)
			{
				return;
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00061DF0 File Offset: 0x0005FFF0
		internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination)
		{
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00061E00 File Offset: 0x00060000
		internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper)
		{
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00061E14 File Offset: 0x00060014
		internal TextInfo()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040018A6 RID: 6310
		[OptionalField(VersionAdded = 2)]
		private string m_listSeparator;

		// Token: 0x040018A7 RID: 6311
		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		// Token: 0x040018A8 RID: 6312
		[OptionalField(VersionAdded = 3)]
		private string m_cultureName;

		// Token: 0x040018A9 RID: 6313
		[NonSerialized]
		private CultureData m_cultureData;

		// Token: 0x040018AA RID: 6314
		[NonSerialized]
		private string m_textInfoName;

		// Token: 0x040018AB RID: 6315
		[NonSerialized]
		private bool? m_IsAsciiCasingSameAsInvariant;

		// Token: 0x040018AC RID: 6316
		internal static TextInfo s_Invariant;

		// Token: 0x040018AD RID: 6317
		[OptionalField(VersionAdded = 2)]
		private string customCultureName;

		// Token: 0x040018AE RID: 6318
		[OptionalField(VersionAdded = 1)]
		internal int m_nDataItem;

		// Token: 0x040018AF RID: 6319
		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x040018B0 RID: 6320
		[OptionalField(VersionAdded = 1)]
		internal int m_win32LangID;

		// Token: 0x040018B1 RID: 6321
		private const int wordSeparatorMask = 536672256;
	}
}
