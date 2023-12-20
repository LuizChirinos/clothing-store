using ClothingStore.Interactions;
using System.Collections.Generic;
using UnityEngine;

namespace ClothingStore.Player
{
    public class PlayerInteractions : MonoBehaviour
    {
        [SerializeField] private TriggerCollider triggerCollider;
        private List<Interactable> interactables;

        private void Start()
        {
            interactables = new List<Interactable>();

            triggerCollider.OnEntered += AddInteraction;
            triggerCollider.OnExited += RemoveInteraction;
        }

        private void RemoveInteraction(Collider2D collider)
        {
            interactables.Remove(collider.GetComponent<Interactable>());
        }

        private void AddInteraction(Collider2D collider)
        {
            interactables.Add(collider.GetComponent<Interactable>());
        }
    }
}
