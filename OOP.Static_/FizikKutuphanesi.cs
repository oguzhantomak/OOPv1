namespace OOP.Static_
{
    // access modifier default değeri :  internal (aynı asmbly içerisinde ulaşılabilir.)
    class FizikKutuphanesi
    {
        // access modifier default değeri : private

        // static olarak işaretlenen nesnelerden 2. bir adet oluşturma şansınız yoktur.

        // ram üzerinde tek bir tane tanımlanır ve proje çalışmaya devam ettiği sürece kullanılmaya devam edecektir.

        public static double PI = 3.1415926535897931;

        // sadece okunabilir, üzerinde değişiklik yapılamaz.
        public readonly string Connection = "server=.;database=northwind;uid=sa;pwd=123";


        public const string ConnectionString = "server=.;database=northwind;uid=sa;pwd=123";
        // const( constant ) => readonly + static

        public static bool Sale(int Id)
        {
            // veri tabanında Id değerine sahip ürünü sat
            return true; // işlem başarılı olursa true, değilse false teslim eder.
        }
    }

    public static class Kutuphane
    {
        public static void Clear()
        {

        }
    }
}
