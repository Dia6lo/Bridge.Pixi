namespace Bridge.Pixi
{
	/// <summary>
	/// A Container represents a collection of display objects.
	/// It is the base class of all display objects that act as a container for other objects.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Container : DisplayObject
	{
		/// <summary>
		/// Retrieves the bounds of the Container as a rectangle.
		/// The bounds calculation takes all visible children into consideration.
		/// </summary>
		public override extern Rectangle Bounds { get; }

		/// <summary>
		/// The array of children of this container.
		/// </summary>
		[FieldProperty]
		public DisplayObject[] Children { get; }

		/// <summary>
		/// The height of the Container, setting this will actually modify the scale to achieve the value set.
		/// </summary>
		[FieldProperty]
		public float Height { get; }

		/// <summary>
		/// Retrieves the non-global local bounds of the Container as a rectangle.
		/// The calculation takes all visible children into consideration.
		/// </summary>
		public override extern Rectangle LocalBounds { get; }

		/// <summary>
		/// The width of the Container, setting this will actually modify the scale to achieve the value set.
		/// </summary>
		[FieldProperty]
		public float Width { get; }

		/// <summary>
		/// Adds a child to the container.
		/// </summary>
		/// <param name="child">The DisplayObject to add to the container</param>
		/// <returns>The child that was added.</returns>
		public extern DisplayObject AddChild(DisplayObject child);

		/// <summary>
		/// Adds a child to the container at a specified index. If the index is out of bounds an error will be thrown.
		/// </summary>
		/// <param name="child">The child to add</param>
		/// <param name="index">The index to place the child in</param>
		/// <returns>The child that was added.</returns>
		public extern DisplayObject AddChildAt(DisplayObject child, int index);

		/// <summary>
		/// Destroys the container
		/// </summary>
		/// <param name="destroyChildren">
		/// if set to true, all the children will have their destroy method called as well
		/// </param>
		public extern void Destroy(bool destroyChildren = false);

		/// <summary>
		/// Returns the child at the specified index.
		/// </summary>
		/// <param name="index">The index to get the child at.</param>
		/// <returns>The child at the given index, if any.</returns>
		public extern DisplayObject GetChildAt(int index);

		/// <summary>
		/// Returns the index position of a child DisplayObject instance.
		/// </summary>
		/// <param name="child">The DisplayObject instance to identify.</param>
		/// <returns>The index position of the child display object to identify.</returns>
		public extern DisplayObject GetChildIndex(DisplayObject child);

		/// <summary>
		/// Removes a child from the container.
		/// </summary>
		/// <param name="child">The DisplayObject to remove.</param>
		/// <returns>The child that was removed.</returns>
		public extern DisplayObject RemoveChild(DisplayObject child);

		/// <summary>
		/// Removes a child from the specified index position.
		/// </summary>
		/// <param name="index">The index to get the child from.</param>
		/// <returns>The child that was removed.</returns>
		public extern DisplayObject RemoveChildAt(int index);

		/// <summary>
		/// Removes all children from this container that begin from certain index.
		/// </summary>
		/// <param name="beginIndex">The beginning position.</param>
		/// <returns>Children that were removed.</returns>
		public extern DisplayObject[] RemoveChildren(int beginIndex = 0);

		/// <summary>
		/// Removes all children from this container that are within the begin and end indexes.
		/// </summary>
		/// <param name="beginIndex">The beginning position.</param>
		/// <param name="endIndex">The ending position.</param>
		/// <returns>Children that were removed.</returns>
		public extern DisplayObject[] RemoveChildren(int beginIndex, int endIndex);

		/// <summary>
		/// Renders the object using the Canvas renderer.
		/// </summary>
		/// <param name="renderer">The renderer.</param>
		public extern void RenderCanvas(CanvasRenderer renderer);

		/// <summary>
		/// Renders the object using the WebGL renderer.
		/// </summary>
		/// <param name="renderer">The renderer.</param>
		public extern void RenderWebGL(WebGLRenderer renderer);

		/// <summary>
		/// Changes the position of an existing child in the display object container.
		/// </summary>
		/// <param name="child">
		/// The child DisplayObject instance for which you want to change the index number.
		/// </param>
		/// <param name="index">The resulting index number for the child display object.</param>
		public extern void SetChildIndex(DisplayObject child, int index);

		/// <summary>
		/// Swaps the position of 2 Display Objects within this container.
		/// </summary>
		public extern void SwapChildren(DisplayObject child, DisplayObject child2);
	}
}