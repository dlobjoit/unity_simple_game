using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
	public float forwardForce;
	public float sidewayForce;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     Debug.Log("Allo");
    //     rb.AddForce(0, 200, 500);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce);
        if(Input.GetKey("d"))
        {
        	rb.AddForce(sidewayForce, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("q"))
        {
        	rb.AddForce(-sidewayForce, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
        	FindObjectOfType<GameManager>().EndGame();
        }
    }
}
