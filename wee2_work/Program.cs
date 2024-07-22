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
            //3-1 for 輸入10個整數，求其最小值
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

            //3-1 while 輸入10個整數，求其最小值
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


            //3-2 for 輸入N個整數，求其最小值
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


            //3-2 while 輸入N個整數，求其最小值
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


            //3-3 for輸入10個整數，列出其中所有大於12的數字。

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


            //3-3 while 輸入10個整數，列出其中所有大於12的數字。
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


            //3-4 for 輸入10個整數，列出其中所有大於12的數字的總和。
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


            //3-4 while 輸入10個整數，列出其中所有大於12的數字的總和。
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


            //3-5 for輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15
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


            //3-5 while輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15
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


            //3-6 for 輸入N個數字，求其所有正數之平方的加總。
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


            //3-6 while 輸入N個數字，求其所有正數之平方的加總。
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


            //3-7  for輸入N個數字，其中有些是負數，將這些負數轉換成正數
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


            //3-7  while輸入N個數字，其中有些是負數，將這些負數轉換成正數
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


            //補充1 for 判斷101-200之間有多少個質數，並輸出所有質數
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

            // 補充1 while  判斷101-200之間有多少個質數，並輸出所有質數

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


            //補充 2 for 輸入一個數，輸出其質因數
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


            //補充 2 while 輸入一個數，輸出其質因數
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


            //補充3 for 求100到300中可以被3與7整除的個數。
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


            //補充3 while 求100到300中可以被3與7整除的個數。

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

        }
    }
}