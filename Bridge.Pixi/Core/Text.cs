using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// A Text Object will create a line or multiple lines of text.
	/// To split a line you can use '\n' in your text string, or add a wordWrap property set to
	/// true and and WordWrapWidth property with a value in the style object.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Text : Sprite
	{
		/// <param name="text">The copy that you would like the text to display.</param>
		/// <param name="style"></param>
		public extern Text(string text = null, TextStyle style = null, Resolution? resolution = null);

		/// <summary>
		/// The canvas element that everything is drawn to.
		/// </summary>
		[FieldProperty]
		public HTMLCanvasElement Canvas { get; set; }

		/// <summary>
		/// The canvas 2d context that everything is drawn with.
		/// </summary>
		[FieldProperty]
		public CanvasRenderingContext2D Context { get; set; }

		/// <summary>
		/// The resolution of the canvas.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// Set the style of the text.
		/// </summary>
		[FieldProperty]
		public TextStyle Style { get; set; }

		/// <summary>
		/// Set the copy for the text object. To split a line you can use '\n'.
		/// </summary>
		[FieldProperty]
		[Name("name")]
		public string Value { get; set; }

		/// <summary>
		/// Destroys this text object.
		/// </summary>
		/// <param name="destroyBaseTexture">Whether to destroy the base texture as well.</param>
		public new extern void Destroy(bool destroyBaseTexture);
	}

	[External]
	[ObjectLiteral]
	public class TextStyle
	{
		/// <summary>
		/// The style and size of the font. Default 'bold 20px Arial'.
		/// </summary>
		[FieldProperty]
		public string Font { get; set; }

		/// <summary>
		/// A canvas fillstyle that will be used on the text e.g 'red', '#00FF00'.
		/// </summary>
		[FieldProperty]
		public Union<string, int> Fill { get; set; }

		/// <summary>
		/// Alignment for multiline text, does not affect single line text.
		/// </summary>
		[FieldProperty]
		public TextAlign Align { get; set; }

		/// <summary>
		/// A canvas fillstyle that will be used on the text stroke e.g 'blue', '#FCFF00'.
		/// </summary>
		[FieldProperty]
		public Union<string, int> Stroke { get; set; }

		/// <summary>
		/// A number that represents the thickness of the stroke. Default is 0 (no stroke).
		/// </summary>
		[FieldProperty]
		public int StrokeThickness { get; set; }

		/// <summary>
		/// Indicates if word wrap should be used.
		/// </summary>
		[FieldProperty]
		public bool WordWrap { get; set; }

		/// <summary>
		/// The width at which text will wrap, it needs wordWrap to be set to true.
		/// </summary>
		[FieldProperty]
		public float WordWrapWidth { get; set; }

		/// <summary>
		/// The line height, a number that represents the vertical space that a letter uses.
		/// </summary>
		[FieldProperty]
		public float LineHeight { get; set; }

		/// <summary>
		/// Set a drop shadow for the text.
		/// </summary>
		[FieldProperty]
		public bool DropShadow { get; set; }

		/// <summary>
		/// A fill style to be used on the dropshadow e.g 'red', '#00FF00'.
		/// </summary>
		[FieldProperty]
		public string DropShadowColor { get; set; }

		/// <summary>
		/// Set a angle of the drop shadow.
		/// </summary>
		[FieldProperty]
		public float DropShadowAngle { get; set; }

		/// <summary>
		/// Set a distance of the drop shadow.
		/// </summary>
		[FieldProperty]
		public float DropShadowDistance { get; set; }

		/// <summary>
		/// Occasionally some fonts are cropped on top or bottom.
		/// Adding some padding will prevent this from happening by adding padding
		/// to the top and bottom of text height.
		/// </summary>
		[FieldProperty]
		public int Padding { get; set; }

		/// <summary>
		/// The baseline of the text that is rendered.
		/// </summary>
		[FieldProperty]
		public CanvasTypes.CanvasTextBaselineAlign TextBaseLine { get; set; }

		/// <summary>
		/// The lineJoin property sets the type of corner created, it can resolve spiked text issues.
		/// Default is 'miter' (creates a sharp corner).
		/// </summary>
		[FieldProperty]
		public CanvasTypes.CanvasLineJoinType LineJoin { get; set; }

		/// <summary>
		/// The miter limit to use when using the 'miter' LineJoin mode.
		/// This can reduce or increase the spikiness of rendered text.
		/// </summary>
		[FieldProperty]
		public float MiterLimit { get; set; }
	}
}