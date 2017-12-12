using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "AtkPrayDefine", menuName = "ProjectFullMoon/FunctionTypeDefine/AtkPrayDefine")]
public class AtkPray : Card_Function
{
    public int finalCount;
    public int baseAtk;
    public int atkBuffer;
    public override void Excute()
    {
        throw new NotImplementedException();
    }
}
