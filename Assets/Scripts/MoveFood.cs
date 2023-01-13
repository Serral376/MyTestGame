using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFood : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + transform.forward*Time.deltaTime;



    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        GameObject.Find("player").GetComponent<Move_character>().Score += 1;

        


    }


}
