﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

using MsgPack = global::MessagePack;

namespace MessagePack {
internal partial class GeneratedMessagePackResolver {
internal partial class NS1 {

	internal sealed class MyTypeFormatter : MsgPack::Formatters.IMessagePackFormatter<global::NS1.MyType>
	{
		public void Serialize(ref MsgPack::MessagePackWriter writer, global::NS1.MyType value, MsgPack::MessagePackSerializerOptions options)
		{
			writer.Write((int)value);
		}

		public global::NS1.MyType Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			return (global::NS1.MyType)reader.ReadInt32();
		}
	}

}
}
}
