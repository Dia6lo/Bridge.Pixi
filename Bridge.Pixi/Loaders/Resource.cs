using System;
using Bridge.Pixi.External;
using Bridge.Html5;

namespace Bridge.Pixi.Loaders
{
	[External]
	[Namespace("PIXI.loaders")]
	public class Resource: EventEmitter
	{
		public extern Resource(string name = null, Union<string, string[]> url = null,
			LoaderOptions options = null);

		[FieldProperty]
		public string Name { get; set; }

		[FieldProperty]
		public Texture Texture { get; set; }

		[FieldProperty]
		public Texture[] Textures { get; set; }

		[FieldProperty]
		[Name("url")]
		public string URL { get; set; }

		[FieldProperty]
		public object Data { get; set; }

		[FieldProperty]
		public Union<bool, string> CrossOrigin { get; set; }

		[FieldProperty]
		public ResourceLoadType LoadType { get; set; }

		[FieldProperty]
		[Name("xhrType")]
		public string XMLHttpRequestType { get; set; }

		[FieldProperty]
		public Error Error { get; set; }

		[FieldProperty]
		[Name("xhr")]
		public XMLHttpRequest XMLHttpRequest { get; set; }

		[FieldProperty]
		[Name("SVGMetadataElement")]
		public object SVGMetadataElement { get; set; }

		public extern void Complete();

		public extern void Load(Action callback = null);
	}
}