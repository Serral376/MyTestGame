using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Move_character : MonoBehaviour
{
    public TMP_Text text_hp;
    public TMP_Text text_score;

    public int HP;
    public int Score;
    public float Speed = 6 ;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        text_hp.text = "HP " + HP;
        text_score.text = "Score " + Score;
        if (HP <= 0)
        {
            Time.timeScale = 0;    
            

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-1, 0, 0) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(1, 0, 0) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 1) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -1) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 1, 0) * Speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.V))
        {
            transform.position = transform.position + new Vector3(0, -1, 0) * Speed * Time.deltaTime;

        }

       
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
        Gizmos.DrawLine(transform.position, transform.position + transform.right);
        Gizmos.DrawLine(transform.position, transform.position + transform.forward + transform.right);
        //Gizmos.DrawLine(transform.position, transform.position +ClicPoint);
    }
    











}
