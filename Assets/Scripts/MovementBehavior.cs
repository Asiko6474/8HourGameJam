using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Vector3 _velocity;

    public Vector3 Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }

    public GameObject Target
    {
        get { return _target; }
        set { _target = Target; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = Speed; }
    }
    public void Update()
    {
        transform.position += Velocity * Time.deltaTime;
        Vector3 direction = _target.transform.position - transform.position;
        Velocity = direction.normalized * Speed;
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.transform == _target)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
