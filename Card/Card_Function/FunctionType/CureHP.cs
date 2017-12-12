using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CureHPDefine", menuName = "ProjectFullMoon/FunctionTypeDefine/CureHPDefine")]
public class CureHP : Card_Function
{
    public TargetType targetType;
    public int cureValue;
    public override void Excute()
    {
        throw new NotImplementedException();
    }
}
