using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class RenderTarget
	{
		/// <param name="gl">The current WebGL drawing context.</param>
		/// <param name="width">The horizontal range of the filter.</param>
		/// <param name="height">The vertical range of the filter.</param>
		/// <param name="scaleMode">The current scale mode.</param>
		/// <param name="resolution">The current resolution.</param>
		/// <param name="root">Whether this object is the root element or not.</param>
		public extern RenderTarget(IWebGLRenderingContext gl, float width, float height,
			ScaleMode scaleMode, Resolution resolution, bool root);

		/// <summary>
		/// Stores filter data for the render target.
		/// </summary>
		[FieldProperty]
		public object[] FilterStack { get; set; }

		/// <summary>
		/// The frame.
		/// </summary>
		[FieldProperty]
		public Rectangle Frame { get; set; }

		// TODO: This is WebGLFramebuffer.
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		[FieldProperty]
		public object FrameBuffer { get; set; }

		/// <summary>
		/// The current WebGL drawing context.
		/// </summary>
		[FieldProperty]
		[Name("gl")]
		public IWebGLRenderingContext GL { get; set; }

		/// <summary>
		/// The projection matrix.
		/// </summary>
		[FieldProperty]
		public Matrix ProjectionMatrix { get; set; }

		/// <summary>
		/// The current resolution.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// Whether this object is the root element or not.
		/// </summary>
		[FieldProperty]
		public bool Root { get; set; }

		/// <summary>
		/// The scale mode.
		/// </summary>
		[FieldProperty]
		public ScaleMode ScaleMode { get; set; }

		/// <summary>
		/// The size of the object as a rectangle.
		/// </summary>
		[FieldProperty]
		public Rectangle Size { get; set; }

		// TODO.
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		[FieldProperty]
		public object StencilBuffer { get; set; }

		/// <summary>
		/// The data structure for the stencil masks.
		/// </summary>
		[FieldProperty]
		public StencilMaskStack StencilMaskStack { get; set; }

		/// <summary>
		/// The texture.
		/// </summary>
		[FieldProperty]
		public Texture Texture { get; set; }

		/// <summary>
		/// The object's transform.
		/// </summary>
		[FieldProperty]
		public Matrix Transform { get; set; }

		/// <summary>
		/// Binds the buffers and initializes the viewport.
		/// </summary>
		public extern void Activate();

		/// <summary>
		/// Binds the stencil buffer.
		/// </summary>
		public extern void AttachStencilBuffer();

		/// <summary>
		/// Updates the projection matrix based on a projection frame.
		/// </summary>
		public extern void CalculateProjection(Rectangle projectionFrame);

		/// <summary>
		/// Clears the filter texture.
		/// </summary>
		/// <param name="bind">Should we bind our framebuffer before clearing?</param>
		public extern void Clear(bool bind = false);

		/// <summary>
		/// Destroys the render target.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Resizes the texture to the specified width and height.
		/// </summary>
		/// <param name="width">The new width of the texture.</param>
		/// <param name="height">The new height of the texture.</param>
		public extern void Resize(float width, float height);
	}
}
