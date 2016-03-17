namespace Bridge.Pixi.Extras
{
	/// <summary>
	/// A BitmapText object will create a line or multiple lines of text using bitmap font.
	/// To split a line you can use '\n', '\r' or '\r\n' in your string. You can generate the fnt files using:
	/// http://www.angelcode.com/products/bmfont/ for windows or http://www.bmglyph.com/ for mac.
	/// </summary>
	[External]
	[Namespace("PIXI.extras")]
	public class BitmapText : Container
	{
		public extern BitmapText(string text, BitmapTextStyle style);

		/// <summary>
		/// The alignment of the BitmapText object.
		/// </summary>
		public TextAlign Align { get; set; }

		/// <summary>
		/// The dirty state of this object.
		/// </summary>
		[FieldProperty]
		public bool Dirty { get; set; }

		/// <summary>
		/// The font descriptor of the BitmapText object.
		/// </summary>
		[FieldProperty]
		public Font Font { get; set; }

		/// <summary>
		/// The max line height. This is useful when trying to use the total height of the Text,
		/// i.e.: when trying to vertically align.
		/// </summary>
		[FieldProperty]
		public float MaxLineHeight { get; set; }

		/// <summary>
		/// The max width of this bitmap text in pixels. If the text provided is longer than the
		/// value provided, line breaks will be automatically inserted in the last whitespace.
		/// Disable by setting value to 0.
		/// </summary>
		[FieldProperty]
		public float MaxLineWidth { get; set; }

		/// <summary>
		/// The text of the BitmapText object.
		/// </summary>
		[FieldProperty]
		[Name("text")]
		public string Value { get; set; }

		/// <summary>
		/// The height of the overall text, different from FontSize,
		/// which is defined in the style object.
		/// </summary>
		[FieldProperty]
		public float TextHeight { get; }

		/// <summary>
		/// The width of the overall text, different from FontSize,
		/// which is defined in the style object.
		/// </summary>
		[FieldProperty]
		public float TextWidth { get; }
	}

	[External]
	[ObjectLiteral]
	public class BitmapTextStyle
	{
		/// <summary>
		/// The font descriptor for the object, can be passed as a string of form "24px FontName" or "FontName"
		/// or as an object with explicit name/size properties.
		/// </summary>
		[FieldProperty]
		public Any<string, Font> Font { get; set; }

		/// <summary>
		/// Alignment for multiline text, does not affect single line text.
		/// </summary>
		[FieldProperty]
		public TextAlign Align { get; set; }

		/// <summary>
		/// The tint color.
		/// </summary>
		[FieldProperty]
		public int Tint { get; set; }
	}
}