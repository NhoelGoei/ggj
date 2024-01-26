using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField] float drainPerSecond;
    [SerializeField] float drainPerMiss;
    [SerializeField] float regenPerHit;
    [SerializeField] Slider healthBar;

    public float health = 100;

    public void Update()
    {
        DPS();
        healthBar.value = health;
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
