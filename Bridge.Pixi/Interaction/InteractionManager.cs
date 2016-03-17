using System;
using Bridge.Html5;

namespace Bridge.Pixi.Interaction
{
	/// <summary>
	/// The interaction manager deals with mouse and touch events. Any DisplayObject can be
	/// interactive if its interactive parameter is set to true.
	/// This manager also supports multitouch.
	/// </summary>
	[External]
	[Namespace("PIXI.interaction")]
	public class InteractionManager
	{
		public extern InteractionManager(SystemRenderer renderer, InteractionManagerOptions options);

		/// <summary>
		/// Should default browser actions automatically be prevented.
		/// </summary>
		[FieldProperty]
		public bool AutoPreventDefault { get; set; }

		/// <summary>
		/// The css style of the cursor that is being used.
		/// </summary>
		[FieldProperty]
		public FontStyle CurrentCursorStyle { get; set; }

		/// <summary>
		/// An event data object to handle all the event tracking/dispatching.
		/// </summary>
		[FieldProperty]
		public object EventData { get; set; }

		/// <summary>
		/// As this frequency increases the interaction events will be checked more often.
		/// </summary>
		[FieldProperty]
		public int InteractionFrequency { get; set; }

		[FieldProperty]
		public InteractionData[] InteractiveDataPool { get; set; }

		[FieldProperty]
		public int Last { get; set; }

		[FieldProperty]
		public InteractionData Mouse { get; set; }

		[FieldProperty]
		public Action OnMouseDown { get; set; }

		[FieldProperty]
		public Action OnMouseMove { get; set; }

		[FieldProperty]
		public Action OnMouseOut { get; set; }

		[FieldProperty]
		public Action OnMouseUp { get; set; }

		[FieldProperty]
		public Action OnTouchEnd { get; set; }

		[FieldProperty]
		public Action OnTouchMove { get; set; }

		[FieldProperty]
		public Action OnTouchStart { get; set; }

		/// <summary>
		/// The renderer this interaction manager works for.
		/// </summary>
		[FieldProperty]
		public SystemRenderer Renderer { get; set; }

		/// <summary>
		/// The current resolution.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// Destroys the interaction manager.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Maps x and y coords from a DOM object and maps them correctly to the pixi view.
		/// The resulting value is stored in the point.
		/// This takes into account the fact that the DOM element could be scaled and positioned
		/// anywhere on the screen.
		/// </summary>
		/// <param name="point">The point that the result will be stored in.</param>
		/// <param name="x">The x coord of the position to map.</param>
		/// <param name="y">The y coord of the position to map.</param>
		public extern void MapPositionToPoint(Point point, float x, float y);

		// TODO
		public extern bool ProcessInteractive(Point point, object displayObject, object func,
			bool hitTest, bool interactive);

		/// <summary>
		/// Updates the state of interactive objects.
		/// Invoked by a throttled ticker update from SharedTicker.
		/// </summary>
		public extern void Update(float deltaTime);
	}

	[External]
	[ObjectLiteral]
	public class InteractionManagerOptions
	{
		/// <summary>
		/// Should the manager automatically prevent default browser actions.
		/// </summary>
		[FieldProperty]
		public bool AutoPreventDefault { get; set; }

		/// <summary>
		/// Frequency increases the interaction events will be checked.
		/// </summary>
		[FieldProperty]
		public int InteractionFrequency { get; set; }
	}
}