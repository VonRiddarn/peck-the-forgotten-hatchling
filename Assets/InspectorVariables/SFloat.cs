using UnityEngine;

namespace FractalPike.Peck.InspectorVariables
{
	[CreateAssetMenu(fileName = "Float", menuName = "Fractal Pike/Variables/Float")]
	public sealed class SFloat : ScriptableObject
	{
		public float value = 0f;
	}
}
