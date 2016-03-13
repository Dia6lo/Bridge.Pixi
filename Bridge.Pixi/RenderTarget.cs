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
		public object[] FilterStack;

		/// <summary>
		/// The frame.
		/// </summary>
		public Rectangle Frame;

		// TODO.
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		public object FrameBuffer;

		/// <summary>
		/// The current WebGL drawing context.
		/// </summary>
		[Name("gl")]
		public IWebGLRenderingContext GL;

		/// <summary>
		/// The projection matrix.
		/// </summary>
		public Matrix ProjectionMatrix;

		/// <summary>
		/// The current resolution.
		/// </summary>
		public Resolution Resolution;

		/// <summary>
		/// Whether this object is the root element or not.
		/// </summary>
		public bool Root;

		/// <summary>
		/// The scale mode.
		/// </summary>
		public ScaleMode ScaleMode;

		/// <summary>
		/// The size of the object as a rectangle.
		/// </summary>
		public Rectangle Size;

		// TODO.
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		public object StencilBuffer;

		/// <summary>
		/// The data structure for the stencil masks.
		/// </summary>
		public StencilMaskStack StencilMaskStack;

		/// <summary>
		/// The texture.
		/// </summary>
		public Texture Texture;

		/// <summary>
		/// The object's transform.
		/// </summary>
		public Matrix Transform;

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
