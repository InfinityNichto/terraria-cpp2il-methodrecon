using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003A2 RID: 930
	public class SamplerState : GraphicsResource
	{
		// Token: 0x060018DD RID: 6365 RVA: 0x00069ECC File Offset: 0x000680CC
		static SamplerState()
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00069EDC File Offset: 0x000680DC
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x00069EF0 File Offset: 0x000680F0
		public TextureAddressMode AddressU
		{
			get
			{
				return this._addressU;
			}
			set
			{
				this.ThrowIfBound();
				this._addressU = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00069F0C File Offset: 0x0006810C
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00069F20 File Offset: 0x00068120
		public TextureAddressMode AddressV
		{
			get
			{
				return this._addressV;
			}
			set
			{
				this.ThrowIfBound();
				this._addressV = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00069F3C File Offset: 0x0006813C
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00069F50 File Offset: 0x00068150
		public TextureAddressMode AddressW
		{
			get
			{
				return this._addressW;
			}
			set
			{
				this.ThrowIfBound();
				this._addressW = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00069F6C File Offset: 0x0006816C
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00069F84 File Offset: 0x00068184
		public Color BorderColor
		{
			get
			{
				Color borderColor = this._borderColor;
				Color color;
				return color;
			}
			set
			{
				this.ThrowIfBound();
				this._borderColor = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00069FA0 File Offset: 0x000681A0
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00069FB4 File Offset: 0x000681B4
		public TextureFilter Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				this.ThrowIfBound();
				this._filter = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00069FD0 File Offset: 0x000681D0
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00069FE4 File Offset: 0x000681E4
		public int MaxAnisotropy
		{
			get
			{
				return this._maxAnisotropy;
			}
			set
			{
				this.ThrowIfBound();
				this._maxAnisotropy = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0006A000 File Offset: 0x00068200
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x0006A014 File Offset: 0x00068214
		public int MaxMipLevel
		{
			get
			{
				return this._maxMipLevel;
			}
			set
			{
				this.ThrowIfBound();
				this._maxMipLevel = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x0006A030 File Offset: 0x00068230
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x0006A044 File Offset: 0x00068244
		public float MipMapLevelOfDetailBias
		{
			get
			{
				/*
An exception occurred when decompiling this method (060018EC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Microsoft.Xna.Framework.Graphics.SamplerState::get_MipMapLevelOfDetailBias()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(SamplerState::_mipMapLevelOfDetailBias, ldloc:SamplerState(this)))
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
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x0006A058 File Offset: 0x00068258
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x0006A06C File Offset: 0x0006826C
		public CompareFunction ComparisonFunction
		{
			get
			{
				return this._comparisonFunction;
			}
			set
			{
				this.ThrowIfBound();
				this._comparisonFunction = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0006A088 File Offset: 0x00068288
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0006A09C File Offset: 0x0006829C
		public TextureFilterMode FilterMode
		{
			get
			{
				return this._filterMode;
			}
			set
			{
				this.ThrowIfBound();
				this._filterMode = value;
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006A0B8 File Offset: 0x000682B8
		internal void BindToGraphicsDevice(GraphicsDevice device)
		{
			if (!this._defaultStateObject)
			{
				if (this.graphicsDevice != null)
				{
				}
				base.GraphicsDevice = device;
				return;
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0006A0E0 File Offset: 0x000682E0
		internal void ThrowIfBound()
		{
			while (!this._defaultStateObject)
			{
				if (this.graphicsDevice == null)
				{
					return;
				}
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0006A100 File Offset: 0x00068300
		public SamplerState()
		{
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			if (!true)
			{
			}
			this.ThrowIfBound();
			this.ThrowIfBound();
			this._maxAnisotropy = 4;
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this._comparisonFunction = CompareFunction.Never;
			this.ThrowIfBound();
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0006A160 File Offset: 0x00068360
		private SamplerState(string name, TextureFilter filter, TextureAddressMode addressMode)
		{
			this.<Name>k__BackingField = name;
			this._filter = filter;
			this._addressU = addressMode;
			this._addressW = addressMode;
			this._addressW = addressMode;
			this._defaultStateObject = true;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0006A198 File Offset: 0x00068398
		private SamplerState(SamplerState cloneSource)
		{
			string <Name>k__BackingField = cloneSource.<Name>k__BackingField;
			this.<Name>k__BackingField = <Name>k__BackingField;
			TextureFilter filter = cloneSource._filter;
			this._filter = filter;
			TextureAddressMode addressU = cloneSource._addressU;
			this._addressU = addressU;
			TextureAddressMode addressV = cloneSource._addressV;
			this._addressV = addressV;
			TextureAddressMode addressW = cloneSource._addressW;
			this._addressW = addressW;
			Color borderColor = cloneSource._borderColor;
			this._borderColor = borderColor;
			CompareFunction comparisonFunction = cloneSource._comparisonFunction;
			this._comparisonFunction = comparisonFunction;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000021DB File Offset: 0x000003DB
		internal SamplerState Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400271B RID: 10011
		public static readonly SamplerState AnisotropicClamp;

		// Token: 0x0400271C RID: 10012
		public static readonly SamplerState AnisotropicWrap;

		// Token: 0x0400271D RID: 10013
		public static readonly SamplerState LinearClamp;

		// Token: 0x0400271E RID: 10014
		public static readonly SamplerState LinearWrap;

		// Token: 0x0400271F RID: 10015
		public static readonly SamplerState PointClamp;

		// Token: 0x04002720 RID: 10016
		public static readonly SamplerState PointWrap;

		// Token: 0x04002721 RID: 10017
		private readonly bool _defaultStateObject;

		// Token: 0x04002722 RID: 10018
		private TextureAddressMode _addressU;

		// Token: 0x04002723 RID: 10019
		private TextureAddressMode _addressV;

		// Token: 0x04002724 RID: 10020
		private TextureAddressMode _addressW;

		// Token: 0x04002725 RID: 10021
		private Color _borderColor;

		// Token: 0x04002726 RID: 10022
		private TextureFilter _filter;

		// Token: 0x04002727 RID: 10023
		private int _maxAnisotropy;

		// Token: 0x04002728 RID: 10024
		private int _maxMipLevel;

		// Token: 0x04002729 RID: 10025
		private float _mipMapLevelOfDetailBias;

		// Token: 0x0400272A RID: 10026
		private TextureFilterMode _filterMode;

		// Token: 0x0400272B RID: 10027
		private CompareFunction _comparisonFunction;
	}
}
