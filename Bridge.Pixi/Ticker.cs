using System;

namespace Bridge.Pixi
{
	/// <summary>
	/// A Ticker class that runs an update loop that other objects listen to.
	/// This class is composed around an EventEmitter object to add listeners
	/// meant for execution on the next requested animation frame.
	/// Animation frames are requested only when necessary,
	/// e.g. When the ticker is started and the emitter has listeners.
	/// </summary>
	[External]
	[Namespace("PIXI.ticker")]
	public class Ticker
	{
		public delegate void UpdateDelegate();
		public delegate void UpdateFromCurrentTimeDelegate(float time);

		/// <summary>
		/// Whether or not this ticker should invoke the method Start automatically when a listener is added.
		/// </summary>
		public bool AutoStart = false;

		/// <summary>
		/// Scalar time value from last frame to this frame.
		/// This value is capped by setting MinFPS and is scaled with Speed.
		/// Note: The cap may be exceeded by scaling.
		/// </summary>
		public float DeltaTime = 1f;

		// TODO: This property also returns DOMHighResTimeStamp.
		/// <summary>
		/// Time elapsed in milliseconds from last frame to this frame.
		/// Opposed to what the DeltaTime is based, this value is neither capped nor scaled.
		/// If the platform supports DOMHighResTimeStamp, this value will have a precision of 1 µs.
		/// </summary>
		[Name("elapsedMS")]
		public float Elapsed = 1f;

		/// <summary>
		/// The frames per second at which this ticker is running.
		/// The default is approximately 60 in most modern browsers.
		/// Note: This does not factor in the value of Speed, which is specific to scaling DeltaTime.
		/// </summary>
		[Name("FPS")]
		public readonly float FPS;

		// TODO: This property also returns DOMHighResTimeStamp.
		/// <summary>
		/// The last time Update was invoked.
		/// This value is also reset internally outside of invoking update,
		/// but only when a new animation frame is requested.
		/// If the platform supports DOMHighResTimeStamp, this value will have a precision of 1 µs.
		/// </summary>
		public readonly float LastTime;

		/// <summary>
		/// Manages the maximum amount of milliseconds allowed to elapse between invoking Update.
		/// This value is used to cap DeltaTime, but does not effect the measured value of FPS.
		/// When setting this property it is clamped to a value between 0 and Pixi.TargetFPMS * 1000.
		/// </summary>
		[Name("minFPS")]
		public float MinFPS = 10f;

		/// <summary>
		/// Factor of DeltaTime.
		/// </summary>
		public float Speed = 1f;

		/// <summary>
		/// Whether or not this ticker has been started.
		/// True if Start has been called.
		/// False if Stop has been called.
		/// While false, this value may change to true in the event of AutoStart being true and a listener is added.
		/// </summary>
		public bool Started;

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#on internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for updates.</param>
		/// <param name="context">The listener context.</param>
		/// <returns>This.</returns>
		public extern Ticker Add(UpdateDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#on internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for updates.</param>
		/// <param name="context">The listener context.</param>
		/// <returns>this</returns>
		public extern Ticker Add(UpdateFromCurrentTimeDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#once internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for one update.</param>
		/// <param name="context">The listener context.</param>
		/// <returns>this</returns>
		public extern Ticker AddOnce(UpdateDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#once internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for one update.</param>
		/// <param name="context">The listener context.</param>
		/// <returns>this</returns>
		public extern Ticker AddOnce(UpdateFromCurrentTimeDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#off internally for 'tick' event.
		/// It checks if the emitter has listeners for 'tick' event. If it does, then it cancels the animation frame.
		/// </summary>
		/// <param name="fn">The listener function to be removed.</param>
		/// <param name="context">The listener context to be removed.</param>
		/// <returns>this</returns>
		public extern Ticker Remove(UpdateDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#off internally for 'tick' event.
		/// It checks if the emitter has listeners for 'tick' event. If it does, then it cancels the animation frame.
		/// </summary>
		/// <param name="fn">The listener function to be removed.</param>
		/// <param name="context">The listener context to be removed.</param>
		/// <returns>this</returns>
		public extern Ticker Remove(UpdateFromCurrentTimeDelegate fn, Action context = null);

		/// <summary>
		/// Starts the ticker. If the ticker has listeners a new animation frame is requested at this point.
		/// </summary>
		public extern void Start();

		/// <summary>
		/// Stops the ticker. If the ticker has requested an animation frame it is canceled at this point.
		/// </summary>
		public extern void Stop();

		/// <summary>
		/// Triggers an update.
		/// An update entails setting the current Elapsed, the current DeltaTime, invoking all listeners with
		/// current DeltaTime, and then finally setting LastTime with the value of CurrentTime that was provided.
		/// This method will be called automatically by animation frame callbacks if the ticker
		/// instance has been started and listeners are added.
		/// </summary>
		public extern void Update();

		// TODO: This method also accepts DOMHighResTimeStamp.
		/// <summary>
		/// Triggers an update.
		/// An update entails setting the current Elapsed, the current DeltaTime, invoking all listeners with
		/// current DeltaTime, and then finally setting LastTime with the value of CurrentTime that was provided.
		/// This method will be called automatically by animation frame callbacks if the ticker
		/// instance has been started and listeners are added.
		/// </summary>
		/// <param name="currentTime">The current time of execution.</param>
		public extern void Update(float currentTime);
	}
}
