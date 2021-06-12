using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag=="Player"){
            //Debug.Log("score+10");
            Destroy(this.gameObject);
            Game_Manage.score += 10;
        }

    }
}
