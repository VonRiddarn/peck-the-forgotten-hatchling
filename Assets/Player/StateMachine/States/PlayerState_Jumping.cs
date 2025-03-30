using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Jumping : State
	{
		public PlayerState_Jumping(StateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}
