namespace FractalPike.Peck.StateManagement
{
	public abstract class State
	{
		protected readonly StateMachine _stateMachine;
		public readonly string name;

		public State(StateMachine stateMachine, string name)
		{
			this.name = name;
			_stateMachine = stateMachine;
		}

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
