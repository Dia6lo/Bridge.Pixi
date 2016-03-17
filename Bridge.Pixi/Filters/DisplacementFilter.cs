namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The DisplacementFilter class uses the pixel values from the specified texture (called the
	/// displacement map) to perform a displacement of an object. You can use this filter to apply
	/// all manor of crazy warping effects Currently the r property of the texture is used to offset
	/// the x and the g property of the texture is used to offset the y.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class DisplacementFilter : AbstractFilter
	{
		/// <param name="sprite">
		/// The sprite used for the displacement map. (make sure its added to the scene!)
		/// </param>
		public extern DisplacementFilter(Sprite sprite);

		/// <summary>
		/// The texture used for the displacement map. Must be power of 2 sized texture.
		/// </summary>
		[FieldProperty]
		public Texture Map { get; set; }
	}
}