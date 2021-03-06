﻿using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// Base shader class for Pixi managed shaders.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public abstract class Shader
	{
		/// <param name="shaderManager">The webgl shader manager this shader works for.</param>
		/// <param name="vertexSrc">The source of the vertex shader.</param>
		/// <param name="fragmentSrc">The source of the fragment shader.</param>
		/// <param name="uniforms">Uniforms for this shader.</param>
		/// <param name="attributes">Attributes for this shader.</param>
		public extern Shader(ShaderManager shaderManager, string vertexSrc = null, string fragmentSrc = null,
			object uniforms = null, object attributes = null);

		/// <summary>
		/// The fragment shader as an array of strings.
		/// </summary>
		[FieldProperty]
		[Name("fragmentSrc")]
		public string FragmentSource { get; set; }

		/// <summary>
		/// The current WebGL drawing context.
		/// </summary>
		[FieldProperty]
		[Name("gl")]
		public IWebGLRenderingContext GL { get; }

		// TODO: It's WebGLProgram.
		/// <summary>
		/// The WebGL program.
		/// </summary>
		[FieldProperty]
		public object Program { get; }

		/// <summary>
		/// A unique id.
		/// </summary>
		[FieldProperty]
		public int UID { get; }

		/// <summary>
		/// The vertex shader as an array of strings.
		/// </summary>
		[FieldProperty]
		[Name("vertexSrc")]
		public string VertexSource { get; set; }

		/// <summary>
		/// Destroys the shader.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Initializes a Sampler2D uniform (which may only be available later on after
		/// InitUniforms once the texture has loaded).
		/// </summary>
		public extern void InitSampler2D(object uniform);

		/// <summary>
		/// Adds a new uniform.
		/// </summary>
		/// <param name="uniform">The new uniform to attach.</param>
		public extern void SyncUniform(object uniform);

		/// <summary>
		/// Updates the shader uniform values.
		/// </summary>
		public extern void SyncUniforms();
	}
}