namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class ShaderManager: WebGLManager
	{
		public extern ShaderManager(WebGLRenderer renderer);

		[FieldProperty]
		[Name("attribState")]
		public object[] AttributesState { get; set; }

		[FieldProperty]
		[Name("maxAttibs")]
		public int MaxAttributes { get; set; }

		[FieldProperty]
		public object[] Stack { get; set; }

		[FieldProperty]
		[Name("tempAttribState")]
		public object[] TemporaryAttributeState { get; set; }

		/// <summary>
		/// Destroys this object.
		/// </summary>
		public override extern void Destroy();

		/// <summary>
		/// Called when there is a WebGL context change.
		/// </summary>
		public override extern void OnContextChange();

		/// <summary>
		/// Takes the attributes given in parameters and uploads them.
		/// </summary>
		[Name("setAttribs")]
		public extern void SetAttributes(object[] attributes);

		/// <summary>
		/// Sets the current shader.
		/// </summary>
		/// <param name="shader">The shader to upload.</param>
		public extern bool SetShader(Shader shader);
	}
}