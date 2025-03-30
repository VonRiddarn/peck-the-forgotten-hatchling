using UnityEngine;

namespace FractalPike.Peck.InspectorVariables
{
	[CreateAssetMenu(fileName = "Int", menuName = "Fractal Pike/Variables/Int")]
	public sealed class SInt : ScriptableObject
	{
		public int value = 0;
	}
}
