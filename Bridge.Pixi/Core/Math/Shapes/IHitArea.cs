namespace Bridge.Pixi
{
	[External]
	[IgnoreCast]
	public interface IHitArea
	{
		/// <summary>
		/// The type of the object, mainly used to avoid instanceof checks.
		/// </summary>
		[FieldProperty]
		ShapeType Type { get; set; }
	}
}