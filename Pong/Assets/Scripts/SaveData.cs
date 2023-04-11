using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
   public void SaveBool(bool value, string saveName)
   {
        int i;
        if (value)  i = 1;
        else i = 0;
        PlayerPrefs.SetInt(saveName, i);
   }
    public bool GetBool(string saveName)
    {
        int i = PlayerPrefs.GetInt(saveName);
        if (i == 1) return true;
        else return false;
    }
}
