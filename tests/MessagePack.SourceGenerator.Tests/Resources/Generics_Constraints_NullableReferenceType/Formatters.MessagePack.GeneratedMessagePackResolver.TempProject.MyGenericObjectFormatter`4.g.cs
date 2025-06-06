﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

using MsgPack = global::MessagePack;

namespace MessagePack {
internal partial class GeneratedMessagePackResolver {
internal partial class TempProject {

	internal sealed class MyGenericObjectFormatter<T1, T2, T3, T4> : MsgPack::Formatters.IMessagePackFormatter<global::TempProject.MyGenericObject<T1, T2, T3, T4>>
		where T1 : global::TempProject.MyClass?
		where T2 : global::TempProject.MyClass
		where T3 : global::TempProject.MyGenericClass<global::TempProject.MyGenericClass<global::TempProject.MyClass?>?>?
		where T4 : global::TempProject.MyClass, global::TempProject.IMyInterface?
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::TempProject.MyGenericObject<T1, T2, T3, T4> value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			writer.WriteArrayHeader(1);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<T1>(formatterResolver).Serialize(ref writer, value.Content, options);
		}

		public global::TempProject.MyGenericObject<T1, T2, T3, T4> Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			var length = reader.ReadArrayHeader();
			var ____result = new global::TempProject.MyGenericObject<T1, T2, T3, T4>();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.Content = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<T1>(formatterResolver).Deserialize(ref reader, options);
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
}
