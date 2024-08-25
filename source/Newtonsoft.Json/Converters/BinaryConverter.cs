using System;
using System.Globalization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F6 RID: 246
	[Preserve]
	public class BinaryConverter : JsonConverter
	{
		// Token: 0x060009FE RID: 2558 RVA: 0x00018948 File Offset: 0x00016B48
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value != null)
			{
				byte[] byteArray = this.GetByteArray(value);
				return;
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00018964 File Offset: 0x00016B64
		private byte[] GetByteArray(object value)
		{
			bool flag = value.GetType().AssignableToTypeName("System.Data.Linq.Binary");
			Type type = value.GetType();
			this.EnsureReflectionObject(type);
			object value2 = this._reflectionObject.GetValue(value, "ToArray");
			if (value2 == null || value2 != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				Type type2 = value2.GetType();
				string text = "Unexpected value type when writing binary: {0}".FormatWith(invariantCulture, type2);
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000189D0 File Offset: 0x00016BD0
		private void EnsureReflectionObject(Type t)
		{
			if (this._reflectionObject == null)
			{
				Type type;
				if ((type != null && type == null) || ("ToArray" != null && "ToArray" == null))
				{
					throw new ArrayTypeMismatchException();
				}
				ReflectionObject reflectionObject;
				this._reflectionObject = reflectionObject;
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00018A08 File Offset: 0x00016C08
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			bool flag = ReflectionUtils.IsNullable(objectType);
			bool flag2 = ReflectionUtils.IsNullableType(objectType);
			Type underlyingType = Nullable.GetUnderlyingType(objectType);
			bool flag3 = underlyingType.AssignableToTypeName("System.Data.Linq.Binary");
			this.EnsureReflectionObject(underlyingType);
			ObjectConstructor<object> <Creator>k__BackingField = this._reflectionObject.<Creator>k__BackingField;
			byte[] array;
			if (array == null || array != null)
			{
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				return "Cannot convert null value to {0}.";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00018A88 File Offset: 0x00016C88
		private byte[] ReadByteArray(JsonReader reader)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return Convert.ToByte(reader, invariantCulture);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00018ABC File Offset: 0x00016CBC
		public override bool CanConvert(Type objectType)
		{
			return objectType.AssignableToTypeName("System.Data.Linq.Binary");
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00018AD4 File Offset: 0x00016CD4
		public BinaryConverter()
		{
		}

		// Token: 0x040003F2 RID: 1010
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		// Token: 0x040003F3 RID: 1011
		private const string BinaryToArrayName = "ToArray";

		// Token: 0x040003F4 RID: 1012
		private ReflectionObject _reflectionObject;
	}
}
