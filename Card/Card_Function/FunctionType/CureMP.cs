using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CureMPDefine", menuName = "ProjectFullMoon/FunctionTypeDefine/CureMPDefine")]
public class CureMP : Card_Function
{
    public TargetType target;
    public int cureValue;

    public override void Excute()
    {
        throw new NotImplementedException();
    }
}
