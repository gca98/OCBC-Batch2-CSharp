using System;

class soal5{
    static void Main(){
        Console.Write("Enter the Number : ");
        // int num = int.Parse(Console.ReadLine());
        int num = 90;
        string temp = num.ToString();
        for (int i = 0; i < temp.Length; i++){
            if(temp[i]=='0')Console.Write("zero ");
            if(temp[i]=='1')Console.Write("one ");
            if(temp[i]=='2')Console.Write("two ");
            if(temp[i]=='3')Console.Write("three ");
            if(temp[i]=='4')Console.Write("four ");
            if(temp[i]=='5')Console.Write("five ");
            if(temp[i]=='6')Console.Write("six ");
            if(temp[i]=='7')Console.Write("seven ");
            if(temp[i]=='8')Console.Write("eight ");
            if(temp[i]=='9')Console.Write("nine ");
        }
    }
}