using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Swimming : PlayerState
	{
		public PlayerState_Swimming(PlayerStateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}