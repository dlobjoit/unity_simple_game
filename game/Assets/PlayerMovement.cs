using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
	public float inputForce;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     Debug.Log("Allo");
    //     rb.AddForce(0, 200, 500);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, inputForce);
    }
}
