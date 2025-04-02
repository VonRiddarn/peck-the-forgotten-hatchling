using System;
using UnityEngine;

namespace FractalPike.Peck.EntityPhysics
{
	public sealed class MomentumController : MonoBehaviour
	{
		/// <remarks>DO NOT MODIFY!</remarks>
		public Vector3 velocity = Vector3.zero;
		/// <remarks>Small overhead due to stack dive, be careful when using in hot path.</remarks>
		public Vector3 HorizontalVelocity => new Vector3(velocity.x, 0, velocity.z);
		/// <remarks>DO NOT MODIFY!</remarks>
		public bool isGrounded = false;

		/// <remarks>DO NOT <c>Invoke</c></remarks>
		/// <summary>Used to detect ceiling collision when <c>velocity.y</c> is positive.</summary>
		public Action OnBonk = null;
	}
}
