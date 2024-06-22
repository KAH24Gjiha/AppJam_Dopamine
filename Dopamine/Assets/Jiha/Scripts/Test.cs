using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public DaySystem dayManager;
    public int GetDopamine;
    // Start is called before the first frame update
    void Start()
    {
        dayManager = GameObject.Find("DayManager").GetComponent<DaySystem>();
    }
    public void Turnp()
    {
        GetDopamine++;
        dayManager.TurnPlus();
    }

}
