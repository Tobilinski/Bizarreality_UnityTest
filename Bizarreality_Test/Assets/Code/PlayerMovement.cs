using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(transform.right * -1 * _speed * Time.deltaTime, ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(transform.right * _speed * Time.deltaTime, ForceMode.Impulse);
        }


        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(transform.forward  * -1 * _speed * Time.deltaTime, ForceMode.Impulse);
        }


        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(transform.forward * _speed * Time.deltaTime, ForceMode.Impulse);
        }
    }
    
}
