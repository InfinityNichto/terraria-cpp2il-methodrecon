using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

// Token: 0x0200023F RID: 575
public class LayoutDefinition
{
	// Token: 0x06000D1B RID: 3355 RVA: 0x0003EC24 File Offset: 0x0003CE24
	private static void SerialiseAtPath(BinaryWriter writer, Transform root)
	{
		if (!true)
		{
		}
		int childCount = root.transform.childCount;
		long num = 0L;
		Transform child = root.transform.GetChild((int)num);
		LayoutDefinition component = child.GetComponent<LayoutDefinition>();
		if (component != null)
		{
			Type type = component.GetType();
			string text = component.name;
			Type type2 = component.GetType();
			Type type3 = component.GetType();
			component.SaveFields(writer, type3, component);
		}
		int childCount2 = child.childCount;
		LayoutDefinition.SerialiseAtPath(writer, child);
		int childCount3 = root.transform.childCount;
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x0003ECA0 File Offset: 0x0003CEA0
	public static void LoadReleaseLayout()
	{
		bool flag = LayoutDefinition.LoadReleaseLayout(Resources.Load<TextAsset>("Content/UILayout").bytes);
		Type type;
		MethodInfo method = type.GetMethod("Awake", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x0003ECF4 File Offset: 0x0003CEF4
	public static bool LoadReleaseLayout(byte[] data)
	{
		object obj;
		if (obj != null)
		{
		}
		Type type = 0.GetType();
		if (!false)
		{
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}
		throw new OutOfMemoryException();
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x0003ED44 File Offset: 0x0003CF44
	public void Save(BinaryWriter writer)
	{
		Type type = base.GetType();
		this.SaveFields(writer, type, this);
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0003ED64 File Offset: 0x0003CF64
	public static bool IsList(Type value)
	{
		bool flag;
		return flag;
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x0003ED74 File Offset: 0x0003CF74
	private void SaveFields(BinaryWriter writer, Type implementingType, object thisObject)
	{
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x0003EE84 File Offset: 0x0003D084
	public void Load(BinaryReader reader)
	{
		Type type = base.GetType();
		this.LoadFields(reader, type, this);
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0003EEA4 File Offset: 0x0003D0A4
	private void LoadFields(BinaryReader reader, Type implementingType, object thisObject)
	{
		bool flag = "Unhandled value type " == "name";
		Debug.LogError("UID mismatch!");
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x0003EF84 File Offset: 0x0003D184
	public bool RefreshStyles([Optional] string specificStyle)
	{
		Type type = base.GetType();
		return this.RefreshFields(type, this, specificStyle);
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0003EFA4 File Offset: 0x0003D1A4
	private bool RefreshFields(Type implementingType, object thisObject, [Optional] string specificStyle)
	{
		if (!true)
		{
		}
		bool flag;
		if (flag)
		{
		}
		TransactionButtonStyle_Definition transactionButtonStyle_Definition;
		if (transactionButtonStyle_Definition != null)
		{
			bool flag2;
			return flag2;
		}
		string text;
		Debug.LogWarning(text);
		bool flag3;
		return flag3;
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x0003EFCC File Offset: 0x0003D1CC
	public LayoutDefinition()
	{
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x0003EFE0 File Offset: 0x0003D1E0
	// Note: this type is marked as 'beforefieldinit'.
	static LayoutDefinition()
	{
	}

	// Token: 0x040017D9 RID: 6105
	public string name;

	// Token: 0x040017DA RID: 6106
	private static List<LayoutDefinition> UIDefinitions;

	// Token: 0x040017DB RID: 6107
	private static Dictionary<Type, bool> typesEncountered;

	// Token: 0x040017DC RID: 6108
	private static StringBuilder output;
}
