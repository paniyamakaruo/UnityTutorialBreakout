using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//RequireComponent　はinspectorにRigidbodyがない場合、クラス前に記載することで自動でinspectorに追加してくれる
//この一文を付け加えることでBallに必要なRigidbodyを追加している
[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour {

    //private　とはBallクラス内でしか使えない、他からアクセスできないことを指す
    //SerializeField　とはprivateでもエディタ上からでも数値を変更することができるようにする
    [SerializeField]
    private float speed = 20.0f;

	// Use this for initialization
	void Start () {
        //ここのthisはボールを指している　this.GetComponent<Rigidbody>()とはBallのinspectorのRigidbodyにアクセスしている
        this.GetComponent<Rigidbody>().AddForce(
            (this.transform.forward + this.transform.right) * this.speed,
            ForceMode.VelocityChange);
		
	}
}