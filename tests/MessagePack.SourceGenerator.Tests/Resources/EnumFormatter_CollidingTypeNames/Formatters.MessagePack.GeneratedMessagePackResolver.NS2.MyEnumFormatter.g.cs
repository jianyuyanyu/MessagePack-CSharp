﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

using MsgPack = global::MessagePack;

namespace MessagePack {
internal partial class GeneratedMessagePackResolver {
internal partial class NS2 {

	internal sealed class MyEnumFormatter : MsgPack::Formatters.IMessagePackFormatter<global::NS2.MyEnum>
	{
		public void Serialize(ref MsgPack::MessagePackWriter writer, global::NS2.MyEnum value, MsgPack::MessagePackSerializerOptions options)
		{
			writer.Write((int)value);
		}

		public global::NS2.MyEnum Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			return (global::NS2.MyEnum)reader.ReadInt32();
		}
	}

}
}
}
