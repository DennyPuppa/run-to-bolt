using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalMedal : MonoBehaviour
{
    public Text finalMedalText;
    public Text medal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        finalMedalText.text =  medal.text;
        medal.enabled = false;
    }
}

