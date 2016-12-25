namespace Bridge.Pixi.Extras
{
	/// <summary>
	/// A MovieClip is a simple way to display an animation depicted by a list of textures.
	/// </summary>
	[External]
	[Namespace("PIXI.extras")]
	public class MovieClip: Sprite
	{
		/// <summary>
		/// A short hand way of creating a MovieClip from an array of frame ids.
		/// </summary>
		/// <param name="frames">The array of frames ids the MovieClip will use as its texture frames.</param>
		public static extern MovieClip FromFrames(string[] frames);

		/// <summary>
		/// A short hand way of creating a movieclip from an array of image urls.
		/// </summary>
		/// <param name="images">The array of image urls the MovieClip will use as its texture frames.</param>
		public static extern MovieClip FromImages(string[] images);

		/// <param name="textures">
		/// An array of Texture or frame objects that make up the animation
		/// </param>
		public extern MovieClip(Union<Texture[], Frame[]> textures);

		/// <summary>
		/// The speed that the MovieClip will play at. Higher is faster, lower is slower.
		/// </summary>
		[FieldProperty]
		public float AnimationSpeed { get; set; }

		/// <summary>
		/// The MovieClips current frame index.
		/// </summary>
		[FieldProperty]
		public int CurrentFrame { get; }

		/// <summary>
		/// The MovieClips current frame index.
		/// </summary>
		[FieldProperty]
		public bool Loop { get; set; }

		/// <summary>
		/// Indicates if the MovieClip is currently playing.
		/// </summary>
		[FieldProperty]
		public bool Playing { get; }

		/// <summary>
		/// The array of textures used for this MovieClip.
		/// </summary>
		[FieldProperty]
		public Texture[] Textures { get; set; }

		/// <summary>
		/// TotalFrames is the total number of frames in the MovieClip.
		/// This is the same as number of textures assigned to the MovieClip.
		/// </summary>
		[FieldProperty]
		public int TotalFrames { get; }

		/// <summary>
		/// Goes to a specific frame and begins playing the MovieClip.
		/// </summary>
		/// <param name="frameNumber">Frame index to start at.</param>
		public extern void GotoAndPlay(int frameNumber);

		/// <summary>
		/// Stops the MovieClip and goes to a specific frame.
		/// </summary>
		/// <param name="frameNumber">Frame index to stop at.</param>
		public extern void GotoAndStop(int frameNumber);

		/// <summary>
		/// Plays the MovieClip.
		/// </summary>
		public extern void Play();

		/// <summary>
		/// Stops the MovieClip.
		/// </summary>
		public extern void Stop();
	}
}