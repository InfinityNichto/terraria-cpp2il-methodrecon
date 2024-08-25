using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures
{
	// Token: 0x0200067F RID: 1663
	public class TileObjectPreviewData
	{
		// Token: 0x06003777 RID: 14199 RVA: 0x00221B14 File Offset: 0x0021FD14
		public void Reset()
		{
			if (!true)
			{
			}
			if (this._data != null)
			{
				return;
			}
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00221B30 File Offset: 0x0021FD30
		public void CopyFrom(TileObjectPreviewData copy)
		{
			ushort type = copy._type;
			int[,] data = this._data;
			this._type = type;
			short style = copy._style;
			this._style = style;
			bool active = copy._active;
			this._active = active;
			float percentValid = copy._percentValid;
			this._percentValid = percentValid;
			if (data != null)
			{
				long num = 0L;
				int num2;
				Array.Clear(data, (int)num, num2);
				Point16 dataSize = this._dataSize;
				return;
			}
			Point16 dataSize2 = copy._dataSize;
			this._dataSize = dataSize2;
			short y = copy._dataSize.Y;
			short y2 = this._dataSize.Y;
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x00221BE8 File Offset: 0x0021FDE8
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x00221BFC File Offset: 0x0021FDFC
		public bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x00221C0C File Offset: 0x0021FE0C
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x00221C20 File Offset: 0x0021FE20
		public ushort Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x00221C34 File Offset: 0x0021FE34
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x00221C48 File Offset: 0x0021FE48
		public short Style
		{
			get
			{
				return this._style;
			}
			set
			{
				this._style = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x00221C5C File Offset: 0x0021FE5C
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x00221C70 File Offset: 0x0021FE70
		public int Alternate
		{
			get
			{
				return this._alternate;
			}
			set
			{
				this._alternate = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x00221C84 File Offset: 0x0021FE84
		// (set) Token: 0x06003782 RID: 14210 RVA: 0x00221C98 File Offset: 0x0021FE98
		public int Random
		{
			get
			{
				return this._random;
			}
			set
			{
				this._random = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003784 RID: 14212 RVA: 0x00221CAC File Offset: 0x0021FEAC
		public Point16 Size
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				if (this._data != null)
				{
				}
				this._size.Y = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x00221CD4 File Offset: 0x0021FED4
		public Point16 Coordinates
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x00221CE4 File Offset: 0x0021FEE4
		public Point16 ObjectStart
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00221CF4 File Offset: 0x0021FEF4
		public void AllInvalid()
		{
			int num = 2;
			int[,] data = this._data;
			data.m_value = num;
		}

		// Token: 0x170006B5 RID: 1717
		public int this[int x, int y]
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600378A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.DataStructures.TileObjectPreviewData::get_Item(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[, ](var_0_06, ldfld:int32[, ](TileObjectPreviewData::_data, ldloc:TileObjectPreviewData(this)))
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
				int[,] data = this._data;
			}
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00221D40 File Offset: 0x0021FF40
		public TileObjectPreviewData()
		{
		}

		// Token: 0x04007881 RID: 30849
		private ushort _type;

		// Token: 0x04007882 RID: 30850
		private short _style;

		// Token: 0x04007883 RID: 30851
		private int _alternate;

		// Token: 0x04007884 RID: 30852
		private int _random;

		// Token: 0x04007885 RID: 30853
		private bool _active;

		// Token: 0x04007886 RID: 30854
		private Point16 _size;

		// Token: 0x04007887 RID: 30855
		private Point16 _coordinates;

		// Token: 0x04007888 RID: 30856
		private Point16 _objectStart;

		// Token: 0x04007889 RID: 30857
		private int[,] _data;

		// Token: 0x0400788A RID: 30858
		private Point16 _dataSize;

		// Token: 0x0400788B RID: 30859
		private float _percentValid;

		// Token: 0x0400788C RID: 30860
		public static TileObjectPreviewData placementCache;

		// Token: 0x0400788D RID: 30861
		public static TileObjectPreviewData randomCache;

		// Token: 0x0400788E RID: 30862
		public const int None = 0;

		// Token: 0x0400788F RID: 30863
		public const int ValidSpot = 1;

		// Token: 0x04007890 RID: 30864
		public const int InvalidSpot = 2;
	}
}
