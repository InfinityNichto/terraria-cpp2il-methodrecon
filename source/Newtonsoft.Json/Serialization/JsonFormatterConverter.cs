using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000081 RID: 129
	[Preserve]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x0000C700 File Offset: 0x0000A900
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
			ValidationUtils.ArgumentNotNull(reader, "reader");
			ValidationUtils.ArgumentNotNull(contract, "contract");
			this._reader = reader;
			this._contract = contract;
			this._member = member;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000C740 File Offset: 0x0000A940
		private T GetTokenValue<T>(object A_1)
		{
			ValidationUtils.ArgumentNotNull(A_1, "value");
			if (A_1 != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			Type type;
			object obj = global::System.Convert.ChangeType(A_1, type, invariantCulture);
			throw new InvalidCastException();
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000C774 File Offset: 0x0000A974
		public object Convert(object value, Type type)
		{
			do
			{
				ValidationUtils.ArgumentNotNull(value, "value");
			}
			while (value == null);
			JsonSerializerInternalReader reader = this._reader;
			JsonISerializableContract contract = this._contract;
			JsonProperty member = this._member;
			object obj;
			return obj;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		public object Convert(object value, TypeCode typeCode)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			if (value != null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return global::System.Convert.ChangeType(value, typeCode, invariantCulture);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		public bool ToBoolean(object value)
		{
			return this.GetTokenValue<bool>(value);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000212A File Offset: 0x0000032A
		public byte ToByte(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000212A File Offset: 0x0000032A
		public char ToChar(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
		public DateTime ToDateTime(object value)
		{
			return 1;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		public decimal ToDecimal(object value)
		{
			return 1;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000212A File Offset: 0x0000032A
		public double ToDouble(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000212A File Offset: 0x0000032A
		public short ToInt16(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000212A File Offset: 0x0000032A
		public int ToInt32(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000212A File Offset: 0x0000032A
		public long ToInt64(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000212A File Offset: 0x0000032A
		public sbyte ToSByte(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000212A File Offset: 0x0000032A
		public float ToSingle(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000212A File Offset: 0x0000032A
		public string ToString(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000212A File Offset: 0x0000032A
		public ushort ToUInt16(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000212A File Offset: 0x0000032A
		public uint ToUInt32(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000212A File Offset: 0x0000032A
		public ulong ToUInt64(object value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400021A RID: 538
		private readonly JsonSerializerInternalReader _reader;

		// Token: 0x0400021B RID: 539
		private readonly JsonISerializableContract _contract;

		// Token: 0x0400021C RID: 540
		private readonly JsonProperty _member;
	}
}
