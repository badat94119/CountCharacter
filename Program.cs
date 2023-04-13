// Bước 1: Khai báo một chuỗi và gán cho nó một giá trị
string str = "Hello, world!";

// Bước 2: Khai báo một biến ký tự và gán hoặc nhập từ bàn phím một giá trị
char ch = 'o';

// Bước 3: Khai báo biến count và gán giá trị 0, để lưu số ký tự đếm được trong chuỗi
int count = 0;

// Bước 4: Sử dụng vòng lặp duyệt từng ký tự trong chuỗi
for (int i = 0; i < str.Length; i++)
{
    // So sánh nếu ký tự trong chuỗi bằng ký tự nhập vào thì tăng biến đếm lên 1
    if (str[i] == ch)
    {
        count++;
    }
}

// In ra số lần xuất hiện của ký tự trong chuỗi
Console.WriteLine("Số lần xuất hiện của ký tự '{0}' trong chuỗi '{1}' là {2}", ch, str, count);

