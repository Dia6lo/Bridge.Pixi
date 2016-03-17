namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class BlendModeManager: WebGLManager
	{
		public extern BlendModeManager(WebGLRenderer renderer);

		/// <summary>
		/// BlendMode from WebGL's point of view.
		/// </summary>
		public extern BlendMode BlendMode
		{
			[Template("currentBlendMode")] get;
			[Template("setBlendMode({0})")] set;
		}

	}
}