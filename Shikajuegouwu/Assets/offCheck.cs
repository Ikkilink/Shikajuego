using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class offCheck : MonoBehaviour
{

    //private CheckA checkA;
    //private CheckR checkR;
    [SerializeField] public static bool outA;
    [SerializeField] public static bool outR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //outA = false;
        //outR = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checkA = GameObject.FindGameObjectWithTag("CheckA").GetComponent<CheckA>();
        //checkR = GameObject.FindGameObjectWithTag("CheckR").GetComponent<CheckR>();
        if (collision.CompareTag("Azul"))
        {

            outA = true;
            //checkA.StartCheckA();
        }



        if (collision.CompareTag("Rojo")) {
            outR = true;
            //checkR.StartCheckR();
        }

    }
}
