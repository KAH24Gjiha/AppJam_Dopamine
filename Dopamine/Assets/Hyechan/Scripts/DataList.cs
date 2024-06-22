using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataList : MonoBehaviour
{
    public List<Food> foodList = new List<Food>();
    public List<Cloth> clothList = new List<Cloth>();

    public static DataList instance;
    private void Awake()
    {
        instance = this;
    }
}

[Serializable]
public class Food
{
    public string name;
    public int cost;
    public int happinessValue;
    public int stressValue;
}
[Serializable]
public class Cloth
{
    public string name;
    public int cost;
    public int happinessValue;
    public int stressValue;
    public bool isLocked;
}
