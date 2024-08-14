using UnityEngine;

namespace Lvl3Mage.MathToolkit
{
	public static class Linear
	{
		/// <summary>
		/// Removes discontinuities between two angles by recalculating the target angle in relation to the starting angle.
		/// </summary>
		/// <param name="from">
		/// The starting angle.
		/// </param>
		/// <param name="to">
		/// The target angle.
		/// </param>
		/// <returns>
		/// The target angle modified to remove discontinuities from the starting angle.
		/// </returns>
		public static float NormalizeAngleRange(float from, float to){
			float delta = Mathf.DeltaAngle(from, to);
			float target = from + delta;
			return target;
		}
		/// <summary>
		/// Transforms a value from one range to another. Unclamped.
		/// </summary>
		/// <param name="value">
		/// An input value in range <see cref="min"/> to <see cref="max"/>.
		/// </param>
		/// <param name="min">
		/// The minimum value of the input range.
		/// </param>
		/// <param name="max">
		/// The maximum value of the input range.
		/// </param>
		/// <param name="newMin">
		/// The minimum value of the output range.
		/// </param>
		/// <param name="newMax">
		/// The maximum value of the output range.
		/// </param>
		/// <returns>
		/// The value transformed to the new range.
		/// </returns>
		public static float TransformRange(float value, float min, float max, float newMin, float newMax){
			return ( (value - min) / (max - min) ) * (newMax - newMin) + newMin;
		}
		/// <summary>
		/// Transforms a value from one range to another. Unclamped.
		/// </summary>
		/// <param name="value">
		/// An input value in range <see cref="inputRange"/>.
		/// </param>
		/// <param name="inputRange">
		/// The input range.
		/// </param>
		/// <param name="outputRange">
		/// The output range.
		/// </param>
		/// <returns>
		/// The value transformed to the new range.
		/// </returns>
		public static float TransformRange(float value, Vector2 inputRange, Vector2 outputRange){
			return TransformRange(value, inputRange.x, inputRange.y, outputRange.x, outputRange.y);
		}
	}
}