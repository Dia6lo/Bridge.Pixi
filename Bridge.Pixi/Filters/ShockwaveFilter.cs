using System.Collections.Generic;

namespace Bridge.Pixi.Filters
{
	[External]
	[Namespace("PIXI.filters")]
	public class ShockwaveFilter : AbstractFilter
	{
		public extern ShockwaveFilter();

		/// <summary>
		/// Sets the center of the shockwave in normalized screen coords.
		/// That is (0,0) is the top-left and (1,1) is the bottom right.
		/// </summary>
		[FieldProperty]
		public Dictionary<string, float> Center { get; set; }

		/// <summary>
		/// Sets the params of the shockwave.
		/// These modify the look and behavior of the shockwave as it ripples out.
		/// </summary>
		[FieldProperty]
		public Dictionary<string, float> Params { get; set; }

		/// <summary>
		/// Sets the elapsed time of the shockwave.
		/// This controls the speed at which the shockwave ripples out.
		/// </summary>
		[FieldProperty]
		public float Time { get; set; }

	}
}