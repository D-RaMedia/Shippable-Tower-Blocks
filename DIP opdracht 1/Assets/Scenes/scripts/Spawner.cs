﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject obj = Instantiate(Player, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity) as GameObject;
                obj.transform.Translate(0, 0, 0.7f);
            }

        }



    }
}
