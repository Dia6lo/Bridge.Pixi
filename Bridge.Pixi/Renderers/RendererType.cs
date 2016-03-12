namespace Bridge.Pixi
{
	[External]
	[Name("PIXI.RENDERER_TYPE")]
	[Enum(Emit.Name)]
	public enum RendererType
	{
		[Name("UNKNOWN")]
		Unknown,

		[Name("WEBGL")]
		WebGl,

		[Name("CANVAS")]
		Canvas
	}
}
