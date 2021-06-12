using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int balance = 50;
    public int limit = 100;
    public float update_rate = 1f;

    private float lastUpdate = 0;

    public Show_Balance BI;
    public GameObject hud_obj;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Random.InitState(System.Guid.NewGuid().GetHashCode());
    }

    // Update is called once per frame
    void Update()
    {   
        // Add random force
        float time = Time.time;
        if(time-lastUpdate > update_rate){
            // Debug.Log("add");
            ForceAdd();
            lastUpdate = time;
        }


        // Balance check
        if(balance>limit || balance<0){
            // Debug.Log("Game Over");
            HUD hud = hud_obj.GetComponent<HUD>();
            hud.GameOver();

            // Play faint animation
            Animator Faint = GetComponent<Animator>();
            Faint.SetTrigger("Faint");

            // let player fall down.
            Collider2D cd = GetComponent<BoxCollider2D>();
            cd.enabled = false;

            
            this.enabled = false;
        }

        // user control
        if(Input.GetKeyDown("j")){
            balance -= 5;
            Debug.Log(balance);
        }
        if(Input.GetKeyDown("k")){
            balance += 5;
            Debug.Log(balance);
        }
    }

    void ForceAdd()
    {   
        int force = 0;
        if(balance < 35)
        {
            force = Random.Range(-25,-20);
            balance += force;
        }
        else if(balance > 65)
        {
            force = Random.Range(25,20);
            balance += force;
        }
        else
        {
            force = Random.Range(-20,20);
            balance += force;
        }
    }
}
