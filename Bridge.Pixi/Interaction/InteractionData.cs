using Bridge.Html5;

namespace Bridge.Pixi.Interaction
{
	/// <summary>
	/// Holds all information related to an Interaction event.
	/// </summary>
	[External]
	[Namespace("PIXI.interaction")]
	public class InteractionData
	{
		public extern InteractionData();

		/// <summary>
		/// This point stores the global coordinates of where the touch/mouse event happened.
		/// </summary>
		[FieldProperty]
		public Point Global { get; set; }

		/// <summary>
		/// When passed to an event handler, this will be the original DOM Event that was captured.
		/// </summary>
		[FieldProperty]
		public Event OriginalEvent { get; set; }

		/// <summary>
		/// The target Sprite that was interacted with.
		/// </summary>
		[FieldProperty]
		public Sprite Target { get; set; }

		/// <summary>
		/// Maps two Rectangle to the quad.
		/// </summary>
		public extern void Map(Rectangle rect, Rectangle rect2);

		/// <summary>
		/// This will return the local coordinates of the specified DisplayObject for this InteractionData.
		/// </summary>
		/// <param name="displayObject">The DisplayObject that you would like the local coordinates of.</param>
		/// <param name="point">A Point object in which to store the value.</param>
		/// <param name="globalPos">A Point object containing your custom global coordinates.</param>
		/// <returns>
		/// A point containing the coordinates of the InteractionData position relative to the DisplayObject.
		/// </returns>
		public extern Point GetLocalPosition(DisplayObject displayObject, Point point = null, Point globalPos = null);
	}
}