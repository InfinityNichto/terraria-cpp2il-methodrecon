using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005B0 RID: 1456
	[ComVisible(true)]
	[Serializable]
	public sealed class NumberFormatInfo : ICloneable, IFormatProvider
	{
		// Token: 0x06002C00 RID: 11264 RVA: 0x0006118C File Offset: 0x0005F38C
		public NumberFormatInfo()
		{
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x0006119C File Offset: 0x0005F39C
		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
			string text = this.numberDecimalSeparator;
			string text2 = this.numberGroupSeparator;
			bool flag = text != text2;
			string text3 = this.numberDecimalSeparator;
			string text4 = this.numberGroupSeparator;
			bool flag2 = text3 != text4;
			string text5 = this.numberDecimalSeparator;
			string text6 = this.currencyGroupSeparator;
			bool flag3 = text5 != text6;
			string text7 = this.currencyDecimalSeparator;
			string text8 = this.numberGroupSeparator;
			bool flag4 = text7 != text8;
			string text9 = this.currencyGroupSeparator;
			bool flag5 = this.currencyDecimalSeparator != text9;
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x00061234 File Offset: 0x0005F434
		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00061244 File Offset: 0x0005F444
		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x00061254 File Offset: 0x0005F454
		internal NumberFormatInfo(CultureData cultureData)
		{
			this.positiveSign = "+";
			this.negativeSign = "-";
			this.currencyGroupSeparator = ",";
			this.currencyDecimalSeparator = ".";
			this.numberDecimalSeparator = ".";
			this.numberGroupSeparator = ",";
			this.currencySymbol = "¤";
			this.nanSymbol = "NaN";
			this.positiveInfinitySymbol = "Infinity";
			this.percentGroupSeparator = ",";
			this.negativeInfinitySymbol = "-Infinity";
			this.percentDecimalSeparator = ".";
			this.percentSymbol = "%";
			this.perMilleSymbol = "‰";
			if (("0" != null && "0" == null) || ("1" != null && "1" == null) || ("2" != null && "2" == null) || ("3" != null && "3" == null) || ("4" != null && "4" == null) || ("5" != null && "5" == null) || ("6" != null && "6" == null) || ("7" != null && "7" == null) || ("8" != null && "8" == null) || ("9" != null && "9" == null))
			{
				throw new ArrayTypeMismatchException();
			}
			this.numberNegativePattern = 1;
			base..ctor();
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (true)
			{
				this.m_isInvariant = true;
				return;
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000613BC File Offset: 0x0005F5BC
		private void VerifyWritable()
		{
			/*
An exception occurred when decompiling this method (06002C05)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Globalization.NumberFormatInfo::VerifyWritable()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:string(var_0_13, call:string(Environment::GetResourceString, ldstr:string("Instance is read-only.")))
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

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x0000207A File Offset: 0x0000027A
		public static NumberFormatInfo InvariantInfo
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000613DC File Offset: 0x0005F5DC
		public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			Type type;
			if (type != null)
			{
			}
			return NumberFormatInfo.CurrentInfo;
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000613F8 File Offset: 0x0005F5F8
		public object Clone()
		{
			object obj = base.MemberwiseClone();
			if (obj != null)
			{
			}
			return obj;
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00061418 File Offset: 0x0005F618
		public int CurrencyDecimalDigits
		{
			get
			{
				return this.currencyDecimalDigits;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x0006142C File Offset: 0x0005F62C
		public string CurrencyDecimalSeparator
		{
			get
			{
				return this.currencyDecimalSeparator;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x00061440 File Offset: 0x0005F640
		public bool IsReadOnly
		{
			get
			{
				return this.isReadOnly;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x00061454 File Offset: 0x0005F654
		public int[] CurrencyGroupSizes
		{
			get
			{
				int[] array = this.currencyGroupSizes;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x00061474 File Offset: 0x0005F674
		public int[] NumberGroupSizes
		{
			get
			{
				int[] array = this.numberGroupSizes;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x00061494 File Offset: 0x0005F694
		public int[] PercentGroupSizes
		{
			get
			{
				int[] array = this.percentGroupSizes;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000614B4 File Offset: 0x0005F6B4
		public string CurrencyGroupSeparator
		{
			get
			{
				return this.currencyGroupSeparator;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x000614C8 File Offset: 0x0005F6C8
		public string CurrencySymbol
		{
			get
			{
				return this.currencySymbol;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000614DC File Offset: 0x0005F6DC
		public static NumberFormatInfo CurrentInfo
		{
			get
			{
				CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
				NumberFormatInfo numInfo;
				if (currentCulture.m_isInherited)
				{
					if (currentCulture != null)
					{
						throw new InvalidCastException();
					}
				}
				else
				{
					numInfo = currentCulture.numInfo;
					while (numInfo == null)
					{
					}
				}
				return numInfo;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x00061514 File Offset: 0x0005F714
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x00061528 File Offset: 0x0005F728
		public string NaNSymbol
		{
			get
			{
				return this.nanSymbol;
			}
			set
			{
				/*
An exception occurred when decompiling this method (06002C13)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Globalization.NumberFormatInfo::set_NaNSymbol(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:string(var_0_1B, call:string(Environment::GetResourceString, ldstr:string("String reference not set to an instance of a String.")))
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00061550 File Offset: 0x0005F750
		public int CurrencyNegativePattern
		{
			get
			{
				return this.currencyNegativePattern;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x00061564 File Offset: 0x0005F764
		public int NumberNegativePattern
		{
			get
			{
				return this.numberNegativePattern;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x00061578 File Offset: 0x0005F778
		public int PercentPositivePattern
		{
			get
			{
				return this.percentPositivePattern;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x0006158C File Offset: 0x0005F78C
		public int PercentNegativePattern
		{
			get
			{
				return this.percentNegativePattern;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x000615A0 File Offset: 0x0005F7A0
		public string NegativeInfinitySymbol
		{
			get
			{
				return this.negativeInfinitySymbol;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x000615B4 File Offset: 0x0005F7B4
		public string NegativeSign
		{
			get
			{
				return this.negativeSign;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000615C8 File Offset: 0x0005F7C8
		public int NumberDecimalDigits
		{
			get
			{
				return this.numberDecimalDigits;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x000615DC File Offset: 0x0005F7DC
		public string NumberDecimalSeparator
		{
			get
			{
				return this.numberDecimalSeparator;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x000615F0 File Offset: 0x0005F7F0
		public string NumberGroupSeparator
		{
			get
			{
				return this.numberGroupSeparator;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x00061604 File Offset: 0x0005F804
		public int CurrencyPositivePattern
		{
			get
			{
				return this.currencyPositivePattern;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x00061618 File Offset: 0x0005F818
		public string PositiveInfinitySymbol
		{
			get
			{
				return this.positiveInfinitySymbol;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x0006162C File Offset: 0x0005F82C
		public string PositiveSign
		{
			get
			{
				return this.positiveSign;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x00061640 File Offset: 0x0005F840
		public int PercentDecimalDigits
		{
			get
			{
				return this.percentDecimalDigits;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x00061654 File Offset: 0x0005F854
		public string PercentDecimalSeparator
		{
			get
			{
				return this.percentDecimalSeparator;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x00061668 File Offset: 0x0005F868
		public string PercentGroupSeparator
		{
			get
			{
				return this.percentGroupSeparator;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x0006167C File Offset: 0x0005F87C
		public string PercentSymbol
		{
			get
			{
				return this.percentSymbol;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x00061690 File Offset: 0x0005F890
		public string PerMilleSymbol
		{
			get
			{
				return this.perMilleSymbol;
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000616A4 File Offset: 0x0005F8A4
		public object GetFormat(Type formatType)
		{
			/*
An exception occurred when decompiling this method (06002C25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Globalization.NumberFormatInfo::GetFormat(System.Type)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0A, call:bool(Type::op_Equality, ldloc:Type(formatType), ldloc:Type(var_0)))
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

		// Token: 0x06002C26 RID: 11302 RVA: 0x000616BC File Offset: 0x0005F8BC
		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			object obj;
			if (true || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000616D4 File Offset: 0x0005F8D4
		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000616F8 File Offset: 0x0005F8F8
		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
		}

		// Token: 0x0400187E RID: 6270
		private static NumberFormatInfo invariantInfo;

		// Token: 0x0400187F RID: 6271
		internal int[] numberGroupSizes;

		// Token: 0x04001880 RID: 6272
		internal int[] currencyGroupSizes;

		// Token: 0x04001881 RID: 6273
		internal int[] percentGroupSizes;

		// Token: 0x04001882 RID: 6274
		internal string positiveSign;

		// Token: 0x04001883 RID: 6275
		internal string negativeSign;

		// Token: 0x04001884 RID: 6276
		internal string numberDecimalSeparator;

		// Token: 0x04001885 RID: 6277
		internal string numberGroupSeparator;

		// Token: 0x04001886 RID: 6278
		internal string currencyGroupSeparator;

		// Token: 0x04001887 RID: 6279
		internal string currencyDecimalSeparator;

		// Token: 0x04001888 RID: 6280
		internal string currencySymbol;

		// Token: 0x04001889 RID: 6281
		internal string ansiCurrencySymbol;

		// Token: 0x0400188A RID: 6282
		internal string nanSymbol;

		// Token: 0x0400188B RID: 6283
		internal string positiveInfinitySymbol;

		// Token: 0x0400188C RID: 6284
		internal string negativeInfinitySymbol;

		// Token: 0x0400188D RID: 6285
		internal string percentDecimalSeparator;

		// Token: 0x0400188E RID: 6286
		internal string percentGroupSeparator;

		// Token: 0x0400188F RID: 6287
		internal string percentSymbol;

		// Token: 0x04001890 RID: 6288
		internal string perMilleSymbol;

		// Token: 0x04001891 RID: 6289
		[OptionalField(VersionAdded = 2)]
		internal string[] nativeDigits;

		// Token: 0x04001892 RID: 6290
		[OptionalField(VersionAdded = 1)]
		internal int m_dataItem;

		// Token: 0x04001893 RID: 6291
		internal int numberDecimalDigits;

		// Token: 0x04001894 RID: 6292
		internal int currencyDecimalDigits;

		// Token: 0x04001895 RID: 6293
		internal int currencyPositivePattern;

		// Token: 0x04001896 RID: 6294
		internal int currencyNegativePattern;

		// Token: 0x04001897 RID: 6295
		internal int numberNegativePattern;

		// Token: 0x04001898 RID: 6296
		internal int percentPositivePattern;

		// Token: 0x04001899 RID: 6297
		internal int percentNegativePattern;

		// Token: 0x0400189A RID: 6298
		internal int percentDecimalDigits;

		// Token: 0x0400189B RID: 6299
		[OptionalField(VersionAdded = 2)]
		internal int digitSubstitution;

		// Token: 0x0400189C RID: 6300
		internal bool isReadOnly;

		// Token: 0x0400189D RID: 6301
		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x0400189E RID: 6302
		[OptionalField(VersionAdded = 2)]
		internal bool m_isInvariant;

		// Token: 0x0400189F RID: 6303
		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsNumber;

		// Token: 0x040018A0 RID: 6304
		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsCurrency;

		// Token: 0x040018A1 RID: 6305
		private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);
	}
}
