namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class TextureShader : Shader
	{
		/// <summary>
		/// The default vertex shader source.
		/// </summary>
		[FieldProperty]
		[Name("defaultVertexSrc")]
		public static string DefaultVertexSource { get; }

		/// <summary>
		/// The default fragment shader source.
		/// </summary>
		[FieldProperty]
		[Name("defaultFragmentSrc")]
		public static string DefaultFragmentSource { get; }

		/// <param name="shaderManager">The webgl shader manager this shader works for.</param>
		/// <param name="vertexSrc">The source of the vertex shader.</param>
		/// <param name="fragmentSrc">The source of the fragment shader.</param>
		/// <param name="uniforms">Uniforms for this shader.</param>
		/// <param name="attributes">Attributes for this shader.</param>
		public extern TextureShader(ShaderManager shaderManager, string vertexSrc = null,
			string fragmentSrc = null, object uniforms = null, object attributes = null);
	}
}