using UnityEngine;

namespace ClothingStore.Player
{
    [RequireComponent(typeof(EntityInput))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 0.1f;
        private EntityInput entityInput;
        private Rigidbody2D rb;

        private void Start()
        {
            entityInput = GetComponent<EntityInput>();
            rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            rb.velocity = entityInput.InputDirection * speed;
        }
    }
}
