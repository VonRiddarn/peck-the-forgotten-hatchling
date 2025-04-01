using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Falling : PlayerState
	{
		public PlayerState_Falling(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}