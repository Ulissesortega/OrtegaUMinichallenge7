//Name: Ulises Ortega
//Date: 09.16.22
//Project Name: Reverse It
//Description: The programe ask the user to input more than 2 numbers or letters in order to see the reverese,
//once the program is executed and complete, It will ask the user if the want to run the program again
//Revised by: Arely Martinez -- The program works well, the data confirmation on the last part does it's job. Overall very simple and easy to easy code.

string userChoice = "";

do{
Console.Clear();
Console.WriteLine("Let's Play Reverse It");
Console.WriteLine("");
Console.WriteLine("Please Type at Least 2 Numbers or More than 2 letters and press enter");
string strInput = Console.ReadLine();

int result = 0;

if (int.TryParse(strInput, out result))
{ 
            int Reverse = 0;  
            while(result>0)  
            {  
                int remainder = result % 10;  
                Reverse = (Reverse * 10) + remainder;  
                result = result / 10;  
            }  
            Console.WriteLine("Reverse No. is {0}",Reverse);  
            //Console.ReadLine(); 
}
else
{ 
    string reverse = "";  
            int Length = 0;  
            Length = strInput.Length - 1;  
            while(Length>=0)  
            {  
                reverse = reverse + strInput[Length];  
                Length--;  
            }  
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}",reverse);  
            //Console.ReadLine();       
}
do
{
    Console.WriteLine("Do you want to continue: Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "Yes" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");
