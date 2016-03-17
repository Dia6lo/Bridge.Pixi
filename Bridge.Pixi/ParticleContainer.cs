namespace Bridge.Pixi
{
	/// <summary>
	/// The ParticleContainer class is a really fast version of the Container built solely for speed,
	/// so use when you need a lot of sprites or particles. The tradeoff of the ParticleContainer
	/// is that advanced functionality will not work. ParticleContainer implements only the basic
	/// object transform (position, scale, rotation). Any other functionality like tinting, masking,
	/// etc will not work on sprites in this batch.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class ParticleContainer : Container
	{
		/// <param name="maxSize">The maximum number of particles that can be renderer by the container.</param>
		/// <param name="properties">The properties of children that should be uploaded to the gpu and applied.</param>
		/// <param name="batchSize">Number of particles per batch.</param>
		public extern ParticleContainer(int maxSize = 15000, ParticleContainerProperties properties = null,
			int batchSize = 15000);

		/// <summary>
		/// The blend mode to be applied to the sprite. Apply a value of Normal to reset the blend mode.
		/// </summary>
		[FieldProperty]
		public BlendMode BlendMode { get; set; }

		[FieldProperty]
		public bool InteractiveChildren { get; set; }

		[FieldProperty]
		public extern ParticleContainerProperties Properties { set; }

		/// <summary>
		/// Used for canvas renderering. If true then the elements will be positioned at the
		/// nearest pixel. This provides a nice speed boost.
		/// </summary>
		[FieldProperty]
		public bool RoundPixels { get; set; }
	}

	[External]
	[ObjectLiteral]
	public class ParticleContainerProperties
	{
		/// <summary>
		/// When true, scale be uploaded and applied.
		/// </summary>
		[FieldProperty]
		public bool Scale { get; set; }

		/// <summary>
		/// When true, position be uploaded and applied.
		/// </summary>
		[FieldProperty]
		public bool Position { get; set; }

		/// <summary>
		/// When true, rotation be uploaded and applied.
		/// </summary>
		[FieldProperty]
		public bool Rotation { get; set; }

		/// <summary>
		/// When true, uvs be uploaded and applied.
		/// </summary>
		[FieldProperty]
		public bool UVs { get; set; }

		/// <summary>
		/// When true, alpha be uploaded and applied.
		/// </summary>
		[FieldProperty]
		public bool Alpha { get; set; }
	}
}