using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public float ItemRandomizer;

    public void Start()
    {
        ItemRandomizer = Random.Range(0, 5);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (ItemRandomizer == 0)
        {
            //Effect 1 (Positive)
        }
        if (ItemRandomizer == 1)
        {
            //Effect 2 (Negative)
        }
        if (ItemRandomizer == 2)
        {
            //Effect 3 (Positive)
        }
        if (ItemRandomizer == 3)
        {
            //Effect 4 (Negative)
        }
        if (ItemRandomizer == 4)
        {
            //Effect 5 (Positive)
        }
        if (ItemRandomizer == 5)
        {
            //Effect 6 (Negative)
        }
    }
}
