namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public abstract class WebGLManager
	{
		/// <param name="renderer">The renderer this manager works for.</param>
		public extern WebGLManager(WebGLRenderer renderer);

		/// <summary>
		/// The renderer this manager works for.
		/// </summary>
		[FieldProperty]
		public WebGLRenderer Renderer { get; set; }

		/// <summary>
		/// Generic destroy methods to be overridden by the subclass.
		/// </summary>
		public abstract void Destroy();

		/// <summary>
		/// Generic method called when there is a WebGL context change.
		/// </summary>
		public abstract void OnContextChange();
	}
}