using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public Transform RespawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("player entered");
        Debug.Log(other);

        if (other.CompareTag("Player"))
        {
            Debug.Log("reset");

            // Disable the CharacterController before resetting the position
            CharacterController controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false; // Disable controller to move player manually
            }

            // Reset the player's position to the respawn point
            other.transform.position = RespawnPoint.position;

            // Re-enable CharacterController after the position reset
            if (controller != null)
            {
                controller.enabled = true;
            }
        }
    }
}