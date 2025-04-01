using FractalPike.Peck.Player.StateManagement.States;
using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement
{
	public sealed class PlayerStateRepository : MonoBehaviour
	{
		public PlayerState Idle;
		public PlayerState Walking;
		public PlayerState Jumping;
		public PlayerState Falling;
		public PlayerState Attacking;
		public PlayerState Gliding;
		public PlayerState Swimming;

		public PlayerStateRepository(PlayerStateMachine stateMachine)
		{
			Idle = new PlayerState_Idle(stateMachine, "idle");
			Walking = new PlayerState_Walking(stateMachine, "walking");
			Jumping = new PlayerState_Jumping(stateMachine, "jumping");
			Falling = new PlayerState_Falling(stateMachine, "falling");
			Attacking = new PlayerState_Attacking(stateMachine, "attacking");
			Gliding = new PlayerState_Gliding(stateMachine, "gliding");
			Swimming = new PlayerState_Swimming(stateMachine, "swimming");
		}
	}
}
