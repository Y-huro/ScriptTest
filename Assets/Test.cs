using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        // 変数初期化
        int money = 100;

        if(money <= 50)
        {
            // moneyが50以下だった場合
            Debug.Log("武器を売る");
        }
        else if(money >= 200)
        {
            // moneyが200以上だった場合
            Debug.Log("武器を買う");
        }
        else
        {
            // それ以外の場合の処理
            Debug.Log("ポーションを買う");
        }*/

        /*
        // numを1で初期化する
        int num = 1;

        // valに代入する値を条件によって変える(三項演算子)
        int val = (num == 1) ? -100 : 100;

        // valの値を表示する
        Debug.Log(val);*/

        /*
        // 変数aを3で初期化する
        int a = 3;
        if(a == 3)
        {
            int b = 5;
            Debug.Log(b);
        }*/

        /*
        int sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
        */

        /*
        int[] points = new int[5];

        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;
        // int[] points = {30,20,50,10,80,15,60,100};

        for(int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }*/

        /*
        int num = Add(3, 6, 1);
        Debug.Log(num);*/

        // ボスクラス
        Boss lastboss = new Boss();
        // lastboss.Attack();
        // lastboss.Defence(3);

        // Midboss midboss = new Midboss();
        // midboss.Attack();
        // midboss.Defence(5);


        // 課題(配列の宣言・出力)
        int[] array = {86,413,1,9375,222};
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("順番に表示：" + array[i]);
        }
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log("逆順に表示：" + array[array.Length - i - 1]);
        }

        // 課題(BossクラスのMagic関数実行)
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    void Goodbye()
    {
        Debug.Log("Goodbye, UnityChan"); 
    }
    void HelloName(int name)
    {
        Debug.Log("Hello," + name);
    }
    int Add(int a, int b, int c)
    {
        int d = a + b + c;
        return d;
    }
    public class Midboss
    {
        private int hp = 30;
        private int power = 10;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }
    }
    public class Boss
    {
        private int hp = 100;
        private int mp = 53;
        private int power = 25;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }
        public void Magic()
        {
            if (this.mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
