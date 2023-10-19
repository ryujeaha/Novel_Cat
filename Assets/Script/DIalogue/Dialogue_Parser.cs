using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Parser : MonoBehaviour
{
    public DIalogue[] Parse(string CSVFileName){
        List<DIalogue> dIalogueList = new List<DIalogue>();// ��� ����Ʈ ����. �Ľ��� ������ �ӽ�����
        TextAsset csvdata = Resources.Load<TextAsset>(CSVFileName);//CSV������ ���� �ü� �ִ� TEXTAsset�̶� �������� ��ȯ�� ������

        string[] data = csvdata.text.Split(new char[]{'\n'});//���� ������ �ɰ��� ����.(���پ�) 

        for(int i = 1; i <data.Length;){
        string[] row = data[i].Split(new char[]{','});//�������� ���� �޸� ������ ����

        DIalogue dIalogue = new DIalogue();
        dIalogue.name = row[1];

        List<string> contextlist = new List<string>(); 
       //dIalogue.conTexts = row[2];//�迭�� �ؽ�Ʈ�� �ٷ� ������ �ȵǼ� ����Ʈ�� ����
        /*do{
            contextlist.Add(row[2]);
        }//while(row[0].ToString == "")
        */
         if(++i < data.Length){
            ;
         }
        }
        return dIalogueList.ToArray();//�迭�� ��ȯ
    }
    private void Start() {
        Parse("CAT_NOVEL");    
    }
}
