using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOn : MonoBehaviour
{
    // StartGame is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetFloat("EstelaActivada") == 1f)
        {
            this.gameObject.GetComponent<Toggle>().isOn = true;
        }
        if (PlayerPrefs.GetFloat("EstelaActivada") == 0f)
        {
            this.gameObject.GetComponent<Toggle>().isOn = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
