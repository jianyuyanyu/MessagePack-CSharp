﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

using MsgPack = global::MessagePack;

namespace MessagePack {
internal partial class GeneratedMessagePackResolver {
internal partial class TempProject {
	internal sealed class MyMessagePackObjectFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::TempProject.MyMessagePackObject>
	{
		// A
		private static global::System.ReadOnlySpan<byte> GetSpan_A() => new byte[1 + 1] { 161, 65 };
		// B
		private static global::System.ReadOnlySpan<byte> GetSpan_B() => new byte[1 + 1] { 161, 66 };

		public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::TempProject.MyMessagePackObject value, global::MessagePack.MessagePackSerializerOptions options)
		{
			if (value is null)
			{
				writer.WriteNil();
				return;
			}

			var formatterResolver = options.Resolver;
			writer.WriteMapHeader(2);
			writer.WriteRaw(GetSpan_A());
			writer.Write(value.A);
			writer.WriteRaw(GetSpan_B());
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.B, options);
		}

		public global::TempProject.MyMessagePackObject Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			var formatterResolver = options.Resolver;
			var length = reader.ReadMapHeader();
			var ____result = new global::TempProject.MyMessagePackObject();

			for (int i = 0; i < length; i++)
			{
				var stringKey = global::MessagePack.Internal.CodeGenHelpers.ReadStringSpan(ref reader);
				switch (stringKey.Length)
				{
					default:
					FAIL:
					  reader.Skip();
					  continue;
					case 1:
					    switch (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey))
					    {
    					    default: goto FAIL;
    					    case 65UL:
        					    reader.Skip();
        					    continue;
    					    case 66UL:
        					    reader.Skip();
        					    continue;
					    }

				}
			}

			reader.Depth--;
			return ____result;
		}
	}

}
}
}
