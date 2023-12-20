using System.Net.Sockets;
using UnityEngine;

namespace ClothingStore.Input
{
    public abstract class EntityInput : MonoBehaviour
    {
        protected Vector2 inputDirection;

        public Vector2 InputDirection { get => inputDirection; }
    }
}
