using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[IgnoreCast]
	[Namespace("PIXI")]
	public abstract class SystemRenderer
	{
		/// <summary>
		/// Whether the render view should be resized automatically.
		/// </summary>
		[FieldProperty]
		public bool AutoResize { get; set; }

		/// <summary>
		/// The background color to fill if not transparent.
		/// </summary>
		[FieldProperty]
		public int BackgroundColor { get; set; }

		// TODO
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		[FieldProperty]
		public object BlendModes { get; set; }

		/// <summary>
		/// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
		/// If the scene is NOT transparent Pixi will use a canvas sized FillRect operation every
		/// frame to set the canvas background color. If the scene is transparent Pixi will use ClearRect
		/// to clear the canvas every frame. Disable this by setting this to false.
		/// For example if your game has a canvas filling background image you often don't need this set.
		/// </summary>
		[FieldProperty]
		public bool ClearBeforeRender { get; set; }

		/// <summary>
		/// The height of the canvas view.
		/// </summary>
		[FieldProperty]
		public float Height { get; set; }

		/// <summary>
		/// Whether or not the contents of the stencil buffer is retained after rendering.
		/// </summary>
		[FieldProperty]
		public bool PreserveDrawingBuffer { get; set; }

		/// <summary>
		/// The resolution of the renderer.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// Whether the render view is transparent.
		/// </summary>
		[FieldProperty]
		public bool Transparent { get; set; }

		/// <summary>
		/// The type of the renderer.
		/// </summary>
		[FieldProperty]
		public RendererType Type { get; set; }

		/// <summary>
		/// The canvas element that everything is drawn to.
		/// </summary>
		[FieldProperty]
		public CanvasElement View { get; set; }

		/// <summary>
		/// The width of the canvas view.
		/// </summary>
		[FieldProperty]
		public float Width { get; set; }

		/// <summary>
		/// Removes everything from the renderer.
		/// </summary>
		/// <param name="removeView">Removes the Canvas element from the DOM.</param>
		public extern void Destroy(bool removeView = false);

		/// <summary>
		/// Renders the object to this view.
		/// </summary>
		/// <param name="object">The object to be rendered.</param>
		public extern void Render(DisplayObject @object);

		/// <summary>
		/// Resizes the canvas view to the specified width and height.
		/// </summary>
		/// <param name="width">The new width of the canvas view.</param>
		/// <param name="height">The new height of the canvas view.</param>
		public extern void Resize(float width, float height);
	}
}
