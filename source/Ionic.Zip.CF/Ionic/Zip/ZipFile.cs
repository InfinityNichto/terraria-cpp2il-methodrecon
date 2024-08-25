using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000027 RID: 39
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	public class ZipFile : IEnumerable<ZipEntry>, IEnumerable, IDisposable
	{
		// Token: 0x06000152 RID: 338 RVA: 0x000056D8 File Offset: 0x000038D8
		public ZipEntry AddItem(string fileOrDirectoryName)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000056E8 File Offset: 0x000038E8
		public ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
		{
			bool flag = File.Exists(fileOrDirectoryName);
			return this.AddFile(fileOrDirectoryName, directoryPathInArchive);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000571C File Offset: 0x0000391C
		public ZipEntry AddFile(string fileName)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000572C File Offset: 0x0000392C
		public ZipEntry AddFile(string fileName, string directoryPathInArchive)
		{
			if (!true)
			{
			}
			string text = ZipEntry.NameInArchive(fileName, directoryPathInArchive);
			ZipEntry zipEntry = ZipEntry.CreateFromFile(fileName, text);
			if (this._StatusMessageTextWriter != null)
			{
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000575C File Offset: 0x0000395C
		public void RemoveEntries(ICollection<ZipEntry> entriesToRemove)
		{
			if (entriesToRemove != null)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005794 File Offset: 0x00003994
		public void RemoveEntries(ICollection<string> entriesToRemove)
		{
			if (entriesToRemove != null)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000057CC File Offset: 0x000039CC
		public void AddFiles(IEnumerable<string> fileNames)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000057DC File Offset: 0x000039DC
		public void UpdateFiles(IEnumerable<string> fileNames)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000057EC File Offset: 0x000039EC
		public void AddFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			long num = 0L;
			this.AddFiles(fileNames, num != 0L, directoryPathInArchive);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005804 File Offset: 0x00003A04
		public void AddFiles(IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive)
		{
			if (fileNames != null)
			{
				this.OnAddStarted();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000058E0 File Offset: 0x00003AE0
		public void UpdateFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			if (fileNames != null)
			{
				this.OnAddStarted();
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005934 File Offset: 0x00003B34
		public ZipEntry UpdateFile(string fileName)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005944 File Offset: 0x00003B44
		public ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
		{
			if (!true)
			{
			}
			string text = ZipEntry.NameInArchive(fileName, directoryPathInArchive);
			if (this[text] != null)
			{
				this.RemoveEntry(text);
			}
			return this.AddFile(fileName, directoryPathInArchive);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005974 File Offset: 0x00003B74
		public ZipEntry UpdateDirectory(string directoryName)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005984 File Offset: 0x00003B84
		public ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive)
		{
			return this.AddOrUpdateDirectoryImpl(directoryName, directoryPathInArchive, AddOrUpdateAction.AddOrUpdate);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000599C File Offset: 0x00003B9C
		public void UpdateItem(string itemName)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000059AC File Offset: 0x00003BAC
		public void UpdateItem(string itemName, string directoryPathInArchive)
		{
			bool flag = File.Exists(itemName);
			ZipEntry zipEntry = this.UpdateFile(itemName, directoryPathInArchive);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000059E8 File Offset: 0x00003BE8
		public ZipEntry AddEntry(string entryName, string content)
		{
			Encoding @default = Encoding.Default;
			return this.AddEntry(entryName, content, @default);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005A08 File Offset: 0x00003C08
		public ZipEntry AddEntry(string entryName, string content, Encoding encoding)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005A18 File Offset: 0x00003C18
		public ZipEntry AddEntry(string entryName, Stream stream)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry = ZipEntry.CreateForStream(entryName, stream);
			DateTime now = DateTime.Now;
			DateTime now2 = DateTime.Now;
			DateTime now3 = DateTime.Now;
			zipEntry.SetEntryTimes(now, now2, now3);
			if (this._StatusMessageTextWriter != null)
			{
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00005A68 File Offset: 0x00003C68
		public ZipEntry AddEntry(string entryName, WriteDelegate writer)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry = ZipEntry.CreateForWriter(entryName, writer);
			if (this._StatusMessageTextWriter != null)
			{
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005A90 File Offset: 0x00003C90
		public ZipEntry AddEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry = ZipEntry.CreateForJitStreamProvider(entryName, opener, closer);
			DateTime now = DateTime.Now;
			DateTime now2 = DateTime.Now;
			DateTime now3 = DateTime.Now;
			zipEntry.SetEntryTimes(now, now2, now3);
			if (this._StatusMessageTextWriter != null)
			{
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005AE0 File Offset: 0x00003CE0
		private ZipEntry _InternalAddEntry(ZipEntry ze)
		{
			CompressionMethod compressionMethod = this._compressionMethod;
			ze.CompressionMethod = compressionMethod;
			CompressionLevel compressionLevel = this.<CompressionLevel>k__BackingField;
			ze.CompressionLevel = compressionLevel;
			ExtractExistingFileAction extractExistingFileAction = this.<ExtractExistingFile>k__BackingField;
			ze.<ExtractExistingFile>k__BackingField = extractExistingFileAction;
			if (this.ZipError != null)
			{
				this._zipErrorAction = ZipErrorAction.InvokeErrorEvent;
				return ze;
			}
			ZipErrorAction zipErrorAction = this._zipErrorAction;
			ze.<ZipErrorAction>k__BackingField = zipErrorAction;
			SetCompressionCallback setCompressionCallback = this.<SetCompression>k__BackingField;
			ze.<SetCompression>k__BackingField = setCompressionCallback;
			Encoding alternateEncoding = this._alternateEncoding;
			ze.<AlternateEncoding>k__BackingField = alternateEncoding;
			ZipOption alternateEncodingUsage = this._alternateEncodingUsage;
			ze.<AlternateEncodingUsage>k__BackingField = alternateEncodingUsage;
			string password = this._Password;
			ze._Password = password;
			if (password != null)
			{
				ZipEntrySource source = ze._Source;
				if (!ze._sourceIsEncrypted)
				{
					ze._restreamRequiredOnSave = true;
				}
				if (ze._Encryption == EncryptionAlgorithm.None)
				{
					ze._Encryption = EncryptionAlgorithm.PkzipWeak;
					return ze;
				}
			}
			EncryptionAlgorithm encryption = this._Encryption;
			ze.Encryption = encryption;
			bool emitNtfsTimes = this._emitNtfsTimes;
			string fileNameInArchive = ze._FileNameInArchive;
			ze._emitNtfsTimes = emitNtfsTimes;
			bool emitUnixTimes = this._emitUnixTimes;
			ze._metadataChanged = true;
			ze._emitUnixTimes = emitUnixTimes;
			this.InternalAddEntry(fileNameInArchive, ze);
			this.AfterAddEntry(ze);
			return ze;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public ZipEntry UpdateEntry(string entryName, string content)
		{
			Encoding @default = Encoding.Default;
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, content, @default);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005C1C File Offset: 0x00003E1C
		public ZipEntry UpdateEntry(string entryName, string content, Encoding encoding)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, content, encoding);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005C3C File Offset: 0x00003E3C
		public ZipEntry UpdateEntry(string entryName, WriteDelegate writer)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, writer);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005C58 File Offset: 0x00003E58
		public ZipEntry UpdateEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, opener, closer);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005C78 File Offset: 0x00003E78
		public ZipEntry UpdateEntry(string entryName, Stream stream)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, stream);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005C94 File Offset: 0x00003E94
		private void RemoveEntryForUpdate(string entryName)
		{
			bool flag = string.IsNullOrEmpty(entryName);
			string directoryName = Path.GetDirectoryName(entryName);
			string fileName = Path.GetFileName(entryName);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005CCC File Offset: 0x00003ECC
		public ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			while (byteContent == null)
			{
			}
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005CE0 File Offset: 0x00003EE0
		public ZipEntry UpdateEntry(string entryName, byte[] byteContent)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, byteContent);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005CFC File Offset: 0x00003EFC
		public ZipEntry AddDirectory(string directoryName)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005D0C File Offset: 0x00003F0C
		public ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
		{
			ZipEntry zipEntry;
			return zipEntry;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005D1C File Offset: 0x00003F1C
		public ZipEntry AddDirectoryByName(string directoryNameInArchive)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry = ZipEntry.CreateFromNothing(directoryNameInArchive);
			zipEntry.MarkAsDirectory();
			Encoding alternateEncoding = this._alternateEncoding;
			zipEntry.<AlternateEncoding>k__BackingField = alternateEncoding;
			ZipOption alternateEncodingUsage = this._alternateEncodingUsage;
			zipEntry.<AlternateEncodingUsage>k__BackingField = alternateEncodingUsage;
			if (alternateEncodingUsage == ZipOption.Default)
			{
			}
			DateTime now = DateTime.Now;
			DateTime now2 = DateTime.Now;
			DateTime now3 = DateTime.Now;
			zipEntry.SetEntryTimes(now, now2, now3);
			bool emitNtfsTimes = this._emitNtfsTimes;
			string fileNameInArchive = zipEntry._FileNameInArchive;
			zipEntry._emitNtfsTimes = emitNtfsTimes;
			bool emitUnixTimes = this._emitUnixTimes;
			zipEntry._metadataChanged = true;
			zipEntry._emitUnixTimes = emitUnixTimes;
			zipEntry._Source = ZipEntrySource.Stream;
			this.InternalAddEntry(fileNameInArchive, zipEntry);
			this.AfterAddEntry(zipEntry);
			return zipEntry;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005DC8 File Offset: 0x00003FC8
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action)
		{
			long num = 0L;
			return this.AddOrUpdateDirectoryImpl(directoryName, rootDirectoryPathInArchive, action, true, (int)num);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005DE4 File Offset: 0x00003FE4
		internal void InternalAddEntry(string name, ZipEntry entry)
		{
			Dictionary<string, ZipEntry> entries = this._entries;
			this._contentsChanged = true;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005E00 File Offset: 0x00004000
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level)
		{
			if (this._StatusMessageTextWriter != null)
			{
			}
			if (level == 0)
			{
				this.OnAddStarted();
			}
			if (this._addOperationCanceled)
			{
			}
			int stringLength = directoryName._stringLength;
			if ("adding" == null)
			{
			}
			string text2;
			string text = Path.Combine(rootDirectoryPathInArchive, text2);
			bool flag = rootDirectoryPathInArchive != "";
			ZipEntry zipEntry = ZipEntry.CreateFromFile(directoryName, text);
			Encoding alternateEncoding = this._alternateEncoding;
			zipEntry.<AlternateEncoding>k__BackingField = alternateEncoding;
			ZipOption alternateEncodingUsage = this._alternateEncodingUsage;
			zipEntry.<AlternateEncodingUsage>k__BackingField = alternateEncodingUsage;
			zipEntry.MarkAsDirectory();
			bool emitNtfsTimes = this._emitNtfsTimes;
			int num = 1;
			string fileNameInArchive = zipEntry._FileNameInArchive;
			zipEntry._emitNtfsTimes = emitNtfsTimes;
			bool emitUnixTimes = this._emitUnixTimes;
			zipEntry._metadataChanged = num != 0;
			zipEntry._emitUnixTimes = emitUnixTimes;
			Dictionary<string, ZipEntry> entries = this._entries;
			string fileNameInArchive2 = zipEntry._FileNameInArchive;
			this.InternalAddEntry(fileNameInArchive2, zipEntry);
			this.AfterAddEntry(zipEntry);
			string fileNameInArchive3 = zipEntry._FileNameInArchive;
			if (!this._addOperationCanceled)
			{
				string[] files = Directory.GetFiles(directoryName);
				long num2 = 0L;
				if (!this._addOperationCanceled)
				{
					if (action != AddOrUpdateAction.AddOnly)
					{
						ZipEntry zipEntry2;
						return zipEntry2;
					}
					if (!this._addOperationCanceled)
					{
						string[] directories = Directory.GetDirectories(directoryName);
						uint attributes = NetCfFile.GetAttributes(fileNameInArchive3);
						if (!this.<AddDirectoryWillTraverseReparsePoints>k__BackingField)
						{
						}
						int num3 = 1;
						ZipEntry zipEntry3 = this.AddOrUpdateDirectoryImpl(fileNameInArchive3, rootDirectoryPathInArchive, action, num3 != 0, (int)num2);
					}
				}
			}
			if (level == 0)
			{
				this.OnAddCompleted();
			}
			return zipEntry;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005F48 File Offset: 0x00004148
		public static bool CheckZip(string zipFileName)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005F5C File Offset: 0x0000415C
		public static bool CheckZip(string zipFileName, bool fixIfNecessary, TextWriter writer)
		{
			if (!true)
			{
			}
			ZipFile zipFile;
			IEnumerator<ZipEntry> enumerator = zipFile.GetEnumerator();
			if (fixIfNecessary)
			{
			}
			if (fixIfNecessary)
			{
			}
			if (fixIfNecessary)
			{
			}
			if (fixIfNecessary)
			{
			}
			if (fixIfNecessary)
			{
				if (enumerator == null)
				{
					return fixIfNecessary;
				}
				goto IL_0033;
			}
			else if (enumerator != null)
			{
				goto IL_0033;
			}
			IL_003A:
			long num;
			while (num == 0L)
			{
			}
			throw new ArrayTypeMismatchException();
			IL_0033:
			if ("{0}: mismatch in Crc32  (0x{1:X4} != 0x{2:X4})" != null)
			{
				goto IL_003A;
			}
			goto IL_003A;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000060BC File Offset: 0x000042BC
		public static void FixZipDirectory(string zipFileName)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000060EC File Offset: 0x000042EC
		public static bool CheckZipPassword(string zipFileName, string password)
		{
			if (!true)
			{
			}
			ZipFile zipFile;
			IEnumerator<ZipEntry> enumerator = zipFile.GetEnumerator();
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
				long num2 = 0L;
				if (zipFile != null)
				{
				}
				if (num2 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000615C File Offset: 0x0000435C
		public string Info
		{
			get
			{
				string name = this._name;
				string text = string.Format("          ZipFile: {0}\n", name);
				bool flag = string.IsNullOrEmpty(this._Comment);
				string comment = this._Comment;
				string text2 = string.Format("          Comment: {0}\n", comment);
				if (this._versionMadeBy != 0)
				{
				}
				if (this._versionNeededToExtract != 0)
				{
				}
				bool? inputUsesZip = this.InputUsesZip64;
				uint diskNumberWithCd = this._diskNumberWithCd;
				uint offsetOfCentralDirectory = this._OffsetOfCentralDirectory;
				long offsetOfCentralDirectory2 = this._OffsetOfCentralDirectory64;
				Dictionary<string, ZipEntry> entries = this._entries;
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000061E4 File Offset: 0x000043E4
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000061F8 File Offset: 0x000043F8
		public bool FullScan
		{
			get
			{
				return this.<FullScan>k__BackingField;
			}
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00006208 File Offset: 0x00004408
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000621C File Offset: 0x0000441C
		public bool SortEntriesBeforeSaving
		{
			get
			{
				return this.<SortEntriesBeforeSaving>k__BackingField;
			}
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000622C File Offset: 0x0000442C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00006240 File Offset: 0x00004440
		public bool AddDirectoryWillTraverseReparsePoints
		{
			get
			{
				return this.<AddDirectoryWillTraverseReparsePoints>k__BackingField;
			}
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00006250 File Offset: 0x00004450
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00006264 File Offset: 0x00004464
		public int BufferSize
		{
			get
			{
				return this._BufferSize;
			}
			set
			{
				this._BufferSize = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006278 File Offset: 0x00004478
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000628C File Offset: 0x0000448C
		public int CodecBufferSize
		{
			get
			{
				return this.<CodecBufferSize>k__BackingField;
			}
			set
			{
				this.<CodecBufferSize>k__BackingField = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000062A0 File Offset: 0x000044A0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000062B4 File Offset: 0x000044B4
		public bool FlattenFoldersOnExtract
		{
			get
			{
				return this.<FlattenFoldersOnExtract>k__BackingField;
			}
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000062C4 File Offset: 0x000044C4
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000062D8 File Offset: 0x000044D8
		public CompressionStrategy Strategy
		{
			get
			{
				return this._Strategy;
			}
			set
			{
				this._Strategy = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000062EC File Offset: 0x000044EC
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00006300 File Offset: 0x00004500
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00006314 File Offset: 0x00004514
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00006328 File Offset: 0x00004528
		public CompressionLevel CompressionLevel
		{
			get
			{
				return this.<CompressionLevel>k__BackingField;
			}
			set
			{
				this.<CompressionLevel>k__BackingField = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000633C File Offset: 0x0000453C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00006350 File Offset: 0x00004550
		public CompressionMethod CompressionMethod
		{
			get
			{
				return this._compressionMethod;
			}
			set
			{
				this._compressionMethod = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00006364 File Offset: 0x00004564
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00006378 File Offset: 0x00004578
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment = value;
				this._contentsChanged = true;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00006394 File Offset: 0x00004594
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000063A8 File Offset: 0x000045A8
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			get
			{
				return this._emitNtfsTimes;
			}
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000063B8 File Offset: 0x000045B8
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000063CC File Offset: 0x000045CC
		public bool EmitTimesInUnixFormatWhenSaving
		{
			get
			{
				return this._emitUnixTimes;
			}
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000063DC File Offset: 0x000045DC
		internal bool Verbose
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000196)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipFile::get_Verbose()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TextWriter(var_0_06, ldfld:TextWriter(ZipFile::_StatusMessageTextWriter, ldloc:ZipFile(this)))
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
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000063F0 File Offset: 0x000045F0
		public bool ContainsEntry(string name)
		{
			/*
An exception occurred when decompiling this method (06000197)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipFile::ContainsEntry(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:string(var_1_10, call:string(SharedUtilities::NormalizePathForUseInZipFile, ldloc:string(name)))
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00006410 File Offset: 0x00004610
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00006424 File Offset: 0x00004624
		public bool CaseSensitiveRetrieval
		{
			get
			{
				return this._CaseSensitiveRetrieval;
			}
			set
			{
				bool caseSensitiveRetrieval = this._CaseSensitiveRetrieval;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00006440 File Offset: 0x00004640
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00006468 File Offset: 0x00004668
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600019A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.Zip.ZipFile::get_UseUnicodeAsNecessary()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_0_06, ldfld:Encoding(ZipFile::_alternateEncoding, ldloc:ZipFile(this)))
	stloc:Encoding(var_1_11, call:Encoding(Encoding::GetEncoding, ldstr:string("UTF-8")))
	stloc:ZipOption(var_3_1A, ldfld:ZipOption(ZipFile::_alternateEncodingUsage, ldloc:ZipFile(this)))
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
				Encoding encoding = Encoding.GetEncoding("UTF-8");
				this._alternateEncoding = encoding;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00006498 File Offset: 0x00004698
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000064AC File Offset: 0x000046AC
		public Zip64Option UseZip64WhenSaving
		{
			get
			{
				return this._zip64;
			}
			set
			{
				this._zip64 = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002122 File Offset: 0x00000322
		public bool? RequiresZip64
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000064C0 File Offset: 0x000046C0
		public bool? OutputUsedZip64
		{
			get
			{
				return this._OutputUsesZip64;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000064D4 File Offset: 0x000046D4
		public bool? InputUsesZip64
		{
			get
			{
				Dictionary<string, ZipEntry> entries = this._entries;
				IEnumerator<ZipEntry> enumerator = this.GetEnumerator();
				long num;
				int num2;
				if (enumerator == null)
				{
					num = 0L;
					num2 = 6;
					if (enumerator != null)
					{
					}
				}
				if (num != 0L || num2 == 0)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000652C File Offset: 0x0000472C
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00006548 File Offset: 0x00004748
		[Obsolete("use AlternateEncoding instead.")]
		public Encoding ProvisionalAlternateEncoding
		{
			get
			{
				ZipOption alternateEncodingUsage = this._alternateEncodingUsage;
				return this._alternateEncoding;
			}
			set
			{
				this._alternateEncoding = value;
				this._alternateEncodingUsage = ZipOption.AsNecessary;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00006564 File Offset: 0x00004764
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00006578 File Offset: 0x00004778
		public Encoding AlternateEncoding
		{
			get
			{
				return this._alternateEncoding;
			}
			set
			{
				this._alternateEncoding = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000658C File Offset: 0x0000478C
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x000065A0 File Offset: 0x000047A0
		public ZipOption AlternateEncodingUsage
		{
			get
			{
				return this._alternateEncodingUsage;
			}
			set
			{
				this._alternateEncodingUsage = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000065B4 File Offset: 0x000047B4
		public static Encoding DefaultEncoding
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000065C8 File Offset: 0x000047C8
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000065DC File Offset: 0x000047DC
		public TextWriter StatusMessageTextWriter
		{
			get
			{
				return this._StatusMessageTextWriter;
			}
			set
			{
				this._StatusMessageTextWriter = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000065F0 File Offset: 0x000047F0
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00006604 File Offset: 0x00004804
		public string TempFileFolder
		{
			get
			{
				return this._TempFileFolder;
			}
			set
			{
				this._TempFileFolder = value;
				if (value != null)
				{
					bool flag = Directory.Exists(value);
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00006658 File Offset: 0x00004858
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00006630 File Offset: 0x00004830
		public string Password
		{
			private get
			{
				return this._Password;
			}
			set
			{
				this._Password = value;
				if (value == null)
				{
					return;
				}
				if (this._Encryption != EncryptionAlgorithm.None)
				{
					return;
				}
				this._Encryption = EncryptionAlgorithm.PkzipWeak;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000666C File Offset: 0x0000486C
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00006680 File Offset: 0x00004880
		public ExtractExistingFileAction ExtractExistingFile
		{
			get
			{
				return this.<ExtractExistingFile>k__BackingField;
			}
			set
			{
				this.<ExtractExistingFile>k__BackingField = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00006694 File Offset: 0x00004894
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000066B8 File Offset: 0x000048B8
		public ZipErrorAction ZipErrorAction
		{
			get
			{
				if (this.ZipError != null)
				{
					this._zipErrorAction = ZipErrorAction.InvokeErrorEvent;
					return ZipErrorAction.InvokeErrorEvent;
				}
				return this._zipErrorAction;
			}
			set
			{
				this._zipErrorAction = value;
				if (this.ZipError != null)
				{
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000066D4 File Offset: 0x000048D4
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x000066E8 File Offset: 0x000048E8
		public EncryptionAlgorithm Encryption
		{
			get
			{
				return this._Encryption;
			}
			set
			{
				this._Encryption = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000066FC File Offset: 0x000048FC
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00006710 File Offset: 0x00004910
		public SetCompressionCallback SetCompression
		{
			get
			{
				return this.<SetCompression>k__BackingField;
			}
			set
			{
				this.<SetCompression>k__BackingField = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006724 File Offset: 0x00004924
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00006738 File Offset: 0x00004938
		public int MaxOutputSegmentSize
		{
			get
			{
				return this._maxOutputSegmentSize;
			}
			set
			{
				while (value != 0)
				{
				}
				this._maxOutputSegmentSize = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00006750 File Offset: 0x00004950
		public int NumberOfSegmentsForMostRecentSave
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipFile::get_NumberOfSegmentsForMostRecentSave()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(ZipFile::_numberOfSegmentsForMostRecentSave, ldloc:ZipFile(this)))
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
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006764 File Offset: 0x00004964
		public override string ToString()
		{
			string name = this._name;
			return string.Format("ZipFile::{0}", name);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002122 File Offset: 0x00000322
		public static Version LibraryVersion
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00006784 File Offset: 0x00004984
		internal void NotifyEntryChanged()
		{
			this._contentsChanged = true;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006798 File Offset: 0x00004998
		internal Stream StreamForDiskNumber(uint diskNumber)
		{
			uint diskNumberWithCd;
			do
			{
				diskNumberWithCd = this._diskNumberWithCd;
			}
			while (this._readName != null);
			ZipSegmentedStream zipSegmentedStream = ZipSegmentedStream.ForReading(this._name, diskNumber, diskNumberWithCd);
			Stream stream;
			return stream;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000067C4 File Offset: 0x000049C4
		internal void Reset(bool whileSaving)
		{
			if (this._JustSaved)
			{
				if (this._readName == null)
				{
					string name = this._name;
				}
				Encoding alternateEncoding = this._alternateEncoding;
				if (this._alternateEncodingUsage == ZipOption.Default)
				{
				}
				return;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000068C0 File Offset: 0x00004AC0
		public ZipFile(string fileName)
		{
			int num = 1;
			int num2 = 8;
			this._emitNtfsTimes = num != 0;
			this._compressionMethod = (CompressionMethod)num2;
			this._ReadStreamIsOurs = num != 0;
			this._locEndOfCDS = (long)num;
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding;
			if (num == 0)
			{
			}
			this._lengthOfReadStream = (long)num2;
			this._BufferSize = num;
			base..ctor();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00006928 File Offset: 0x00004B28
		public ZipFile(string fileName, Encoding encoding)
		{
			int num = 1;
			int num2 = 8;
			this._emitNtfsTimes = num != 0;
			this._compressionMethod = (CompressionMethod)num2;
			this._ReadStreamIsOurs = num != 0;
			this._locEndOfCDS = (long)num;
			Encoding encoding2 = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding2;
			if (num == 0)
			{
			}
			this._lengthOfReadStream = (long)num2;
			this._BufferSize = num;
			base..ctor();
			int num3 = 2;
			this._alternateEncoding = encoding;
			this._alternateEncodingUsage = (ZipOption)num3;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000069A0 File Offset: 0x00004BA0
		public ZipFile()
		{
			this._emitNtfsTimes = true;
			this._compressionMethod = CompressionMethod.Deflate;
			this._ReadStreamIsOurs = true;
			this._locEndOfCDS = 1L;
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding;
			if (!true)
			{
			}
			this._lengthOfReadStream = 8L;
			this._BufferSize = 1;
			base..ctor();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000069F4 File Offset: 0x00004BF4
		public ZipFile(Encoding encoding)
		{
			this._emitNtfsTimes = true;
			this._compressionMethod = CompressionMethod.Deflate;
			this._ReadStreamIsOurs = true;
			this._locEndOfCDS = 1L;
			Encoding encoding2 = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding2;
			if (!true)
			{
			}
			this._lengthOfReadStream = 8L;
			this._BufferSize = 1;
			base..ctor();
			this._alternateEncoding = encoding;
			this._alternateEncodingUsage = ZipOption.Always;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00006A54 File Offset: 0x00004C54
		public ZipFile(string fileName, TextWriter statusMessageWriter)
		{
			int num = 1;
			int num2 = 8;
			this._emitNtfsTimes = num != 0;
			this._compressionMethod = (CompressionMethod)num2;
			this._ReadStreamIsOurs = num != 0;
			this._locEndOfCDS = (long)num;
			Encoding encoding = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding;
			if (num == 0)
			{
			}
			this._lengthOfReadStream = (long)num2;
			this._BufferSize = num;
			base..ctor();
			this._InitInstance(fileName, statusMessageWriter);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00006AC4 File Offset: 0x00004CC4
		public ZipFile(string fileName, TextWriter statusMessageWriter, Encoding encoding)
		{
			int num = 1;
			int num2 = 8;
			this._emitNtfsTimes = num != 0;
			this._compressionMethod = (CompressionMethod)num2;
			this._ReadStreamIsOurs = num != 0;
			this._locEndOfCDS = (long)num;
			Encoding encoding2 = Encoding.GetEncoding("IBM437");
			this._alternateEncoding = encoding2;
			if (num == 0)
			{
			}
			this._lengthOfReadStream = (long)num2;
			this._BufferSize = num;
			base..ctor();
			int num3 = 2;
			this._alternateEncoding = encoding;
			this._alternateEncodingUsage = (ZipOption)num3;
			this._InitInstance(fileName, statusMessageWriter);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00006B44 File Offset: 0x00004D44
		public void Initialize(string fileName)
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00006B60 File Offset: 0x00004D60
		private void _initEntriesDictionary()
		{
			bool caseSensitiveRetrieval = this._CaseSensitiveRetrieval;
			if (true && caseSensitiveRetrieval)
			{
				if (!true)
				{
				}
				return;
			}
			if (!true)
			{
			}
			if (this._entries != null)
			{
				return;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00006B8C File Offset: 0x00004D8C
		private void _InitInstance(string zipFileName, TextWriter statusMessageWriter)
		{
			this._name = zipFileName;
			this._StatusMessageTextWriter = statusMessageWriter;
			this._contentsChanged = true;
			this.<AddDirectoryWillTraverseReparsePoints>k__BackingField = true;
			this.<CompressionLevel>k__BackingField = CompressionLevel.Default;
			this._initEntriesDictionary();
			bool flag = File.Exists(this._name);
			if (this.<FullScan>k__BackingField)
			{
				ZipFile.ReadIntoInstance_Orig(this);
				return;
			}
			ZipFile.ReadIntoInstance(this);
			this._fileAlreadyExists = true;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00006BEC File Offset: 0x00004DEC
		private List<ZipEntry> ZipEntriesAsList
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.List`1<Ionic.Zip.ZipEntry> Ionic.Zip.ZipFile::get_ZipEntriesAsList()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_0_0E, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
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
		}

		// Token: 0x17000073 RID: 115
		public ZipEntry this[int ix]
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zip.ZipEntry Ionic.Zip.ZipFile::get_Item(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.List`1<class Ionic.Zip.ZipEntry>(var_0_06, callgetter:List`1[exp:class [mscorlib]System.Collections.Generic.List`1<class Ionic.Zip.ZipEntry>](ZipFile::get_ZipEntriesAsList, ldloc:ZipFile(this)))
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
		}

		// Token: 0x17000074 RID: 116
		public ZipEntry this[string fileName]
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zip.ZipEntry Ionic.Zip.ZipFile::get_Item(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:string(var_0_09, call:string(SharedUtilities::NormalizePathForUseInZipFile, ldloc:string(fileName)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_1_10, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
	stloc:string(var_2_21, call:string(string::Replace, ldloc:string(var_0_09), ldstr:string("/"), ldstr:string("\\")))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_3_28, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_4_2F, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
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
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00006C5C File Offset: 0x00004E5C
		public ICollection<string> EntryFileNames
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001CA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.ICollection`1<System.String> Ionic.Zip.ZipFile::get_EntryFileNames()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
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
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00006C70 File Offset: 0x00004E70
		public ICollection<ZipEntry> Entries
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.ICollection`1<Ionic.Zip.ZipEntry> Ionic.Zip.ZipFile::get_Entries()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
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
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00006C84 File Offset: 0x00004E84
		public ICollection<ZipEntry> EntriesSorted
		{
			get
			{
				return this.Entries;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00006CD0 File Offset: 0x00004ED0
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zip.ZipFile::get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<string, class Ionic.Zip.ZipEntry>(ZipFile::_entries, ldloc:ZipFile(this)))
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
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public void RemoveEntry(ZipEntry entry)
		{
			while (entry == null)
			{
			}
			Dictionary<string, ZipEntry> entries = this._entries;
			string text = SharedUtilities.NormalizePathForUseInZipFile(entry._FileNameInArchive);
			this._contentsChanged = true;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006D10 File Offset: 0x00004F10
		public void RemoveEntry(string fileName)
		{
			ZipEntry zipEntry;
			do
			{
				if (!true)
				{
				}
				string text;
				zipEntry = this[text];
			}
			while (zipEntry == null);
			this.RemoveEntry(zipEntry);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006D34 File Offset: 0x00004F34
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00006D48 File Offset: 0x00004F48
		protected virtual void Dispose(bool disposeManagedResources)
		{
			if (!this._disposed)
			{
				if (!this._ReadStreamIsOurs || this._readstream != null)
				{
				}
				if (this._temporaryFileName == null || this._name == null || this._writestream != null)
				{
				}
				this._disposed = true;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00006D8C File Offset: 0x00004F8C
		internal Stream ReadStream
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001D2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.ZipFile::get_ReadStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:FileStream(var_1_23, call:FileStream(File::Open, ldloc:string(var_0), ldc.i4:FileMode(3), ldc.i4:FileAccess(1), ldc.i4:FileShare(3)))
	stfld:Stream(ZipFile::_readstream, ldloc:ZipFile(this), ldloc:FileStream[exp:Stream](var_1_23))
	stfld:bool(ZipFile::_ReadStreamIsOurs, ldloc:ZipFile(this), ldc.i4:bool(1))
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
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00006DCC File Offset: 0x00004FCC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00006E14 File Offset: 0x00005014
		private Stream WriteStream
		{
			get
			{
				/*
An exception occurred when decompiling this method (060001D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream Ionic.Zip.ZipFile::get_WriteStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_3:
	stloc:string(var_5_39, call:string(Path::GetDirectoryName, ldloc:string(var_1_12)))
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
				while (value != null)
				{
				}
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006E24 File Offset: 0x00005024
		private string ArchiveNameForEvent
		{
			get
			{
				string name = this._name;
				return "(stream)";
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001D6 RID: 470 RVA: 0x00006E40 File Offset: 0x00005040
		// (remove) Token: 0x060001D7 RID: 471 RVA: 0x00006E68 File Offset: 0x00005068
		public event EventHandler<SaveProgressEventArgs> SaveProgress
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this.SaveProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this.SaveProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006E90 File Offset: 0x00005090
		internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			if (this.SaveProgress != null)
			{
				string name = this._name;
				if (SaveProgressEventArgs.ByteUpdate("(stream)", entry, bytesXferred, totalBytesToXfer)._cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
			return this._saveOperationCanceled;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006ED0 File Offset: 0x000050D0
		private void OnSaveEntry(int current, ZipEntry entry, bool before)
		{
			if (this.SaveProgress != null)
			{
				string name = this._name;
				Dictionary<string, ZipEntry> entries = this._entries;
				if (9 != 0)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006F00 File Offset: 0x00005100
		private void OnSaveEvent(ZipProgressEventType eventFlavor)
		{
			if (this.SaveProgress != null && this._name != null)
			{
				this._saveOperationCanceled = true;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006F24 File Offset: 0x00005124
		private void OnSaveStarted()
		{
			if (this.SaveProgress != null)
			{
				string name = this._name;
				if (SaveProgressEventArgs.Started("(stream)")._cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006F58 File Offset: 0x00005158
		private void OnSaveCompleted()
		{
			if (this.SaveProgress != null)
			{
				string name = this._name;
				SaveProgressEventArgs saveProgressEventArgs = SaveProgressEventArgs.Completed("(stream)");
				return;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001DD RID: 477 RVA: 0x00006F80 File Offset: 0x00005180
		// (remove) Token: 0x060001DE RID: 478 RVA: 0x00006FA8 File Offset: 0x000051A8
		public event EventHandler<ReadProgressEventArgs> ReadProgress
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this.ReadProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ReadProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006FD0 File Offset: 0x000051D0
		private void OnReadStarted()
		{
			if (this.ReadProgress != null)
			{
				string name = this._name;
				ReadProgressEventArgs readProgressEventArgs = ReadProgressEventArgs.Started("(stream)");
				return;
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006FF8 File Offset: 0x000051F8
		private void OnReadCompleted()
		{
			if (this.ReadProgress != null)
			{
				string name = this._name;
				ReadProgressEventArgs readProgressEventArgs = ReadProgressEventArgs.Completed("(stream)");
				return;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007020 File Offset: 0x00005220
		internal void OnReadBytes(ZipEntry entry)
		{
			if (this.ReadProgress != null)
			{
				string name = this._name;
				Stream readStream = this.ReadStream;
				long lengthOfReadStream = this.LengthOfReadStream;
				return;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000704C File Offset: 0x0000524C
		internal void OnReadEntry(bool before, ZipEntry entry)
		{
			if (this.ReadProgress != null)
			{
				string name = this._name;
				Dictionary<string, ZipEntry> entries = this._entries;
				return;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007074 File Offset: 0x00005274
		private long LengthOfReadStream
		{
			get
			{
				long lengthOfReadStream = this._lengthOfReadStream;
				long fileLength;
				if (this._ReadStreamIsOurs)
				{
					fileLength = SharedUtilities.GetFileLength(this._name);
					return fileLength;
				}
				this._lengthOfReadStream = fileLength;
				return fileLength;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001E4 RID: 484 RVA: 0x000070A8 File Offset: 0x000052A8
		// (remove) Token: 0x060001E5 RID: 485 RVA: 0x000070D0 File Offset: 0x000052D0
		public event EventHandler<ExtractProgressEventArgs> ExtractProgress
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this.ExtractProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ExtractProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000070F8 File Offset: 0x000052F8
		private void OnExtractEntry(int current, bool before, ZipEntry currentEntry, string path)
		{
			if (this.ExtractProgress != null)
			{
				string name = this._name;
				Dictionary<string, ZipEntry> entries = this._entries;
				if (17 != 0)
				{
					this._extractOperationCanceled = true;
				}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00007128 File Offset: 0x00005328
		internal bool OnExtractBlock(ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			if (this.ExtractProgress != null)
			{
				string name = this._name;
				if (ExtractProgressEventArgs.ByteUpdate("(stream)", entry, bytesWritten, totalBytesToWrite)._cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00007168 File Offset: 0x00005368
		internal bool OnSingleEntryExtract(ZipEntry entry, string path, bool before)
		{
			if (this.ExtractProgress != null)
			{
				string name = this._name;
				ExtractProgressEventArgs extractProgressEventArgs = ExtractProgressEventArgs.BeforeExtractEntry("(stream)", entry, path);
				ExtractProgressEventArgs extractProgressEventArgs2;
				if (extractProgressEventArgs2._cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000071A8 File Offset: 0x000053A8
		internal bool OnExtractExisting(ZipEntry entry, string path)
		{
			if (this.ExtractProgress != null)
			{
				string name = this._name;
				if (ExtractProgressEventArgs.ExtractExisting("(stream)", entry, path)._cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000071E4 File Offset: 0x000053E4
		private void OnExtractAllCompleted(string path)
		{
			if (this.ExtractProgress != null)
			{
				string name = this._name;
				ExtractProgressEventArgs extractProgressEventArgs = ExtractProgressEventArgs.ExtractAllCompleted("(stream)", path);
				return;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007210 File Offset: 0x00005410
		private void OnExtractAllStarted(string path)
		{
			if (this.ExtractProgress != null)
			{
				string name = this._name;
				ExtractProgressEventArgs extractProgressEventArgs = ExtractProgressEventArgs.ExtractAllStarted("(stream)", path);
				return;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001EC RID: 492 RVA: 0x0000723C File Offset: 0x0000543C
		// (remove) Token: 0x060001ED RID: 493 RVA: 0x00007264 File Offset: 0x00005464
		public event EventHandler<AddProgressEventArgs> AddProgress
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this.AddProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this.AddProgress, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000728C File Offset: 0x0000548C
		private void OnAddStarted()
		{
			if (this.AddProgress != null)
			{
				string name = this._name;
				if (AddProgressEventArgs.Started("(stream)")._cancel)
				{
					this._addOperationCanceled = true;
				}
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000072C0 File Offset: 0x000054C0
		private void OnAddCompleted()
		{
			if (this.AddProgress != null)
			{
				string name = this._name;
				AddProgressEventArgs addProgressEventArgs = AddProgressEventArgs.Completed("(stream)");
				return;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000072E8 File Offset: 0x000054E8
		internal void AfterAddEntry(ZipEntry entry)
		{
			if (this.AddProgress != null)
			{
				string name = this._name;
				Dictionary<string, ZipEntry> entries = this._entries;
				AddProgressEventArgs addProgressEventArgs;
				if (addProgressEventArgs._cancel)
				{
					this._addOperationCanceled = true;
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001F1 RID: 497 RVA: 0x0000731C File Offset: 0x0000551C
		// (remove) Token: 0x060001F2 RID: 498 RVA: 0x00007344 File Offset: 0x00005544
		public event EventHandler<ZipErrorEventArgs> ZipError
		{
			add
			{
				Delegate @delegate = Delegate.Combine(this.ZipError, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			remove
			{
				Delegate @delegate = Delegate.Remove(this.ZipError, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000736C File Offset: 0x0000556C
		internal bool OnZipErrorSaving(ZipEntry entry, Exception exc)
		{
			if (this.ZipError != null)
			{
				object @lock = this.LOCK;
				Monitor.Enter(@lock);
				ZipErrorEventArgs zipErrorEventArgs = ZipErrorEventArgs.Saving(this._name, entry, exc);
				EventHandler<ZipErrorEventArgs> zipError = this.ZipError;
				if (zipErrorEventArgs._cancel)
				{
					this._saveOperationCanceled = true;
				}
				Monitor.Exit(@lock);
			}
			return this._saveOperationCanceled;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000073E8 File Offset: 0x000055E8
		public void ExtractAll(string path)
		{
			this._InternalExtractAll(path, true);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007400 File Offset: 0x00005600
		public void ExtractAll(string path, ExtractExistingFileAction extractExistingFile)
		{
			this.<ExtractExistingFile>k__BackingField = extractExistingFile;
			this._InternalExtractAll(path, true);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000741C File Offset: 0x0000561C
		private void _InternalExtractAll(string path, bool overrideExtractExistingProperty)
		{
			for (;;)
			{
				TextWriter statusMessageTextWriter = this._StatusMessageTextWriter;
				int num = 1;
				this._inExtractAll = num != 0;
				this.OnExtractAllStarted(path);
				Dictionary<string, ZipEntry> entries = this._entries;
				TextWriter statusMessageTextWriter2 = this._StatusMessageTextWriter;
				if ("Name" != null && "Name" == null)
				{
					goto IL_0151;
				}
				if ("Modified" != null && "Modified" == null)
				{
					goto IL_0157;
				}
				if ("Size" != null && "Size" == null)
				{
					goto IL_015D;
				}
				if ("Ratio" != null && "Ratio" == null)
				{
					goto IL_0163;
				}
				if ("Packed" != null && "Packed" == null)
				{
					goto IL_0169;
				}
				TextWriter statusMessageTextWriter3 = this._StatusMessageTextWriter;
				if (this._StatusMessageTextWriter != null)
				{
					break;
				}
				string password = this._Password;
				if (password != null)
				{
					if (password != null)
					{
						continue;
					}
					if (!true)
					{
						return;
					}
				}
				ExtractExistingFileAction extractExistingFileAction = this.<ExtractExistingFile>k__BackingField;
				if (this._extractOperationCanceled)
				{
					goto Block_10;
				}
			}
			DateTime dateTime;
			string text = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
			if (text == null || text != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
			Block_10:
			if (false)
			{
				throw new OutOfMemoryException();
			}
			if (!this._extractOperationCanceled)
			{
				Dictionary<string, ZipEntry> entries2 = this._entries;
				string text3;
				string text2 = Path.Combine(path, text3);
				return;
			}
			return;
			IL_0151:
			throw new ArrayTypeMismatchException();
			IL_0157:
			throw new ArrayTypeMismatchException();
			IL_015D:
			throw new ArrayTypeMismatchException();
			IL_0163:
			throw new ArrayTypeMismatchException();
			IL_0169:
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000075FC File Offset: 0x000057FC
		public static ZipFile Read(string fileName)
		{
			if (!true)
			{
			}
			ZipFile zipFile;
			return zipFile;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00007610 File Offset: 0x00005810
		public static ZipFile Read(string fileName, ReadOptions options)
		{
			while (fileName == null)
			{
			}
			int stringLength = fileName._stringLength;
			ZipFile zipFile;
			return zipFile;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00007628 File Offset: 0x00005828
		private static ZipFile Read(string fileName, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			/*
An exception occurred when decompiling this method (060001F9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zip.ZipFile Ionic.Zip.ZipFile::Read(System.String,System.IO.TextWriter,System.Text.Encoding,System.EventHandler`1<Ionic.Zip.ReadProgressEventArgs>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000C:
	brtrue(IL_0000, logicnot:bool(ldloc:string[exp:bool](fileName)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007644 File Offset: 0x00005844
		public static ZipFile Read(Stream zipStream)
		{
			if (!true)
			{
			}
			ZipFile zipFile;
			return zipFile;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007658 File Offset: 0x00005858
		public static ZipFile Read(Stream zipStream, ReadOptions options)
		{
			while (zipStream == null)
			{
			}
			object identity = zipStream._identity;
			Stream.ReadWriteTask activeReadWriteTask = zipStream._activeReadWriteTask;
			SemaphoreSlim asyncActiveSemaphore = zipStream._asyncActiveSemaphore;
			ZipFile zipFile;
			return zipFile;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007680 File Offset: 0x00005880
		private static ZipFile Read(Stream zipStream, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			/*
An exception occurred when decompiling this method (060001FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Ionic.Zip.ZipFile Ionic.Zip.ZipFile::Read(System.IO.Stream,System.IO.TextWriter,System.Text.Encoding,System.EventHandler`1<Ionic.Zip.ReadProgressEventArgs>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	brtrue(IL_0000, logicnot:bool(ldloc:Encoding[exp:bool](encoding)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00007698 File Offset: 0x00005898
		private static void ReadIntoInstance(ZipFile zf)
		{
			Stream readStream = zf.ReadStream;
			string name = zf._name;
			zf._readName = name;
			zf.OnReadStarted();
			uint num = ZipFile.ReadFirstFourBytes(readStream);
			int num2 = 19280;
			long num3 = SharedUtilities.FindSignature(readStream, num2);
			ZipFile.ReadIntoInstance_Orig(zf);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000773C File Offset: 0x0000593C
		private static void Zip64SeekToCentralDirectory(ZipFile zf)
		{
			Stream readStream = zf.ReadStream;
			long num;
			zf._OffsetOfCentralDirectory64 = num;
			int num2 = SharedUtilities.ReadInt(readStream);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00007760 File Offset: 0x00005960
		private static uint ReadFirstFourBytes(Stream s)
		{
			/*
An exception occurred when decompiling this method (060001FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Ionic.Zip.ZipFile::ReadFirstFourBytes(System.IO.Stream)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00007770 File Offset: 0x00005970
		private static void ReadCentralDirectory(ZipFile zf)
		{
			if (!true)
			{
			}
			ZipEntry zipEntry;
			if (zipEntry != null)
			{
				if (zf._StatusMessageTextWriter != null)
				{
					string fileNameInArchive = zipEntry._FileNameInArchive;
				}
				Dictionary<string, ZipEntry> entries = zf._entries;
				string fileNameInArchive2 = zipEntry._FileNameInArchive;
				bool inputUsesZip = zipEntry._InputUsesZip64;
				string fileNameInArchive3 = zipEntry._FileNameInArchive;
				return;
			}
			zf._zip64 = Zip64Option.Always;
			long locEndOfCDS = zf._locEndOfCDS;
			Stream readStream = zf.ReadStream;
			long locEndOfCDS2 = zf._locEndOfCDS;
			ZipFile.ReadCentralDirectoryFooter(zf);
			if (zf._StatusMessageTextWriter != null)
			{
				bool flag = string.IsNullOrEmpty(zf._Comment);
				TextWriter statusMessageTextWriter = zf._StatusMessageTextWriter;
				string comment = zf._Comment;
				if (zf._StatusMessageTextWriter != null)
				{
					Dictionary<string, ZipEntry> entries2 = zf._entries;
				}
			}
			zf.OnReadCompleted();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00007814 File Offset: 0x00005A14
		private static void ReadIntoInstance_Orig(ZipFile zf)
		{
			zf.OnReadStarted();
			if (zf._StatusMessageTextWriter != null && zf._name != null)
			{
				return;
			}
			ZipEntry zipEntry;
			if (zipEntry != null)
			{
				if (zf._StatusMessageTextWriter != null)
				{
					string fileNameInArchive = zipEntry._FileNameInArchive;
				}
				Dictionary<string, ZipEntry> entries = zf._entries;
				string fileNameInArchive2 = zipEntry._FileNameInArchive;
				return;
			}
			ZipEntry zipEntry2;
			if (zipEntry2 != null)
			{
				Dictionary<string, ZipEntry> entries2 = zf._entries;
				string fileNameInArchive3 = zipEntry2._FileNameInArchive;
				if (entries2 != null)
				{
					string comment = zipEntry2._Comment;
					if (zipEntry2._IsDirectory)
					{
					}
				}
				string fileNameInArchive4 = zipEntry2._FileNameInArchive;
				return;
			}
			long locEndOfCDS = zf._locEndOfCDS;
			Stream readStream = zf.ReadStream;
			long locEndOfCDS2 = zf._locEndOfCDS;
			ZipFile.ReadCentralDirectoryFooter(zf);
			if (zf._StatusMessageTextWriter != null)
			{
				bool flag = string.IsNullOrEmpty(zf._Comment);
				TextWriter statusMessageTextWriter = zf._StatusMessageTextWriter;
				string comment2 = zf._Comment;
			}
			zf.OnReadCompleted();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000078E8 File Offset: 0x00005AE8
		private static void ReadCentralDirectoryFooter(ZipFile zf)
		{
			Stream readStream = zf.ReadStream;
			int num = SharedUtilities.ReadSignature(readStream);
			ushort num2;
			zf._versionMadeBy = num2;
			ushort num3;
			zf._versionNeededToExtract = num3;
			uint num4;
			zf._diskNumberWithCd = num4;
			int num5 = SharedUtilities.ReadSignature(readStream);
			int num6 = SharedUtilities.ReadSignature(readStream);
			Stream readStream2 = zf.ReadStream;
			uint diskNumberWithCd = zf._diskNumberWithCd;
			if (diskNumberWithCd == 0U)
			{
				if (diskNumberWithCd == 0U)
				{
				}
				zf._diskNumberWithCd = diskNumberWithCd;
			}
			if (diskNumberWithCd == 0U)
			{
			}
			ZipFile.ReadZipFileComment(zf);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00007974 File Offset: 0x00005B74
		private static void ReadZipFileComment(ZipFile zf)
		{
			Stream readStream = zf.ReadStream;
			Stream readStream2 = zf.ReadStream;
			Encoding alternateEncoding = zf._alternateEncoding;
			zf._Comment = alternateEncoding;
			zf._contentsChanged = true;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000079A4 File Offset: 0x00005BA4
		public static bool IsZipFile(string fileName)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000079B8 File Offset: 0x00005BB8
		public static bool IsZipFile(string fileName, bool testExtract)
		{
			int num = 3;
			FileStream fileStream;
			bool flag = ZipFile.IsZipFile(fileStream, num != 0);
			long num2 = 0L;
			if (fileStream != null)
			{
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00007A18 File Offset: 0x00005C18
		public static bool IsZipFile(Stream stream, bool testExtract)
		{
			if (!true)
			{
			}
			ZipFile zipFile;
			IEnumerator<ZipEntry> enumerator = zipFile.GetEnumerator();
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
				long num2 = 0L;
				if (zipFile != null)
				{
				}
				if (num2 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007A80 File Offset: 0x00005C80
		private void DeleteFileWithRetry(string filename)
		{
			File.Delete(filename);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007AB0 File Offset: 0x00005CB0
		public void Save()
		{
			int num = 1;
			this.OnSaveStarted();
			if (this.WriteStream != null)
			{
				bool flag;
				if (num == 0 || flag)
				{
					if (flag)
					{
						if (flag)
						{
						}
						if (flag)
						{
							if (flag)
							{
								return;
							}
							if ("No save is necessary...." != null)
							{
							}
							return;
						}
					}
					else
					{
						ICollection<ZipEntry> collection;
						if (collection != null)
						{
							return;
						}
						return;
					}
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007C48 File Offset: 0x00005E48
		private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007C84 File Offset: 0x00005E84
		private void RemoveTempFile()
		{
			bool flag = File.Exists(this._temporaryFileName);
			string temporaryFileName = this._temporaryFileName;
			File.Delete(temporaryFileName);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007CB8 File Offset: 0x00005EB8
		private void CleanupAfterSaveOperation()
		{
			if (this._name != null)
			{
				if (this._writestream != null)
				{
				}
				if (this._temporaryFileName != null)
				{
					this.RemoveTempFile();
				}
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public void Save(string fileName)
		{
			string name = this._name;
			if (name != null)
			{
				this._readName = name;
				return;
			}
			this._name = fileName;
			bool flag = Directory.Exists(fileName);
			string name2 = this._name;
			this._contentsChanged = true;
			bool flag2 = File.Exists(name2);
			this._fileAlreadyExists = true;
			this.Save();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007D38 File Offset: 0x00005F38
		public void Save(Stream outputStream)
		{
			if (outputStream != null)
			{
				this._contentsChanged = true;
				this.Save();
				return;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007D58 File Offset: 0x00005F58
		public IEnumerator<ZipEntry> GetEnumerator()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007D68 File Offset: 0x00005F68
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (0600020F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Ionic.Zip.ZipFile::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Ionic.Zip.ZipEntry>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Ionic.Zip.ZipEntry>](ZipFile::GetEnumerator, ldloc:ZipFile(this)))
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

		// Token: 0x06000210 RID: 528 RVA: 0x00007D7C File Offset: 0x00005F7C
		[DispId(-4)]
		public IEnumerator GetNewEnum()
		{
			/*
An exception occurred when decompiling this method (06000210)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator Ionic.Zip.ZipFile::GetNewEnum()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Ionic.Zip.ZipEntry>(var_0_06, call:IEnumerator`1[exp:class [mscorlib]System.Collections.Generic.IEnumerator`1<class Ionic.Zip.ZipEntry>](ZipFile::GetEnumerator, ldloc:ZipFile(this)))
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

		// Token: 0x06000211 RID: 529 RVA: 0x00007D90 File Offset: 0x00005F90
		// Note: this type is marked as 'beforefieldinit'.
		static ZipFile()
		{
			Encoding encoding = Encoding.GetEncoding("IBM437");
		}

		// Token: 0x040000BD RID: 189
		private TextWriter _StatusMessageTextWriter;

		// Token: 0x040000BE RID: 190
		private bool _CaseSensitiveRetrieval;

		// Token: 0x040000BF RID: 191
		private Stream _readstream;

		// Token: 0x040000C0 RID: 192
		private Stream _writestream;

		// Token: 0x040000C1 RID: 193
		private ushort _versionMadeBy;

		// Token: 0x040000C2 RID: 194
		private ushort _versionNeededToExtract;

		// Token: 0x040000C3 RID: 195
		private uint _diskNumberWithCd;

		// Token: 0x040000C4 RID: 196
		private int _maxOutputSegmentSize;

		// Token: 0x040000C5 RID: 197
		private uint _numberOfSegmentsForMostRecentSave;

		// Token: 0x040000C6 RID: 198
		private ZipErrorAction _zipErrorAction;

		// Token: 0x040000C7 RID: 199
		private bool _disposed;

		// Token: 0x040000C8 RID: 200
		private Dictionary<string, ZipEntry> _entries;

		// Token: 0x040000C9 RID: 201
		private List<ZipEntry> _zipEntriesAsList;

		// Token: 0x040000CA RID: 202
		private string _name;

		// Token: 0x040000CB RID: 203
		private string _readName;

		// Token: 0x040000CC RID: 204
		private string _Comment;

		// Token: 0x040000CD RID: 205
		internal string _Password;

		// Token: 0x040000CE RID: 206
		private bool _emitNtfsTimes;

		// Token: 0x040000CF RID: 207
		private bool _emitUnixTimes;

		// Token: 0x040000D0 RID: 208
		private CompressionStrategy _Strategy;

		// Token: 0x040000D1 RID: 209
		private CompressionMethod _compressionMethod;

		// Token: 0x040000D2 RID: 210
		private bool _fileAlreadyExists;

		// Token: 0x040000D3 RID: 211
		private string _temporaryFileName;

		// Token: 0x040000D4 RID: 212
		private bool _contentsChanged;

		// Token: 0x040000D5 RID: 213
		private bool _hasBeenSaved;

		// Token: 0x040000D6 RID: 214
		private string _TempFileFolder;

		// Token: 0x040000D7 RID: 215
		private bool _ReadStreamIsOurs;

		// Token: 0x040000D8 RID: 216
		private object LOCK;

		// Token: 0x040000D9 RID: 217
		private bool _saveOperationCanceled;

		// Token: 0x040000DA RID: 218
		private bool _extractOperationCanceled;

		// Token: 0x040000DB RID: 219
		private bool _addOperationCanceled;

		// Token: 0x040000DC RID: 220
		private EncryptionAlgorithm _Encryption;

		// Token: 0x040000DD RID: 221
		private bool _JustSaved;

		// Token: 0x040000DE RID: 222
		private long _locEndOfCDS;

		// Token: 0x040000DF RID: 223
		private uint _OffsetOfCentralDirectory;

		// Token: 0x040000E0 RID: 224
		private long _OffsetOfCentralDirectory64;

		// Token: 0x040000E1 RID: 225
		private bool? _OutputUsesZip64;

		// Token: 0x040000E2 RID: 226
		internal bool _inExtractAll;

		// Token: 0x040000E3 RID: 227
		private Encoding _alternateEncoding;

		// Token: 0x040000E4 RID: 228
		private ZipOption _alternateEncodingUsage;

		// Token: 0x040000E5 RID: 229
		private static Encoding _defaultEncoding;

		// Token: 0x040000E6 RID: 230
		private int _BufferSize;

		// Token: 0x040000E7 RID: 231
		internal Zip64Option _zip64;

		// Token: 0x040000E8 RID: 232
		private bool _SavingSfx;

		// Token: 0x040000E9 RID: 233
		public static readonly int BufferSizeDefault;

		// Token: 0x040000EA RID: 234
		private EventHandler<SaveProgressEventArgs> SaveProgress;

		// Token: 0x040000EB RID: 235
		private EventHandler<ReadProgressEventArgs> ReadProgress;

		// Token: 0x040000EC RID: 236
		private long _lengthOfReadStream;

		// Token: 0x040000ED RID: 237
		private EventHandler<ExtractProgressEventArgs> ExtractProgress;

		// Token: 0x040000EE RID: 238
		private EventHandler<AddProgressEventArgs> AddProgress;

		// Token: 0x040000EF RID: 239
		private EventHandler<ZipErrorEventArgs> ZipError;

		// Token: 0x040000F0 RID: 240
		private bool <FullScan>k__BackingField;

		// Token: 0x040000F1 RID: 241
		private bool <SortEntriesBeforeSaving>k__BackingField;

		// Token: 0x040000F2 RID: 242
		private bool <AddDirectoryWillTraverseReparsePoints>k__BackingField;

		// Token: 0x040000F3 RID: 243
		private int <CodecBufferSize>k__BackingField;

		// Token: 0x040000F4 RID: 244
		private bool <FlattenFoldersOnExtract>k__BackingField;

		// Token: 0x040000F5 RID: 245
		private CompressionLevel <CompressionLevel>k__BackingField;

		// Token: 0x040000F6 RID: 246
		private ExtractExistingFileAction <ExtractExistingFile>k__BackingField;

		// Token: 0x040000F7 RID: 247
		private SetCompressionCallback <SetCompression>k__BackingField;

		// Token: 0x02000028 RID: 40
		private sealed class <>c__DisplayClass1
		{
			// Token: 0x06000212 RID: 530 RVA: 0x00007DA8 File Offset: 0x00005FA8
			public <>c__DisplayClass1()
			{
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00007DBC File Offset: 0x00005FBC
			public int <get_EntriesSorted>b__0(ZipEntry x, ZipEntry y)
			{
				string fileNameInArchive = x._FileNameInArchive;
				string fileNameInArchive2 = y._FileNameInArchive;
				StringComparison stringComparison = this.sc;
				return string.Compare(fileNameInArchive, fileNameInArchive2, stringComparison);
			}

			// Token: 0x040000F8 RID: 248
			public StringComparison sc;
		}

		// Token: 0x02000029 RID: 41
		private sealed class <GetEnumerator>d__3 : IEnumerator<ZipEntry>, IEnumerator, IDisposable
		{
			// Token: 0x06000214 RID: 532 RVA: 0x00007DE8 File Offset: 0x00005FE8
			private bool MoveNext()
			{
				if (this.<>1__state == 0)
				{
					Dictionary<string, ZipEntry> entries = this.<>4__this._entries;
					int num = 1;
					this.<>1__state = num;
					int num2 = 1;
					this.<>1__state = num2;
					Dictionary.ValueCollection values = entries._values;
					int num3 = 2;
					entries._entries = num3;
					entries._freeCount = values;
					entries._buckets = values;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000215 RID: 533 RVA: 0x00007E4C File Offset: 0x0000604C
			ZipEntry IEnumerator<ZipEntry>.Current
			{
				[DebuggerHidden]
				get
				{
					return this.<>2__current;
				}
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00002122 File Offset: 0x00000322
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000217 RID: 535 RVA: 0x00007E60 File Offset: 0x00006060
			void IDisposable.Dispose()
			{
				int num = this.<>1__state;
				this.<>m__Finally6();
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000218 RID: 536 RVA: 0x00007E7C File Offset: 0x0000607C
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					/*
An exception occurred when decompiling this method (06000218)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object Ionic.Zip.ZipFile/<GetEnumerator>d__3::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ZipEntry(var_0_06, ldfld:ZipEntry('<GetEnumerator>d__3'::<>2__current, ldloc:'<GetEnumerator>d__3'(this)))
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
			}

			// Token: 0x06000219 RID: 537 RVA: 0x00007E90 File Offset: 0x00006090
			[DebuggerHidden]
			public <GetEnumerator>d__3(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00007EAC File Offset: 0x000060AC
			private void <>m__Finally6()
			{
				int num = 1;
				this.<>1__state = num;
			}

			// Token: 0x040000F9 RID: 249
			private ZipEntry <>2__current;

			// Token: 0x040000FA RID: 250
			private int <>1__state;

			// Token: 0x040000FB RID: 251
			public ZipFile <>4__this;

			// Token: 0x040000FC RID: 252
			public ZipEntry <e>5__4;

			// Token: 0x040000FD RID: 253
			public Dictionary<string, ZipEntry>.ValueCollection.Enumerator <>7__wrap5;
		}
	}
}
