using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject foodChooserUI;
    public GameObject closetChooserUI;

    public void ToggleClosetCActive()
    {
        closetChooserUI.SetActive(!closetChooserUI.activeSelf);
    }
    public void ClothWear()
    {

    }

    public void ToggleFoodChooser()
    {
        foodChooserUI.SetActive(!foodChooserUI.activeSelf);
    }
    public void EatFood(int index)
    {
        Cat.instance.Eat(DataList.instance.foodList[index]);
    }

    public void Stroke()
    {
        int n = Random.Range(0, 2);

        if (n == 0)
            DataManager.Instance.playerDB.Dopamine++;
        else
            DataManager.Instance.playerDB.stress += 2;
    }

    public void PlayWithCat()
    {
        int n = Random.Range(0, 3);
        DataManager.Instance.playerDB.Dopamine += n;
    }
}
