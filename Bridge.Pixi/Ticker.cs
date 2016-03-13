using System;
using Bridge;

namespace Pixi
{
	/// <summary>
	/// A Ticker class that runs an update loop that other objects listen to.
	/// This class is composed around an EventEmitter object to add listeners meant for execution on the next requested animation frame.
	/// Animation frames are requested only when necessary, e.g. When the ticker is started and the emitter has listeners.
	/// </summary>
	[External]
	[Namespace("PIXI.ticker")]
	public class Ticker
	{
		public delegate void UpdateDelegate();
		public delegate void UpdateFromCurrentTimeDelegate(float time);

		/// <summary>
		/// Whether or not this ticker should invoke the method PIXI.ticker.Ticker#start automatically when a listener is added.
		/// </summary>
		public bool AutoStart;

		/// <summary>
		/// Scalar time value from last frame to this frame.
		/// This value is capped by setting PIXI.ticker.Ticker#minFPS and is scaled with PIXI.ticker.Ticker#speed.
		/// Note: The cap may be exceeded by scaling.
		/// </summary>
		public float DeltaTime = 1f;


		/// <summary>
		/// Time elapsed in milliseconds from last frame to this frame.
		/// Opposed to what the scalar PIXI.ticker.Ticker#deltaTime is based, this value is neither capped nor scaled.
		/// If the platform supports DOMHighResTimeStamp, this value will have a precision of 1 µs.
		/// </summary>
		public float ElapsedMS;

		/// <summary>
		/// The frames per second at which this ticker is running.
		/// The default is approximately 60 in most modern browsers.
		/// Note: This does not factor in the value of PIXI.ticker.Ticker#speed, which is specific to scaling PIXI.ticker.Ticker#deltaTime.
		/// </summary>
		[Name("FPS")]
		public float FPS;

		/// <summary>
		/// Manages the maximum amount of milliseconds allowed to elapse between invoking PIXI.ticker.Ticker#update.
		/// This value is used to cap PIXI.ticker.Ticker#deltaTime, but does not effect the measured value of PIXI.ticker.Ticker#FPS.
		/// When setting this property it is clamped to a value between 0 and PIXI.TARGET_FPMS * 1000.
		/// </summary>
		[Name("minFPS")]
		public float MinFPS = 10f;

		/// <summary>
		/// Factor of current PIXI.ticker.Ticker#deltaTime.
		/// </summary>
		public float Speed = 1f;

		/// <summary>
		/// Whether or not this ticker has been started.
		/// true if PIXI.ticker.Ticker#start has been called.
		/// false if PIXI.ticker.Ticker#stop has been called.
		/// While false, this value may change to true in the event of PIXI.ticker.Ticker#autoStart being true and a listener is added.
		/// </summary>
		public bool Started;

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#on internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for updates</param>
		/// <param name="context">The listener context</param>
		/// <returns>this</returns>
		public extern Ticker Add(UpdateDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#on internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for updates</param>
		/// <param name="context">The listener context</param>
		/// <returns>this</returns>
		public extern Ticker Add(UpdateFromCurrentTimeDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#once internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for one update</param>
		/// <param name="context">The listener context</param>
		/// <returns>this</returns>
		public extern Ticker AddOnce(UpdateDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#once internally for the internal 'tick' event.
		/// It checks if the emitter has listeners, and if so it requests a new animation frame at this point.
		/// </summary>
		/// <param name="fn">The listener function to be added for one update</param>
		/// <param name="context">The listener context</param>
		/// <returns>this</returns>
		public extern Ticker AddOnce(UpdateFromCurrentTimeDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#off internally for 'tick' event.
		/// It checks if the emitter has listeners for 'tick' event. If it does, then it cancels the animation frame.
		/// </summary>
		/// <param name="fn">The listener function to be removed</param>
		/// <param name="context">The listener context to be removed</param>
		/// <returns>this</returns>
		public extern Ticker Remove(UpdateDelegate fn, Action context = null);

		/// <summary>
		/// Calls module:eventemitter3.EventEmitter#off internally for 'tick' event.
		/// It checks if the emitter has listeners for 'tick' event. If it does, then it cancels the animation frame.
		/// </summary>
		/// <param name="fn">The listener function to be removed</param>
		/// <param name="context">The listener context to be removed</param>
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
	}
}
