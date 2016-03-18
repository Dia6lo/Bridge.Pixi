namespace Bridge.Pixi.Mesh
{
	[External]
	[Namespace("PIXI.mesh")]
	public class Plane : Mesh
	{
		public extern Plane(Texture texture, float segmentsX = 10, float segmentsY = 10);

		public float SegmentsX { get; set; }

		public float SegmentsY { get; set; }
	}
}