using UnityEngine;

public class Collision_detection : MonoBehaviour {

    public Player_movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {



        if(collisionInfo.collider.tag == "Obstacles")
        {
            Debug.Log("We hit an obstacle.");
            movement.enabled = false;
            FindObjectOfType<Game_manager_script>().EndGame();
        }
    }

}
