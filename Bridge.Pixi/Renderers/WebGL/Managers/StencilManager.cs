namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class StencilManager: WebGLManager
	{
		public extern StencilManager(WebGLRenderer renderer);

		public StencilMaskStack MaskStack
		{
			[Template("stencilMaskStack")] get;
			[Template("setMaskStack({0})")] set;
		}

		public extern void BindGraphics(Graphics graphics, object[] webGLData);

		/// <summary>
		/// Removes the last mask from the mask stack and doesn't return it.
		/// </summary>
		public extern void PopMask(object[] maskData);

		/// <summary>
		/// Removes the last mask from the stencil stack and doesn't return it.
		/// </summary>
		public extern void PopStencil(Graphics graphics, object[] webGLData);

		/// <summary>
		/// Applies the Mask and adds it to the current filter stack.
		/// </summary>
		public extern void PushMask(object[] webGLData);

		/// <summary>
		/// Applies the Mask and adds it to the current filter stack.
		/// </summary>
		public extern void PushStencil(Graphics graphics, object[] webGLData);
	}
}