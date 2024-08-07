using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5-1例題
            // 宣告一個陣列，用來存放 10 個數字
            // 想像一個有 10 個空盒子，我們要把輸入的數字放進這些盒子裡
            //int[] numbers = new int[10];

            //// 宣告變數，用來累加數字和以及作為迴圈索引
            //// sum 用來記錄所有數字加起來的總和，i 用來標記我們現在是處理第幾個數字
            //int sum = 0, i;

            //// 輸入 10 個數字
            //// 我們會請使用者一個一個輸入數字，並把輸入的數字放到剛剛準備好的盒子裡
            //Console.WriteLine("請輸入 10 個數字：");
            //for (i = 0; i < 10; i++)
            //{
            //    // 每次迴圈都會問使用者輸入一個數字
            //    Console.Write($"數字 {i + 1}: ");
            //    // 把使用者輸入的數字轉換成整數，並存放到對應的盒子裡
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //    // 把剛才輸入的數字加到總和裡
            //    sum += numbers[i];
            //}

            //// 計算平均值
            //// 把所有的數字加起來的總和，除以總共的數字數量 (10)，就是平均值
            //double average = (double)sum / 10;

            //// 輸出結果
            //// 把計算出來的平均值顯示在Console視窗上
            //Console.WriteLine($"這 10 個數字的平均值為：{average}");
            //Console.ReadKey();


            //5-2例題
            //我們先準備 10 個盒子，也就是 numbers 這個陣列
            //int[] numbers = new int[10];

            //// 我們要找最大的那個盒子裡的數字，所以先假設第一個盒子裡的數字最大。
            //int max = 0;

            //// 我們一個一個把數字放進盒子裡。
            //Console.WriteLine("請輸入 10 個數字：");
            //for (int i = 0; i < 10; i++)   //這是一個迴圈，這裡的 i 就像是一個標號，從第一個盒子開始檢查，一直到第十個盒子。
            //{
            //    Console.Write($"數字 {i + 1}: ");  //每次迴圈，都顯示「請輸入第幾個數字？」，比如第一次是「請輸入第 1 個數字：」，第二次是「請輸入第 2 個數字：」，以此類推。
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());  //numbers[i] =：最後，我們把這個數字放到第 i 個盒子裡。
            //}

            //// 我們要檢查每個盒子裡的數字，看看有沒有比我們一開始假設的最大數字還大的。
            //for (int i = 0; i < 10; i++)
            //{
            //    // 如果這個盒子的數字比我們之前找到的最大數字還大，
            //    // 我們就把這個數字當作新的最大數字。
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            //// 最後找到最大的數字是哪一個。
            //Console.WriteLine($"這 10 個數字中的最大值是：{max}");
            //Console.ReadKey();


            //5-3例題
            //double[] A = new double[10];  // 宣告一個可以存放 10 個雙精度浮點數的陣列，命名為 A
            //double x;                     // 宣告一個變數 x，用來儲存要查找的數字
            //bool found = false;          // 宣告一個布林變數 found，初始為 false，用來表示是否找到目標數字

            //// 輸入 10 個數字
            //Console.WriteLine("請輸入 10 個數字:");
            //for (int i = 0; i < A.Length; i++)  //從 0 開始，一直重複執行迴圈體內的程式碼，直到 i 的值等於或大於陣列 A 的長度。每一次迴圈，變數 i 的值都會增加 1，代表我們正在處理陣列 A 中的下一個元素。
            //{
            //    Console.Write($"請輸入第 {i + 1} 個數字:");  // 提示使用者輸入第 i+1 個數字
            //    A[i] = Convert.ToDouble(Console.ReadLine()); // 讀取使用者輸入的數字，轉換成雙精度浮點數，並存入陣列 A 的第 i 個位置
            //}

            //// 輸入要查找的數字
            //Console.WriteLine("請輸入要查找的數字 x:");
            //x = Convert.ToDouble(Console.ReadLine()); // 讀取使用者輸入的數字，轉換成雙精度浮點數，並存入變數 x

            //// 搜尋數字
            //for (int i = 0; i < A.Length && !found; i++)  // 這個迴圈會一直執行，直到找到目標數字或遍歷完整個陣列
            //{
            //    if (A[i] == x)  // 如果陣列 A 的第 i 個元素等於要查找的數字 x
            //    {
            //        found = true; // 將 found 設為 true，表示找到目標數字
            //        Console.WriteLine($"數字 {x} 存在於陣列中的索引 {i}"); // 輸出找到的訊息，並顯示索引位置
            //    }
            //}

            //// 判斷是否找到
            //if (!found)  // 如果 found 仍然為 false，表示沒有找到目標數字
            //{
            //    Console.WriteLine($"數字 {x} 不存在於陣列中");
            //}

            //Console.ReadKey();


            //5-4例題
            // 想像我們有三個格子，每個格子裡可以放很多數字。
            //我們把這三個格子分別叫做 A、B、C。
            //int[,] matrixA = new int[2, 3];
            //int[,] matrixB = new int[2, 3];
            //int[,] matrixC = new int[2, 3];

            //// 輸入矩陣 A 的元素
            //Console.WriteLine("請輸入矩陣 A 的元素：");
            //for (int i = 0; i < 2; i++)   // 外面這一圈迴圈是為了每一行
            //{
            //    for (int j = 0; j < 3; j++) // 裡面這一圈迴圈是為了每一列
            //    {
            //        Console.Write($"A[{i},{j}] = ");   // 我們問你：「A[i,j] 這個位置要填什麼數字？」
            //        if (!int.TryParse(Console.ReadLine(), out matrixA[i, j])) // 你輸入的數字會放在 A[i,j] 這個位置
            //        {
            //            Console.WriteLine("輸入格式錯誤，請重新輸入數字！"); // 如果你的輸入不是數字，我們會再請你輸入一次
            //            j--; // 重新輸入當前元素
            //        }
            //    }
            //}

            //// 輸入矩陣 B 的元素
            //Console.WriteLine("請輸入矩陣 B 的元素："); // 在螢幕上顯示這句話，請使用者輸入數字
            //for (int i = 0; i < 2; i++) // 外層迴圈，控制行的次數
            //{
            //    for (int j = 0; j < 3; j++) // 內層迴圈，控制列的次數
            //    {
            //        Console.Write($"B[{i},{j}] = "); // 顯示要輸入的位置，例如 B[0,0]
            //        if (!int.TryParse(Console.ReadLine(), out matrixB[i, j])) // 檢查輸入是否為數字
            //        {
            //            Console.WriteLine("輸入格式錯誤，請重新輸入數字！"); // 如果不是數字，提醒使用者
            //            j--; // 讓使用者重新輸入同一個位置
            //        }
            //    }
            //}

            //// 計算兩個矩陣的和，並存入矩陣 C
            //Console.WriteLine("正在計算兩個矩陣的和..."); // 告訴使用者程式正在運算
            //for (int i = 0; i < 2; i++) // 外層迴圈，控制行的次數
            //{
            //    for (int j = 0; j < 3; j++) // 內層迴圈，控制列的次數
            //    {
            //        matrixC[i, j] = matrixA[i, j] + matrixB[i, j]; // 將 A 和 B 對應位置的數字相加，結果存入 C
            //    }
            //}

            //// 輸出矩陣 C 的內容
            //Console.WriteLine("矩陣 C 的內容為："); // 顯示計算結果
            //for (int i = 0; i < 2; i++) // 外層迴圈，控制行的次數
            //{
            //    for (int j = 0; j < 3; j++) // 內層迴圈，控制列的次數
            //    {
            //        Console.Write($"{matrixC[i, j]}\t"); // 輸出 C 格子裡的數字，用 tab 分隔
            //    }
            //    Console.WriteLine(); // 換行
            //}
            //Console.ReadKey();


            //5-5例題
            // 宣告三個矩陣，分別是 A (2x3), B (3x1), C (2x1)
            //int[,] matrixA = new int[2, 3];  
            //int[,] matrixB = new int[3, 1];  
            //int[,] matrixC = new int[2, 1];  

            //// 輸入矩陣 A 的元素
            //Console.WriteLine("請輸入矩陣 A 的數值 (2x3):");  // 在電腦螢幕上顯示這句話，請你輸入數字給表格 A
            //for (int i = 0; i < 2; i++)  // 重複做下面的事情 2 次，每次換一行
            //{
            //    for (int j = 0; j < 3; j++)  // 重複做下面的事情 3 次，每次換一列
            //    {
            //        Console.Write($"A[{i},{j}] = ");  // 顯示要輸入的數字的位置，例如 A[0,0]
            //        try
            //        {
            //            matrixA[i, j] = Convert.ToInt32(Console.ReadLine()); // 把你輸入的數字存到表格 A 的指定位置
            //        }
            //        catch (FormatException) // 如果輸入的不是數字，就會發生錯誤
            //        {
            //            Console.WriteLine("輸入格式錯誤，請重新輸入數字！"); // 告訴你輸入錯了，請再輸入一次
            //            j--;  // 因為輸入錯了，所以這一列要重新輸入，所以 j 要減 1
            //        }
            //    }
            //}

            //// 輸入矩陣 B 的元素
            //Console.WriteLine("請輸入矩陣 B 的數值 (3x1):");  // 在電腦螢幕上顯示這句話，請你輸入數字給表格 B
            //for (int i = 0; i < 3; i++)  // 重複做下面的事情 3 次，每次換一行
            //{
            //    for (int j = 0; j < 1; j++)  // 重複做下面的事情 1 次，因為 B 只有 1 列
            //    {
            //        Console.Write($"B[{i},{j}] = ");  // 顯示要輸入的數字的位置，例如 B[0,0]
            //        try
            //        {
            //            matrixB[i, j] = Convert.ToInt32(Console.ReadLine()); // 把你輸入的數字存到表格 B 的指定位置
            //        }
            //        catch (FormatException) // 如果輸入的不是數字，就會發生錯誤
            //        {
            //            Console.WriteLine("輸入格式錯誤，請重新輸入數字！"); // 告訴你輸入錯了，請再輸入一次
            //            j--;  // 因為輸入錯了，所以這一列要重新輸入，所以 j 要減 1
            //        }
            //    }
            //}

            //// 計算矩陣 A 和 B 的乘積，結果存入矩陣 C
            //Console.WriteLine("正在計算兩個表格的乘法...");  // 在螢幕上顯示這句話，告訴你電腦正在計算

            //for (int i = 0; i < matrixA.GetLength(0); i++)  // 針對表格 A 的每一行，從第一行開始，一直到最後一行
            //{
            //    for (int j = 0; j < matrixB.GetLength(1); j++)  // 針對表格 B 的每一列，從第一列開始，一直到最後一列
            //    {
            //        matrixC[i, j] = 0;  // 把表格 C 對應位置的值先設為 0，準備累加計算結果
            //        for (int k = 0; k < matrixA.GetLength(1); k++)  // 針對表格 A 的每一列，進行一次計算
            //        {
            //            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];  
            //                                                             // 將 A 表格第 i 行第 k 列的值，乘上 B 表格第 k 行第 j 列的值，
            //                                                             // 再把這個乘積加到 C 表格第 i 行第 j 列的值上
            //        }
            //    }
            //}

            //// 輸出矩陣 C 的內容
            //Console.WriteLine("計算完畢，結果如下：");  
            //for (int i = 0; i < matrixC.GetLength(0); i++)  // 針對表格 C 的每一行
            //{
            //    for (int j = 0; j < matrixC.GetLength(1); j++)  // 針對表格 C 的每一列
            //    {
            //        Console.WriteLine($"C[{i},{j}] = {matrixC[i, j]}");  // 顯示 C 表格中的每個值
            //    }
            //}

            //Console.ReadKey();


            //5-1習題
            //1.宣告一個可以存放 10 個數字的陣列 A
            //int[] A = new int[10];

            //// 2. 輸入 10 個數字到陣列 A 中
            //Console.WriteLine("請輸入 10 個數字：");
            //for (int i = 0; i < 10; i++)  //這個迴圈會重複執行 10 次，每次迴圈都會處理陣列 A 中的一個元素。
            //{
            //    Console.Write($"A[{i}] = "); //這行程式會在螢幕上顯示要輸入的數字的位置，例如「A[0] = 」
            //    A[i] = Convert.ToInt32(Console.ReadLine());  //這行程式會讀取使用者輸入的數字，並將其存入陣列 A 的對應位置
            //}

            //// 3. 檢查每個數字，並根據大小進行調整
            //for (int i = 0; i < 10; i++)  //這個迴圈會重複執行 10 次，每次迴圈都會輸出陣列 A 中的一個元素。
            //{
            //    if (A[i] > 5) //這行程式會檢查陣列 A 中的每個數字是否大於 5。
            //    {
            //        // 如果數字大於 5，就減去 5
            //        A[i] -= 5;
            //    }
            //    else
            //    {
            //        // 如果數字小於等於 5，就加上 5
            //        A[i] += 5;
            //    }
            //}

            //// 4. 輸出調整後的陣列
            //Console.WriteLine("調整後的陣列：");
            //for (int i = 0; i < 10; i++)  //這個迴圈會重複執行 10 次，每次迴圈都會輸出陣列 A 中的一個元素。
            //{
            //    Console.WriteLine($"A[{i}] = {A[i]}"); //這行程式會將陣列 A 中的每個元素的值輸出到螢幕上。
            //}

            //Console.ReadKey();


            //5-2習題
            // 1. 準備一個可以放 10 個數字的盒子 (陣列 A)
            //int[] A = new int[10]; // 宣告一個名為 A 的陣列，可以存放 10 個整數

            //// 2. 把數字放進盒子裡
            //Console.WriteLine("請輸入 10 個數字："); // 在螢幕上顯示提示訊息，讓使用者知道要輸入 10 個數字
            //for (int i = 0; i < 10; i++) // 這個迴圈會重複 10 次，每次 i 的值會從 0 增加到 9
            //{
            //    Console.Write($"A[{i}] = "); // 顯示要輸入的數字的位置，例如 A[0] = 
            //    A[i] = Convert.ToInt32(Console.ReadLine()); // 讀取使用者輸入的數字，並將其轉換為整數，存入陣列 A 的第 i 個位置
            //}

            //// 3. 對每個數字做加法，並把結果放回原來的格子
            //for (int i = 0; i < 10; i++) // 這個迴圈會重複 10 次，每次 i 的值會從 0 增加到 9
            //{
            //    A[i] = A[i] + i; // 將陣列 A 的第 i 個元素的值加上 i，然後將結果存回 A[i]
            //}

            //// 4. 把加完後的數字拿出來看
            //Console.WriteLine("加完後的數字："); // 顯示"加完後的數字："這個字串
            //for (int i = 0; i < 10; i++) // 這個迴圈會重複 10 次，每次 i 的值會從 0 增加到 9
            //{
            //    Console.WriteLine($"A[{i}] = {A[i]}"); // 顯示陣列 A 的第 i 個元素的值
            //}

            //Console.ReadKey();


            //5-3習題
            //// 1. 宣告兩個長度為 10 的整數陣列 A 和 B
            //int[] A = new int[10];
            //int[] B = new int[10];

            //// 2. 讓使用者輸入 10 個數字，並將這些數字存入陣列 A 中
            //// 告訴使用者要輸入 10 個數字
            //Console.WriteLine("請輸入 10 個數字：");

            ////  啟動一個迴圈，讓使用者輸入 10 個數字
            //for (int i = 0; i < 10; i++)
            //{
            //    // 顯示提示訊息，例如 "A[0] = "
            //    Console.Write($"A[{i}] = ");

            //    //  讀取使用者輸入的數字，並將其存入陣列 A 的第 i 個位置
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //// 3. 判斷 A 陣列中的每個數字是否大於等於 0，並將結果存入 B 陣列
            //for (int i = 0; i < 10; i++)
            //{
            //    // 判斷 A 陣列中第 i 個元素是否大於等於 0
            //    if (A[i] >= 0)
            //    {
            //        // 如果 A[i] 大於等於 0，則將 B 陣列的對應位置設為 1
            //        B[i] = 1;
            //    }
            //    else
            //    {
            //        // 如果 A[i] 小於 0，則將 B 陣列的對應位置設為 0
            //        B[i] = 0;
            //    }
            //}

            //// 4. 輸出 B 陣列的內容
            //Console.WriteLine("B 陣列的內容：");
            //// 這行會在螢幕上顯示 "B 陣列的內容：" 這句話，告訴我們接下來要輸出的是 B 陣列的內容。

            //for (int i = 0; i < 10; i++)
            //{
            //    // 這個 for 迴圈會重複執行 10 次，每次執行時，i 的值會從 0 增加到 9。
            //    // 迴圈的目的在於遍歷 B 陣列中的每個元素，並將其輸出到螢幕上。

            //    Console.WriteLine($"B[{i}] = {B[i]}");
            //    // 這行會輸出 B 陣列中第 i 個元素的值。
            //    // $"B[{i}] = {B[i]}" 是 C# 的格式化字串，會將 i 和 B[i] 的值分別替換到 {} 中。
            //    // 例如，當 i 為 0 時，這行會輸出 "B[0] = (B[0] 的值)"。
            //}

            //Console.ReadKey();


            //5-4習題
            //// 1. 宣告一個 3x5 的二維整數陣列 A，用來儲存 15 個數字
            //int[,] A = new int[3, 5]; // 宣告一個 3 行 5 列的二維陣列

            //// 2. 讓使用者輸入 15 個數字，並將其存入陣列 A 中
            //Console.WriteLine("請輸入 15 個數字：");
            //for (int i = 0; i < 3; i++) // 外層迴圈控制行
            //{
            //    for (int j = 0; j < 5; j++) // 內層迴圈控制列
            //    {
            //        Console.Write($"A[{i},{j}] = "); // 提示使用者輸入第 i 行第 j 列的數字
            //        A[i, j] = Convert.ToInt32(Console.ReadLine()); // 讀取使用者輸入，並將其轉換為整數存入陣列
            //    }
            //}

            //// 3. 宣告兩個一維整數陣列，分別用來儲存每一行和每一列的和
            //int[] rowSum = new int[3]; // 宣告一個長度為 3 的陣列，用來儲存每一行的和
            //int[] colSum = new int[5]; // 宣告一個長度為 5 的陣列，用來儲存每一列的和

            //// 4. 計算每一行的和
            //for (int i = 0; i < 3; i++) // 外層迴圈遍歷每一行
            //{
            //    for (int j = 0; j < 5; j++) // 內層迴圈遍歷每一列
            //    {
            //        rowSum[i] += A[i, j]; // 將當前元素的值加到對應行的和中
            //    }
            //}

            //// 5. 計算每一列的和
            //for (int j = 0; j < 5; j++) // 外層迴圈遍歷每一列
            //{
            //    for (int i = 0; i < 3; i++) // 內層迴圈遍歷每一行
            //    {
            //        colSum[j] += A[i, j]; // 將當前元素的值加到對應列的和中
            //    }
            //}

            //// 6. 輸出結果
            //Console.WriteLine("每一行的和：");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"第 {i + 1} 行的和為：{rowSum[i]}"); // 輸出每一行的和
            //}

            //Console.WriteLine("每一列的和：");
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine($"第 {j + 1} 列的和為：{colSum[j]}"); // 輸出每一列的和
            //}

            //Console.ReadKey();

            //5-5習題
            //// 1. 宣告一個 3x5 的二維整數陣列 A，用來儲存 15 個數字
            //int[,] A = new int[3, 5]; // 宣告一個 3 行 5 列的二維陣列

            //// 2. 讓使用者輸入 15 個數字，並將其存入陣列 A 中
            //Console.WriteLine("請輸入 15 個數字：");
            //for (int i = 0; i < 3; i++) // 外層迴圈控制行
            //{
            //    for (int j = 0; j < 5; j++) // 內層迴圈控制列
            //    {
            //        Console.Write($"A[{i},{j}] = "); // 提示使用者輸入第 i 行第 j 列的數字
            //        A[i, j] = Convert.ToInt32(Console.ReadLine()); // 讀取使用者輸入，並將其轉換為整數存入陣列
            //    }
            //}

            //// 3. 宣告兩個一維整數陣列，分別用來儲存每一行和每一列的最小值
            //int[] rowMin = new int[3]; // 宣告一個長度為 3 的陣列，用來儲存每一行的最小值
            //int[] colMin = new int[5]; // 宣告一個長度為 5 的陣列，用來儲存每一列的最小值

            //// 4. 找出每一行的最小值
            //for (int i = 0; i < 3; i++) // 外層迴圈遍歷每一行
            //{
            //    rowMin[i] = A[i, 0]; // 將第一個元素暫時設為最小值
            //    for (int j = 1; j < 5; j++) // 內層迴圈遍歷每一列，從第二個元素開始比較
            //    {
            //        if (A[i, j] < rowMin[i]) // 如果當前元素比目前行的最小值還小
            //        {
            //            rowMin[i] = A[i, j]; // 則更新最小值
            //        }
            //    }
            //}

            //// 5. 找出每一列的最小值
            //for (int j = 0; j < 5; j++) // 外層迴圈遍歷每一列
            //{
            //    colMin[j] = A[0, j]; // 將第一個元素暫時設為最小值
            //    for (int i = 1; i < 3; i++) // 內層迴圈遍歷每一行，從第二個元素開始比較
            //    {
            //        if (A[i, j] < colMin[j]) // 如果當前元素比目前行的最小值還小
            //        {
            //            colMin[j] = A[i, j]; // 則更新最小值
            //        }
            //    }
            //}

            //// 6. 輸出結果
            //Console.WriteLine("每一行的最小值：");
            //for (int i = 0; i < 3; i++)  //這個迴圈會遍歷陣列中的每一行
            //{
            //    Console.WriteLine($"第 {i + 1} 行的最小值為：{rowMin[i]}"); // 輸出每一行的最小值
            //}

            //Console.WriteLine("每一列的最小值：");
            //for (int j = 0; j < 5; j++)  //這個迴圈會遍歷陣列中的每一列
            //{
            //    Console.WriteLine($"第 {j + 1} 列的最小值為：{colMin[j]}"); // 輸出每一列的最小值
            //}

            //Console.ReadKey();


            //5-6習題
            //// 1. 宣告兩個陣列，每個陣列可以儲存 5 個數字
            //int[] a = new int[5]; // 宣告一個名為 a 的陣列，用來儲存第一組數字
            //int[] b = new int[5]; // 宣告一個名為 b 的陣列，用來儲存第二組數字

            //// 2. 讓使用者輸入第一組數字，並將它們存入陣列 a 中
            //Console.WriteLine("請輸入5個數字，分別存入陣列a：");
            //for (int i = 0; i < 5; i++) // 迴圈會重複 5 次，每次輸入一個數字
            //{
            //    Console.Write($"a[{i}] = "); // 提示使用者輸入第 i 個數字
            //    a[i] = Convert.ToInt32(Console.ReadLine()); // 讀取使用者輸入的數字，並將其存入陣列 a 的第 i 個位置
            //}

            //// 3. 讓使用者輸入第二組數字，並將它們存入陣列 b 中
            //Console.WriteLine("請輸入5個數字，分別存入陣列b：");
            //for (int i = 0; i < 5; i++) // 迴圈會重複 5 次，每次輸入一個數字
            //{
            //    Console.Write($"b[{i}] = "); // 提示使用者輸入第 i 個數字
            //    b[i] = Convert.ToInt32(Console.ReadLine()); // 讀取使用者輸入的數字，並將其存入陣列 b 的第 i 個位置
            //}

            //// 4. 將兩個陣列中對應位置的數字相加，並輸出結果
            //Console.WriteLine("兩個陣列中對應位置的數字相加的結果：");
            //for (int i = 0; i < 5; i++) // 迴圈會重複 5 次，每次計算一對數字的和
            //{
            //    int sum = a[i] + b[i]; // 將 a[i] 和 b[i] 相加，結果存入 sum
            //    Console.WriteLine($"a[{i}] + b[{i}] = {sum}"); // 輸出計算結果
            //}

            //Console.ReadKey();


            //5-7習題
            // 宣告兩個整數陣列，用來儲存使用者輸入的數字
            int[] a = new int[5]; // 宣告一個長度為 5 的整數陣列 a，用來儲存第一組數字
            int[] b = new int[5]; // 宣告一個長度為 5 的整數陣列 b，用來儲存第二組數字

            // 宣告變數，用來儲存兩個陣列中的最大值
            int max_a = 0; // 初始化 a 陣列中的最大值為 0
            int max_b = 0; // 初始化 b 陣列中的最大值為 0

            // 輸入陣列 a 的元素
            Console.WriteLine("請輸入5個數字，分別存入陣列a：");
            for (int i = 0; i < 5; i++) // 迴圈執行 5 次，每次輸入一個數字
            {
                Console.Write($"a[{i}] = "); // 提示使用者輸入第 i 個數字
                a[i] = Convert.ToInt32(Console.ReadLine()); // 將使用者輸入的字串轉換為整數，存入陣列 a 的第 i 個位置
                if (a[i] > max_a) // 如果輸入的數字大於目前 a 陣列中的最大值
                {
                    max_a = a[i]; // 更新 a 陣列中的最大值
                }
            }

            // 輸入陣列 b 的元素
            Console.WriteLine("請輸入5個數字，分別存入陣列b：");
            for (int i = 0; i < 5; i++)  // 迴圈執行 5 次，每次輸入一個數字
            {
                Console.Write($"b[{i}] = "); // 提示使用者輸入第 i 個數字
                b[i] = Convert.ToInt32(Console.ReadLine()); // 將使用者輸入的字串轉換為整數，存入陣列 b 的第 i 個位置
                if (b[i] > max_b)  // 如果輸入的數字大於目前 b 陣列中的最大值
                {
                    max_b = b[i]; // 更新 b 陣列中的最大值
                }
            }

            // 比較兩個陣列的最大值，並輸出較小者
            int smallerMax;
            if (max_a < max_b) // 如果 a 陣列的最大值比 b 陣列的小
            {
                smallerMax = max_a; // 則 smallerMax 等於 max_a
            }
            else
            {
                smallerMax = max_b; // 否則，smallerMax 等於 max_b
            }
            Console.WriteLine($"兩個陣列中最大的較小值是：{smallerMax}");

            Console.ReadKey();

        }
    }
}








