using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraType//�������� ������ �޸��� ������ �Ѵ�
{
    ObjectFront,//ī�޶� ������Ʈ ������ ���°�
    Reset,//ī�޶� �ٽ� ���� ���·� ���ƿ��°�
    FaideOut,//���̵� �ƿ�(ȭ�� ����)
    FaidIn,//���̵� ��(ȭ�� ���� ����)
    FlashOut,//�÷��þƿ�(��½�̴� ȿ��)
    FlashIn,//�÷����ι�½�̴� ȿ������?
    ShowCutScene,//�ƾ��� �����ִ°�
    HideCutScene,//�ƽ��� ����°�
}

[System.Serializable]
public class DIalogue
{
   [Tooltip("��縦 �ϴ� ĳ������ �̸�")]//�ν����� â���� �ش� ������ ������ ���� ���� ��ɾ�
    public string name;//��縦 �ϴ� ĳ������ �̸�

    //[HideInInspector]
    [Tooltip("��系��")]//�ν����� â���� �ش� ������ ������ ���� ���� ��ɾ�
    public string[] conTexts;//����� ����(�� ĳ���Ͱ� ������ ���� �� �����Ƿ� �迭�� ����)

    [HideInInspector]
    public string[] spritename;
}

[System.Serializable]

public class DialogueEvent{

public string name;//���� �̺�Ʈ�� ��� �̺�Ʈ���� �����ϱ����� �̸�����(�� �Ĵ��̺�Ʈ,�� �̺�Ʈ)

    public Vector2 line;//X���� Y������ ��縦 �����س��� ���� ����
    public DIalogue[] dialogues;//�Ѹ��� ���ϴ� ���� �ƴ� �ٸ� �����ι����� ���̾�α׷νᵵ ����ϱ����� �迭�� ����
}
