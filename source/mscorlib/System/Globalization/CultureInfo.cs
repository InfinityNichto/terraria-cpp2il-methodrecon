using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Mono.Interop;

namespace System.Globalization
{
	// Token: 0x020005C0 RID: 1472
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class CultureInfo : ICloneable, IFormatProvider
	{
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x00062BC4 File Offset: 0x00060DC4
		internal CultureData _cultureData
		{
			get
			{
				return this.m_cultureData;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x00062BD8 File Offset: 0x00060DD8
		internal bool _isInherited
		{
			get
			{
				return this.m_isInherited;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x00062BEC File Offset: 0x00060DEC
		public static CultureInfo InvariantCulture
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x00062C00 File Offset: 0x00060E00
		public static CultureInfo CurrentCulture
		{
			get
			{
				return Thread.CurrentThread.CurrentCulture;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x00062C1C File Offset: 0x00060E1C
		public static CultureInfo CurrentUICulture
		{
			get
			{
				return Thread.CurrentThread.CurrentUICulture;
			}
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00062C38 File Offset: 0x00060E38
		internal static CultureInfo ConstructCurrentCulture()
		{
			int num;
			do
			{
				num = 1;
				if (num == 0)
				{
				}
			}
			while (num != 0);
			if (!true)
			{
			}
			return CultureInfo.InvariantCulture;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00062C74 File Offset: 0x00060E74
		internal static CultureInfo ConstructCurrentUICulture()
		{
			if (!true)
			{
			}
			return CultureInfo.ConstructCurrentCulture();
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x00062C8C File Offset: 0x00060E8C
		internal string Territory
		{
			get
			{
				return this.territory;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x00062CA0 File Offset: 0x00060EA0
		internal string _name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x00062CB4 File Offset: 0x00060EB4
		public virtual int LCID
		{
			get
			{
				return this.cultureID;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x00062CC8 File Offset: 0x00060EC8
		public virtual string Name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x00062CDC File Offset: 0x00060EDC
		public virtual Calendar Calendar
		{
			get
			{
				Calendar calendar;
				if (this.calendar == null)
				{
					if (!this.constructed)
					{
						int num = this.cultureID;
						this.constructed = true;
					}
					int num2 = this.default_calendar_type;
					if (!true)
					{
					}
					calendar = CultureInfo.CreateCalendar(num2);
					this.calendar = calendar;
				}
				return calendar;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x00062D20 File Offset: 0x00060F20
		public virtual CultureInfo Parent
		{
			get
			{
				CultureInfo cultureInfo = this.parent_culture;
				if (cultureInfo != null)
				{
					return cultureInfo;
				}
				if (!this.constructed)
				{
					int num = this.cultureID;
					int num2 = 1;
					this.constructed = num2 != 0;
				}
				int num3 = this.cultureID;
				int num4 = this.datetime_index;
				if (!this.m_isReadOnly)
				{
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				this.parent_culture = invariantCulture;
				return invariantCulture;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x00062DA8 File Offset: 0x00060FA8
		public virtual TextInfo TextInfo
		{
			get
			{
				if (this.textInfo == null)
				{
					int num;
					if (!this.constructed)
					{
						num = this.cultureID;
						this.constructed = true;
					}
					Monitor.Enter(this, num != 0);
					if (this.textInfo != null)
					{
					}
					bool isReadOnly = this.m_isReadOnly;
					TextInfo textInfo = this.CreateTextInfo(isReadOnly);
					long num2 = 0L;
					this.textInfo = textInfo;
					if (true)
					{
						Monitor.Exit(this);
					}
					if (num2 != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				return this.textInfo;
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00062E30 File Offset: 0x00061030
		public virtual object Clone()
		{
			if (!this.constructed)
			{
				int num = this.cultureID;
				int num2 = 1;
				this.constructed = num2 != 0;
			}
			object obj = base.MemberwiseClone();
			if (obj != null)
			{
			}
			object obj2;
			if (obj2 != null)
			{
			}
			object obj3;
			if (obj3 != null)
			{
			}
			return obj;
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00062E74 File Offset: 0x00061074
		public override bool Equals(object value)
		{
			if (value != null)
			{
				int num = this.cultureID;
				string name = this.m_name;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00062E98 File Offset: 0x00061098
		public static CultureInfo[] GetCultures(CultureTypes types)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0 || num != 0)
			{
			}
			if (num == 0)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (invariantCulture == null || invariantCulture != null)
			{
				return invariantCulture;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00062ED4 File Offset: 0x000610D4
		private unsafe CultureInfo.Data GetTextInfoData()
		{
			void* ptr = this.textinfo_data;
			CultureInfo.Data data;
			return data;
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00062EEC File Offset: 0x000610EC
		public override int GetHashCode()
		{
			int num;
			return num;
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00062EFC File Offset: 0x000610FC
		public static CultureInfo ReadOnly(CultureInfo ci)
		{
			if (!true)
			{
				int num = 1;
				NumberFormatInfo numberFormatInfo;
				if (numberFormatInfo == null || num == 0)
				{
				}
				DateTimeFormatInfo dateTimeFormatInfo;
				if (dateTimeFormatInfo != null)
				{
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00062F1C File Offset: 0x0006111C
		public override string ToString()
		{
			return this.m_name;
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x00062F30 File Offset: 0x00061130
		public virtual CompareInfo CompareInfo
		{
			get
			{
				if (this.compareInfo == null)
				{
					int num;
					if (!this.constructed)
					{
						num = this.cultureID;
						this.constructed = true;
					}
					Monitor.Enter(this, num != 0);
					if (this.compareInfo != null)
					{
					}
					long num2 = 0L;
					Monitor.Exit(this);
					if (num2 != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				return this.compareInfo;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x00062F98 File Offset: 0x00061198
		public virtual bool IsNeutralCulture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002CEF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.CultureInfo::get_IsNeutralCulture()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CultureInfo::cultureID, ldloc:CultureInfo(this)))
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

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00062FB0 File Offset: 0x000611B0
		private void CheckNeutral()
		{
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x00062FC0 File Offset: 0x000611C0
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x00062FEC File Offset: 0x000611EC
		public virtual NumberFormatInfo NumberFormat
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002CF1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.NumberFormatInfo System.Globalization.CultureInfo::get_NumberFormat()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:CultureData(var_1_15, ldfld:CultureData(CultureInfo::m_cultureData, ldloc:CultureInfo(this)))
	stloc:bool(var_2_1C, ldfld:bool(CultureInfo::m_isReadOnly, ldloc:CultureInfo(this)))
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
			set
			{
				do
				{
					if (!this.constructed)
					{
						int num = this.cultureID;
						this.constructed = true;
					}
					if (this.m_isReadOnly)
					{
						return;
					}
				}
				while (value == null);
				this.numInfo = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x00063024 File Offset: 0x00061224
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00063074 File Offset: 0x00061274
		public virtual DateTimeFormatInfo DateTimeFormat
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002CF3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.DateTimeFormatInfo System.Globalization.CultureInfo::get_DateTimeFormat()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_002E:
	stloc:CultureData(var_2_34, ldfld:CultureData(CultureInfo::m_cultureData, ldloc:CultureInfo(this)))
	stloc:bool(var_3_3B, ldfld:bool(CultureInfo::m_isReadOnly, ldloc:CultureInfo(this)))
	call:void(Thread::MemoryBarrier)
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
			set
			{
				do
				{
					if (!this.constructed)
					{
						int num = this.cultureID;
						this.constructed = true;
					}
					if (this.m_isReadOnly)
					{
						return;
					}
				}
				while (value == null);
				this.dateTimeInfo = value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000630AC File Offset: 0x000612AC
		public virtual string EnglishName
		{
			get
			{
				if (!this.constructed)
				{
					int num = this.cultureID;
					this.constructed = true;
				}
				return this.englishname;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000630D8 File Offset: 0x000612D8
		public bool IsReadOnly
		{
			get
			{
				return this.m_isReadOnly;
			}
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000630EC File Offset: 0x000612EC
		public virtual object GetFormat(Type formatType)
		{
			/*
An exception occurred when decompiling this method (06002CF7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Globalization.CultureInfo::GetFormat(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, call:bool(Type::op_Equality, ldloc:Type(formatType), ldloc:Type(var_0)))
	stloc:bool(var_3_12, call:bool(Type::op_Equality, ldloc:Type(formatType), ldloc:Type(var_2)))
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

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00063110 File Offset: 0x00061310
		private void Construct()
		{
			int num = this.cultureID;
			this.constructed = true;
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x0000207A File Offset: 0x0000027A
		private bool construct_internal_locale_from_lcid(int lcid)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0000207A File Offset: 0x0000027A
		private bool construct_internal_locale_from_name(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0000207A File Offset: 0x0000027A
		private static string get_current_locale_name()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x0000207A File Offset: 0x0000027A
		private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x0006312C File Offset: 0x0006132C
		private void ConstructInvariant(bool read_only)
		{
			this.cultureID = 127;
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			this.numInfo = invariantInfo;
			object obj = invariantInfo.Clone();
			if (obj != null)
			{
				this.numInfo = obj;
				throw new InvalidCastException();
			}
			TextInfo invariant = TextInfo.Invariant;
			this.textInfo = invariant;
			this.englishname = "Invariant Language (Invariant Country)";
			this.nativename = "Invariant Language (Invariant Country)";
			this.default_calendar_type = 257;
			this.win3lang = "IVL";
			this.iso3lang = "IVL";
			this.iso2lang = "iv";
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000631BC File Offset: 0x000613BC
		private TextInfo CreateTextInfo(bool readOnly)
		{
			/*
An exception occurred when decompiling this method (06002CFE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.TextInfo System.Globalization.CultureInfo::CreateTextInfo(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureData(var_0_06, ldfld:CultureData(CultureInfo::m_cultureData, ldloc:CultureInfo(this)))
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

		// Token: 0x06002CFF RID: 11519 RVA: 0x000631D0 File Offset: 0x000613D0
		public CultureInfo(int culture)
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000631E0 File Offset: 0x000613E0
		public CultureInfo(int culture, bool useUserOverride)
		{
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000631F0 File Offset: 0x000613F0
		private CultureInfo(int culture, bool useUserOverride, bool read_only)
		{
			this.constructed = true;
			this.m_isReadOnly = read_only;
			CultureData invariant = CultureData.Invariant;
			this.m_cultureData = invariant;
			this.ConstructInvariant(read_only);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0006328C File Offset: 0x0006148C
		public CultureInfo(string name)
		{
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0006329C File Offset: 0x0006149C
		public CultureInfo(string name, bool useUserOverride)
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000632AC File Offset: 0x000614AC
		private unsafe CultureInfo(string name, bool useUserOverride, bool read_only)
		{
			if (name == null)
			{
				return;
			}
			this.constructed = true;
			this.m_useUserOverride = true;
			Type type;
			bool flag = base.GetType() != type;
			long num3;
			if (name._stringLength != 0)
			{
				string text = name.ToLowerInvariant();
				bool flag2 = this.ConstructLocaleFromName(text);
				void* ptr = this.textinfo_data;
				string name2 = this.m_name;
				int num = this.datetime_index;
				int calendarType = this.CalendarType;
				int num2 = this.number_index;
				string text2 = this.iso2lang;
				num3 = 0L;
				CultureData cultureData;
				this.m_cultureData = cultureData;
				return;
			}
			CultureData invariant = CultureData.Invariant;
			this.m_cultureData = invariant;
			this.ConstructInvariant(num3 != 0L);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00063354 File Offset: 0x00061554
		private CultureInfo()
		{
			this.constructed = true;
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00063370 File Offset: 0x00061570
		private static void insert_into_shared_tables(CultureInfo c)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			int num = c.cultureID;
			string name = c.m_name;
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00063394 File Offset: 0x00061594
		public static CultureInfo GetCultureInfo(int culture)
		{
			if (!true)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000633E0 File Offset: 0x000615E0
		public static CultureInfo GetCultureInfo(string name)
		{
			if (!true)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00063404 File Offset: 0x00061604
		internal static CultureInfo CreateCulture(string name, bool reference)
		{
			return 1;
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00063414 File Offset: 0x00061614
		public unsafe static CultureInfo CreateSpecificCulture(string name)
		{
			void* ptr;
			if (true)
			{
				CultureInfo cultureInfo;
				ptr = cultureInfo.textinfo_data;
				string name2 = cultureInfo.m_name;
				int num = cultureInfo.datetime_index;
				int calendarType = cultureInfo.CalendarType;
				int num2 = cultureInfo.number_index;
				string text = cultureInfo.iso2lang;
				CultureData cultureData;
				cultureInfo.m_cultureData = cultureData;
			}
			if (ptr == null)
			{
			}
			return CultureInfo.InvariantCulture;
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0006346C File Offset: 0x0006166C
		private bool ConstructLocaleFromName(string name)
		{
			/*
An exception occurred when decompiling this method (06002D0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Globalization.CultureInfo::ConstructLocaleFromName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(string::_stringLength, ldloc:string(name)))
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

		// Token: 0x06002D0C RID: 11532 RVA: 0x00063484 File Offset: 0x00061684
		private static CultureInfo CreateSpecificCultureFromNeutral(string name)
		{
			/*
An exception occurred when decompiling this method (06002D0C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.CultureInfo System.Globalization.CultureInfo::CreateSpecificCultureFromNeutral(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_1_06, call:uint32('<PrivateImplementationDetails>'::ComputeStringHash, ldloc:string(var_0)))
	stloc:bool(var_2_12, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("arn")))
	stloc:bool(var_3_1E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("pa")))
	stloc:bool(var_4_2A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ii")))
	stloc:bool(var_5_37, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("tk")))
	stloc:bool(var_6_44, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("mi")))
	stloc:bool(var_7_51, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("af")))
	stloc:bool(var_8_5E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("da")))
	stloc:bool(var_9_6B, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("lb")))
	stloc:bool(var_10_78, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ja")))
	stloc:bool(var_11_85, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("th")))
	stloc:bool(var_12_92, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("uk")))
	stloc:bool(var_13_9F, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("hu")))
	stloc:bool(var_14_AC, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sma")))
	stloc:bool(var_15_B9, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ta")))
	stloc:bool(var_16_C6, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("gsw")))
	stloc:bool(var_17_D3, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("nn")))
	stloc:bool(var_18_E0, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("am")))
	stloc:bool(var_19_ED, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("lt")))
	stloc:bool(var_20_FA, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sw")))
	stloc:bool(var_21_107, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sah")))
	stloc:bool(var_22_114, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("te")))
	stloc:bool(var_23_121, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("zu")))
	stloc:bool(var_24_12E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("iu-cans")))
	stloc:bool(var_25_13B, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("gl")))
	stloc:bool(var_26_148, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("rm")))
	stloc:bool(var_27_155, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("is")))
	stloc:bool(var_28_162, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("quz")))
	stloc:bool(var_29_16F, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("id")))
	stloc:bool(var_30_17C, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ur")))
	stloc:bool(var_31_189, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ro")))
	stloc:bool(var_32_196, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("el")))
	stloc:bool(var_33_1A3, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("prs")))
	stloc:bool(var_34_1B0, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("xh")))
	stloc:bool(var_35_1BD, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("syr")))
	stloc:bool(var_36_1CA, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("mn-mong")))
	stloc:bool(var_37_1D7, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ne")))
	stloc:bool(var_38_1E4, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("tr")))
	stloc:bool(var_39_1F1, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("kok")))
	stloc:bool(var_40_1FE, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("lo")))
	stloc:bool(var_41_20B, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ml")))
	stloc:bool(var_42_218, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("tt")))
	stloc:bool(var_43_225, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("moh")))
	stloc:bool(var_44_232, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("bg")))
	stloc:bool(var_45_23F, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("mt")))
	stloc:bool(var_46_24C, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("cs")))
	stloc:bool(var_47_259, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("hi")))
	stloc:bool(var_48_266, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("en")))
	stloc:bool(var_49_273, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("as")))
	stloc:bool(var_50_280, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("gu")))
	stloc:bool(var_51_28D, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sr-cyrl")))
	stloc:bool(var_52_29A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("tzm-latn")))
	stloc:bool(var_53_2A7, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("de")))
	stloc:bool(var_54_2B4, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sq")))
	stloc:bool(var_55_2C1, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sr-latn")))
	stloc:bool(var_56_2CE, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("tn")))
	stloc:bool(var_57_2DB, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("fo")))
	stloc:bool(var_58_2E8, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("cy")))
	stloc:bool(var_60_2F5, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ky")))
	stloc:bool(var_61_302, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sl")))
	stloc:bool(var_62_30F, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("co")))
	stloc:bool(var_63_31C, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("kk")))
	stloc:bool(var_65_329, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ru")))
	stloc:bool(var_66_336, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("bs-cyrl")))
	stloc:bool(var_67_343, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ig")))
	stloc:bool(var_68_350, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("nb")))
	stloc:bool(var_69_35D, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("et")))
	stloc:bool(var_70_36A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("kn")))
	stloc:bool(var_71_377, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("mk")))
	stloc:bool(var_72_384, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("fy")))
	stloc:bool(var_73_391, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("smj")))
	stloc:bool(var_74_39E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("be")))
	stloc:bool(var_75_3AB, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("mr")))
	stloc:bool(var_76_3B8, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("pl")))
	stloc:bool(var_77_3C5, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("yo")))
	stloc:bool(var_78_3D2, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ga")))
	stloc:bool(var_79_3DF, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ar")))
	stloc:bool(var_80_3EC, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("fil")))
	stloc:bool(var_81_3F9, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ba")))
	stloc:bool(var_82_406, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("hy")))
	stloc:bool(var_83_413, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("eu")))
	stloc:bool(var_84_420, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("zh-cht")))
	stloc:bool(var_85_42D, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ko")))
	stloc:bool(var_86_43A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ha")))
	stloc:bool(var_87_447, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("bs")))
	stloc:bool(var_88_454, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("az-latn")))
	stloc:bool(var_89_461, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("tg-cyrl")))
	stloc:bool(var_90_46E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("km")))
	stloc:bool(var_91_47B, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("wo")))
	stloc:bool(var_92_488, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sk")))
	stloc:bool(var_93_495, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("he")))
	stloc:bool(var_94_4A2, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sv")))
	stloc:bool(var_95_4AF, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("dsb")))
	stloc:bool(var_96_4BC, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("gd")))
	stloc:bool(var_97_4C9, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ca")))
	stloc:bool(var_98_4D6, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("it")))
	stloc:bool(var_99_4E3, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("oc")))
	stloc:bool(var_100_4F0, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("bo")))
	stloc:bool(var_101_4FD, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ps")))
	stloc:bool(var_102_50A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("uz")))
	stloc:bool(var_103_517, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("uz-cyrl")))
	stloc:bool(var_104_524, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sa")))
	stloc:bool(var_105_531, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ms")))
	stloc:bool(var_106_53E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("fr")))
	stloc:bool(var_107_54B, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("es")))
	stloc:bool(var_108_558, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("fa")))
	stloc:bool(var_109_565, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("si")))
	stloc:bool(var_110_572, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("az-cyrl")))
	stloc:bool(var_111_57F, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("or")))
	stloc:bool(var_112_58C, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("pt")))
	stloc:bool(var_113_599, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("rw")))
	stloc:bool(var_114_5A6, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("dv")))
	stloc:bool(var_115_5B3, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("sms")))
	stloc:bool(var_116_5C0, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("smn")))
	stloc:bool(var_117_5CD, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("vi")))
	stloc:bool(var_118_5DA, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("se")))
	stloc:bool(var_119_5E7, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ug")))
	stloc:bool(var_120_5F4, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("lv")))
	stloc:bool(var_121_601, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("iu")))
	stloc:bool(var_122_60E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("ka")))
	stloc:bool(var_123_61B, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("zh-hans")))
	stloc:bool(var_124_628, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("bn")))
	stloc:bool(var_125_635, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("kl")))
	stloc:bool(var_126_642, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("mn")))
	stloc:bool(var_127_64F, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("nl")))
	stloc:bool(var_128_65C, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("br")))
	stloc:bool(var_129_669, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("hr")))
	stloc:bool(var_130_676, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("hsb")))
	stloc:bool(var_131_683, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("qut")))
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

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x00063B18 File Offset: 0x00061D18
		internal int CalendarType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002D0D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Globalization.CultureInfo::get_CalendarType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(CultureInfo::default_calendar_type, ldloc:CultureInfo(this)))
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

		// Token: 0x06002D0E RID: 11534 RVA: 0x00063B2C File Offset: 0x00061D2C
		private static Calendar CreateCalendar(int calendarType)
		{
			return "System.Globalization.UmAlQuraCalendar";
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00063B58 File Offset: 0x00061D58
		private static Exception CreateNotFoundException(string name)
		{
			/*
An exception occurred when decompiling this method (06002D0F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Globalization.CultureInfo::CreateNotFoundException(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_10, call:string(string::Concat, ldstr:string("Culture name "), ldloc:string(name), ldstr:string(" is not supported.")))
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

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x00063B78 File Offset: 0x00061D78
		public static CultureInfo DefaultThreadCurrentCulture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002D10)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.CultureInfo System.Globalization.CultureInfo::get_DefaultThreadCurrentCulture()

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
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x00063B88 File Offset: 0x00061D88
		public static CultureInfo DefaultThreadCurrentUICulture
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002D11)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.CultureInfo System.Globalization.CultureInfo::get_DefaultThreadCurrentUICulture()

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
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x00063B98 File Offset: 0x00061D98
		internal string SortName
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x00063BAC File Offset: 0x00061DAC
		internal static CultureInfo UserDefaultUICulture
		{
			get
			{
				if (!true)
				{
				}
				return CultureInfo.ConstructCurrentUICulture();
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x00063BC4 File Offset: 0x00061DC4
		internal static CultureInfo UserDefaultCulture
		{
			get
			{
				if (!true)
				{
				}
				return CultureInfo.ConstructCurrentCulture();
			}
		}

		// Token: 0x06002D15 RID: 11541
		private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX);

		// Token: 0x06002D16 RID: 11542
		private static extern void SetUserPreferredCultureInfoInAppX(string name);

		// Token: 0x06002D17 RID: 11543 RVA: 0x00063BDC File Offset: 0x00061DDC
		[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
		private static void OnCultureInfoChangedInAppX(string language)
		{
			if (language != null)
			{
				if (!true)
				{
				}
				return;
			}
			if (!true)
			{
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00063BF8 File Offset: 0x00061DF8
		internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
		{
			for (;;)
			{
				if (!true)
				{
				}
				if (!true)
				{
					return;
				}
			}
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00063C0C File Offset: 0x00061E0C
		internal static void SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo cultureInfo)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00063C24 File Offset: 0x00061E24
		internal bool HasInvariantCultureName
		{
			get
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00063C38 File Offset: 0x00061E38
		internal static bool VerifyCultureName(string cultureName, bool throwException)
		{
			char c;
			bool flag = char.IsLetterOrDigit(c);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00063C60 File Offset: 0x00061E60
		internal static bool VerifyCultureName(CultureInfo culture, bool throwException)
		{
			bool flag;
			return !true || flag;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00063C74 File Offset: 0x00061E74
		// Note: this type is marked as 'beforefieldinit'.
		static CultureInfo()
		{
		}

		// Token: 0x0400190A RID: 6410
		private static CultureInfo invariant_culture_info;

		// Token: 0x0400190B RID: 6411
		private static object shared_table_lock;

		// Token: 0x0400190C RID: 6412
		private static CultureInfo default_current_culture;

		// Token: 0x0400190D RID: 6413
		private bool m_isReadOnly;

		// Token: 0x0400190E RID: 6414
		private int cultureID;

		// Token: 0x0400190F RID: 6415
		[NonSerialized]
		private int parent_lcid;

		// Token: 0x04001910 RID: 6416
		[NonSerialized]
		private int datetime_index;

		// Token: 0x04001911 RID: 6417
		[NonSerialized]
		private int number_index;

		// Token: 0x04001912 RID: 6418
		[NonSerialized]
		private int default_calendar_type;

		// Token: 0x04001913 RID: 6419
		private bool m_useUserOverride;

		// Token: 0x04001914 RID: 6420
		internal NumberFormatInfo numInfo;

		// Token: 0x04001915 RID: 6421
		internal DateTimeFormatInfo dateTimeInfo;

		// Token: 0x04001916 RID: 6422
		private TextInfo textInfo;

		// Token: 0x04001917 RID: 6423
		internal string m_name;

		// Token: 0x04001918 RID: 6424
		[NonSerialized]
		private string englishname;

		// Token: 0x04001919 RID: 6425
		[NonSerialized]
		private string nativename;

		// Token: 0x0400191A RID: 6426
		[NonSerialized]
		private string iso3lang;

		// Token: 0x0400191B RID: 6427
		[NonSerialized]
		private string iso2lang;

		// Token: 0x0400191C RID: 6428
		[NonSerialized]
		private string win3lang;

		// Token: 0x0400191D RID: 6429
		[NonSerialized]
		private string territory;

		// Token: 0x0400191E RID: 6430
		[NonSerialized]
		private string[] native_calendar_names;

		// Token: 0x0400191F RID: 6431
		private CompareInfo compareInfo;

		// Token: 0x04001920 RID: 6432
		[NonSerialized]
		private unsafe readonly void* textinfo_data;

		// Token: 0x04001921 RID: 6433
		private int m_dataItem;

		// Token: 0x04001922 RID: 6434
		private Calendar calendar;

		// Token: 0x04001923 RID: 6435
		[NonSerialized]
		private CultureInfo parent_culture;

		// Token: 0x04001924 RID: 6436
		[NonSerialized]
		private bool constructed;

		// Token: 0x04001925 RID: 6437
		[NonSerialized]
		internal byte[] cached_serialized_form;

		// Token: 0x04001926 RID: 6438
		[NonSerialized]
		internal CultureData m_cultureData;

		// Token: 0x04001927 RID: 6439
		[NonSerialized]
		internal bool m_isInherited;

		// Token: 0x04001928 RID: 6440
		internal const int InvariantCultureId = 127;

		// Token: 0x04001929 RID: 6441
		private const int CalendarTypeBits = 8;

		// Token: 0x0400192A RID: 6442
		internal const int LOCALE_INVARIANT = 127;

		// Token: 0x0400192B RID: 6443
		private const string MSG_READONLY = "This instance is read only";

		// Token: 0x0400192C RID: 6444
		private static CultureInfo s_DefaultThreadCurrentUICulture;

		// Token: 0x0400192D RID: 6445
		private static CultureInfo s_DefaultThreadCurrentCulture;

		// Token: 0x0400192E RID: 6446
		private static Dictionary<int, CultureInfo> shared_by_number;

		// Token: 0x0400192F RID: 6447
		private static Dictionary<string, CultureInfo> shared_by_name;

		// Token: 0x04001930 RID: 6448
		private static CultureInfo s_UserPreferredCultureInfoInAppX;

		// Token: 0x04001931 RID: 6449
		internal static readonly bool IsTaiwanSku;

		// Token: 0x020005C1 RID: 1473
		private struct Data
		{
			// Token: 0x04001932 RID: 6450
			public int ansi;

			// Token: 0x04001933 RID: 6451
			public int ebcdic;

			// Token: 0x04001934 RID: 6452
			public int mac;

			// Token: 0x04001935 RID: 6453
			public int oem;

			// Token: 0x04001936 RID: 6454
			public bool right_to_left;

			// Token: 0x04001937 RID: 6455
			public byte list_sep;
		}

		// Token: 0x020005C2 RID: 1474
		private sealed class OnCultureInfoChangedDelegate : MulticastDelegate
		{
			// Token: 0x06002D1E RID: 11550 RVA: 0x00063C88 File Offset: 0x00061E88
			public OnCultureInfoChangedDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06002D1F RID: 11551 RVA: 0x00063CDC File Offset: 0x00061EDC
			public void Invoke(string language)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
