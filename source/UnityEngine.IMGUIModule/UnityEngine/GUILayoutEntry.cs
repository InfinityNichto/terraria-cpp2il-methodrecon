using System;
using Cpp2IlInjected;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	internal class GUILayoutEntry
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
		public GUIStyle style
		{
			get
			{
				return this.m_Style;
			}
			set
			{
				this.m_Style = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		public virtual int marginLeft
		{
			get
			{
				return this.m_Style.margin.left;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		public virtual int marginRight
		{
			get
			{
				return this.m_Style.margin.right;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020B8 File Offset: 0x000002B8
		public virtual int marginTop
		{
			get
			{
				return this.m_Style.margin.top;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020D8 File Offset: 0x000002D8
		public virtual int marginBottom
		{
			get
			{
				return this.m_Style.margin.bottom;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020F5 File Offset: 0x000002F5
		public int marginHorizontal
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020F5 File Offset: 0x000002F5
		public int marginVertical
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002104 File Offset: 0x00000304
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
		{
			this.rect.m_XMin = _minWidth;
			if (!true)
			{
			}
			GUIStyle none = GUIStyle.none;
			this.m_Style = none;
			base..ctor();
			GUIStyle none2;
			if (_style == null)
			{
				if (!true)
				{
				}
				none2 = GUIStyle.none;
			}
			this.m_Style = none2;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002150 File Offset: 0x00000350
		public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
		{
			this.rect.m_XMin = _minWidth;
			if (!true)
			{
			}
			GUIStyle none = GUIStyle.none;
			this.m_Style = none;
			base..ctor();
			this.m_Style = _style;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002190 File Offset: 0x00000390
		public virtual void CalcWidth()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021A0 File Offset: 0x000003A0
		public virtual void CalcHeight()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021B0 File Offset: 0x000003B0
		public virtual void SetHorizontal(float x, float width)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021C0 File Offset: 0x000003C0
		public virtual void SetVertical(float y, float height)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021D0 File Offset: 0x000003D0
		protected virtual void ApplyStyleSettings(GUIStyle style)
		{
			throw new MissingMethodException();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002210 File Offset: 0x00000410
		public virtual void ApplyOptions(GUILayoutOption[] options)
		{
			if (options != null)
			{
				object value = options.value;
				return;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002288 File Offset: 0x00000488
		public override string ToString()
		{
			if (!true)
			{
			}
			return "" + " ";
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002378 File Offset: 0x00000578
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutEntry()
		{
		}

		// Token: 0x04000001 RID: 1
		public float minWidth;

		// Token: 0x04000002 RID: 2
		public float maxWidth;

		// Token: 0x04000003 RID: 3
		public float minHeight;

		// Token: 0x04000004 RID: 4
		public float maxHeight;

		// Token: 0x04000005 RID: 5
		public Rect rect;

		// Token: 0x04000006 RID: 6
		public int stretchWidth;

		// Token: 0x04000007 RID: 7
		public int stretchHeight;

		// Token: 0x04000008 RID: 8
		public bool consideredForMargin = true;

		// Token: 0x04000009 RID: 9
		private GUIStyle m_Style;

		// Token: 0x0400000A RID: 10
		internal static Rect kDummyRect;

		// Token: 0x0400000B RID: 11
		protected static int indent;
	}
}
