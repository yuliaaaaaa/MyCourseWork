using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDConection : MonoBehaviour
{
    // Start is called before the first frame update

    public void ReceiveValue(int receivedValue)
    {
        // ќбробл€йте отримане значенн€ тут
        Debug.Log("Received value: " + receivedValue);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
