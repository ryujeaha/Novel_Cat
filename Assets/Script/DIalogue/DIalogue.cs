using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DIalogue
{
    [Tooltip("대사 치는 캐릭터 이름")]
    public string name;
    [Tooltip("대사 내용")]
    public string[] context;//대사변수
}

[System.Serializable]

public class DialogueEvent{

    public string name;

    public Vector2 line;
    public DIalogue[] dIalogues;
}
