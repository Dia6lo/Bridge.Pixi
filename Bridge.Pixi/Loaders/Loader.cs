using System;
using System.Collections.Generic;
using Bridge.Pixi.External;
using Bridge.Pixi.Interaction;

namespace Bridge.Pixi.Loaders
{
	/// <summary>
	/// The new loader, extends Resource Loader by Chad Engler : https://github.com/englercj/resource-loader.
	/// </summary>
	[External]
	[Namespace("PIXI.loaders")]
	public class Loader: EventEmitter
	{
		/// <param name="baseUrl">The base url for all resources loaded by this loader.</param>
		/// <param name="concurrency">The number of resources to load concurrently.</param>
		public extern Loader(string baseUrl = "", int concurrency = 10);

		[FieldProperty]
		public string BaseUrl { get; set; }

		[FieldProperty]
		public float Progress { get; set; }

		[FieldProperty]
		public bool Loading { get; set; }

		[FieldProperty]
		public Dictionary<string, Resource> Resources { get; set; }

		public extern Loader Add(string name, string url, LoaderOptions options = null,
			Action callback = null);

		public extern Loader Add(string url, LoaderOptions options = null, Action callback = null);

		public extern Loader Add(object obj, LoaderOptions options = null, Action callback = null);

		public extern Loader Before(Action fn);

		public extern Loader Pre(Action fn);

		public extern Loader After(Action fn);

		public extern Loader Use(Action fn);

		public extern void Reset();

		public extern Loader Load(Action<Loader, object> callback = null);

		[Template("on('complete', {action})")]
		public extern Loader OnComplete(Action<InteractionEvent> action);

		[Template("on('error', {action})")]
		public extern Loader OnError(Action<InteractionEvent> action);

		[Template("on('load', {action})")]
		public extern Loader OnLoad(Action<InteractionEvent> action);

		[Template("on('progress', {action})")]
		public extern Loader OnProgress(Action<InteractionEvent> action);

		[Template("on('start', {action})")]
		public extern Loader OnStart(Action<InteractionEvent> action);

		[Template("once('complete', {action})")]
		public extern Loader OnceComplete(Action<InteractionEvent> action);

		[Template("once('error', {action})")]
		public extern Loader OnceError(Action<InteractionEvent> action);

		[Template("once('load', {action})")]
		public extern Loader OnceLoad(Action<InteractionEvent> action);

		[Template("once('progress', {action})")]
		public extern Loader OnceProgress(Action<InteractionEvent> action);

		[Template("once('start', {action})")]
		public extern Loader OnceStart(Action<InteractionEvent> action);
	}
}