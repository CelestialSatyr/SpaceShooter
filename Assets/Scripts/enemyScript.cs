using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    //Speed
    
    //I use this to for the player(s) position
    [SerializeField] private Transform playerPos;

    //Speed of the basic enemy
    [SerializeField] private float Speed = 0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        Vector3 localPosition = playerPos.transform.position - transform.position;
        transform.Translate(localPosition.normalized.x * Time.deltaTime * Speed, localPosition.normalized.y * Time.deltaTime * Speed, localPosition.normalized.z * Time.deltaTime * Speed);
    }
}
