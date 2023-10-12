using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DIalogue
{
    [Tooltip("��� ġ�� ĳ���� �̸�")]
    public string name;
    [Tooltip("��� ����")]
    public string[] context;//��纯��
}

[System.Serializable]

public class DialogueEvent{

    public string name;

    public Vector2 line;
    public DIalogue[] dIalogues;
}
