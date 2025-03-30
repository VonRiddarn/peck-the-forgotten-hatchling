using UnityEngine;

namespace FractalPike.Peck.InspectorVariables
{
	[CreateAssetMenu(fileName = "Vector3", menuName = "Fractal Pike/Variables/Vector 3")]
	public class SVector3 : ScriptableObject
	{
		public Vector3 value = Vector3.zero;
	}
}
