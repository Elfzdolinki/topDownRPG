using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastInteraction : MonoBehaviour
{
    public float rayDistance = 5f;            // How far the ray will travel
    public LayerMask hitLayers;               // Choose specific layers to detect
    public Vector2 rayDirection = Vector2.right;  // Direction of the ray (right by default)

    public bool canInteract; // Checks if the player can interact with smth



    void Update()
    {
        RayInteraction();



    }

    void RayInteraction()
    {
        // Cast a ray from the player's position in the specified direction
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, rayDirection, rayDistance, hitLayers);

        // Draw the ray in the Scene view for debugging
        Debug.DrawRay(transform.position, rayDirection * rayDistance, Color.red);


        if (hitInfo.collider != null)
        {
            // Try to get the Interactable component from the hit object
            Interactable interactable = hitInfo.collider.GetComponent<Interactable>();

            // If there's an interactable object and the player presses "E"
            if (interactable != null && Input.GetKeyDown(KeyCode.E))
            {
                interactable.Interact();
            }
        }
    }
}
