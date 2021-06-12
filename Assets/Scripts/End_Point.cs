using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Point : MonoBehaviour
{   
    public GameObject gamewin_obj;
    public GameObject player;
    public GameObject slider;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag=="Player"){
            HUD hud = gamewin_obj.GetComponent<HUD>();
            hud.GameWin();

            Player pl = player.GetComponent<Player>();
            pl.rb.constraints = RigidbodyConstraints2D.FreezePosition;

            Show_Balance showB = slider.GetComponent<Show_Balance>();
            showB.clock = true;
        }

    }

}
