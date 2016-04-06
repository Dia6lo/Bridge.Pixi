namespace Bridge.Pixi.Interaction
{
	[External]
	[ObjectLiteral]
	public class InteractionEvent
	{
		[FieldProperty]
		public bool Stopped { get; set; }

		[FieldProperty]
		public DisplayObject Target { get; set; }

		[FieldProperty]
		public string Type { get; set; }

		[FieldProperty]
		public InteractionData Data { get; set; }
	}
}