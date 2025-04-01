using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Attacking : PlayerState
	{
		public PlayerState_Attacking(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}