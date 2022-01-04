using UnityEngine;

public class Player_movement : MonoBehaviour {

    public Rigidbody rb;
    public float sidewaysSpeed = 750f;
    public float moveSpeed = 1800f;


    void FixedUpdate()
    {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime, ForceMode.VelocityChange);

        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<Game_manager_script>().EndGame();
        }
    }

}
