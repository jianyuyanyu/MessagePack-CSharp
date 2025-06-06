﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

using MsgPack = global::MessagePack;

namespace MessagePack {
internal partial class GeneratedMessagePackResolver {

	internal sealed class HasFieldWithCustomFormatterAttributeFormatter : MsgPack::Formatters.IMessagePackFormatter<global::HasFieldWithCustomFormatterAttribute>
	{
		private readonly global::UnserializableRecordFormatter __CustomValueCustomFormatter__ = new global::UnserializableRecordFormatter();

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::HasFieldWithCustomFormatterAttribute value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			writer.WriteArrayHeader(1);
			this.__CustomValueCustomFormatter__.Serialize(ref writer, value.CustomValue, options);
		}

		public global::HasFieldWithCustomFormatterAttribute Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			var length = reader.ReadArrayHeader();
			var ____result = new global::HasFieldWithCustomFormatterAttribute();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.CustomValue = this.__CustomValueCustomFormatter__.Deserialize(ref reader, options);
						break;
					default:
						reader.Skip();
						break;
				}
			}

			reader.Depth--;
			return ____result;
		}
	}
}
}
