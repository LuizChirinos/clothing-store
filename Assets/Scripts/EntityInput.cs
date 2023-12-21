using System;
using System.Net.Sockets;
using UnityEngine;

namespace ClothingStore.Input
{
    public abstract class EntityInput : MonoBehaviour
    {
        public event Action OnInteracted;
        protected Vector2 inputDirection;

        public Vector2 InputDirection { get => inputDirection; }

        protected void RaiseInteractionEvent() => OnInteracted?.Invoke();
    }
}
