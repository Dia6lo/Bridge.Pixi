using System;

namespace Bridge.Pixi.External
{
	/// <summary>
	/// https://github.com/primus/eventemitter3
	/// </summary>
	public abstract class EventEmitter
	{
		public extern Action GetListeners(string @event);

		public extern bool Emit(string @event, params object[] args);

		public extern EventEmitter On(string @event, Delegate fn, object context = null);

		public extern EventEmitter Once(string @event, Delegate fn, object context = null);

		public extern EventEmitter RemoveListener(string @event, Delegate fn,
			object context = null, bool? once = null);

		public extern EventEmitter RemoveAllListeners(string @event);

		public extern EventEmitter Off(string @event, Delegate fn,
			object context = null, bool? once = null);

		public extern EventEmitter AddListener(string @event, Delegate fn,
			object context = null);
	}
}
