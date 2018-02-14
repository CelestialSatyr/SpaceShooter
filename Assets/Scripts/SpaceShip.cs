using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    //controls
    [SerializeField]
    string forward;
    [SerializeField]
    string backward;
    [SerializeField]
    string left;
    [SerializeField]
    string right;
    [SerializeField]
    string shoot;
    //speed and stuff
    [SerializeField]
    float speed;
    [SerializeField]
    private int turnSpeed;
    //shooting
    [SerializeField]
    private Transform Origin, m_target;
    [SerializeField]
    private float initialForce;
    [SerializeField]
    private Rigidbody Projectile;
    Vector3 SP_box;
    void Update()
    {
        //movement
        if (Input.GetKey(forward))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0), Space.Self);
        }
        if (Input.GetKey(backward))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0), Space.Self);
        }
        if (Input.GetKey(left))
        {
            transform.Rotate(new Vector3(0, 0, turnSpeed * Time.deltaTime), Space.Self);
        }
        if (Input.GetKey(right))
        {
            transform.Rotate(new Vector3(0, 0, -turnSpeed * Time.deltaTime), Space.Self);
        }
        //shooting
        if (Input.GetKeyDown(shoot))
        {
            Vector3 direction = (m_target.position - transform.position).normalized;
            Rigidbody newBullet = Instantiate(Projectile, Origin.position, Origin.rotation);
            newBullet.AddForce(direction * initialForce * Time.fixedDeltaTime);
        }
    }
}
