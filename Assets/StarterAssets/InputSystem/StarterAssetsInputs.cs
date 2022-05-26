using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
        public bool aim;
        public bool EvadeLeft;
        public bool EvadeRight;
        //combat
        public bool combatMode;
        public bool HitHeavy;
        public bool Hit;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}

        //AIM
        public void OnAim(InputValue value)
        {
            AimInput(value.isPressed);
        }
        //combat
        public void OnHit(InputValue value)
        {
            HitInput(value.isPressed);
        }
        public void OnCombatMode(InputValue value)
        {
            CombatModeInput(value.isPressed);
        }
        public void OnHitHeavy(InputValue value)
        {
            HitHeavyInput(value.isPressed);
        }

        public void OnEvadeLeft(InputValue value)
        {
            EvadeLeftInput(value.isPressed);
        }
        public void OnEvadeRight(InputValue value)
        {
            EvadeRightInput(value.isPressed);
        }

#endif


        public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

        //AIM
        public void AimInput(bool newAimState)
        {
            aim = newAimState;
        }
        //combat
        public void HitInput(bool newHitState)
        {
            Hit = newHitState;
        }
        public void CombatModeInput(bool newHitState)
        {
            combatMode = newHitState;
        }
        public void HitHeavyInput(bool newHitHeavyState)
        {
            HitHeavy = newHitHeavyState;
        }

        public void EvadeLeftInput(bool newEvadeLeftState)
        {
            EvadeLeft = newEvadeLeftState;
        }
        public void EvadeRightInput(bool newEvadeRightState)
        {
            EvadeRight = newEvadeRightState;
        }


        //
        private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}