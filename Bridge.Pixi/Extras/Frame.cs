namespace Bridge.Pixi.Extras
{
	[External]
	[ObjectLiteral]
	public class Frame
	{
		/// <summary>
		/// The Texture of the frame.
		/// </summary>
		[FieldProperty]
		public Texture Texture { get; set; }

		/// <summary>
		/// The duration of the frame in ms.
		/// </summary>
		[FieldProperty]
		public float Time { get; set; }
	}
}