using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    public Transform InteractionPoint;
    public LayerMask InteractionLayer;
    private PlayerMovement playerMovement;
    [SerializeField] private float InteractionpointRadius = 1f;
    public bool IsInteracting { get; private set; }

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        var colliders = Physics.OverlapSphere(InteractionPoint.position, InteractionpointRadius, InteractionLayer);

        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            for (int i = 0; i < colliders.Length; i++)
            {
                var interactable = colliders[i].GetComponent<IInteractable>();

                if (interactable != null) StartInteraction(interactable);
            }
        }
        else if (IsInteracting && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            EndInteraction();
        }
    }

    void StartInteraction(IInteractable interactable)
    {
        interactable.Interact(this, out bool interactsuccessfull);
        playerMovement.enabled = false;
        IsInteracting = true;
    }

    void EndInteraction()
    {
        IsInteracting = false;
        playerMovement.enabled = true;
    }
}
