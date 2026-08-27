using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace caohuy
{
    internal class session_2
     {
        public enum Currency
        {


            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4,
        }

        static void Bai_1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào chỉ số điện mới ( kWh): ");
            decimal New = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Nhập vào chỉ số điện cũ ( kWh ):");
            decimal old = Convert.ToDecimal(Console.ReadLine());
            if (New < old)
                Console.WriteLine("Chỉ số điện mới phải lớn hơn chỉ số điện cũ.");
            while (New < old)
            {
                Console.Write("Nhập lại chỉ số điện mới:");
                New = Convert.ToDecimal(Console.ReadLine());
            }
            if (New < 0)
                Console.WriteLine("Số điện mới phải lớn hơn 0");
            if (old < 0)
                Console.WriteLine("Số điện cũ phải lớn hơn hoặc bằng 0");
            while (New < 0)
            {
                Console.Write("Nhập lại số điện mới: ");
                New = Convert.ToDecimal(Console.ReadLine());
            }
            while (old < 0)
            {
                Console.Write("Nhập lại số điện cũ: ");
                old = Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine($"Số điện tiêu thụ tháng này là : {New - old} kWh");
            decimal total = (New - old);
            decimal totalfee = 0;
            if (total <= 50)
            {
                totalfee = (New - old) * 1806m;
                Console.WriteLine($" Tiền điện chưa thuế là :{totalfee:#,##0} VND");
            }
            if (50m < total && total <= 100m)
            {
                totalfee = (total - 50m) * 1806m + 50m * 1866m;
                Console.WriteLine($"Tiền điện chưa thuế là:{totalfee:#,##0}  VND");
            }
            if (100m < total && total <= 200m)
            {
                totalfee = (total - 100m) * 2167m + 50m * 1866 + 50m * 1806m;
                Console.WriteLine($"Tiền điện chưa thuế là: {totalfee:#,##0} VND");
            }
            if (200m < total && total <= 300m)
            {
                totalfee = (total - 200m) * 2729m + 50m * 1866 + 50m * 1806m + 100m * 2167m;
                Console.WriteLine($"Tiền điện chưa thuế là: {totalfee:#,##0} VND");
            }
            if (total > 300)
            {
                totalfee = (total - 300m) * 3050m + 50m * 1866 + 50m * 1806m + 100m * 2167m + 100m * 2729m;
                Console.WriteLine($"Tiền điện chưa thuế là: {totalfee:#,##0} VND");
            }
            decimal vat = totalfee * 8 / 100;
            Console.WriteLine($"Tiền thuế VAT (8%) là: {vat:#,##0} VND");
            decimal Total = vat + totalfee;
            Console.WriteLine($"Tổng tiền phải thanh toán là:{Total:#,##0} VND");
        }
        static void Bai_2()
        {
            Console.Write("Chiều cao (m):");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cân nặng (kg):");
            double w = Convert.ToDouble(Console.ReadLine());
            if (h > 2.51 || h < 0)
            {
                Console.WriteLine("Chiều cao không hợp lệ. Vui lòng nhập lại.");
                Console.Write("Chiều cao (m):");
                h = Convert.ToDouble(Console.ReadLine());
            }
            if (w > 635 || w < 0)
            {
                Console.WriteLine("Cân nặng không hợp lệ. Vui lòng nhập lại ");
                Console.Write("Cân nặng (kg):");
                w = Convert.ToDouble(Console.ReadLine());
            }
            double BMI = w / (h * h);
            Console.WriteLine($"Chỉ số BMI của bạn là: {BMI:F2}");
            if (BMI < 18.5)
                Console.WriteLine($"Phân loại sức khỏe : Gầy (Thiếu cân)");
            if (18.5 <= BMI && BMI < 25)
                Console.WriteLine($"Phân loại sức khỏe : Bình thường (Lí tưởng) ");
            if (23.0 <= BMI && BMI < 25.0)
                Console.WriteLine($"Phân loại sức khỏe : Thừa cân (Tiền béo phì)");
            if (BMI >= 25.0)
                Console.WriteLine($"Phân loại sức khỏe : Béo phì");
            double suggestmin = 18.5 * h * h;
            double suggestmax = 22.9 * h * h;
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {suggestmin:F2} kg đến {suggestmax:F2} kg");
        }
        static void Bai_3()
        { 
        Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập số tiền VND:");
            decimal vnd = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Chọn ngoại tệ (USD-1,EUR-2,JPY -3, GBP -4):");
            int choice = int.Parse(Console.ReadLine());
        Currency freefire = (Currency)choice;
        decimal rate = 0;
            switch (freefire)
            {
                case Currency.USD:
                    rate = 25400m;
                    break;
                case Currency.EUR:
                    rate = 27200m;
                    break;
                case Currency.JPY:
                    rate = 165m;
                    break;
                case Currency.GBP:
                    rate = 32100m;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ:");
                    return;
            }
    Console.WriteLine($"Phí dịch vụ là:{vnd * 0.005m} VND");
            Console.WriteLine($"Số tiền VND tính đổi: {vnd * 0.95m} VND ");
            Console.WriteLine($"Số tiền {freefire} nhận được là: {(vnd * 0.95m) / rate} {freefire} ");
        }
        static void Bai_4()
        {
            Console.Write("Enter your date of birth (dd/MM/yyyy):");
            DateTime day = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime result) ? result : DateTime.MinValue;
            DateTime now = DateTime.Now;
            TimeSpan age = now - day;
            int haha = DateTime.Now.Year;
            Console.WriteLine($"Your age is :{age.Days / 365} years old ");
            Console.WriteLine($"You have been alive for {age.TotalDays} days");
            if (result.Month > DateTime.Now.Month)
            {
                DateTime hehe = new DateTime(haha, result.Month, result.Day);
                TimeSpan nextbirthday1 = hehe - now;
                Console.WriteLine($"Next your birthday is left:{nextbirthday1.Days} days");
            }
            else
            {
                DateTime hehehe = new DateTime(haha + 1, result.Month, result.Day);
                TimeSpan nextbirthday2 = hehehe - now;
                Console.WriteLine($"Next your birthday is left:{nextbirthday2.Days} days");
            }
        }
        static void Bai_5_1()
        {
            Console.Write("Enter your score of C# programming (0-10):");
            double score_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your score of discrete Mathematics (0-10):");
            double score_2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your score of English (0-10):");
            double score_3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("How many credits does C# programming have ? :");
            int credit_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many credits does discrete Mathematics have ? :");
            int credit_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many credits does English have ? :");
            int credit_3 = Convert.ToInt32(Console.ReadLine());
            double score_avr = (score_1 * credit_1 + score_2 * credit_2 + score_3 * credit_3) / (credit_1 + credit_2 + credit_3);
            Console.WriteLine($"Your average score is: {score_avr:F2}");
            if (score_avr >= 8.5 && score_avr <= 10)
            {
                Console.WriteLine("Your rank is : A ");
                Console.WriteLine("GPA:4.0");
                Console.WriteLine("Learning ability: Excellent and Good");
            }
            if (score_avr >= 7.0 && score_avr < 8.5)
            {
                Console.WriteLine("Your rank is : B ");
                Console.WriteLine("GPA:3.0");
                Console.WriteLine("Learning ability: Great");
            }
            if (score_avr >= 5.5 && score_avr < 7.0)
            {
                Console.WriteLine("Your rank is : C ");
                Console.WriteLine("GPA:2.0");
                Console.WriteLine("Learning ability: Average");
            }
            if (score_avr >= 4.0 && score_avr < 5.5)
            {
                Console.WriteLine("Your rank is : D ");
                Console.WriteLine("GPA:1.0");
                Console.WriteLine("Learning ability: Weak");
            }
            if (score_avr < 4.0)
            {
                Console.WriteLine("Your rank is : F ");
                Console.WriteLine("GPA:0.0");
                Console.WriteLine("Learning ability: Poor");
            }
        }
        private static void Main(string[] args)
        {
            
        }












    }
}     


