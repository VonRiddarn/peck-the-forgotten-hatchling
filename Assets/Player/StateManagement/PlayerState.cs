using FractalPike.Peck.StateManagement;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public class PlayerState : State
	{
		public PlayerState(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}

		public virtual void HandleJumpInput() {}
		public virtual void HandleAttackInput() {}
		public virtual void HandleRollInput() {}
		public virtual void HandleInteractInput() {}
	}
}
