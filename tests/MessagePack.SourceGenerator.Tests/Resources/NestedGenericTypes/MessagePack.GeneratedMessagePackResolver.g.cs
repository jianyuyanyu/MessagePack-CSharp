﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

using MsgPack = global::MessagePack;

[assembly: MsgPack::Internal.GeneratedAssemblyMessagePackResolverAttribute(typeof(MessagePack.GeneratedMessagePackResolver), 3, 0)]

namespace MessagePack {

/// <summary>A MessagePack resolver that uses generated formatters for types in this assembly.</summary>
partial class GeneratedMessagePackResolver : MsgPack::IFormatterResolver
{
	/// <summary>An instance of this resolver that only returns formatters specifically generated for types in this assembly.</summary>
	public static readonly MsgPack::IFormatterResolver Instance = new GeneratedMessagePackResolver();

	private GeneratedMessagePackResolver()
	{
	}

	public MsgPack::Formatters.IMessagePackFormatter<T> GetFormatter<T>()
	{
		return FormatterCache<T>.Formatter;
	}

	private static class FormatterCache<T>
	{
		internal static readonly MsgPack::Formatters.IMessagePackFormatter<T> Formatter;

		static FormatterCache()
		{
			var f = GeneratedMessagePackResolverGetFormatterHelper.GetFormatter(typeof(T));
			if (f != null)
			{
				Formatter = (MsgPack::Formatters.IMessagePackFormatter<T>)f;
			}
		}
	}

	private static class GeneratedMessagePackResolverGetFormatterHelper
	{
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> closedTypeLookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(6)
		{
			{ typeof(global::TempProject.MyObject2[]), 0 },
			{ typeof(global::System.Collections.Generic.List<global::TempProject.MyObject2>), 1 },
			{ typeof(global::TempProject.MyGenericObject<global::TempProject.MyObject2>), 2 },
			{ typeof(global::TempProject.MyInnerGenericObject<global::TempProject.MyObject2>), 3 },
			{ typeof(global::TempProject.MyObject), 4 },
			{ typeof(global::TempProject.MyObject2), 5 },
		};
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> openTypeLookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(3)
		{
			{ typeof(global::TempProject.MyGenericObject<>), 0 },
			{ typeof(global::TempProject.MyInnerGenericObject<>), 1 },
			{ typeof(global::TempProject.Wrapper<>), 2 },
		};

		internal static object GetFormatter(global::System.Type t)
		{
			if (closedTypeLookup.TryGetValue(t, out int closedKey))
			{
				switch (closedKey)
				{
					case 0: return new MsgPack::Formatters.ArrayFormatter<global::TempProject.MyObject2>();
					case 1: return new MsgPack::Formatters.ListFormatter<global::TempProject.MyObject2>();
					case 2: return new global::MessagePack.GeneratedMessagePackResolver.TempProject.MyGenericObjectFormatter<global::TempProject.MyObject2>();
					case 3: return new global::MessagePack.GeneratedMessagePackResolver.TempProject.MyInnerGenericObjectFormatter<global::TempProject.MyObject2>();
					case 4: return new global::MessagePack.GeneratedMessagePackResolver.TempProject.MyObjectFormatter();
					case 5: return new global::MessagePack.GeneratedMessagePackResolver.TempProject.MyObject2Formatter();
					default: return null; // unreachable
				};
			}
			if (t.IsGenericType && openTypeLookup.TryGetValue(t.GetGenericTypeDefinition(), out int openKey))
			{
				switch (openKey)
				{
					case 0: return global::System.Activator.CreateInstance(typeof(global::MessagePack.GeneratedMessagePackResolver.TempProject.MyGenericObjectFormatter<>).MakeGenericType(t.GenericTypeArguments));
					case 1: return global::System.Activator.CreateInstance(typeof(global::MessagePack.GeneratedMessagePackResolver.TempProject.MyInnerGenericObjectFormatter<>).MakeGenericType(t.GenericTypeArguments));
					case 2: return global::System.Activator.CreateInstance(typeof(global::MessagePack.GeneratedMessagePackResolver.TempProject.WrapperFormatter<>).MakeGenericType(t.GenericTypeArguments));
					default: return null; // unreachable
				};
			}

			return null;
		}
	}
}

}