using UnityEngine;

namespace FractalPike.Peck.InspectorVariables
{
	[CreateAssetMenu(fileName = "Vector 2", menuName = "Fractal Pike/Variables/Vector2")]
	public sealed class SVector2 : ScriptableObject
	{
		public Vector2 value = Vector2.zero;
	}
}