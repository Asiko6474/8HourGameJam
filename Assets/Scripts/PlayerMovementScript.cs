using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _jump;
    public bool _isGrounded = true;

    [SerializeField]
    private float _jumpForce;

    public Vector3 Jump
    {
        get { return _jump; }
        set { _jump = value; }
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Jump = new Vector3(0.0f, _jumpForce, 0.0f);
    }
    private void OnCollisionStay(Collision collision)
    {
        _isGrounded = true;
    }

    private void OnTriggerEnter(Collider other)
    {
            SceneManager.LoadScene("SampleScene");

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody.AddForce(Jump * _jumpForce, ForceMode.Impulse);
            _isGrounded = false;
        }
        
    }
}
