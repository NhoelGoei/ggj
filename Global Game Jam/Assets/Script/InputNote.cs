using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputNote : MonoBehaviour
{
    [SerializeField] string notePart;

    public List<GameObject> noteOnInput;
    public bool inArea = false;
    public HealthBarScript healthBar;

    private int currentIndex=0;
    private bool noteHit = false;

    public List<AudioClip> audioClips;
    private AudioSource audioSource;

    public List<AudioClip> AudioClips;
    private AudioSource AudioSource;

    public GameObject HitVFX;
    public GameObject MissVFX;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        try
        {
            switch (notePart)
            {
                case "downNote":
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        if (noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteHit();
                        }
                        else if (!noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteMiss();
                        }
                    }
                    break;
                case "upNote":
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        if (noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteHit();
                        }
                        else if (!noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteMiss();
                        }
                    }
                    break;
                case "leftNote":
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteHit();
                        }
                        else if (!noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteMiss();
                        }
                    }
                    break;
                case "rightNote":
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteHit();
                        }
                        else if (!noteHit && inArea && noteOnInput[currentIndex] != null)
                        {
                            OnNoteMiss();
                        }
                    }
                    break;
            }
        }
        catch (System.ArgumentOutOfRangeException) { }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Note"))
        {
            noteHit = true;
            noteOnInput[currentIndex] = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        noteHit = false;
    }

    public void OnNoteHit()
    {
        Debug.Log("Note Hit!");
        Destroy(noteOnInput[currentIndex]);
        currentIndex++;
        healthBar.RPH();
        PlayRandomAudio();
        GameObject objectToDestroy = Instantiate(HitVFX, transform.position, Quaternion.identity);
        Destroy(objectToDestroy, 1f);
    }
    public void OnNoteMiss()
    {
        Debug.Log("Note Miss!");
        Destroy(noteOnInput[currentIndex]);
        currentIndex++;
        healthBar.DPM();
        PlaysRandomAudio();
        GameObject objectToDestroy = Instantiate(MissVFX, transform.position, Quaternion.identity);
        Destroy(objectToDestroy, 1f);
    }
    public void PlayRandomAudio()
    {
        if (audioClips.Count > 0)
        {
            // Select a random audio clip from the list
            AudioClip randomClip = audioClips[Random.Range(0, audioClips.Count)];

            // Play the selected audio clip
            audioSource.clip = randomClip;
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Audio clips list is empty!");
        }
    }
    public void PlaysRandomAudio()
    {
        if (AudioClips.Count > 0)
        {
            // Select a random audio clip from the list
            AudioClip randomClip = AudioClips[Random.Range(0, AudioClips.Count)];

            // Play the selected audio clip
            AudioSource.clip = randomClip;
            AudioSource.Play();
        }
        else
        {
            Debug.LogError("Audio clips list is empty!");
        }
    }
}
