using System;
using System.Diagnostics.Contracts;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace S1144;

/// <summary>
/// Provides a base implementation for JSON converters of structs that may or may not be nullable.
/// </summary>
/// <typeparam name="T">The type of structs to convert.</typeparam>
public class NullableStructJsonConverter<T> : JsonConverterFactory
	where T : struct
{
	private static readonly JsonSerializerOptions FallbackOptions = new(JsonSerializerDefaults.Web);
	private readonly Nullable nullable;
	private readonly NotNullable notNullable;

	/// <summary>
	/// Initializes a new instance of the <see cref="NullableStructJsonConverter{T}"/> class.
	/// </summary>
	protected NullableStructJsonConverter()
	{
		nullable = new(this);
		notNullable = new(this);
	}

	/// <inheritdoc />
	[Pure]
	public override bool CanConvert(Type typeToConvert)
		=> typeToConvert == typeof(T) || typeToConvert == typeof(T?);

	/// <inheritdoc />
	[Pure]
	public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options) => this switch
	{
		_ when typeToConvert == typeof(T) => notNullable,
		_ when typeToConvert == typeof(T?) => nullable,
		_ => null,
	};

	/// <inheritdoc cref="JsonConverter{T}.Read(ref Utf8JsonReader, Type, JsonSerializerOptions)" />
	[Pure]
	public virtual T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		=> ReadNullable(ref reader, typeToConvert, options) ?? default;

	/// <inheritdoc cref="Read(ref Utf8JsonReader, Type, JsonSerializerOptions)" />
	[Pure]
	public virtual T? ReadNullable(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		=> JsonSerializer.Deserialize<T?>(ref reader, FallbackOptions);

	/// <inheritdoc cref="JsonConverter{T}.Write(Utf8JsonWriter, T, JsonSerializerOptions)" />
	public virtual void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		=> JsonSerializer.Serialize(writer, value, FallbackOptions);

	/// <inheritdoc cref="Write(Utf8JsonWriter, T, JsonSerializerOptions)" />
	public virtual void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
		=> JsonSerializer.Serialize(writer, value, FallbackOptions);

	private sealed class NotNullable(NullableStructJsonConverter<T> converter) : JsonConverter<T>
	{
		/// <inheritdoc />
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			=> converter.Read(ref reader, typeToConvert, options);

		/// <inheritdoc />
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
			=> converter.Write(writer, value, FallbackOptions);
	}

	private sealed class Nullable(NullableStructJsonConverter<T> converter) : JsonConverter<T?>
	{
		/// <inheritdoc />
		public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			=> converter.ReadNullable(ref reader, typeToConvert, options);

		/// <inheritdoc />
		public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
			=> converter.Write(writer, value, FallbackOptions);
	}
}
