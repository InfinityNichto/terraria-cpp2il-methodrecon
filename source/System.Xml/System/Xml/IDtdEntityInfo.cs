using System;

namespace System.Xml
{
	// Token: 0x0200001A RID: 26
	internal interface IDtdEntityInfo
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000082 RID: 130
		string Name { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000083 RID: 131
		bool IsExternal { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000084 RID: 132
		bool IsDeclaredInExternal { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000085 RID: 133
		bool IsUnparsedEntity { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000086 RID: 134
		bool IsParameterEntity { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000087 RID: 135
		string BaseUriString { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000088 RID: 136
		string DeclaredUriString { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000089 RID: 137
		string SystemId { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008A RID: 138
		string PublicId { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139
		string Text { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008C RID: 140
		int LineNumber { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008D RID: 141
		int LinePosition { get; }
	}
}
