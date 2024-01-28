using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightedButton : MonoBehaviour
{
    [SerializeField] GameObject stage1;
    [SerializeField] GameObject stage2;
    [SerializeField] GameObject stage3;

    public void ActiveBG1()
    {
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
    }
    public void ActiveBG2()
    {
        stage1.SetActive(false);
        stage2.SetActive(true);
        stage3.SetActive(false);
    }
    public void ActiveBG3()
    {
        stage1.SetActive(false);
        stage2.SetActive(false);
        stage3.SetActive(true);
    }
}
