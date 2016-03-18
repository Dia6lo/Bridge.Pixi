using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// A RenderTexture is a special texture that allows any Pixi display object to be rendered to it.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class RenderTexture : Texture
	{
		public extern RenderTexture(IRenderer renderer, float width = 100, float height = 100,
			ScaleMode scaleMode = ScaleMode.Default, Resolution? resolution = null);

		/// <summary>
		/// The renderer this RenderTexture uses.
		/// A RenderTexture can only belong to one renderer at the moment if its webGL.
		/// </summary>
		[FieldProperty]
		public IRenderer Renderer { get; set; }

		/// <summary>
		/// The Resolution of the texture.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// Clears the RenderTexture.
		/// </summary>
		public extern void Clear();

		/// <summary>
		/// Will return a a base64 encoded string of this texture.
		/// It works by calling Canvas and then running toDataURL on that.
		/// </summary>
		public extern string GetBase64();

		/// <summary>
		/// Creates a Canvas element, renders this RenderTexture to it and then returns it.
		/// </summary>
		public extern CanvasElement GetCanvas();

		/// <summary>
		/// Will return a HTML Image of the texture.
		/// </summary>
		public extern ImageElement GetImage();

		/// <summary>
		/// Will return a one-dimensional array containing the pixel data of a pixel within
		/// the texture in RGBA order, with integer values between 0 and 255 (included).
		/// </summary>
		public extern Uint8ClampedArray GetPixel(float x, float y);

		/// <summary>
		/// Will return a one-dimensional array containing the pixel data of the entire texture
		/// in RGBA order, with integer values between 0 and 255 (included).
		/// </summary>
		public extern Uint8ClampedArray GetPixels();

		/// <summary>
		/// Draw/render the given DisplayObject onto the texture.
		/// </summary>
		/// <param name="displayObject">The display object to render this texture on.</param>
		/// <param name="matrix">Optional matrix to apply to the display object before rendering.</param>
		/// <param name="clear">If true the texture will be cleared before the DisplayObject is drawn.</param>
		/// <param name="updateTransform">
		/// If true the DisplayObject's WorldTransform/WorldAlpha and all children transformations
		/// will be restored. Not restoring this information will be a little faster.
		/// </param>
		public extern void Render(DisplayObject displayObject, Matrix matrix = null,
			bool clear = false, bool updateTransform = true);

		/// <summary>
		/// Resizes the RenderTexture.
		/// </summary>
		/// <param name="width">The width to resize to.</param>
		/// <param name="height">The height to resize to.</param>
		/// <param name="updateBase">Should the BaseTexture.Width and height values be resized as well?</param>
		public extern void Resize(float width, float height, bool updateBase = false);
	}
}