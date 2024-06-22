using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public static Cat instance;

    public float happiness;
    public float stress;

    public int strokeValue;
    void Awake()
    {
        instance = this;
    }

    public void Eat(Food food)
    {
        Debug.Log(food.name);
        happiness += food.happinessValue;
        stress += food.stressValue;
    }
}
