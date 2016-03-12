namespace Bridge.Pixi
{
	/// <summary>
	/// A set of functions used to handle masking.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class CanvasMaskManager
	{
		/// <summary>
		/// Restores the current drawing context to the state it was before the mask was applied.
		/// </summary>
		/// <param name="renderer">The renderer context to use.</param>
		public extern void PopMask(SystemRenderer renderer);

		/// <summary>
		/// This method adds it to the current stack of masks.
		/// </summary>
		/// <param name="maskData">The mask data that will be pushed.</param>
		/// <param name="renderer">The renderer context to use.</param>
		public extern void PushMask(object maskData, SystemRenderer renderer);
	}
}
