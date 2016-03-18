namespace Bridge.Pixi.Loaders
{
	[External]
	[Name("PIXI.loaders.Resource.XHR_RESPONSE_TYPE")]
	[Enum(Emit.Name)]
	public enum XMLHttpRequestResponseType
	{
		[Name("DEFAULT")]
		Default,

		[Name("BUFFER")]
		Buffer,

		[Name("BLOB")]
		Blob,

		[Name("DOCUMENT")]
		Document,

		[Name("JSON")]
		JSON,

		[Name("TEXT")]
		Text
	}
}