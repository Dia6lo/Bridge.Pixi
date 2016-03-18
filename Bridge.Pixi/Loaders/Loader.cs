using System;
using System.Collections.Generic;
using Bridge.Pixi.External;

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
	}
}