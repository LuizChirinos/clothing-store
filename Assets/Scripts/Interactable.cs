using UnityEngine;

namespace ClothingStore.Interactions
{
    public class Interactable : MonoBehaviour
    {
        private bool interacted;

        protected bool Interacted { get => interacted; }

        public virtual void OverrideInteract()
        {

        }
    }
}
