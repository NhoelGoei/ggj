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

    // Update is called once per frame
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
    }
    public void OnNoteMiss()
    {
        Debug.Log("Note Miss!");
        Destroy(noteOnInput[currentIndex]);
        currentIndex++;
        healthBar.DPM();
    }
}
