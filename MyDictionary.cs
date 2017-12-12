using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyDictionary : SerializableDictionary<int, GameObject>
{
    public int Obj_ID;
    public GameObject Obj;
}
