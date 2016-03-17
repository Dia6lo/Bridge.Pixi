namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class MaskManager: WebGLManager
	{
		public extern MaskManager(WebGLRenderer renderer);

		/// <summary>
		/// Removes the last mask from the mask stack and doesn't return it.
		/// </summary>
		public extern void PopMask(RenderTarget target, object[] maskData);

		/// <summary>
		/// Removes the last filter from the filter stack and doesn't return it.
		/// </summary>
		public extern void PopSpriteMask();

		/// <summary>
		/// Removes the last filter from the filter stack and doesn't return it.
		/// </summary>
		public extern void PopStencilMask(RenderTarget target, object[] maskData);

		/// <summary>
		/// Applies the Mask and adds it to the current filter stack.
		/// </summary>
		public extern void PushMask(Graphics graphics, object[] webGLData);

		/// <summary>
		/// Applies the Mask and adds it to the current filter stack.
		/// </summary>
		public extern void PushSpriteMask(RenderTarget target, object[] maskData);

		/// <summary>
		/// Applies the Mask and adds it to the current filter stack.
		/// </summary>
		public extern void PushStencilMask(RenderTarget target, object[] maskData);
	}
}