using System;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002F RID: 47
	[Preserve]
	public abstract class JsonConverter
	{
		// Token: 0x06000159 RID: 345
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		// Token: 0x0600015A RID: 346
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		// Token: 0x0600015B RID: 347
		public abstract bool CanConvert(Type objectType);

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00005950 File Offset: 0x00003B50
		public virtual bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00005960 File Offset: 0x00003B60
		public virtual bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005970 File Offset: 0x00003B70
		protected JsonConverter()
		{
		}
	}
}
