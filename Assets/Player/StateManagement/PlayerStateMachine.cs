using FractalPike.Peck.Player.StateManagement.States;
using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement
{
	public sealed class PlayerStateMachine : StateMachine
	{
		// Input is in hot path, so we use a field instead of property.
		/// <summary>Only modify from the appropriate <c>Input manager</c>!</summary>
		public Vector2 movementDirection = Vector2.zero;
		
		// NOTE: We're going for pure speed.
		// This is using direct casts with no safety. If the state provided is not a PlayerState this WILL crash.
		public void HandleJumpInput() => ((PlayerState)currentState).HandleJumpInput();
		public void HandleAttackInput() => ((PlayerState)currentState).HandleAttackInput();
		public void HandleRollInput() => ((PlayerState)currentState).HandleRollInput();
		public void HandleInteractInput() => ((PlayerState)currentState).HandleInteractInput();
	}	
}
