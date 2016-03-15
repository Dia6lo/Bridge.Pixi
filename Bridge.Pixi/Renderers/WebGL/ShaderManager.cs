namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class ShaderManager: WebGLManager
	{
		public extern ShaderManager(WebGLRenderer renderer);

		[Name("attribState")]
		public object[] AttributesState;

		[Name("maxAttibs")]
		public int MaxAttributes;

		public object[] Stack;

		[Name("tempAttribState")]
		public object[] TemporaryAttributeState;

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
		public extern void SetShader(Shader shader);
	}
}