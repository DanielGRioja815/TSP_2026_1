using UnityEngine;
using UnityEngine.XR;

public class ColliderController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical);

        rb.AddForce(movimiento * 5);
    }
    //metodos de colision
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision con: " + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Mantiene la colision con: " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sale de colision con: " + collision.gameObject.name);
    }


    //metodos trigger
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger con: " + other.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Mantiene Trigger con: " + other.gameObject.name);

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sale del Trigger con: " + other.gameObject.name);

    }
}
