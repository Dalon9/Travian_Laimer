using UnityEngine;

public class Player : MonoBehaviour
{

    public float JumpForce;

    private bool _onFloor;
    private Rigidbody _rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _onFloor = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onFloor)
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (GameManager.Instance.IsRunning())
        {
            _rb.AddForce(Vector3.up * JumpForce);
            _onFloor = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Floor")
        {
            _onFloor = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            GameManager.Instance.GameOver();
        }
    }
}
