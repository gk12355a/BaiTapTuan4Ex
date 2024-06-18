using System;

// Định nghĩa ngoại lệ tùy chỉnh AgeOutOfRangeException
public class AgeOutOfRangeException : Exception
{
    public AgeOutOfRangeException(string message) : base(message)
    {
    }
}

class UniversityAdmission
{
    static void Main()
    {
        try
        {
            // Nhập tuổi của học sinh
            Console.Write("Nhap tuoi cua hoc sinh: ");
            int age = int.Parse(Console.ReadLine());

            // Kiểm tra tuổi có nằm trong phạm vi từ 18 đến 25 không
            if (age < 18 || age > 25)
            {
                throw new AgeOutOfRangeException("Tuoi khong thoa man.");
            }

            // Nếu tuổi hợp lệ
            Console.WriteLine("Hoc sinh du dieu kien.");
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("ERROR: Vui long nhap mot so nguyen hop le.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("End.");
        }
    }
}