namespace Bridge.Pixi
{
	/// <summary>
	/// The WebGLRenderer draws the scene and all its content onto a WebGL enabled canvas.
	/// This renderer should be used for browsers that support WebGL.
	/// This Render works by automatically managing WebGLBatches, so no need for Sprite Batches or Sprite Clouds.
	/// Don't forget to add the view to your DOM or you will not see anything :)
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class WebGLRenderer: SystemRenderer
	{
		public extern WebGLRenderer(float width, float height, WebGLRendererOptions options = null);

		// TODO
		[FieldProperty]
		public object BlendModeManager { get; set; }

		// TODO
		public extern object Renderer
		{
			[Template("currentRenderer")] get;
			[Template("setObjectRenderer({0})")] set;
		}

		// TODO
		public extern object RenderTarget
		{
			[Template("currentRenderTarget")] get;
			[Template("setRenderTarget({0})")] set;
		}

		// TODO
		[FieldProperty]
		public object DrawCount { get; set; }

		// TODO
		[FieldProperty]
		public object FilterManager { get; set; }

		// TODO
		[FieldProperty]
		public object MaskManager { get; set; }

		// TODO
		[FieldProperty]
		public object ShaderManager { get; set; }

		// TODO
		[FieldProperty]
		public object StencilManager { get; set; }

		// TODO
		public extern void DestroyTexture(object texture);

		// TODO
		public extern void RenderDisplayObject(object displayObject, object renderTarget);

		// TODO
		public extern void UpdateTexture(object texture);
	}

	[External]
	[ObjectLiteral]
	public class WebGLRendererOptions : RendererOptions
	{
		/// <summary>
		/// Forces FXAA antialiasing to be used over native. FXAA is faster, but may not always look as great.
		/// </summary>
		[FieldProperty]
		[Name("forceFXAA")]
		public bool ForceFXAA { get; set; }
	}
}
