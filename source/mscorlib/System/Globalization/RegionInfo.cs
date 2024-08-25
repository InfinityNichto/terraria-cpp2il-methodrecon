using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Globalization
{
	// Token: 0x020005C6 RID: 1478
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class RegionInfo
	{
		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x00064240 File Offset: 0x00062440
		public static RegionInfo CurrentRegion
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002D35)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Globalization.RegionInfo System.Globalization.RegionInfo::get_CurrentRegion()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(callgetter:CultureInfo[exp:bool](CultureInfo::get_CurrentCulture)))
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

		// Token: 0x06002D36 RID: 11574 RVA: 0x00064258 File Offset: 0x00062458
		public RegionInfo(int culture)
		{
			if (!true)
			{
			}
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(culture);
			bool byTerritory = this.GetByTerritory(cultureInfo);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00064280 File Offset: 0x00062480
		public RegionInfo(string name)
		{
			do
			{
				base..ctor();
			}
			while (name == null);
			string text = name.ToUpperInvariant();
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo(name);
			bool byTerritory = this.GetByTerritory(cultureInfo);
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x000642AC File Offset: 0x000624AC
		private RegionInfo(CultureInfo ci)
		{
			this.regionId = 244;
			this.iso2Name = "IV";
			this.iso3Name = "ivc";
			this.win3Name = "IVC";
			this.englishName = "Invariant Country";
			this.nativeName = "Invariant Country";
			this.currencySymbol = "¤";
			this.isoCurrencySymbol = "XDR";
			this.currencyEnglishName = "International Monetary Fund";
			this.currencyNativeName = "International Monetary Fund";
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00064344 File Offset: 0x00062544
		private bool GetByTerritory(CultureInfo ci)
		{
			while (ci == null)
			{
			}
			string territory = ci.territory;
			if (territory != null)
			{
				string text = territory.ToUpperInvariant();
				return;
			}
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0000207A File Offset: 0x0000027A
		private bool construct_internal_region_from_name(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x00064368 File Offset: 0x00062568
		[ComVisible(false)]
		public virtual string CurrencyEnglishName
		{
			get
			{
				return this.currencyEnglishName;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x0006437C File Offset: 0x0006257C
		public virtual string CurrencySymbol
		{
			get
			{
				return this.currencySymbol;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00064390 File Offset: 0x00062590
		[MonoTODO("DisplayName currently only returns the EnglishName")]
		public virtual string DisplayName
		{
			get
			{
				return this.englishName;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000643A4 File Offset: 0x000625A4
		public virtual string EnglishName
		{
			get
			{
				return this.englishName;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000643B8 File Offset: 0x000625B8
		[ComVisible(false)]
		public virtual int GeoId
		{
			get
			{
				return this.regionId;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000643CC File Offset: 0x000625CC
		public virtual bool IsMetric
		{
			get
			{
				string text = this.iso2Name;
				bool flag = text == "US";
				return text == "UK";
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x000643FC File Offset: 0x000625FC
		public virtual string ISOCurrencySymbol
		{
			get
			{
				return this.isoCurrencySymbol;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x00064410 File Offset: 0x00062610
		[ComVisible(false)]
		public virtual string NativeName
		{
			get
			{
				return this.nativeName;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x00064424 File Offset: 0x00062624
		[ComVisible(false)]
		public virtual string CurrencyNativeName
		{
			get
			{
				return this.currencyNativeName;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00064438 File Offset: 0x00062638
		public virtual string Name
		{
			get
			{
				return this.iso2Name;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0006444C File Offset: 0x0006264C
		public virtual string ThreeLetterISORegionName
		{
			get
			{
				return this.iso3Name;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00064460 File Offset: 0x00062660
		public virtual string ThreeLetterWindowsRegionName
		{
			get
			{
				return this.win3Name;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x00064474 File Offset: 0x00062674
		public virtual string TwoLetterISORegionName
		{
			get
			{
				return this.iso2Name;
			}
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00064488 File Offset: 0x00062688
		public override bool Equals(object value)
		{
			if (value != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x0000207A File Offset: 0x0000027A
		public override string ToString()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x0006449C File Offset: 0x0006269C
		internal static void ClearCachedData()
		{
		}

		// Token: 0x04001943 RID: 6467
		private static RegionInfo currentRegion;

		// Token: 0x04001944 RID: 6468
		private int regionId;

		// Token: 0x04001945 RID: 6469
		private string iso2Name;

		// Token: 0x04001946 RID: 6470
		private string iso3Name;

		// Token: 0x04001947 RID: 6471
		private string win3Name;

		// Token: 0x04001948 RID: 6472
		private string englishName;

		// Token: 0x04001949 RID: 6473
		private string nativeName;

		// Token: 0x0400194A RID: 6474
		private string currencySymbol;

		// Token: 0x0400194B RID: 6475
		private string isoCurrencySymbol;

		// Token: 0x0400194C RID: 6476
		private string currencyEnglishName;

		// Token: 0x0400194D RID: 6477
		private string currencyNativeName;
	}
}
