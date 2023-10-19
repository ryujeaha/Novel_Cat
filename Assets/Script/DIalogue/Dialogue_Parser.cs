using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Parser : MonoBehaviour
{
    public DIalogue[] Parse(string CSVFileName){
        List<DIalogue> dIalogueList = new List<DIalogue>();// 대사 리스트 생성. 파싱한 데이터 임시저장
        TextAsset csvdata = Resources.Load<TextAsset>(CSVFileName);//CSV파일을 가져 올수 있는 TEXTAsset이란 형식으로 변환후 가져옴

        string[] data = csvdata.text.Split(new char[]{'\n'});//엔터 단위로 쪼개서 저장.(한줄씩) 

        for(int i = 1; i <data.Length;){
        string[] row = data[i].Split(new char[]{','});//가로줄을 전부 콤마 단위로 구별

        DIalogue dIalogue = new DIalogue();
        dIalogue.name = row[1];

        List<string> contextlist = new List<string>(); 
       //dIalogue.conTexts = row[2];//배열은 텍스트에 바로 대입이 안되서 리스트로 실행
        /*do{
            contextlist.Add(row[2]);
        }//while(row[0].ToString == "")
        */
         if(++i < data.Length){
            ;
         }
        }
        return dIalogueList.ToArray();//배열로 변환
    }
    private void Start() {
        Parse("CAT_NOVEL");    
    }
}
