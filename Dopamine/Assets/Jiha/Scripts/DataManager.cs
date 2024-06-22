using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class DataManager : MonoBehaviour
{
    static GameObject container;
    static DataManager instance;

    //[SerializeField] public static List<Item> itemList = new List<Item>();
    public static DataManager Instance
    {
        get
        {
            if (!instance)
            {
                container = new GameObject();
                container.name = "DataManager";
                instance = container.AddComponent(typeof(DataManager)) as DataManager;
                DontDestroyOnLoad(container);
            }
            return instance;
        }
    }

    string GameDataFileName = "GameData.json";

    public PlayerData playerDB = new PlayerData();

    // �ҷ�����
    public void LoadGameData()
    {
        string filePath = Application.persistentDataPath + "/" + GameDataFileName;
        //Debug.Log(filePath);

        if (File.Exists(filePath))
        {
            string FromJsonData = File.ReadAllText(filePath);
            playerDB = JsonUtility.FromJson<PlayerData>(FromJsonData);
            Debug.Log("�ҷ����� �Ϸ�");
        }
        else
        {
            Debug.Log("�ҷ����� ����");
        }
    }
    // �����ϱ�
    public void SaveGameData()
    {
        string ToJsonData = JsonUtility.ToJson(playerDB, true);
        string filePath = Application.persistentDataPath + "/" + GameDataFileName;
        //string jsonString = JsonConvert.SerializeObject(gameData);
        File.WriteAllText(filePath, ToJsonData);

        Debug.Log("���� �Ϸ�");
    }
    public void DeleteGameData()
    {
        string filePath = Application.persistentDataPath + "/" + GameDataFileName;
        System.IO.File.Delete(filePath);

    }
    private void Awake()
    {
        LoadGameData();
    }
}
