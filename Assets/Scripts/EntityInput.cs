using UnityEngine;

namespace ClothingStore.Input
{
    public class EntityInput : MonoBehaviour, IInput
    {
        [SerializeField]
        private Vector2 inputDirection;

        public Vector2 InputDirection { get => inputDirection; set => inputDirection = value; }

        private void Start()
        {

        }

        private void MovementStarted()
        {

        }

        private void MovementHandled()
        {

        }

        private void MovementFinished()
        {

        }
    }
}
