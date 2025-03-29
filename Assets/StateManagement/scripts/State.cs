namespace FractalPike.Peck.StateManagement
{
	public abstract class State
	{
		protected StateMachine _stateMachine;
		
		public State(StateMachine stateMachine) => _stateMachine = stateMachine;

		public abstract void Enter();
		public abstract void Exit();
		public abstract void CheckTransitions();
		public abstract void Update();
		public abstract void FixedUpdate();
		public abstract void LateUpdate();
	}
}
