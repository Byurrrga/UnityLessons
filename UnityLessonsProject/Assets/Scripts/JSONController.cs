using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public int level;
    public string name;
}

public class JSONController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerData pd = new PlayerData();

        pd.level = 1;
        pd.name = "Sergey";

        string json = JsonUtility.ToJson(pd);

        Debug.Log(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
