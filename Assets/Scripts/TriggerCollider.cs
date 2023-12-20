using System;
using UnityEngine;

namespace ClothingStore
{
    public class TriggerCollider : MonoBehaviour
    {
        public delegate void OnCollisionEventHandler(Collider2D collider);
        public event OnCollisionEventHandler OnEntered; 
        public event OnCollisionEventHandler OnExited; 

        [SerializeField] private string targetTag;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Using string tag to handle multiple collision objects
            //Simple layer comparison would not be enough, even if it is more optimized
            if (collision.gameObject.CompareTag(targetTag))
            {
                OnEntered?.Invoke(collision);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(targetTag))
            {
                OnExited?.Invoke(collision);
            }
        }
    }
}
