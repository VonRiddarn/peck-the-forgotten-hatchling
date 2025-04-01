using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Jumping : PlayerState
	{
		public PlayerState_Jumping(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}
