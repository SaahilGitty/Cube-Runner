using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_win : MonoBehaviour {


    void OnTriggerEnter()
    {
        FindObjectOfType<Game_manager_script>().CompleteLevel();
    }

}
