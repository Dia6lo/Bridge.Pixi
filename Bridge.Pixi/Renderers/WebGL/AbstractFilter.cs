namespace Bridge.Pixi
{
	/// <summary>
	/// This is the base class for creating a Pixi filter.
	/// Currently only WebGL supports filters.
	/// If you want to make a custom filter this should be your base class.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public abstract class AbstractFilter
	{
		/// <param name="vertexSrc">The vertex shader source.</param>
		/// <param name="fragmentSrc">The fragment shader source.</param>
		/// <param name="uniforms">An object containing the uniforms for this filter.</param>
		public extern AbstractFilter(Any<string, string[]> vertexSrc,
			Any<string, string[]> fragmentSrc, object uniforms);

		/// <summary>
		/// The extra padding that the filter might need.
		/// </summary>
		public float Padding;

		/// <summary>
		/// The uniforms as an object.
		/// </summary>
		public object Uniforms;

		/// <summary>
		/// Applies the filter.
		/// </summary>
		/// <param name="renderer">The renderer to retrieve the filter from.</param>
		/// <param name="clear">Whether or not we want to clear the outputTarget.</param>
		public extern void ApplyFilter(WebGLRenderer renderer, RenderTarget input,
			RenderTarget output, bool clear);

		/// <summary>
		/// Grabs a shader from the current renderer.
		/// </summary>
		/// <param name="renderer">The renderer to retrieve the shader from.</param>
		public extern void GetShader(WebGLRenderer renderer);

		/// <summary>
		/// Syncs a uniform between the class object and the shaders.
		/// </summary>
		public extern void SyncUniform(object uniform);
	}
}
