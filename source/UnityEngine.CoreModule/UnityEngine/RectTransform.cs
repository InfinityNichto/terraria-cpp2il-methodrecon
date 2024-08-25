using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000E4 RID: 228
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[NativeClass("UI::RectTransform")]
	public sealed class RectTransform : Transform
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060004CA RID: 1226 RVA: 0x00008B18 File Offset: 0x00006D18
		// (remove) Token: 0x060004CB RID: 1227 RVA: 0x00008B30 File Offset: 0x00006D30
		public static event RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate;
				if (@delegate != null)
				{
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00008B48 File Offset: 0x00006D48
		public Rect rect
		{
			get
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00008B5C File Offset: 0x00006D5C
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00008B70 File Offset: 0x00006D70
		public Vector2 anchorMin
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00008B84 File Offset: 0x00006D84
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00008B98 File Offset: 0x00006D98
		public Vector2 anchorMax
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00008BAC File Offset: 0x00006DAC
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00008BC0 File Offset: 0x00006DC0
		public Vector2 anchoredPosition
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00008BD4 File Offset: 0x00006DD4
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00008BE8 File Offset: 0x00006DE8
		public Vector2 sizeDelta
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00008BFC File Offset: 0x00006DFC
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00008C10 File Offset: 0x00006E10
		public Vector2 pivot
		{
			get
			{
				throw new MissingMethodException();
			}
			set
			{
				throw new MissingMethodException();
			}
		}

		// Token: 0x170000FE RID: 254
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00008C24 File Offset: 0x00006E24
		public Vector2 offsetMin
		{
			set
			{
				Vector2 anchoredPosition = this.anchoredPosition;
				Vector2 sizeDelta = this.sizeDelta;
				Vector2 pivot = this.pivot;
				Vector2 sizeDelta2 = this.sizeDelta;
				this.sizeDelta = value;
				Vector2 anchoredPosition2 = this.anchoredPosition;
				Vector2 pivot2 = this.pivot;
				this.anchoredPosition = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00008C6C File Offset: 0x00006E6C
		public Vector2 offsetMax
		{
			set
			{
				Vector2 anchoredPosition = this.anchoredPosition;
				Vector2 sizeDelta = this.sizeDelta;
				Vector2 pivot = this.pivot;
				Vector2 sizeDelta2 = this.sizeDelta;
				this.sizeDelta = value;
				Vector2 anchoredPosition2 = this.anchoredPosition;
				Vector2 pivot2 = this.pivot;
				this.anchoredPosition = value;
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00008CB4 File Offset: 0x00006EB4
		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
			if (fourCornersArray != null)
			{
			}
			Debug.LogError("Calling GetLocalCorners with an array that is null or has less than 4 elements.");
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
			if (fourCornersArray != null)
			{
			}
			Debug.LogError("Calling GetWorldCorners with an array that is null or has less than 4 elements.");
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00008D20 File Offset: 0x00006F20
		public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			Vector2 sizeDelta = this.sizeDelta;
			Vector2 parentSize = this.GetParentSize();
			Vector2 anchorMax = this.anchorMax;
			Vector2 anchorMin = this.anchorMin;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00008D5C File Offset: 0x00006F5C
		[RequiredByNativeCode]
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00008D6C File Offset: 0x00006F6C
		private Vector2 GetParentSize()
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00008D8C File Offset: 0x00006F8C
		private void get_rect_Injected([Out] Rect ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00008DA0 File Offset: 0x00006FA0
		private void get_anchorMin_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00008DB4 File Offset: 0x00006FB4
		private void set_anchorMin_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00008DC8 File Offset: 0x00006FC8
		private void get_anchorMax_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00008DDC File Offset: 0x00006FDC
		private void set_anchorMax_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00008DF0 File Offset: 0x00006FF0
		private void get_anchoredPosition_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00008E04 File Offset: 0x00007004
		private void set_anchoredPosition_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00008E18 File Offset: 0x00007018
		private void get_sizeDelta_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00008E2C File Offset: 0x0000702C
		private void set_sizeDelta_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00008E40 File Offset: 0x00007040
		private void get_pivot_Injected([Out] Vector2 ret)
		{
			throw new MissingMethodException();
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00008E54 File Offset: 0x00007054
		private void set_pivot_Injected(Vector2 value)
		{
			throw new MissingMethodException();
		}

		// Token: 0x040003F8 RID: 1016
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

		// Token: 0x020000E5 RID: 229
		public enum Axis
		{
			// Token: 0x040003FA RID: 1018
			Horizontal,
			// Token: 0x040003FB RID: 1019
			Vertical
		}

		// Token: 0x020000E6 RID: 230
		public sealed class ReapplyDrivenProperties : MulticastDelegate
		{
			// Token: 0x060004E9 RID: 1257 RVA: 0x00008E68 File Offset: 0x00007068
			public ReapplyDrivenProperties(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00008EBC File Offset: 0x000070BC
			public void Invoke(RectTransform driven)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
