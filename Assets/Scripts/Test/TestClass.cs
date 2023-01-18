using UnityEngine;

public class SaveData
{
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public int testParam;
}

public class TestClass : MonoBehaviour
{
    private SaveData mySaveData;
    private void Start()
    {
        SaveData saveData = new SaveData();
        saveData.testParam = 5;
        TempSaveData(saveData);

        saveData.testParam = 10;
        Debug.Log(mySaveData.testParam);
    }
    private void TempSaveData(SaveData tempSaveData)
    {
        //mySaveData = new SaveData(tempSaveData);
        mySaveData = (SaveData)tempSaveData.Clone();
    }
}
