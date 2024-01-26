using UnityEngine;
using System.Collections.Generic;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab; // Prefab of the note object to spawn
    public float noteSpeed = 5f; // Speed at which notes move towards the player
    public List<float> spawnDelays; // List of delays for spawning notes
    public float spawnOffset = 1f; // Offset to adjust note spawning timing

    private int currentSpawnIndex = 0; // Index of the current spawn delay in the list

    void Start()
    {
        // Start spawning notes
        Invoke("SpawnNote", spawnOffset);
    }

    void SpawnNote()
    {
        // Check if there are more spawn delays in the list
        if (currentSpawnIndex < spawnDelays.Count)
        {
            // Calculate next spawn time
            float nextSpawnTime = Time.time + spawnDelays[currentSpawnIndex];

            // Instantiate a note at the spawn position
            GameObject newNote = Instantiate(notePrefab, transform.position, Quaternion.identity);

            // Set note's speed
            newNote.GetComponent<Note>().speed = noteSpeed;

            // Increment the index for the next spawn delay
            currentSpawnIndex++;

            // Schedule the next spawn
            Invoke("SpawnNote", nextSpawnTime - Time.time);
        }
    }
}
