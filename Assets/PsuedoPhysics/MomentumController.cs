using System;
using UnityEngine;

namespace FractalPike.Peck.PsuedoPhysics
{
	public sealed class MomentumController : MonoBehaviour
	{
		/// <summary>DO NOT MODIFY!</summary>
		public Vector3 velocity = Vector3.zero;
		/// <summary>Small overhead due to stack dive, be careful when using in hot path.</summary>
		public Vector3 HorizontalVelocity => new Vector3(velocity.x, 0, velocity.z);
		/// <summary>DO NOT MODIFY!</summary>
		public bool isGrounded = false;

		public Action OnBonk = null;
	}
}
