using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAMON : MonoBehaviour
{
    [SerializeField] private float _speed = 0.0f;

    private Rigidbody _rb;
    // Start is called before the first frame update
    public void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }
    private void Move()
    {
        float axis = Input.GetAxisRaw("Horizontal");
        Vector3 velocity = Vector3.right * axis * _speed;
        _rb.velocity = velocity;

        //float rightAxis = Input.GetAxisRaw("Horizontal");
        //Vector2 direction = new Vector2(rightAxis, 0);
        //float magnitude = direction.magnitude;
        //direction.Normalize();
        //direction *= _speed;
        //_rb.velocity = direction;
    }
    public void MoveIzq()
    {

    }

    public void MoveDer()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
