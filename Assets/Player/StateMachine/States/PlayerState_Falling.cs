using FractalPike.Peck.StateManagement;
using UnityEngine;

namespace FractalPike.Peck.Player.StateManagement.States
{
	public sealed class PlayerState_Falling : State
	{
		public PlayerState_Falling(StateMachine stateMachine, string name) : base(stateMachine, name) {}
	}
}