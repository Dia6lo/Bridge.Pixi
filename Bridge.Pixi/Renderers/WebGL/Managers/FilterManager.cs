namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class FilterManager: WebGLManager
	{
		public extern FilterManager(WebGLRenderer renderer);

		[FieldProperty]
		public Rectangle CurrentFrame { get; set; }

		public object[] FilterStack
		{
			[Template("filterStack")] get;
			[Template("setFilterStack({0})")] set;
		}

		[FieldProperty]
		public RenderTarget[] TexturePool { get; set; }

		[FieldProperty]
		public Rectangle TextureSize { get; set; }

		/// <summary>
		/// Grabs an render target from the internal pool.
		/// </summary>
		/// <param name="clear">Whether or not we need to clear the RenderTarget.</param>
		public extern RenderTarget GetRenderTarget(bool clear = false);

		/// <summary>
		/// Removes the last filter from the filter stack and returns it.
		/// </summary>
		public extern object PopFilter();

		/// <summary>
		/// Applies the filter and adds it to the current filter stack.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="filters">The filters that will be pushed to the current filter stack.</param>
		public extern void PushFilter(DisplayObject target, AbstractFilter[] filters);
	}
}