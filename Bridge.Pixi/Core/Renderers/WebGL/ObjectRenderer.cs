namespace Bridge.Pixi
{
	/// <summary>
	/// Base for a common object renderer that can be used as a system renderer plugin.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public abstract class ObjectRenderer: WebGLManager
	{
		public extern ObjectRenderer(WebGLRenderer renderer);

		public extern void Flush();

		public extern void Render(DisplayObject @object);

		public extern void Start();

		public extern void Stop();
	}
}