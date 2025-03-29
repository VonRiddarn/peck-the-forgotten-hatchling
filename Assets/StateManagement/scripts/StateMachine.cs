using UnityEngine;

namespace FractalPike.Peck.StateManagement 
{
	public class StateMachine : MonoBehaviour
	{
		#if UNITY_EDITOR
		[Header("Debug")]
		[SerializeField] bool _logStateChange = false;
		#endif

		/// <summary>DO NOT MODIFY!<br/>Use <c>SetState(newState)</c> instead!</summary>
		[HideInInspector] public State currentState = null;


		void Update() => currentState?.Update();
		void FixedUpdate() => currentState?.FixedUpdate();
		void LateUpdate()
		{
			currentState?.LateUpdate();
			currentState.CheckTransitions();
		}

		public void SetState(State newState)
		{
			if(currentState == newState)
				return;

			#if UNITY_EDITOR
			if(_logStateChange) 
				Debug.Log($"STATE CHANGE [{currentState?.ToString() ?? "None"}] -> [{newState?.ToString() ?? "None"}]\nIn: {this}");
			#endif

			currentState?.Exit();
			currentState = newState;
			currentState?.Enter();
		}
	}
}