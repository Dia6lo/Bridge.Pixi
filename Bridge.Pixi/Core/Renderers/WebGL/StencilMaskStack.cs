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
		[FieldProperty]
		public int Count { get; set; }

		[FieldProperty]
		public bool Reverse { get; set; }

		/// <summary>
		/// The actual stack.
		/// </summary>
		[FieldProperty]
		public object[] StencilStack { get; set; }
	}
}