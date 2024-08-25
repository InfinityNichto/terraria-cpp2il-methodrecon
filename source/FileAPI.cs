using System;
using System.IO;

// Token: 0x0200006D RID: 109
public interface FileAPI
{
	// Token: 0x0600025B RID: 603
	string GetUserSavePath();

	// Token: 0x0600025C RID: 604
	void LegacySync();

	// Token: 0x0600025D RID: 605
	void Mount(bool forSync);

	// Token: 0x0600025E RID: 606
	void Unmount(bool forSync);

	// Token: 0x0600025F RID: 607
	void CreateDirectory(string directory);

	// Token: 0x06000260 RID: 608
	void WriteFile(string filename, byte[] fileData);

	// Token: 0x06000261 RID: 609
	void Delete(string filename);

	// Token: 0x06000262 RID: 610
	byte[] ReadFile(string filename);

	// Token: 0x06000263 RID: 611
	bool Exists(string filename);

	// Token: 0x06000264 RID: 612
	string[] GetFiles(string filename, string searchPattern);

	// Token: 0x06000265 RID: 613
	string[] GetFolders(string filename);

	// Token: 0x06000266 RID: 614
	void SetAttributes(string filename, FileAttributes fileAttributes);

	// Token: 0x06000267 RID: 615
	void Shutdown();
}
