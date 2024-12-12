// See https://aka.ms/new-console-template for more information
using System.Text;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
Console.WriteLine("Hello, World!");

//csv読み込み
string filePath = @".\Data\sample.csv";

try
{
    using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("Shift_JIS")))
    {
        string line;
        if ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine("１行目をスキップ");
        }

        if ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine("２行目をスキップ");
        }

        while ((line = reader.ReadLine()) != null)
        {
            // カンマで分割して各要素を配列に格納
            string[] values = line.Split(',');

            // 分割した値を表示
            foreach (var value in values)
            {
                Console.Write(value + "\t");
            }
            Console.WriteLine(); // 行を分ける

        }
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("指定されたCSVファイルが見つかりません。");
}
catch (Exception ex)
{
    Console.WriteLine("エラーが発生しました: " + ex.Message);
}