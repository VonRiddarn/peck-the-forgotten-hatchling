namespace FractalPike.Peck.StateManagement
{
	public abstract class State
	{
		protected StateMachine _stateMachine;
		
		public State(StateMachine stateMachine) => _stateMachine = stateMachine;

		public virtual void Enter() { }
		public virtual void SubscribeToEvents() { }

		public virtual void Exit() { }
		public virtual void UnsubscribeToEvents() { }

		public virtual void CheckTransitions() { }
		public virtual void Update() { }
		public virtual void FixedUpdate() { }
		public virtual void LateUpdate() { }
	}
}
