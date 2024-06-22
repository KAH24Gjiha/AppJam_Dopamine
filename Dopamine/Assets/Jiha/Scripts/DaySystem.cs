using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DaySystem : MonoBehaviour
{
    public PlayerData playerData;

    
    public int turn;
    public int GetDopamine;

    public Slider turnSlider; //슬라이더로 할지 단순 grid로 설정할지 아직 모르겠음.
    public GameObject finishPopUp;

    public GameObject testObj;

    private void Awake()
    {
        playerData = DataManager.Instance.playerDB;
        
    }
    void Start()
    {

    }

    public void TurnPlus()
    {
        this.turn++;
        if (turn >= 12) DayFinish();
        turnSlider.value += 1; //슬라이더 MAxValue는 10 (턴 값과 완전동일)
        //만약 grid로 작업시 turnSlider.transform.Child(turn).GetComponent<Image>().color = new Color(1,1,1,1);?
        
    }
    public void DayFinish()
    {
        finishPopUp.SetActive(true);
        void SetResult()
        {
            TMP_Text Emotion = finishPopUp.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>();
            TMP_Text Clothes = finishPopUp.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>();
            TMP_Text EatList = finishPopUp.transform.GetChild(0).GetChild(2).GetComponent<TMP_Text>();

            TMP_Text Result = finishPopUp.transform.GetChild(0).GetChild(3).GetComponent<TMP_Text>();
            TMP_Text Money = finishPopUp.transform.GetChild(0).GetChild(4).GetComponent<TMP_Text>();

            //---
            GetDopamine = testObj.GetComponent<Test>().GetDopamine;
            Emotion.text = "얻은 도파민 : " + GetDopamine;
            Clothes.text = "입은 옷은 마음에 들었나? : ";
            EatList.text = "밥을 제 때 먹었나? : ";

            Result.text = "최종 기분! : " + playerData.Dopamine;
            Money.text = "이만큼 얻었다! : " + GetMoney();
        }
        SetResult();

        playerData.Days++;
    }
    public int GetMoney()
    {
        float money = 0;
        money += playerData.Dopamine * 5;
        money -= playerData.stress * 2;
        if (money < 5) money = 5;
        else if (money > 50) money = 50;

        return (int)money;
    }

    public void IsGrowth()
    {
        if(playerData.Days > ((float)playerData.age))
        {
            playerData.age += 30;
            //
        }
        //고양이 기본값.성장스탯 변화
    }

}
