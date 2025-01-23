using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class KeyOpenDoor : MonoBehaviour
{
    #region ----------------- Fields -----------------

    [SerializeField] private ScoreManager scoreManager; // Reference to the ScoreManager to increment the score

    #endregion

    #region ----------------- Unity Methods -----------------

    /// <summary>
    /// Called when the key collides with another object.
    /// If the collided object has the tag "Door", this key deactivates itself,
    /// enables the XRGrabInteractable component on the door's parent, and increments the score.
    /// </summary>
    /// <param name="other">The collider of the object the key collided with.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            // Deactivate the key
            gameObject.SetActive(false);

            // Enable XRGrabInteractable on the parent object of the door
            other.gameObject.GetComponentInParent<XRGrabInteractable>().enabled = true;

            // Increment the player's score
            scoreManager.Score++;
        }
    }

    #endregion
}
