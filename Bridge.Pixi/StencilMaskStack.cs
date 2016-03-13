namespace Bridge.Pixi
{
	/// <summary>
	/// Generic Mask Stack data structure.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class StencilMaskStack
	{
		/// <param name="renderer">The renderer this manager works for.</param>
		public extern StencilMaskStack(WebGLRenderer renderer);

		/// <summary>
		/// Internal count.
		/// </summary>
		public int Count;

		/// <summary>
		/// TODO @alvin
		/// </summary>
		public bool Reverse;

		/// <summary>
		/// The actual stack.
		/// </summary>
		public object[] StencilStack;
	}
}