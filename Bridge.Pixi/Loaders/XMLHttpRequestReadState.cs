namespace Bridge.Pixi.Loaders
{
	[External]
	[Name("PIXI.loaders.Resource.XHR_READ_STATE")]
	[Enum(Emit.Name)]
	public enum XMLHttpRequestReadState
	{
		[Name("UNSENT")]
		Unsent,

		[Name("OPENED")]
		Opened,

		[Name("HEADERS_RECEIVED")]
		HeadersReceived,

		[Name("LOADING")]
		Loading,

		[Name("DONE")]
		Done
	}
}