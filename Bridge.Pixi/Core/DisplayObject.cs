using System;
using Bridge.Pixi.External;
using Bridge.Pixi.Interaction;

namespace Bridge.Pixi
{
	/// <summary>
	/// The base class for all objects that are rendered on the screen.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public abstract class DisplayObject: EventEmitter
	{
		/// <summary>
		/// The opacity of the object.
		/// </summary>
		[FieldProperty]
		public float Alpha { get; set; }

		/// <summary>
		/// Set this to true if you want this display object to be cached as a bitmap.
		/// This basically takes a snap shot of the display object as it is at that moment.
		/// It can provide a performance benefit for complex static DisplayObjects.
		/// To remove simply set this property to 'null'.
		/// </summary>
		[FieldProperty]
		public bool? CacheAsBitmap { get; set; }

		/// <summary>
		/// The area the filter is applied to. This is used as more of an optimisation rather than
		/// figuring out the dimensions of the DisplayObject each frame you can set this rectangle.
		/// </summary>
		[FieldProperty]
		public Rectangle FilterArea { get; set; }

		/// <summary>
		/// Sets the filters for the DisplayObject.
		/// IMPORTANT: This is a WebGL only feature and will be ignored by the canvas renderer.
		/// To remove filters simply set this property to null.
		/// </summary>
		[FieldProperty]
		public AbstractFilter[] Filters { get; set; }

		/// <summary>
		/// Defines whether this object reacts to On and Once events.
		/// Note: set this to true BEFORE calling On and Once methods.
		/// </summary>
		[FieldProperty]
		public bool Interactive { get; set; }

		/// <summary>
		/// Retrieves the local bounds of the DisplayObject as a rectangle object.
		/// </summary>
		/// <returns></returns>
		public virtual extern Rectangle LocalBounds { get; }

		/// <summary>
		/// Sets a mask for the DisplayObject. A mask is an object that limits the visibility of
		/// an object to the shape of the mask applied to it.
		/// In Pixi a regular mask must be a Graphics or a Sprite object.
		/// This allows for much faster masking in canvas as it utilises shape clipping.
		/// To remove a mask, set this property to null.
		/// </summary>
		[FieldProperty]
		public Any<Graphics, Sprite> Mask { get; set; }

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
		[FieldProperty]
		public Point Pivot { get; set; }

		/// <summary>
		/// The coordinate of the object relative to the local coordinates of the parent.
		/// </summary>
		[FieldProperty]
		public Point Position { get; set; }

		/// <summary>
		/// Can this object be rendered, if false the object will not be drawn but the
		/// UpdateTransform methods will still be called.
		/// </summary>
		[FieldProperty]
		public bool Renderable { get; set; }

		/// <summary>
		/// The rotation of the object in radians.
		/// </summary>
		[FieldProperty]
		public float Rotation { get; set; }

		/// <summary>
		/// The scale factor of the object.
		/// </summary>
		[FieldProperty]
		public Point Scale { get; set; }

		/// <summary>
		/// The visibility of the object.
		/// If false the object will not be drawn, and the updateTransform function will not be called.
		/// </summary>
		[FieldProperty]
		public bool Visible { get; set; }

		/// <summary>
		/// The multiplied alpha of the DisplayObject.
		/// </summary>
		[FieldProperty]
		public float WorldAlpha { get; }

		/// <summary>
		/// Current transform of the object based on world (parent) factors.
		/// </summary>
		[FieldProperty]
		public Matrix WorldTransform { get; }

		/// <summary>
		/// Indicates if the sprite is globally visible.
		/// </summary>
		[FieldProperty]
		public bool WorldVisible { get; }

		/// <summary>
		/// The position of the displayObject on the x axis relative to the local coordinates of the parent.
		/// </summary>
		[FieldProperty]
		public float X { get; set; }

		/// <summary>
		/// The position of the displayObject on the y axis relative to the local coordinates of the parent.
		/// </summary>
		[FieldProperty]
		public float Y { get; set; }

		/// <summary>
		/// Base destroy method for generic display objects.
		/// </summary>
		public extern void Display();

		/// <summary>
		/// Base destroy method for generic display objects.
		/// </summary>
		public virtual extern void Destroy();

		/// <summary>
		/// Useful function that returns a texture of the display object that can then be used to create sprites.
		/// This can be quite useful if your displayObject is static/complicated and needs to be reused multiple times.
		/// </summary>
		/// <param name="renderer">The renderer used to generate the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture being generated.</param>
		/// <param name="resolution">The resolution of the texture being generated.</param>
		/// <returns></returns>
		public virtual extern Texture GenerateTexture(IRenderer renderer,
			ScaleMode scaleMode = ScaleMode.Default, Resolution? resolution = null);

		/// <summary>
		/// Retrieves the bounds of the DisplayObject as a rectangle object.
		/// </summary>
		/// <param name="matrix">The transformation matrix of the sprite.</param>
		/// <returns>The framing rectangle.</returns>
		public extern Rectangle GetBounds(Matrix matrix = null);

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

		[Template("on('click', {action})")]
		public extern DisplayObject OnClick(Action<InteractionEvent> action);

		[Template("on('mousedown', {action})")]
		public extern DisplayObject OnMouseDown(Action<InteractionEvent> action);

		[Template("on('mouseout', {action})")]
		public extern DisplayObject OnMouseOut(Action<InteractionEvent> action);

		[Template("on('mouseover', {action})")]
		public extern DisplayObject OnMouseOver(Action<InteractionEvent> action);

		[Template("on('mouseup', {action})")]
		public extern DisplayObject OnMouseUp(Action<InteractionEvent> action);

		[Template("on('mouseclick', {action})")]
		public extern DisplayObject OnMouseClick(Action<InteractionEvent> action);

		[Template("on('mouseupoutside', {action})")]
		public extern DisplayObject OnMouseUpOutside(Action<InteractionEvent> action);

		[Template("on('rightclick', {action})")]
		public extern DisplayObject OnRightClick(Action<InteractionEvent> action);

		[Template("on('rightdown', {action})")]
		public extern DisplayObject OnRightDown(Action<InteractionEvent> action);

		[Template("on('rightup', {action})")]
		public extern DisplayObject OnRightUp(Action<InteractionEvent> action);

		[Template("on('rightupoutside', {action})")]
		public extern DisplayObject OnRightUpOutside(Action<InteractionEvent> action);

		[Template("on('tap', {action})")]
		public extern DisplayObject OnTap(Action<InteractionEvent> action);

		[Template("on('touchend', {action})")]
		public extern DisplayObject OnTouchEnd(Action<InteractionEvent> action);

		[Template("on('touchendoutside', {action})")]
		public extern DisplayObject OnTouchEndOutside(Action<InteractionEvent> action);

		[Template("on('touchstart', {action})")]
		public extern DisplayObject OnTouchStart(Action<InteractionEvent> action);

		[Template("on('touchmove', {action})")]
		public extern DisplayObject OnTouchMove(Action<InteractionEvent> action);

		[Template("once('click', {action})")]
		public extern DisplayObject OnceClick(Action<InteractionEvent> action);

		[Template("once('mousedown', {action})")]
		public extern DisplayObject OnceMouseDown(Action<InteractionEvent> action);

		[Template("once('mouseout', {action})")]
		public extern DisplayObject OnceMouseOut(Action<InteractionEvent> action);

		[Template("once('mouseover', {action})")]
		public extern DisplayObject OnceMouseOver(Action<InteractionEvent> action);

		[Template("once('mouseup', {action})")]
		public extern DisplayObject OnceMouseUp(Action<InteractionEvent> action);

		[Template("once('mouseclick', {action})")]
		public extern DisplayObject OnceMouseClick(Action<InteractionEvent> action);

		[Template("once('mouseupoutside', {action})")]
		public extern DisplayObject OnceMouseUpOutside(Action<InteractionEvent> action);

		[Template("once('rightclick', {action})")]
		public extern DisplayObject OnceRightClick(Action<InteractionEvent> action);

		[Template("once('rightdown', {action})")]
		public extern DisplayObject OnceRightDown(Action<InteractionEvent> action);

		[Template("once('rightup', {action})")]
		public extern DisplayObject OnceRightUp(Action<InteractionEvent> action);

		[Template("once('rightupoutside', {action})")]
		public extern DisplayObject OnceRightUpOutside(Action<InteractionEvent> action);

		[Template("once('tap', {action})")]
		public extern DisplayObject OnceTap(Action<InteractionEvent> action);

		[Template("once('touchend', {action})")]
		public extern DisplayObject OnceTouchEnd(Action<InteractionEvent> action);

		[Template("once('touchendoutside', {action})")]
		public extern DisplayObject OnceTouchEndOutside(Action<InteractionEvent> action);

		[Template("once('touchstart', {action})")]
		public extern DisplayObject OnceTouchStart(Action<InteractionEvent> action);

		[Template("once('touchmove', {action})")]
		public extern DisplayObject OnceTouchMove(Action<InteractionEvent> action);
	}
}
