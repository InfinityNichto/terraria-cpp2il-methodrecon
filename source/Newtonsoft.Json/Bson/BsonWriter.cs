using System;
using System.Globalization;
using System.IO;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200012C RID: 300
	[Preserve]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0001BD78 File Offset: 0x00019F78
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0001BD90 File Offset: 0x00019F90
		public DateTimeKind DateTimeKindHandling
		{
			get
			{
				return this._writer.<DateTimeKindHandling>k__BackingField;
			}
			set
			{
				this._writer.<DateTimeKindHandling>k__BackingField = value;
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001BDAC File Offset: 0x00019FAC
		public BsonWriter(Stream stream)
		{
			if (!true)
			{
			}
			base..ctor();
			ValidationUtils.ArgumentNotNull(stream, "stream");
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		public BsonWriter(BinaryWriter writer)
		{
			if (!true)
			{
			}
			base..ctor();
			ValidationUtils.ArgumentNotNull(writer, "writer");
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001BDF4 File Offset: 0x00019FF4
		public override void Flush()
		{
			BinaryWriter writer = this._writer._writer;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001BE10 File Offset: 0x0001A010
		protected override void WriteEnd(JsonToken token)
		{
			base.WriteEnd(token);
			BsonToken <Parent>k__BackingField = this._parent.<Parent>k__BackingField;
			this._parent = <Parent>k__BackingField;
			if (base.Top != 0)
			{
				return;
			}
			BsonBinaryWriter writer = this._writer;
			BsonToken root = this._root;
			int num = writer.CalculateSize(root);
			writer.WriteTokenInternal(root);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000212A File Offset: 0x0000032A
		public override void WriteComment(string text)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000212A File Offset: 0x0000032A
		public override void WriteStartConstructor(string name)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000212A File Offset: 0x0000032A
		public override void WriteRaw(string json)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0000212A File Offset: 0x0000032A
		public override void WriteRawValue(string json)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0001BE60 File Offset: 0x0001A060
		public override void WriteStartArray()
		{
			base.WriteStartArray();
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0001BE74 File Offset: 0x0001A074
		public override void WriteStartObject()
		{
			base.WriteStartObject();
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001BE88 File Offset: 0x0001A088
		public override void WritePropertyName(string name)
		{
			base.WritePropertyName(name);
			this._propertyName = name;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
		public override void Close()
		{
			base.Close();
			if (this.<CloseOutput>k__BackingField)
			{
				BsonBinaryWriter writer = this._writer;
				if (writer != null)
				{
					BinaryWriter writer2 = writer._writer;
					return;
				}
			}
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001BED4 File Offset: 0x0001A0D4
		private void AddParent(BsonToken container)
		{
			this.AddToken(container);
			this._parent = container;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		private void RemoveParent()
		{
			BsonToken <Parent>k__BackingField = this._parent.<Parent>k__BackingField;
			this._parent = <Parent>k__BackingField;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0001BF10 File Offset: 0x0001A110
		private void AddValue(object value, BsonType type)
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0001BF20 File Offset: 0x0001A120
		internal void AddToken(BsonToken token)
		{
			if (this._parent != null)
			{
				return;
			}
			this._root = token;
			this._parent = token;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001BF5C File Offset: 0x0001A15C
		public override void WriteValue(object value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0001BF70 File Offset: 0x0001A170
		public override void WriteNull()
		{
			base.WriteNull();
			long num = 0L;
			this.AddValue(num, BsonType.Null);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0001BF90 File Offset: 0x0001A190
		public override void WriteUndefined()
		{
			base.WriteUndefined();
			long num = 0L;
			this.AddValue(num, BsonType.Undefined);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public override void WriteValue(string value)
		{
			base.WriteValue(value);
			if (value != null)
			{
				return;
			}
			long num = 0L;
			this.AddValue(num, BsonType.Null);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		public override void WriteValue(int value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		public override void WriteValue(long value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001C010 File Offset: 0x0001A210
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0001C024 File Offset: 0x0001A224
		public override void WriteValue(float value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001C038 File Offset: 0x0001A238
		public override void WriteValue(double value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0001C04C File Offset: 0x0001A24C
		public override void WriteValue(bool value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0001C060 File Offset: 0x0001A260
		public override void WriteValue(short value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0001C074 File Offset: 0x0001A274
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0001C088 File Offset: 0x0001A288
		public override void WriteValue(char value)
		{
			base.WriteValue(value);
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0001C0A8 File Offset: 0x0001A2A8
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		public override void WriteValue(decimal value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		public override void WriteValue(DateTime value)
		{
			base.WriteValue(value);
			DateTimeZoneHandling dateTimeZoneHandling = this._dateTimeZoneHandling;
			if (!true)
			{
			}
			DateTime dateTime = DateTimeUtils.EnsureDateTime(value, dateTimeZoneHandling);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0001C108 File Offset: 0x0001A308
		public override void WriteValue(DateTimeOffset value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0001C11C File Offset: 0x0001A31C
		public override void WriteValue(byte[] value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0001C130 File Offset: 0x0001A330
		public override void WriteValue(Guid value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0001C144 File Offset: 0x0001A344
		public override void WriteValue(TimeSpan value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0001C158 File Offset: 0x0001A358
		public override void WriteValue(Uri value)
		{
			base.WriteValue(value);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001C16C File Offset: 0x0001A36C
		public void WriteObjectId(byte[] value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			base.UpdateScopeWithFinishedValue();
			base.AutoComplete(JsonToken.Undefined);
			this.AddValue(value, BsonType.Oid);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0001C19C File Offset: 0x0001A39C
		public void WriteRegex(string pattern, string options)
		{
			ValidationUtils.ArgumentNotNull(pattern, "pattern");
			base.UpdateScopeWithFinishedValue();
			base.AutoComplete(JsonToken.Undefined);
		}

		// Token: 0x0400046E RID: 1134
		private readonly BsonBinaryWriter _writer;

		// Token: 0x0400046F RID: 1135
		private BsonToken _root;

		// Token: 0x04000470 RID: 1136
		private BsonToken _parent;

		// Token: 0x04000471 RID: 1137
		private string _propertyName;
	}
}
