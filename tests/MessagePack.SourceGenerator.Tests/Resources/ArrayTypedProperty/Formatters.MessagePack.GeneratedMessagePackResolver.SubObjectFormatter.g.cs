﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

using MsgPack = global::MessagePack;

namespace MessagePack {
internal partial class GeneratedMessagePackResolver {

	internal sealed class SubObjectFormatter : MsgPack::Formatters.IMessagePackFormatter<global::SubObject>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::SubObject value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			writer.WriteArrayHeader(0);
		}

		public global::SubObject Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			reader.Skip();
			return new global::SubObject();
		}
	}
}
}
