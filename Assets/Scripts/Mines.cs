using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mines : MonoBehaviour
{
    [SerializeField] private MeshCollider OuterRange;
    [SerializeField] private List<GameObject> Enemies;
    [SerializeField] private MeshCollider Touching;

    void Start()
    {
        if (OuterRange == null) { OuterRange = GetComponent<MeshCollider>(); }
        if (Touching == null) { Touching = GetComponent<MeshCollider>(); }
    }

    public void OnCollisionEnter(Collision collision)
    {
        foreach(GameObject Enemy in Enemies)
        {
            Destroy(Enemy);
            Enemies.Remove(transform.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Enemies.Add(other.transform.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Enemies.Remove(other.transform.gameObject);
        }
    }
}
