namespace Bridge.Pixi.Loaders
{
	[External]
	[ObjectLiteral]
	public class LoaderOptions
	{
		[FieldProperty]
		public Union<bool, string> CrossOrigin { get; set; }

		[FieldProperty]
		public ResourceLoadType LoadType { get; set; }

		[FieldProperty]
		[Name("xhrType")]
		public string XMLHttpRequestType { get; set; }

		[FieldProperty]
		public object MetaData { get; set; }
	}
}