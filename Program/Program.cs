public static class Program {

    public static void Main(){
        Console.Write("Input number of Fibonacci Series : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Fibonacci(n);

    }

    public static void Fibonacci(int n){
        int first = 0; 
        int second = 1; 
        int res;

        for( int i = 0; i < n; i++){
            Console.Write(first + " ");
            res = first + second;
            first = second;
            second = res;
        }   

    }

    public static void Velcome(string name){

        Console.WriteLine("Have a nice day!");

    }
}


