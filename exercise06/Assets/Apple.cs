using UnityEngine;

using System.Collections;
using System.Collections.Generic;


public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 15f * Time.deltaTime, 0);
    }
}