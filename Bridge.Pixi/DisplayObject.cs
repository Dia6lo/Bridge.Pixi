namespace Bridge.Pixi
{
	// TODO: This class inherits EventEmitter.
	/// <summary>
	/// The base class for all objects that are rendered on the screen.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public abstract class DisplayObject
	{
		/// <summary>
		/// The opacity of the object.
		/// </summary>
		public float Alpha;

		/// <summary>
		/// Retrieves the bounds of the DisplayObject as a rectangle object
		/// </summary>
		public virtual extern Rectangle Bounds { get; }

		/// <summary>
		/// Set this to true if you want this display object to be cached as a bitmap.
		/// This basically takes a snap shot of the display object as it is at that moment.
		/// It can provide a performance benefit for complex static DisplayObjects.
		/// To remove simply set this property to 'null'.
		/// </summary>
		public bool? CacheAsBitmap;

		/// <summary>
		/// The area the filter is applied to. This is used as more of an optimisation rather than
		/// figuring out the dimensions of the DisplayObject each frame you can set this rectangle.
		/// </summary>
		public Rectangle FilterArea;

		/// <summary>
		/// Sets the filters for the DisplayObject.
		/// IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
		/// To remove filters simply set this property to null.
		/// </summary>
		public AbstractFilter[] Filters;

		/// <summary>
		/// Retrieves the local bounds of the DisplayObject as a rectangle object.
		/// </summary>
		/// <returns></returns>
		public virtual extern Rectangle LocalBounds { get; }

		// TODO.
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		public object Mask;

		/// <summary>
		/// The display object container that contains this display object.
		/// </summary>
		public extern Container Parent
		{
			[Template("parent")] get;
			[Template("setParent({0})")] set;
		}

		/// <summary>
		/// The pivot point of the displayObject that it rotates around.
		/// </summary>
		public Point Pivot;

		/// <summary>
		/// The coordinate of the object relative to the local coordinates of the parent.
		/// </summary>
		public Point Position;

		/// <summary>
		/// Can this object be rendered, if false the object will not be drawn but the
		/// UpdateTransform methods will still be called.
		/// </summary>
		public bool Renderable;

		/// <summary>
		/// The rotation of the object in radians.
		/// </summary>
		public float Rotation;

		/// <summary>
		/// The scale factor of the object.
		/// </summary>
		public Point Scale;

		/// <summary>
		/// The visibility of the object.
		/// If false the object will not be drawn, and the updateTransform function will not be called.
		/// </summary>
		public bool Visible;

		/// <summary>
		/// The multiplied alpha of the DisplayObject.
		/// </summary>
		public readonly float WorldAlpha;

		/// <summary>
		/// Current transform of the object based on world (parent) factors.
		/// </summary>
		public readonly Matrix WorldTransform;

		/// <summary>
		/// Indicates if the sprite is globally visible.
		/// </summary>
		public readonly bool WorldVisible;

		/// <summary>
		/// The position of the displayObject on the x axis relative to the local coordinates of the parent.
		/// </summary>
		public float X;

		/// <summary>
		/// The position of the displayObject on the y axis relative to the local coordinates of the parent.
		/// </summary>
		public float Y;

		/// <summary>
		/// Base destroy method for generic display objects.
		/// </summary>
		public extern void Display();

		/// <summary>
		/// Useful function that returns a texture of the display object that can then be used to create sprites.
		/// This can be quite useful if your displayObject is static/complicated and needs to be reused multiple times.
		/// </summary>
		/// <param name="renderer">The renderer used to generate the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture being generated.</param>
		/// <param name="resolution">The resolution of the texture being generated.</param>
		/// <returns></returns>
		public extern Texture GenerateTexture(SystemRenderer renderer, ScaleMode scaleMode, Resolution resolution);

		/// <summary>
		/// Calculates the global position of the display object.
		/// </summary>
		/// <param name="position">The world origin to calculate from.</param>
		/// <returns>A point object representing the position of this object.</returns>
		public extern Point ToGlobal(Point position);

		/// <summary>
		/// Calculates the local position of the display object relative to another point.
		/// </summary>
		/// <param name="position">The world origin to calculate from.</param>
		/// <param name="from">The DisplayObject to calculate the global position from.</param>
		/// <returns>A point object representing the position of this object.</returns>
		public extern Point ToLocal(Point position, DisplayObject from = null);
	}
}
