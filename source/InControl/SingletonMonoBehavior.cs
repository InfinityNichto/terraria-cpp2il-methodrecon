using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200006D RID: 109
	public abstract class SingletonMonoBehavior<TComponent> : MonoBehaviour where TComponent : MonoBehaviour
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0000FD78 File Offset: 0x0000DF78
		public static TComponent Instance
		{
			get
			{
				if (!true)
				{
				}
				bool flag;
				if (!flag)
				{
				}
				long num = 0L;
				if (flag)
				{
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
		protected bool EnforceSingleton
		{
			get
			{
				int instanceID = base.GetInstanceID();
				bool isPlaying = Application.isPlaying;
				long num = 0L;
				base.enabled = num != 0L;
				return true;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		protected bool IsTheSingleton
		{
			get
			{
				int instanceID = base.GetInstanceID();
				if (this == null)
				{
				}
				long num = 0L;
				if (this != null)
				{
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0000FE24 File Offset: 0x0000E024
		protected bool IsNotTheSingleton
		{
			get
			{
				int instanceID = base.GetInstanceID();
				if (this == null)
				{
				}
				long num = 0L;
				if (this != null)
				{
				}
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000025E1 File Offset: 0x000007E1
		private static TComponent[] FindInstances()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000FE64 File Offset: 0x0000E064
		private static TComponent FindFirstInstance()
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000FE74 File Offset: 0x0000E074
		protected virtual void Awake()
		{
			int num = 1;
			bool isPlaying = Application.isPlaying;
			if (num == 0)
			{
			}
			int instanceID = base.GetInstanceID();
			long num2 = 0L;
			base.enabled = num2 != 0L;
			if (instanceID == 0)
			{
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		protected virtual void OnDestroy()
		{
			int instanceID = base.GetInstanceID();
			if (this == null)
			{
			}
			if (this == null)
			{
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000FF1C File Offset: 0x0000E11C
		protected SingletonMonoBehavior()
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000FF30 File Offset: 0x0000E130
		// Note: this type is marked as 'beforefieldinit'.
		static SingletonMonoBehavior()
		{
		}

		// Token: 0x040003F2 RID: 1010
		private static TComponent instance;

		// Token: 0x040003F3 RID: 1011
		private static bool hasInstance;

		// Token: 0x040003F4 RID: 1012
		private static int instanceId;

		// Token: 0x040003F5 RID: 1013
		private static readonly object lockObject;

		// Token: 0x0200006E RID: 110
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600050D RID: 1293 RVA: 0x0000FF40 File Offset: 0x0000E140
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x0000FF50 File Offset: 0x0000E150
			public <>c()
			{
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x0000FF64 File Offset: 0x0000E164
			internal int <FindInstances>b__12_0(TComponent a, TComponent b)
			{
				Transform transform;
				int siblingIndex = transform.GetSiblingIndex();
				Transform transform2;
				int siblingIndex2 = transform2.GetSiblingIndex();
				return siblingIndex2.CompareTo(siblingIndex2);
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x000025E1 File Offset: 0x000007E1
			internal bool <Awake>b__14_0(TComponent o)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040003F6 RID: 1014
			public static readonly SingletonMonoBehavior<TComponent>.<>c <>9;

			// Token: 0x040003F7 RID: 1015
			public static Comparison<TComponent> <>9__12_0;

			// Token: 0x040003F8 RID: 1016
			public static Func<TComponent, bool> <>9__14_0;
		}
	}
}
