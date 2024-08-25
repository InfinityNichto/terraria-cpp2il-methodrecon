using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200039F RID: 927
	public class DepthStencilState : GraphicsResource
	{
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x00069854 File Offset: 0x00067A54
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x00069868 File Offset: 0x00067A68
		public bool DepthBufferEnable
		{
			get
			{
				return this._depthBufferEnable;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0006987C File Offset: 0x00067A7C
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00069890 File Offset: 0x00067A90
		public bool DepthBufferWriteEnable
		{
			get
			{
				return this._depthBufferWriteEnable;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000698A4 File Offset: 0x00067AA4
		// (set) Token: 0x060018A6 RID: 6310 RVA: 0x000698B8 File Offset: 0x00067AB8
		public StencilOperation CounterClockwiseStencilDepthBufferFail
		{
			get
			{
				return this._counterClockwiseStencilDepthBufferFail;
			}
			set
			{
				this.ThrowIfBound();
				this._counterClockwiseStencilDepthBufferFail = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x060018A8 RID: 6312 RVA: 0x000698D4 File Offset: 0x00067AD4
		public StencilOperation CounterClockwiseStencilFail
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.ThrowIfBound();
				this._counterClockwiseStencilFail = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x000698F0 File Offset: 0x00067AF0
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x00069904 File Offset: 0x00067B04
		public CompareFunction CounterClockwiseStencilFunction
		{
			get
			{
				return this._counterClockwiseStencilFunction;
			}
			set
			{
				this.ThrowIfBound();
				this._counterClockwiseStencilFunction = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00069920 File Offset: 0x00067B20
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x00069934 File Offset: 0x00067B34
		public StencilOperation CounterClockwiseStencilPass
		{
			get
			{
				return this._counterClockwiseStencilPass;
			}
			set
			{
				this.ThrowIfBound();
				this._counterClockwiseStencilPass = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x00069950 File Offset: 0x00067B50
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x00069964 File Offset: 0x00067B64
		public CompareFunction DepthBufferFunction
		{
			get
			{
				return this._depthBufferFunction;
			}
			set
			{
				this.ThrowIfBound();
				this._depthBufferFunction = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x00069980 File Offset: 0x00067B80
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x00069994 File Offset: 0x00067B94
		public int ReferenceStencil
		{
			get
			{
				return this._referenceStencil;
			}
			set
			{
				this.ThrowIfBound();
				this._referenceStencil = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x000699B0 File Offset: 0x00067BB0
		// (set) Token: 0x060018B2 RID: 6322 RVA: 0x000699C4 File Offset: 0x00067BC4
		public StencilOperation StencilDepthBufferFail
		{
			get
			{
				return this._stencilDepthBufferFail;
			}
			set
			{
				this.ThrowIfBound();
				this._stencilDepthBufferFail = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060018B3 RID: 6323 RVA: 0x000699E0 File Offset: 0x00067BE0
		// (set) Token: 0x060018B4 RID: 6324 RVA: 0x000699F4 File Offset: 0x00067BF4
		public bool StencilEnable
		{
			get
			{
				return this._stencilEnable;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060018B5 RID: 6325 RVA: 0x00069A08 File Offset: 0x00067C08
		// (set) Token: 0x060018B6 RID: 6326 RVA: 0x00069A1C File Offset: 0x00067C1C
		public StencilOperation StencilFail
		{
			get
			{
				return this._stencilFail;
			}
			set
			{
				this.ThrowIfBound();
				this._stencilFail = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060018B7 RID: 6327 RVA: 0x00069A38 File Offset: 0x00067C38
		// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00069A4C File Offset: 0x00067C4C
		public CompareFunction StencilFunction
		{
			get
			{
				return this._stencilFunction;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060018B9 RID: 6329 RVA: 0x00069A60 File Offset: 0x00067C60
		// (set) Token: 0x060018BA RID: 6330 RVA: 0x00069A74 File Offset: 0x00067C74
		public int StencilMask
		{
			get
			{
				return this._stencilMask;
			}
			set
			{
				this.ThrowIfBound();
				this._stencilMask = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x00069A90 File Offset: 0x00067C90
		// (set) Token: 0x060018BC RID: 6332 RVA: 0x00069AA4 File Offset: 0x00067CA4
		public StencilOperation StencilPass
		{
			get
			{
				return this._stencilPass;
			}
			set
			{
				this.ThrowIfBound();
				this._stencilPass = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060018BD RID: 6333 RVA: 0x00069AC0 File Offset: 0x00067CC0
		// (set) Token: 0x060018BE RID: 6334 RVA: 0x00069AD4 File Offset: 0x00067CD4
		public int StencilWriteMask
		{
			get
			{
				return this._stencilWriteMask;
			}
			set
			{
				this.ThrowIfBound();
				this._stencilWriteMask = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x00069AF0 File Offset: 0x00067CF0
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00069B04 File Offset: 0x00067D04
		public bool TwoSidedStencilMode
		{
			get
			{
				return this._twoSidedStencilMode;
			}
			set
			{
				this.ThrowIfBound();
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00069B18 File Offset: 0x00067D18
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

		// Token: 0x060018C2 RID: 6338 RVA: 0x00069B40 File Offset: 0x00067D40
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

		// Token: 0x060018C3 RID: 6339 RVA: 0x00069B60 File Offset: 0x00067D60
		public DepthStencilState()
		{
			this.ThrowIfBound();
			this._depthBufferEnable = true;
			this.ThrowIfBound();
			this._depthBufferWriteEnable = true;
			this.ThrowIfBound();
			this._depthBufferFunction = CompareFunction.LessEqual;
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this.ThrowIfBound();
			this._stencilMask = 1;
			this.ThrowIfBound();
			this._stencilWriteMask = 1;
			this.ThrowIfBound();
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00069BF8 File Offset: 0x00067DF8
		private DepthStencilState(string name, bool depthBufferEnable, bool depthBufferWriteEnable)
		{
			this.<Name>k__BackingField = name;
			this._defaultStateObject = true;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00069C14 File Offset: 0x00067E14
		private DepthStencilState(DepthStencilState cloneSource)
		{
			string <Name>k__BackingField = cloneSource.<Name>k__BackingField;
			this.<Name>k__BackingField = <Name>k__BackingField;
			bool depthBufferEnable = cloneSource._depthBufferEnable;
			this._depthBufferEnable = depthBufferEnable;
			bool depthBufferWriteEnable = cloneSource._depthBufferWriteEnable;
			this._depthBufferWriteEnable = depthBufferWriteEnable;
			CompareFunction depthBufferFunction = cloneSource._depthBufferFunction;
			this._depthBufferFunction = depthBufferFunction;
			int referenceStencil = cloneSource._referenceStencil;
			this._referenceStencil = referenceStencil;
			StencilOperation stencilDepthBufferFail = cloneSource._stencilDepthBufferFail;
			this._stencilDepthBufferFail = stencilDepthBufferFail;
			bool stencilEnable = cloneSource._stencilEnable;
			this._stencilEnable = stencilEnable;
			int stencilWriteMask = cloneSource._stencilWriteMask;
			this._stencilWriteMask = stencilWriteMask;
			bool twoSidedStencilMode = cloneSource._twoSidedStencilMode;
			this._twoSidedStencilMode = twoSidedStencilMode;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00069CB0 File Offset: 0x00067EB0
		static DepthStencilState()
		{
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000021DB File Offset: 0x000003DB
		internal DepthStencilState Clone()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040026F9 RID: 9977
		private readonly bool _defaultStateObject;

		// Token: 0x040026FA RID: 9978
		private bool _depthBufferEnable;

		// Token: 0x040026FB RID: 9979
		private bool _depthBufferWriteEnable;

		// Token: 0x040026FC RID: 9980
		private StencilOperation _counterClockwiseStencilDepthBufferFail;

		// Token: 0x040026FD RID: 9981
		private StencilOperation _counterClockwiseStencilFail;

		// Token: 0x040026FE RID: 9982
		private CompareFunction _counterClockwiseStencilFunction;

		// Token: 0x040026FF RID: 9983
		private StencilOperation _counterClockwiseStencilPass;

		// Token: 0x04002700 RID: 9984
		private CompareFunction _depthBufferFunction;

		// Token: 0x04002701 RID: 9985
		private int _referenceStencil;

		// Token: 0x04002702 RID: 9986
		private StencilOperation _stencilDepthBufferFail;

		// Token: 0x04002703 RID: 9987
		private bool _stencilEnable;

		// Token: 0x04002704 RID: 9988
		private StencilOperation _stencilFail;

		// Token: 0x04002705 RID: 9989
		private CompareFunction _stencilFunction;

		// Token: 0x04002706 RID: 9990
		private int _stencilMask;

		// Token: 0x04002707 RID: 9991
		private StencilOperation _stencilPass;

		// Token: 0x04002708 RID: 9992
		private int _stencilWriteMask;

		// Token: 0x04002709 RID: 9993
		private bool _twoSidedStencilMode;

		// Token: 0x0400270A RID: 9994
		public static readonly DepthStencilState Default;

		// Token: 0x0400270B RID: 9995
		public static readonly DepthStencilState DepthRead;

		// Token: 0x0400270C RID: 9996
		public static readonly DepthStencilState None;
	}
}
