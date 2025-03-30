using FractalPike.Peck.InspectorVariables;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FractalPike.Peck.InputManagement
{
	[RequireComponent(typeof(PlayerInput))]
	public sealed class InputWrapper : MonoBehaviour
	{
		// Input is in hot path, so we wont be using a property here.
		/// <summary>DO NOT MODIFY!</summary>
		public static InputWrapper instance = null;

		[Header("Dependencies")]
		[SerializeField] SVector2 _inputDirection = null;

		PlayerInput _playerInput = null;

		bool InitializeSingleton()
		{
			if(instance == null)
			{
				instance = this;
				DontDestroyOnLoad(gameObject);
				return true;
			}
			else
			{
				Destroy(gameObject);
				return false;
			}
		}

		void Awake()
		{
			// Make sure we wont accidentally run subscriptions on object due for deletion
			if(!InitializeSingleton())
				return;	

			_playerInput = GetComponent<PlayerInput>();
		}

		void Update()
		{
			// TODO!!!: REMOVE IN BUILD!
			DebugInputs();

			switch(_playerInput.currentActionMap.name)
			{
				case "Gameplay":
				RunGameplayInput();
				break;

				case "UI":
				RunInterfaceInput();
				break;

				default:
				RunGameplayInput();
				#if UNITY_EDITOR
				Debug.Log($"{_playerInput.currentActionMap.name} is not a valid action map!");
				#endif
				break;
			}
		}

		// TODO: Potentially have some kind of exit state for the inputs so that
		// Movementdirection isn't stuck in the last direction?
		// Might be overkill as we can override player behaviour at game state level.
		void RunGameplayInput()
		{
			_inputDirection.value = _playerInput.actions["Move"].ReadValue<Vector2>();
			Debug.Log(_inputDirection.value);
		}

		void RunInterfaceInput()
		{
			// To be added.
		}


		void DebugInputs()
		{
			if(Input.GetKeyDown(KeyCode.K))
				_playerInput.SwitchCurrentActionMap(_playerInput.currentActionMap.name == "Gameplay" ? "UI" : "Gameplay");
		}
	}
}