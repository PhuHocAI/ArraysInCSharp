using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        //string[] numbers = new string[3];
        //numbers[0] = "John";
        //numbers[1] = "Doe";

        //Console.WriteLine(numbers[2]);// Output: String.empty: Chuỗi rỗng
        ////Hàm kiểm tra chuỗi rỗng trong C#: string.IsNullOrEmpty(string)
        //Console.WriteLine(numbers[3]);//Output: IndexOutOfRangeException: Lỗi vượt quá chỉ số mảng
        ////multicursor: Shift + Alt + .
        //foreach (var num in numbers)
        //{
        //    Console.WriteLine(num);
        //}
        //ctrl + shift + T: kiếm file để mở

        //Những interface liên quan tới danh sách:
        //1. IEnumerable: cung cấp GetEnumerator() để duyệt qua các phần tử
        IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 6 };
        //Thằng này chỉ đọc, không thể thêm, sửa, xóa
        //là 1 ví dụ về tính kế thừa (IEnumerable kế thừa từ Arrays)
        //foreach (var item in numbers)
        //{
        //    Console.Write(item);
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write(numbers.ElementAt(i));//không thể dùng cách truyền index kiểu numbers[i] được
        //    //vì đây không phải là mảng, đây là interface của mảng
        //}
        //2. ICollection: kế thừa từ IEnumerable, cung cấp Count, Add, Remove
        //Trong vs, nếu đặt tên có chữ I đứng trước thì đó là interface !CHỈ VISUAL STUDIO!
        ICollection<dynamic> numbers2 = new List<dynamic> { 10, 20, 30 };
        numbers2.Add(66.6f);
        numbers2.Add("Hello");
        numbers2.Remove(20);
        foreach (var item in numbers2)
        {
            Console.WriteLine(item);
        }
        //3. IList: kế thừa từ ICollection, cung cấp IndexOf, Insert, RemoveAt
    }

}