using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wee2_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-1 例題 while 讀入五個整數，求這五個整數的和
            //Console.WriteLine("請輸入五個數值。");

            //int n = 5;
            //int sum = 0;
            //int i = 1;

            //while (i <= n)
            //{
            //    Console.WriteLine($"第{i}個數值為");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + num; // 將輸入的數字加到 sum 中
            //    i++; // 增加計數器 i
            //}

            //Console.WriteLine($"答案是{sum}");
            //Console.ReadKey();


            //3-2 例題 for 求N個整數的和，N由使用者輸入
            //Console.WriteLine("請輸入要輸入的整數個數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"第{i}個數值為:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num; // 將輸入的數字加到 sum 中
            //}

            //Console.WriteLine($"答案是{sum}");
            //Console.ReadKey();


            //3-2 例題 while 求N個整數的和，N由使用者輸入
            //Console.WriteLine("請輸入要輸入的整數個數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //int i = 1;

            //while (i <= n)
            //{
            //    Console.WriteLine($"第{i}個數值為:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + num; // 將輸入的數字加到 sum 中
            //    i++; // 增加計數器 i
            //}

            //Console.WriteLine($"答案是{sum}");
            //Console.ReadKey();

            //3-3例題 while 假設有N個正整數，求其中的最大值
            //Console.WriteLine("請輸入整數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int max = 0;
            //int i = 1;

            //while (i <= n)
            //{
            //    Console.WriteLine($"第{i}個值");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    i++; // 增加計數器 i
            //}

            //Console.WriteLine($"最大值為 {max}");
            //Console.ReadKey();


            //3-1習題 for 輸入10個整數，求其最小值
            //Console.WriteLine("請輸入10個整數：");
            //int MIN = int.MaxValue; // 初始化 MIN 為最大整數值 (int.MaxValue 表示 C# 中 32 位整數變量所能存儲的最大值。通過將 min 初始化為此值，我們可以保證第一個輸入整數將始終被視為迄今為止的最小值，然後我們可以在遇到任何後續輸入整數時更新 min 如果它們更小)

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"輸入第 {i} 個數字：");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (i == 1 || tmp < MIN) //如果 i 等於 1 或者 tmp 小於 MIN，則會執行 MIN = tmp;，即更新 MIN 的值為 tmp
            //    {
            //        MIN = tmp; // 則 min 的值更新為使用者輸入的數字。
            //    }
            //}
            //Console.WriteLine($"最小值為: {MIN}");
            //Console.ReadKey();


            //3-4 例題 for 假設有N個正整數，求最大奇數值
            //Console.WriteLine("請輸入正整數的個數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int max = int.MinValue; // 初始化最大奇數值為最小整數值

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num % 2 != 0 && num > max) // 如果是奇數且大於目前的最大奇數值
            //    {
            //        max = num;
            //    }
            //}

            //if (max == int.MinValue)
            //{
            //    Console.WriteLine("沒有輸入奇數。");
            //}
            //else
            //{
            //    Console.WriteLine($"最大奇數值為: {max}");
            //}

            //Console.ReadKey();


            //3-4 例題 while 假設有N個正整數，求最大奇數值
            //Console.WriteLine("請輸入正整數的個數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int max = int.MinValue; // 初始化最大奇數值為最小整數值
            //int i = 1;

            //while (i <= n)
            //{
            //    Console.WriteLine($"請輸入第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num % 2 != 0 && num > max) // 如果是奇數且大於目前的最大奇數值
            //    {
            //        max = num;
            //    }
            //    i++; // 增加計數器 i
            //}

            //if (max == int.MinValue)
            //{
            //    Console.WriteLine("沒有輸入奇數。");
            //}
            //else
            //{
            //    Console.WriteLine($"最大奇數值為: {max}");
            //}

            //Console.ReadKey();

            //3-5 例題 for 求N階層，即求123…N。請求輸入N，讓for迴圈自2依序乘到N
            //Console.WriteLine("請輸入整數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n < 0)        //如果 n 小於 0，則結束程式。這是因為階層只對非負整數定義（即 n >= 0）
            //{
            //    return;
            //}
            //int value = 1;
            //for (int i = 2; i < n + 1; i++)   //使用 for 迴圈從 2 到 n 進行迭代，計算階層值 value *= i; 將 value 與當前的 i 相乘，並更新 value。這樣，每次迴圈都將 value 乘上 i。
            //{
            //    value *= i;
            //}
            //Console.WriteLine($"{n}階層為{value}");
            //Console.ReadKey();


            //3-5 例題 while 求N階層，即求123…N。請求輸入N，讓for迴圈自2依序乘到N
            //Console.WriteLine("請輸入整數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n < 0) // 如果 n 小於 0，則結束程式
            //{
            //    return;
            //}

            //int value = 1;
            //int i = 2;

            //// 使用 while 迴圈從 2 乘到 n
            //while (i <= n)
            //{
            //    value *= i; // 將 value 與當前的 i 相乘，並更新 value
            //    i++; // 增加計數器 i
            //}

            //Console.WriteLine($"{n} 階層為 {value}");
            //Console.ReadKey();


            //3-6 for 99乘法
            //Console.WriteLine("99 乘法表:");
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int result = i * j;
            //        Console.WriteLine($"{i}*{j}={result}");
            //    }
            //}
            //Console.ReadKey();

            //3-6 while 99乘法
            //Console.WriteLine("99 乘法表:");

            //int i = 1; // 初始化外層計數器
            //while (i <= 9)
            //{
            //    int j = 1; // 初始化內層計數器
            //    while (j <= 9)
            //    {
            //        int result = i * j;
            //        Console.WriteLine($"{i}*{j}={result}");
            //        j++; // 增加內層計數器
            //    }
            //    i++; // 增加外層計數器
            //}

            //Console.ReadKey();


            //3-7 for 99乘法改寫輸出排版
            //Console.WriteLine("99 乘法表:");
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int result = i * j;
            //        // 打印每一個乘法表的元素
            //        // 使用 \t 來對齊結果
            //        Console.Write($"{i}*{j}={result}\t");
            //    }
            //    // 每行結束後換行
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            //3-7 while 99乘法改寫輸出排版
            //Console.WriteLine("99 乘法表:");

            //int i = 1;
            //// 外層 while 迴圈控制行數
            //while (i <= 9)
            //{
            //    int j = 1;
            //    // 內層 while 迴圈控制列數
            //    while (j <= 9)
            //    {
            //        int result = i * j;
            //        // 打印每一個乘法表的元素
            //        Console.Write($"{i}*{j}={result}\t");
            //        j++;
            //    }
            //    // 每行結束後換行
            //    Console.WriteLine();
            //    i++;
            //}
            //Console.ReadKey ();


            //3-1 習題 while 輸入10個整數，求其最小值
            //Console.WriteLine("請輸入10個整數：");
            //int min = int.MaxValue;
            //int count = 1;

            //while (count <= 10)
            //{
            //    Console.WriteLine($"請輸入第{count}個數字：");
            //    int tmp = Convert.ToInt32(Console.ReadLine());

            //    if (tmp < min) //如果使用者輸入的數字小於 min，
            //    {
            //        min = tmp; //則將 min 的值更新為使用者輸入的數字。
            //    }

            //    count++;
            //}

            //Console.WriteLine($"最小值為：{min}");
            //Console.ReadKey();


            //3-2 習題 for 輸入N個整數，求其最小值
            //Console.WriteLine("請輸入整數數量：");        //要求輸入N個數值
            //int n = Convert.ToInt32(Console.ReadLine());

            //int min = int.MaxValue;  // 初始化 MIN 為最大整數值
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i} 個整數：");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num < min) //如果使用者輸入的數字小於 min，
            //    {
            //        min = num; //則將 min 的值更新為使用者輸入的數字。
            //    }
            //}

            //Console.WriteLine($"最小值為：{min}");
            //Console.ReadKey();


            //3-2 習題 while 輸入N個整數，求其最小值
            //Console.WriteLine("請輸入整數數量：");        //要求輸入N個數值
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //int min = int.MaxValue;  // 初始化 MIN 為最大整數值
            //while (count < n)
            //{
            //    Console.WriteLine($"請輸入第 {count} 個整數：");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num < min) //如果使用者輸入的數字小於 min，
            //    {
            //        min = num; //則將 min 的值更新為使用者輸入的數字。
            //    }

            //    count++;
            //}

            //Console.WriteLine($"最小值為：{min}");
            //Console.ReadKey();


            //3-3 習題 for輸入10個整數，列出其中所有大於12的數字。

            // 宣告一個空字串變數來儲存大於12的數字
            //string output = "";

            //// 提示使用者輸入10個整數
            //Console.WriteLine("請輸入10個整數：");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i} 個整數：");
            //    int temp;

            //    // 確保輸入的是有效的整數
            //    if (int.TryParse(Console.ReadLine(), out temp))
            //    {
            //        // 如果數字大於12，將其加入到輸出字串中
            //        if (temp > 12)
            //        {
            //            output += temp + " ";
            //        }
            //    }
            //    else
            //    {
            //        // 如果輸入無效，提示重新輸入
            //        Console.WriteLine($"輸入無效，請重新輸入第 {i} 個整數：");
            //        i--; // 減少計數器以便重新輸入這一個數字
            //    }
            //}

            //// 列出所有大於12的數字
            //Console.WriteLine("所有大於12的數字有：" + output);
            //Console.ReadKey();


            //3-3 習題 while 輸入10個整數，列出其中所有大於12的數字。
            // 宣告一個空字串變數來儲存大於12的數字
            //string output = "";

            //// 提示使用者輸入10個整數
            //Console.WriteLine("請輸入10個整數：");

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine($"請輸入第 {i} 個整數：");
            //    int temp;

            //    // 確保輸入的是有效的整數
            //    if (int.TryParse(Console.ReadLine(), out temp))
            //    {
            //        // 如果數字大於12，將其加入到輸出字串中
            //        if (temp > 12)
            //        {
            //            output += temp + " ";
            //        }
            //        i++; // 只有在有效輸入時才增加計數器
            //    }
            //    else
            //    {
            //        // 如果輸入無效，提示重新輸入
            //        Console.WriteLine($"輸入無效，請重新輸入第{i}個整數：");
            //    }
            //}

            //// 列出所有大於12的數字
            //Console.WriteLine("所有大於12的數字有：" + output);
            //Console.ReadKey();


            //3-4 習題 for 輸入10個整數，列出其中所有大於12的數字的總和。
            // 宣告一個空字串變數來儲存大於12的數字，以及一個整數變數來儲存總和
            //string output = "";
            //int sum = 0;

            //// 提示使用者輸入10個整數
            //Console.WriteLine("請輸入10個整數：");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i} 個整數：");
            //    int temp;

            //    // 確保輸入的是有效的整數
            //    if (int.TryParse(Console.ReadLine(), out temp))
            //    {
            //        // 如果數字大於12，將其加入到輸出字串中，並累加到總和
            //        if (temp > 12)
            //        {
            //            output += temp + " ";
            //            sum += temp;
            //        }
            //    }
            //    else
            //    {
            //        // 如果輸入無效，提示重新輸入
            //        Console.WriteLine($"輸入無效，請重新輸入第 {i} 個整數：");
            //        i--; // 減少計數器以便重新輸入這一個數字
            //    }
            //}

            //// 列出所有大於12的數字和它們的總和
            //Console.WriteLine("所有大於12的數字有：" + output);
            //Console.WriteLine("這些數字的總和為：" + sum);
            //Console.ReadKey();


            //3-4 習題 while 輸入10個整數，列出其中所有大於12的數字的總和。
            // 宣告一個空字串變數來儲存大於12的數字，以及一個整數變數來儲存總和
            //string output = "";
            //int sum = 0;

            //// 提示使用者輸入10個整數
            //Console.WriteLine("請輸入10個整數：");

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine($"請輸入第 {i} 個整數：");
            //    int temp;

            //    // 確保輸入的是有效的整數
            //    if (int.TryParse(Console.ReadLine(), out temp))
            //    {
            //        // 如果數字大於12，將其加入到輸出字串中，並累加到總和
            //        if (temp > 12)
            //        {
            //            output += temp + " ";
            //            sum += temp;
            //        }
            //        i++; // 只有在有效輸入時才增加計數器
            //    }
            //    else
            //    {
            //        // 如果輸入無效，提示重新輸入
            //        Console.WriteLine($"輸入無效，請重新輸入第 {i} 個整數：");
            //    }
            //}

            //// 列出所有大於12的數字和它們的總和
            //Console.WriteLine("所有大於12的數字有：" + output);
            //Console.WriteLine("這些數字的總和為：" + sum);
            //Console.ReadKey();


            //3-5 習題 for輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15
            // 讀取數字的數量
            //Console.WriteLine("請輸入數字的數量：");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// 初始化變數
            //int max = int.MinValue;  // 記錄最大奇數，初始為最小整數值
            //bool found = false;      // 用來檢查是否有找到奇數

            //// 讀取 N 個數字
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 檢查是否為奇數
            //    if (num % 2 != 0)  //除2不能被整除 餘數不等於0
            //    {
            //        // 更新最大奇數
            //        if (num > max)   //如果是奇數且大於目前的 max，則更新 max 和 found
            //        {
            //            max = num;
            //            found = true;
            //        }
            //    }
            //}

            //// 輸出結果
            //if (found)
            //{
            //    Console.WriteLine($"所有奇數中的最大值是: {max}");
            //}
            //else
            //{
            //    Console.WriteLine("沒有找到奇數");
            //}

            //Console.ReadKey();


            //3-5 習題 while輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15
            // 讀取數字的數量
            //Console.WriteLine("請輸入數字的數量:");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// 初始化變數
            //int max = int.MinValue;  // 記錄最大奇數，初始為最小整數值
            //bool found = false;      // 用來檢查是否有找到奇數

            //// 讀取 N 個數字
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 檢查是否為奇數
            //    if (num % 2 != 0)
            //    {
            //        // 更新最大奇數
            //        if (num > max)
            //        {
            //            max = num;
            //            found = true;
            //        }
            //    }
            //}

            //// 輸出結果
            //if (found)
            //{
            //    Console.WriteLine($"所有奇數中的最大值是: {max}");
            //}
            //else
            //{
            //    Console.WriteLine("沒有找到奇數");
            //}
            //Console.ReadKey();


            //3-6 習題 for 輸入N個數字，求其所有正數之平方的加總。
            // 讀取數字的數量
            //Console.WriteLine("請輸入數字的數量：");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// 初始化變數
            //int sumOfSquares = 0;  // 儲存正數平方和

            //// 使用 for 迴圈讀取 N 個數字
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 檢查是否為正數
            //    if (num > 0)
            //    {
            //        // 計算正數的平方並加到累積值中
            //        sumOfSquares += num * num;
            //    }
            //}

            //// 輸出結果
            //Console.WriteLine($"所有正數平方和是: {sumOfSquares}");
            //Console.ReadKey();


            //3-6 習題 while 輸入N個數字，求其所有正數之平方的加總。
            // 讀取數字的數量
            //Console.WriteLine("請輸入數字的數量 :");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// 初始化變數
            //int sumOfSquares = 0;  // 儲存正數平方和
            //int i = 0;             // 計數器初始化

            //// 使用 while 迴圈讀取 N 個數字
            //while (i < n)
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 檢查是否為正數
            //    if (num > 0)
            //    {
            //        // 計算正數的平方並加到累積值中
            //        sumOfSquares += num * num;
            //    }

            //    i++;  // 更新計數器
            //}

            //// 輸出結果
            //Console.WriteLine($"所有正數平方和是: {sumOfSquares}");
            //Console.ReadKey();


            //3-7 習題 for輸入N個數字，其中有些是負數，將這些負數轉換成正數
            // 讀取數字的數量
            //Console.WriteLine("請輸入數字的數量: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// 使用 for 迴圈讀取 N 個數字
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 使用 Math.Abs 將負數轉換為正數
            //    num = Math.Abs(num);

            //    // 顯示處理後的數字
            //    Console.WriteLine($"處理後的數字是: {num}");
            //}
            //Console.ReadKey();


            //3-7 習題 while輸入N個數字，其中有些是負數，將這些負數轉換成正數
            // 讀取數字的數量
            //Console.WriteLine("請輸入數字的數量 :");
            //int n = Convert.ToInt32(Console.ReadLine());

            //// 初始化計數器
            //int i = 0;

            //// 使用 while 迴圈讀取 N 個數字
            //while (i < n)
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 使用 Math.Abs 將負數轉換為正數
            //    num = Math.Abs(num);

            //    // 顯示處理後的數字
            //    Console.WriteLine($"處理後的數字是: {num}");

            //    i++;  // 更新計數器
            //}
            //Console.ReadKey();


            //補充1 習題 for 判斷101-200之間有多少個質數，並輸出所有質數
            //Console.WriteLine("101 到 200 之間的質數有:");

            //// 檢查從 101 到 200 的每一個數字
            //for (int num = 101; num <= 200; num++)  //初始化計數器 num 為 101。只要 num 小於等於 200，就繼續執行迴圈。num++ 每次迴圈執行後將 num 的值增加 1。
            //{
            //    bool isPrime = true;  //初始化一個布林變數 isPrime，用來假設當前數字是質數

            //    // 判斷 num 是否為質數
            //    for (int i = 2; i <= Math.Sqrt(num); i++)  //檢查 num 是否能被從 2 到 num 的平方根之間的數字整除 , 迴圈條件是初始化內層迴圈計數器 i 為 2。  i 小於或等於 num 的平方根。這是因為我們只需要檢查到平方根就能知道是否有其他因數 , 每次迴圈執行後將 i 的值增加 1。
            //    {
            //        if (num % i == 0) //num % i == 0 檢查 num 是否能被 i 整除（即 num 除以 i 的餘數是否為 0）。如果能整除，num 不是質數。
            //        {
            //            isPrime = false; //isPrime = false 將 isPrime 設為 false，表示 num 不是質數
            //            break;  //break 退出內層迴圈，因為已經找到一個因數，不需要再檢查其他數字
            //        }
            //    }

            //    // 如果是質數，則輸出
            //    if (isPrime)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //Console.ReadKey();

            // 補充1 習題 while  判斷101-200之間有多少個質數，並輸出所有質數

            //Console.WriteLine("101 到 200 之間的質數有:");

            //int num = 101;

            //// 檢查從 101 到 200 的每一個數字
            //while (num <= 200)
            //{
            //    bool isPrime = true;            //bool isPrime = true 初始化一個布林變數 isPrime，預設為 true，假設當前的 num 是質數
            //    int i = 2;
            //                                    //初始化 i 為 2，用來測試 num 是否可以被其他數字整除。
            //                                    //內層 while 迴圈從 i = 2 開始，直到 i 大於 num 的平方根。這樣做是為了提高效率，因為如果 num 有因數，它的因數一定有一個小於或等於 sqrt(num)。
            //                                    //if (num % i == 0) 檢查 num 是否可以被 i 整除（即 num 除以 i 的餘數是否為 0）。如果能整除，num 不是質數。
            //                                    //isPrime = false 將 isPrime 設為 false，表示 num 不是質數。
            //                                    //break 退出內層迴圈，因為已經找到一個因數，不需要再檢查其他數字。
            //                                    //i++ 增加 i 的值，進入下一個數字進行檢查。
            //    // 判斷 num 是否為質數
            //    while (i <= Math.Sqrt(num))
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //        i++;
            //    }

            //    // 如果是質數，則輸出
            //    if (isPrime)
            //    {
            //        Console.WriteLine(num);
            //    }

            //    num++;
            //}

            //Console.ReadKey();


            //補充 2 習題 for 輸入一個數，輸出其質因數
            //Console.WriteLine("請輸入一個正整數:");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"數字 {number} 的質因數有:");

            //// 檢查從 2 開始到 number 的每個數字
            //for (int i = 2; i <= number; i++)   //for 迴圈從 i = 2 開始，直到 i 小於或等於 number。這是因為質因數從 2 開始，並且我們需要檢查到 number 自身。
            //{
            //    // 當 number 可以被 i 整除時
            //    if (number % i == 0)  //即 number % i == 0）。如果能整除，則 i 是 number 的質因數。
            //    {
            //        Console.WriteLine(i);
            //        // 把 number 除以 i
            //        number /= i;                //number /= i; 將 number 除以 i，更新 number 的值。這樣可以處理 i 的重複因數情況（例如 12 = 2 × 2 × 3）

            //        // 重新檢查這個 i，避免同一個質因數被重複輸出
            //        i--;
            //    }
            //}
            //Console.ReadKey();


            //補充 2 習題 while 輸入一個數，輸出其質因數
            //Console.WriteLine("請輸入一個正整數:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int divisor = 2;

            //Console.WriteLine($"數字 {number} 的質因數有:");

            //// 初始化質因數
            //while (number > 1)
            //{
            //    // 檢查 divisor 是否為質因數
            //    while (number % divisor == 0)
            //    {
            //        Console.WriteLine(divisor);
            //        number /= divisor;
            //    }
            //    divisor++;
            //}
            //Console.ReadKey();


            //補充3 習題 for 求100到300中可以被3與7整除的個數。
            //int count = 0;

            //// 使用 for 迴圈遍歷 100 到 300 之間的數字
            //for (int i = 100; i <= 300; i++)        //迴圈從 i = 100 開始，直到 i 小於或等於 300，每次迴圈結束後 i 自動加 1。
            //{
            //    // 檢查是否能被 3 和 7 同時整除
            //    if (i % 3 == 0 && i % 7 == 0)       //使用 if 語句檢查 i 是否能被 3 和 7 同時整除
            //    {
            //        count++;                            //如果條件滿足，count 變數加 1
            //    }
            //}

            //Console.WriteLine($"100 到 300 之間可以被 3 和 7 同時整除的數字個數是: {count}");
            //Console.ReadKey();


            //補充3 習題 while 求100到300中可以被3與7整除的個數。

            //int count = 0;
            //int i = 100;

            //// 使用 while 迴圈遍歷 100 到 300 之間的數字
            //while (i <= 300)
            //{
            //    // 檢查是否能被 3 和 7 同時整除
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        count++;
            //    }

            //    i++;
            //}

            //Console.WriteLine($"100 到 300 之間可以被 3 和 7 同時整除的數字個數是: {count}");
            //Console.ReadKey();

            //4-1例題
            //int specialNumber = -1; // 設定特殊數字，當輸入該數字時終止迴圈
            //int input;

            //Console.WriteLine("請輸入數字（輸入負數或特殊數字結束）：");

            //while (true)
            //{
            //    input = Convert.ToInt32(Console.ReadLine());

            //    // 判斷是否為特殊數字或負數
            //    if (input == specialNumber || input < 0)
            //    {
            //        break; // 終止迴圈
            //    }

            //    // 處理正數的邏輯（這裡僅顯示輸入的數字）
            //    Console.WriteLine($"你輸入的數字是: {input}");
            //}

            //Console.WriteLine("迴圈結束");
            //Console.ReadKey();


            //例題4-2
            // 讀取兩個正整數
            //Console.Write("請輸入第一個正整數：");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入第二個正整數：");
            //int b = Convert.ToInt32(Console.ReadLine());

            //// 初始化布林變數來控制迴圈
            //bool validInput = true;

            //// 處理特殊情況
            //if (a == 0 && b == 0)
            //{
            //    Console.WriteLine("兩個數不能都為零。");
            //    validInput = false; // 設置 validInput 為 false
            //}
            //else if (a == 0)
            //{
            //    Console.WriteLine($"最大公約數是 {Math.Abs(b)}");
            //    validInput = false; // 設置 validInput 為 false
            //}
            //else if (b == 0)
            //{
            //    Console.WriteLine($"最大公約數是 {Math.Abs(a)}");
            //    validInput = false; // 設置 validInput 為 false
            //}

            //// 使用 while 迴圈來計算最大公約數
            //while (validInput && b != 0) // 當 validInput 為 true 且 b 不為 0 時繼續迴圈
            //{
            //    int remainder = a % b; // 計算 a 除以 b 的餘數
            //    a = b; // 將 b 設為新的 a
            //    b = remainder; // 將餘數設為新的 b
            //}

            //// 當 b 為 0 時，a 就是最大公約數
            //if (validInput)
            //{
            //    Console.WriteLine($"最大公約數是 {Math.Abs(a)}");
            //}

            //Console.ReadKey();


            //例題4-3
            // 讀取要輸入的數字個數 N
            //Console.Write("請輸入數字的個數 N：");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// 檢查 N 是否為正數
            //if (N <= 0)
            //{
            //    Console.WriteLine("N 必須是正整數。");
            //    // 繼續執行程式碼，這裡可以加上提示或其他操作
            //    Console.WriteLine("請重新啟動程式並輸入正整數。");
            //}
            //else
            //{
            //    int sum = 0; // 用來存儲數字的和
            //    int i = 1;   // 計數器，從 1 開始

            //    // 使用 while 迴圈讀取 N 個數字並計算和
            //    while (i <= N)       //條件 i <= 當 i 超過 N 時，while 迴圈的條件不再滿足，迴圈自動終止，
            //    {
            //        Console.Write($"請輸入第 {i} 個數字：");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        sum += num; // 將輸入的數字加到和中
            //        i++; // 計數器遞增
            //    }
            //    Console.WriteLine($"這 {N} 個數字的和是: {sum}");
            //}

            //Console.ReadKey();


            //習題4-1  while寫一程式求N個數字的最大值。
            // 讀取要輸入的數字個數 N
            //Console.Write("請輸入數字的個數 N：");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// 檢查 N 是否為正數
            //if (N <= 0)
            //{
            //    Console.WriteLine("N 必須是正整數。");
            //    Console.WriteLine("請重新啟動程式並輸入正整數。");
            //}
            //else
            //{
            //    int max = int.MinValue; // 初始化最大值為最小整數
            //    int i = 1; // 計數器，從 1 開始

            //    // 使用 while 迴圈讀取 N 個數字並找出最大值
            //    while (i <= N)
            //    {
            //        Console.Write($"請輸入第 {i} 個數字：");
            //        int num = Convert.ToInt32(Console.ReadLine());

            //        // 檢查是否是目前的最大值
            //        if (num > max)
            //        {
            //            max = num; // 更新最大值
            //        }

            //        i++; // 計數器遞增
            //    }

            //    // 輸出結果
            //    Console.WriteLine($"這 {N} 個數字中的最大值是: {max}");
            //}

            //Console.ReadKey();


            //習題4-2 while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
            //等差級數是一種數字序列，其中每個數字與前一個數字之間的差是固定的。這個固定的差叫做公差。比如說，如果你有一個數字序列，它的起始值是 2，每個數字之間的差是 3，那麼這個序列就是：2, 5, 8, 11, 14, …。
            // 讀取等差級數的參數
            //Console.Write("請輸入等差級數的起始值：");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("請輸入等差級數的間隔差：");
            //int difference = Convert.ToInt32(Console.ReadLine());

            //Console.Write("請輸入等差級數的項數 N：");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// 檢查 N 是否為正數
            //if (N <= 0)
            //{
            //    Console.WriteLine("N 必須是正整數。");
            //    Console.WriteLine("請重新啟動程式並輸入正整數。");
            //}
            //else
            //{
            //    int sum = 0; // 初始化總和
            //    int current = start; // 當前數字，從起始值開始
            //    int count = 0; // 計數器，跟蹤已處理的數字數量

            //    // 使用 while 迴圈計算等差級數的總和
            //    while (count < N)
            //    {
            //        sum += current; // 將當前數字加入總和
            //        current += difference; // 計算下一個數字
            //        count++; // 計數器遞增
            //    }

            //    Console.WriteLine($"等差級數的總和是: {sum}");
            //}

            //Console.ReadKey();


            //4-3 while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和
            // 讀取數字的個數 N
            //Console.WriteLine("請輸入數字的個數 N:");
            //int N = Convert.ToInt32(Console.ReadLine());

            //// 初始化變數
            //int count = 0; // 用來計數已經處理的數字
            //int sum = 0;   // 用來累加小於 13 的數字的總和

            //// 當處理的數字數量小於 N
            //while (count < N)
            //{
            //    Console.WriteLine($"請輸入第 {count + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 檢查數字是否小於 13
            //    if (num < 13)
            //    {
            //        sum += num; // 將小於 13 的數字加到總和中
            //    }

            //    count++; // 處理的數字數量增加 1
            //}

            //Console.WriteLine($"小於 13 的數字的總和是: {sum}");
            //Console.ReadKey();


            //4-4 while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字
            // 讀取數字的個數 N
            //Console.WriteLine("請輸入數字的個數 N:");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int count = 0; // 用來計數已經處理的數字
            //bool found = false; // 標記是否找到符合條件的數字

            //while (count < N)
            //{
            //    Console.WriteLine($"請輸入第 {count + 1} 個數字:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // 檢查數字是否大於 7 而小於 10
            //    if (num > 7 && num < 10)
            //    {
            //        Console.WriteLine($"找到符合條件的數字: {num}");
            //        found = true; // 設置標記為已找到
            //        break; // 找到符合條件的數字後停止迴圈
            //    }

            //    count++; // 處理的數字數量增加 1
            //}

            //// 如果沒有找到符合條件的數字
            //if (!found)
            //{
            //    Console.WriteLine("沒有找到符合條件的數字。");
            //}
            //Console.ReadKey();


            //4-5 while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi
            //int n = 5; // 一共要讀入 5 個數字
            //int count = 0; // 用來計數已經處理的數字
            //bool found = false; // 標記是否找到符合條件的數字

            //Console.WriteLine("請輸入 a1 到 a5:");
            //while (count < n)
            //{
            //    // 讀取 a 和 b 的數字
            //    Console.Write($"a{count + 1}: ");
            //    int a = Convert.ToInt32(Console.ReadLine());

            //    Console.Write($"b{count + 1}: ");
            //    int b = Convert.ToInt32(Console.ReadLine());

            //    // 比較 ai 和 bi
            //    if (a > b)
            //    {
            //        Console.WriteLine($"找到符合條件的數字: a{count + 1} = {a}, b{count + 1} = {b}");
            //        found = true; // 設置標記為已找到
            //        break; 
            //    }

            //    count++; // 處理的數字數量增加 1
            //}

            //// 如果沒有找到符合條件的數字
            //if (!found)
            //{
            //    Console.WriteLine("沒有找到符合條件的數字。");
            //}
            //Console.ReadKey();

            //補充1 漢堡
            //// 讀取使用者輸入的時間（分鐘）
            //Console.Write("請輸入Eric吃漢堡的時間（分鐘）=");
            //int totalMinutes = Convert.ToInt32(Console.ReadLine());

            //// 初始化變數
            //int timeInterval = 5; // 每 5 分鐘吃一個漢堡
            //int count = 0; // 記錄吃的漢堡數量
            //int timeAccumulated = 0; // 記錄累計時間

            //Console.WriteLine("吃漢堡的紀錄如下：");

            //// 使用 while 迴圈來計算和顯示吃漢堡的時間
            //while (totalMinutes >= timeInterval)
            //{
            //    // 每 5 分鐘吃一個漢堡
            //    count++;
            //    timeAccumulated += timeInterval;
            //    totalMinutes -= timeInterval;

            //    // 顯示當前漢堡的時間點
            //    Console.WriteLine($"第 {count} 個漢堡，吃在 {timeAccumulated} 分鐘");
            //}

            //// 顯示總共吃了多少個漢堡和剩餘的時間
            //Console.WriteLine($"總共吃了 {count} 個漢堡，共花了 {timeAccumulated} 分鐘，還剩下 {totalMinutes} 分鐘");

            //Console.ReadKey();


            //補充2 貸款還清
            // 總貸款額（萬元）
            //double loanAmount = 560; // 560萬元
            //                         // 每月還款額（萬元）
            //double monthlyPayment = 4; // 4萬元
            //                           // 每12個月額外還款（萬元）
            //double annualBonusPayment = 1; // 1萬元
            //                               // 記錄已經還款的月份數
            //int months = 0;

            //// 使用 while 迴圈計算每月還款情況
            //while (loanAmount > 0)
            //{
            //    // 每月還款
            //    loanAmount -= monthlyPayment;
            //    months++;

            //    // 每12個月額外還款一次
            //    if (months % 12 == 0)
            //    {
            //        loanAmount -= annualBonusPayment;
            //    }
            //}

            //Console.WriteLine($"小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，需要還款的總月數: {months}個月");
            //Console.ReadKey();

            //補充3 猜數字
            // 初始化隨機數生成器
            Random random = new Random();
            // 生成一個1到100之間的隨機數字
            int targetNumber = random.Next(1, 101);

            int guess = 0;

            Console.WriteLine("請猜一個1到100之間的數字：");

            // 使用 while 迴圈讓使用者猜數字
            while (guess != targetNumber)
            {
                // 讀取使用者輸入的數字
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < targetNumber)
                {
                    Console.WriteLine("太小了，再試一次！");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("太大了，再試一次！");
                }
                else
                {
                    Console.WriteLine("恭喜你，猜中了！");
                }
            }

            Console.ReadKey();

        }
    }
}