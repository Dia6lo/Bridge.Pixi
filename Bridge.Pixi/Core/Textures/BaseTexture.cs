using System;
using Bridge.Html5;
using Bridge.Pixi.External;
using Bridge.Pixi.Interaction;

namespace Bridge.Pixi
{
	/// <summary>
	/// A texture stores the information that represents an image. All textures have a base texture.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class BaseTexture: EventEmitter
	{
		/// <summary>
		/// Helper function that creates a base texture from the given canvas element.
		/// </summary>
		/// <param name="canvas">The canvas element source of the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		public static extern BaseTexture FromCanvas(HTMLCanvasElement canvas, ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// Helper function that creates a base texture from the given image url.
		/// If the image is not in the base texture cache it will be created and loaded.
		/// </summary>
		/// <param name="imageUrl">The image url of the texture.</param>
		/// <param name="crossorigin">Should use anonymous CORS? Defaults to true if the URL is not a data-URI.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		public static extern BaseTexture FromImage(string imageUrl, bool crossorigin = false,
			ScaleMode scaleMode = ScaleMode.Default);

		/// <param name="source">The source object of the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		/// <param name="resolution">The resolution of the texture for devices with different pixel ratios.</param>
		public extern BaseTexture(Any<HTMLImageElement, HTMLCanvasElement> source,
			ScaleMode scaleMode = ScaleMode.Default, Resolution? resolution = null);

		/// <summary>
		/// Set to true once the base texture has successfully loaded.
		/// This is never true if the underlying source fails to load or has no texture data.
		/// </summary>
		[FieldProperty]
		public bool HasLoaded { get; }

		/// <summary>
		/// The height of the base texture set when the image has loaded.
		/// </summary>
		[FieldProperty]
		public float Height { get; }

		[FieldProperty]
		[Name("imageUrl")]
		public string ImageURL { get; set; }

		/// <summary>
		/// Set to true if the source is currently loading. If an Image source is loading
		/// the 'loaded' or 'error' event will be dispatched when the operation ends.
		/// An underlying source that is immediately-available bypasses loading entirely.
		/// </summary>
		[FieldProperty]
		public bool IsLoading { get; }

		/// <summary>
		/// Set this to true if a mipmap of this texture needs to be generated.
		/// This value needs to be set before the texture is used.
		/// Also the texture must be a power of two size to work.
		/// </summary>
		[FieldProperty]
		public bool Mipmap { get; set; }

		/// <summary>
		/// Controls if RGB channels should be pre-multiplied by Alpha (WebGL only).
		/// </summary>
		[FieldProperty]
		public bool PremultipliedAlpha { get; set; }

		/// <summary>
		/// Used to store the actual height of the source of this texture.
		/// </summary>
		[FieldProperty]
		public float RealHeight { get; }

		/// <summary>
		/// Used to store the actual width of the source of this texture.
		/// </summary>
		[FieldProperty]
		public float RealWidth { get; }

		/// <summary>
		/// The Resolution of the texture.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// The scale mode to apply when scaling this texture.
		/// </summary>
		[FieldProperty]
		public ScaleMode ScaleMode { get; set; }

		/// <summary>
		/// The image source that is used to create the texture.
		/// </summary>
		[FieldProperty]
		public Any<HTMLImageElement, HTMLCanvasElement> Source { get; }

		/// <summary>
		/// The width of the base texture set when the image has loaded.
		/// </summary>
		[FieldProperty]
		public float Width { get; }

		/// <summary>
		/// Destroys this base texture.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Frees the texture from WebGL memory without destroying this texture object.
		/// This means you can still use the texture later which will upload it to GPU memory again.
		/// </summary>
		public extern void Dispose();

		/// <summary>
		/// Load a source. If the source is not-immediately-available, such as an image that
		/// needs to be downloaded, then the 'loaded' or 'error' event will be dispatched in the
		/// future and hasLoaded will remain false after this call.
		/// </summary>
		/// <param name="source">The source object of the texture.</param>
		protected extern void LoadSource(Any<HTMLImageElement, HTMLCanvasElement> source);

		/// <summary>
		/// Updates the texture on all the WebDL renderers, this also assumes the src has changed.
		/// </summary>
		public extern void Update();

		/// <summary>
		/// Changes the source image of the texture. The original source must be an Image element.
		/// </summary>
		/// <param name="newSrc">The path of the image.</param>
		public extern void UpdateSourceImage(string newSrc);

		[Template("on('dispose', {action})")]
		public extern BaseTexture OnDispose(Action<InteractionEvent> action);

		[Template("on('error', {action})")]
		public extern BaseTexture OnError(Action<InteractionEvent> action);

		[Template("on('loaded', {action})")]
		public extern BaseTexture OnLoaded(Action<InteractionEvent> action);

		[Template("on('update', {action})")]
		public extern BaseTexture OnUpdate(Action<InteractionEvent> action);

		[Template("once('dispose', {action})")]
		public extern BaseTexture OnceDispose(Action<InteractionEvent> action);

		[Template("once('error', {action})")]
		public extern BaseTexture OnceError(Action<InteractionEvent> action);

		[Template("once('loaded', {action})")]
		public extern BaseTexture OnceLoaded(Action<InteractionEvent> action);

		[Template("once('update', {action})")]
		public extern BaseTexture OnceUpdate(Action<InteractionEvent> action);
	}
}