using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Idle : PlayerState
	{
		public PlayerState_Idle(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}
