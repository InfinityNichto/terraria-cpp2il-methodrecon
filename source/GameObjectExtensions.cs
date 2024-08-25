using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FD RID: 765
public static class GameObjectExtensions
{
	// Token: 0x060011B9 RID: 4537 RVA: 0x00056E80 File Offset: 0x00055080
	public static GameObject FindInChildren(this GameObject gameObject, string name)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		Transform transform;
		return transform.gameObject;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00056E9C File Offset: 0x0005509C
	public static T FindInChildren<T>(this GameObject gameObject) where T : Component
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00056EB0 File Offset: 0x000550B0
	public static T FindInObjectOrChildren<T>(this GameObject gameObject) where T : Component
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00056EC4 File Offset: 0x000550C4
	public static T[] GetComponentsInObjectChildren<T>(this GameObject gameObject) where T : Component
	{
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00056ED4 File Offset: 0x000550D4
	public static T FindInParents<T>(this GameObject gameObject) where T : Component
	{
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x000021DB File Offset: 0x000003DB
	public static T FindInObjectOrParents<T>(this GameObject gameObject) where T : Component
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00056EE8 File Offset: 0x000550E8
	public static void SetLayer(this GameObject gameObject, int layer)
	{
		if (!true)
		{
		}
		gameObject.transform.SetLayer(layer);
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x00056F08 File Offset: 0x00055108
	public static GameObject InstantiatePrefabAsChild(this GameObject gameObject, GameObject prefab)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		GameObject gameObject2;
		Transform transform = gameObject2.transform;
		Transform transform2;
		transform.parent = transform2;
		long num = 0L;
		transform.localRotation = num;
		int num2;
		gameObject2.SetLayer(num2);
		return gameObject2;
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00056F40 File Offset: 0x00055140
	public static string GetPath(this GameObject gameObject)
	{
		Transform transform;
		return transform.GetPath();
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00056F54 File Offset: 0x00055154
	public static GameObject Parent(this GameObject gameObject)
	{
		Transform transform;
		Transform parent = transform.parent;
		Transform transform2;
		return transform2.parent.gameObject;
	}
}
