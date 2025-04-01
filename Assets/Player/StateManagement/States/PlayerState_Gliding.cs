using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Gliding : PlayerState
	{
		public PlayerState_Gliding(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}