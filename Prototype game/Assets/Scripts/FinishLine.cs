using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public Text winText;

    // Use this for initialization
    void Start()
    {
    }

    //Turn on if object is triggerit
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Vehicle")
        {
            winText.text = "You Win!";

            StartCoroutine(Return());
        }
        //Wait for seconds real time
        IEnumerator Return()
        {
            yield return new WaitForSecondsRealtime(1.7f);
            winText.text = "";
        }

    }
}
