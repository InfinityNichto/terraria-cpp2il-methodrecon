using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002D RID: 45
	[Preserve]
	[Serializable]
	public class JsonWriterException : JsonException
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00005764 File Offset: 0x00003964
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00005778 File Offset: 0x00003978
		public string Path
		{
			[CompilerGenerated]
			get
			{
				return this.<Path>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Path>k__BackingField = value;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000578C File Offset: 0x0000398C
		public JsonWriterException()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000057A0 File Offset: 0x000039A0
		public JsonWriterException(string message)
			: base(message)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000057B4 File Offset: 0x000039B4
		public JsonWriterException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000057CC File Offset: 0x000039CC
		public JsonWriterException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000057E4 File Offset: 0x000039E4
		internal JsonWriterException(string message, Exception innerException, string path)
			: base(message, innerException)
		{
			this.Path = path;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005800 File Offset: 0x00003A00
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			JsonWriterException ex2;
			return ex2;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005810 File Offset: 0x00003A10
		internal static JsonWriterException Create(string path, string message, Exception ex)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x040000C5 RID: 197
		[CompilerGenerated]
		private string <Path>k__BackingField;
	}
}
