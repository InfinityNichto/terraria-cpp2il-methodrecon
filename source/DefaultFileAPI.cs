using System;
using System.IO;
using Terraria;
using UnityEngine;

// Token: 0x0200006C RID: 108
public class DefaultFileAPI : FileAPI
{
	// Token: 0x0600024D RID: 589 RVA: 0x000068F0 File Offset: 0x00004AF0
	public DefaultFileAPI(PlatformUser user)
	{
		if (!true)
		{
		}
		Debug.Log("DefaultFileAPI");
		this.platformUser = user;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00006918 File Offset: 0x00004B18
	public void Shutdown()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00006928 File Offset: 0x00004B28
	public string GetUserSavePath()
	{
		if (Application.persistentDataPath._stringLength == 0)
		{
			Debug.Log("SetupPaths: Unity path is empty.  Trying native method...");
		}
		string text;
		this._userSavePath = text;
		return text;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0000695C File Offset: 0x00004B5C
	public void LegacySync()
	{
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000696C File Offset: 0x00004B6C
	public void Mount(bool forSync)
	{
		bool flag = string.IsNullOrEmpty(this._userSavePath);
		string savePath = Main.SavePath;
		this._userSavePath = savePath;
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00006994 File Offset: 0x00004B94
	public void Unmount(bool forSync)
	{
	}

	// Token: 0x06000253 RID: 595 RVA: 0x000069A4 File Offset: 0x00004BA4
	public void CreateDirectory(string directory)
	{
		DirectoryInfo directoryInfo = Directory.CreateDirectory(directory);
	}

	// Token: 0x06000254 RID: 596 RVA: 0x000069B8 File Offset: 0x00004BB8
	public void WriteFile(string filename, byte[] fileData)
	{
		if (!true)
		{
		}
		string directoryName = Path.GetDirectoryName(filename);
		bool flag = Directory.Exists(directoryName);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(directoryName);
		File.WriteAllBytes(filename, fileData);
	}

	// Token: 0x06000255 RID: 597 RVA: 0x000069E4 File Offset: 0x00004BE4
	public void Delete(string filename)
	{
		File.Delete(filename);
	}

	// Token: 0x06000256 RID: 598 RVA: 0x000069F8 File Offset: 0x00004BF8
	public byte[] ReadFile(string filename)
	{
		return File.ReadAllBytes(filename);
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00006A0C File Offset: 0x00004C0C
	public string[] GetFiles(string path, string searchPattern)
	{
		bool flag = Directory.Exists(path);
		return Directory.GetFiles(path, searchPattern);
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00006A2C File Offset: 0x00004C2C
	public string[] GetFolders(string path)
	{
		bool flag = Directory.Exists(path);
		return Directory.GetDirectories(path);
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00006A48 File Offset: 0x00004C48
	public bool Exists(string filename)
	{
		return File.Exists(filename);
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00006A5C File Offset: 0x00004C5C
	public void SetAttributes(string filename, FileAttributes fileAttributes)
	{
		File.SetAttributes(filename, fileAttributes);
	}

	// Token: 0x04000217 RID: 535
	private int mountCount;

	// Token: 0x04000218 RID: 536
	private string _userSavePath;

	// Token: 0x04000219 RID: 537
	private PlatformUser platformUser;
}
