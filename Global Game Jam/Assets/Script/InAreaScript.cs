using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAreaScript : MonoBehaviour
{
    public InputNote inputNote;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Note")) 
        {
            inputNote.inArea = true;
            inputNote.noteOnInput.Add(collision.gameObject);
        }
    }
}
