namespace Bridge.Pixi.Loaders
{
	[External]
	[Name("PIXI.loaders.Resource.LOAD_TYPE")]
	[Enum(Emit.Name)]
	public enum ResourceLoadType
	{
		[Name("XHR")]
		XMLHttpRequest,

		[Name("IMAGE")]
		Image,

		[Name("AUDIO")]
		Audio,

		[Name("VIDEO")]
		Video
	}
}