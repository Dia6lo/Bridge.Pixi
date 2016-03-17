namespace Bridge.Pixi
{
	/// <summary>
	/// This shader is used to draw simple primitive shapes for Graphics.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class PrimitiveShader : Shader
	{
		public extern PrimitiveShader(ShaderManager shaderManager);
	}
}