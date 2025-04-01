using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Walking : PlayerState
	{
		public PlayerState_Walking(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}