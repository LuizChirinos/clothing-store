using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ClothingStore.Input
{
    public class PlayerInputController : EntityInput
    {
        private PlayerInputAction playerInputAction;

        private void Start()
        {
            playerInputAction = new PlayerInputAction();

            playerInputAction.Player.Movement.started += MovementStarted;
            playerInputAction.Player.Movement.performed += MovementPerformed;
            playerInputAction.Player.Movement.canceled += MovementCanceled;

            playerInputAction.Player.Interact.performed += InteractionPerformed;
            playerInputAction.Enable();
        }

        private void InteractionPerformed(InputAction.CallbackContext context)
        {
            RaiseInteractionEvent();
        }

        private void MovementStarted(InputAction.CallbackContext context)
        {
            inputDirection = context.ReadValue<Vector2>();
        }


        private void MovementPerformed(InputAction.CallbackContext context)
        {
            inputDirection = context.ReadValue<Vector2>();
        }

        private void MovementCanceled(InputAction.CallbackContext context)
        {
            inputDirection = Vector2.zero;
        }
    }
}
