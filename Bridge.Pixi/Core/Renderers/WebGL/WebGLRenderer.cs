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
		public extern WebGLRenderer(float width = 800, float height = 600, RendererOptions options = null);

		/// <summary>
		/// Manages the BlendModes.
		/// </summary>
		[FieldProperty]
		public BlendModeManager BlendModeManager { get; set; }

		/// <summary>
		/// The currently active ObjectRenderer.
		/// </summary>
		public ObjectRenderer Renderer
		{
			[Template("currentRenderer")] get;
			[Template("setObjectRenderer({0})")] set;
		}

		/// <summary>
		/// Holds the current render target.
		/// </summary>
		public extern RenderTarget RenderTarget
		{
			[Template("currentRenderTarget")] get;
			[Template("setRenderTarget({0})")] set;
		}

		/// <summary>
		/// Counter for the number of draws made each frame
		/// </summary>
		[FieldProperty]
		public int DrawCount { get; set; }

		/// <summary>
		/// Manages the filters.
		/// </summary>
		[FieldProperty]
		public FilterManager FilterManager { get; set; }

		/// <summary>
		/// Manages the masks using the stencil buffer.
		/// </summary>
		[FieldProperty]
		public MaskManager MaskManager { get; set; }

		/// <summary>
		/// Deals with managing the shader programs and their attributes.
		/// </summary>
		[FieldProperty]
		public ShaderManager ShaderManager { get; set; }

		/// <summary>
		/// Manages the stencil buffer.
		/// </summary>
		[FieldProperty]
		public StencilManager StencilManager { get; set; }

		/// <summary>
		/// Deletes the texture from WebGL.
		/// </summary>
		/// <param name="texture">The texture to destroy.</param>
		public extern void DestroyTexture(Any<BaseTexture, Texture> texture);

		/// <summary>
		/// Renders a Display Object.
		/// </summary>
		/// <param name="displayObject">The DisplayObject to render.</param>
		/// <param name="renderTarget">The render target to use to render this display object.</param>
		public extern void RenderDisplayObject(DisplayObject displayObject, RenderTarget renderTarget);

		/// <summary>
		/// Updates and/or Creates a WebGL texture for the renderer's context.
		/// </summary>
		/// <param name="texture">The texture to update.</param>
		public extern void UpdateTexture(Any<BaseTexture, Texture> texture);
	}
}
