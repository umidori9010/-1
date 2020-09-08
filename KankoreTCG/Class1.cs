// fread4.cs

using System;
using System.IO;
using System.Text;
using System.Collections;
//using System.Windows.Forms;

class FileRead4
{
    public string[,] mData;
    public string[,] yData;

    public void deck1()
    {

    StreamReader objReader = new StreamReader("Resources\\Decklist.csv");
        ArrayList arrText = new ArrayList();

        string sLine = ""; // ←　一時格納用
        

        // ファイルから1行ずつ読み込む
        while (sLine != null)
        {
            // ファイルから1行ずつ読み込むReadToEndでもいい
            sLine = objReader.ReadLine();
            if (sLine != null)
                arrText.Add(sLine); // addメソッドで追記
        }
        objReader.Close();
        // -----------------------------------

        // 行列数を数える
        int line_count = arrText.Count; // 行数を数えているだけ
                                        // 列数を数えるために適当な配列に格納して数えてみる
        string temp = (string)arrText[0]; // string型にキャスト
                                          // splitメソッドで文字列アレイにして数える
        string[] temp2 = temp.Split(',');
        int col_count = temp2.Length; // 列数を数えているだけ
                                      // -----------------------------------

        // ArrayListから2次元配列に格納する．
        // 2次元配列の定義
        mData = new string[line_count, col_count];
        int a = 0, b = 0;
        foreach (string sOutput in arrText)
        {
            // 一行ずつ読み込んで，各行をsplitメソッドで分ける
            string[] temp_line = sOutput.Split(',');
            foreach (string value in temp_line)
            {
                mData[a, b] = value;

                b++;
            }
            b = 0;
            a++;
        }
        //MessageBox.Show("check");
        // -----------------------------------
    }
    public void deck2()
    {

        StreamReader objReader = new StreamReader("Resources\\Decklist.csv");
        ArrayList arrText = new ArrayList();

        string sLine = ""; // ←　一時格納用


        // ファイルから1行ずつ読み込む
        while (sLine != null)
        {
            // ファイルから1行ずつ読み込むReadToEndでもいい
            sLine = objReader.ReadLine();
            if (sLine != null)
                arrText.Add(sLine); // addメソッドで追記
        }
        objReader.Close();
        // -----------------------------------

        // 行列数を数える
        int line_count = arrText.Count; // 行数を数えているだけ
                                        // 列数を数えるために適当な配列に格納して数えてみる
        string temp = (string)arrText[0]; // string型にキャスト
                                          // splitメソッドで文字列アレイにして数える
        string[] temp2 = temp.Split(',');
        int col_count = temp2.Length; // 列数を数えているだけ
                                      // -----------------------------------

        // ArrayListから2次元配列に格納する．
        // 2次元配列の定義
        yData = new string[line_count, col_count];
        int a = 0, b = 0;
        foreach (string sOutput in arrText)
        {
            // 一行ずつ読み込んで，各行をsplitメソッドで分ける
            string[] temp_line = sOutput.Split(',');
            foreach (string value in temp_line)
            {
                yData[a, b] = value;

                b++;
            }
            b = 0;
            a++;
        }
        //MessageBox.Show("check");
        // -----------------------------------
    }

}
