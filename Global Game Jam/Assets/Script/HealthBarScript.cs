using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] float drainPerSecond;
    [SerializeField] float drainPerMiss;
    [SerializeField] float regenPerHit;
    [SerializeField] Slider healthBar;

    public AudioSource bgm;

    public float health = 100;

    public void Update()
    {
        DPS();
        healthBar.value = health;
        if(health >= 100)
        {
            health = 100;
        }
        if (health <= 0)
        {
            SceneManager.LoadScene("LoseGame");
        }
        if (!bgm.isPlaying)
        {
            SceneManager.LoadScene("WinGame");
        }
    }

    public void DPS()
    {
        health -= drainPerSecond * Time.deltaTime;
    }

    public void DPM()
    {
        health -= drainPerMiss;
    }

    public void RPH()
    {
        health += regenPerHit;
    }
}
