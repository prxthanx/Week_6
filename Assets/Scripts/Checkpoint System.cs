using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 checkpointPosition; // Store the checkpoint position

    // When the player enters the checkpoint area
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointPosition = other.transform.position; // Save the player's position
            Debug.Log("Checkpoint saved at: " + checkpointPosition);
        }
    }

    // Get the saved checkpoint position
    public Vector3 GetCheckpointPosition()
    {
        return checkpointPosition;
    }
}
