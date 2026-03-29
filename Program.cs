/*
AI Transparency Statement:
AI was used to shape parts of this assignment, including outlining ideas and improving the structure of the report.
All code and written content were developed independently by me. AI suggestions were refined and reviewed to meet the assignment requirements.
*/

/* Test Plan

(1) MenuHelper.ValidChoice(int) method

   input                 Expected Result                                      Actual Result
|----------------------|--------------------------------------|-------------------------------------------------|
1) 1                    Running Household Cost Calculator              Running Household Cost Calculator
2) 2                    Runnning Library Catalogue                     Running Library Catalouge
3) 3                    Running Hexadecimal Calculator                 Running Hexadecimal Calculator
4) 4                    Terminated Program                             Terminated Program
5) 0                    Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
6) 10                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
7) 100                  Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4     
8) 1000                 Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4 
9) 1000000000000000     Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4 
9) -10                  Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4     
10) -100                Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
11) -1000               Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
12) -1000000000000000   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
13) !                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
14)@                    Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
15)#                    Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
16)$                    Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
17) %                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
18) ^                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
19) &                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4        
20) *                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
21) (                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
22) )                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
23) _                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
24) +                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
25) [                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4
26) ]                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
27) ;                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
28) .                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4           
29) ,                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
30) <                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
31) .                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
32) !@##@$#%$%$^%#      Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
33) null                Invalid input! Choose a number from 1-4        (endless loop)Invalid input! Choose a number from 1-4 
^ for 33) I manually changed choice to null and got infinite loop of invalid inputs, so theres an issue there

34) abcdefg             Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4        
35) 3.14                Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4    
36) 2.0                 Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4        
37) " " (space)         Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4        
38) " "                 Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4        
39) 😂                   Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4           
40) 你好                 Invalid input! Choose a number from 1-4        Invalid input! Choose a number from 1-4           

(2) Appliance Name

1)1                   Accepts value because appliance can be numerical  Accepts value because appliance can be numerical 

Note - I could've improved by creating a JSON file  for the appliances
also I could've added numbers in forbidden symbols too, but
I chose to keep it because applainces could be numerical


2)2                   Accepts value because appliance can be numerical  Accepts value because appliance can be numerical
3)3                   Accepts value because appliance can be numerical   Accepts value because appliance can be numerical      
4)4                   Accepts value because appliance can be numerical   Accepts value because appliance can be numerical    
5)0                   Accepts value because appliance can be numerical   Accepts value because appliance can be numerical   
6)10                  Accepts value because appliance can be numerical   Accepts value because appliance can be numerical
7)100                 Accepts value because appliance can be numerical   Accepts value because appliance can be numerical
8)1000                Accepts value because appliance can be numerical   Accepts value because appliance can be numerical
9)1000000000000000    Accepts value because appliance can be numerical   Accepts value because appliance can be numerical                    
10)-10                Ignore because won't need negatives in appliance name  Erroneously accepts the value 
11)-100               Ignore because won't need negatives in appliance name  Erroneously accepts the value  
12)-1000              Ignore because won't need negatives in appliance name  Erroneously accepts the value  
13)-1000000000000000  Ignore because won't need negatives in appliance name  Erroneously accepts the value  
14)!                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again 
15)@                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
16)#                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
17)$                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
18)%                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
19)^                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
20)&                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
21)*                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again  
22)(                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
23))                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
24)_                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
25)+                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
26)[                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
27)]                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
28);                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
29).                  Ignore because it is a forbidden symbol             IS accepted
Note for 29) input of '.' is accepted
but it was intentional as GetValidInput()
is used for library catalogue and some authors have a period
in the name, same goes for "-"


30),                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
31)<                  Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again         
32)!@##@$#%$%$^%#     Ignore because it is a forbidden symbol             Doesn't accept - Input contains forbidden symbols. Please try again   
33)null               Ignore because it is a forbidden symbol             Accepts which is bad    
^ for 33) I manually changed choice to null and got infinite loop of invalid inputs, so theres an issue there
34)abcdefg            Accepts the string                                  Accepts the string   
35)3.14               Accepts the string                                  Accepts the string     
36)2.0                Accepts the string                                  Accepts the string     
37)" " (space)        Doesn't accept                                      Doesn't accept "Input cannot be empty. Please enter a valid value."  
38)"" (empty input)   DOesn't accept                                      Does accept
39)😂                 Doesn't accept                                       Does accept  
40)你好                Doesn't accept                                      Does accept
41)-                    Ignore because it is a forbidden symbol             IS accepted


Reflection from (2) I need to 
populate my forbidden symbols.csv
to catch erroneous inputs
Also I need to consider whether I should use numbers
or not


(3) MenuHelper.ValidChoice(decimal)

1)1                         Accepted it is an integer       Accepted
2)2                         Accepted it is an integer       Accepted
3)3                         Accepted it is an integer       Accepted
4)4                         Accepted it is an integer       Accepted
5)0                         Accepted it is an integer       Accepted    
6)10                        Accepted it is an integer       Accepted
7)100                       Accepted it is an integer       Accepted
8)1000                      Accepted it is an integer       Accepted
9)1000000000000000          Accepted it is an integer       NOT accepted "Invalid input! Choose a number from 0-999999999"
10)-10                      Not accepted as is negative     NOT accepted Invalid input! Choose a number from 0-999999999
11)-100                     Not accepted as is negative     NOT accepted Invalid input! Choose a number from 0-999999999
12)-1000                    Not accepted as is negative     NOT accepted Invalid input! Choose a number from 0-999999999
13)-1000000000000000        Not accepted as is negative     NOT accepted Invalid input! Choose a number from 0-999999999    
14)!                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
15)@                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
16)#                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999                       
17)$                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
18)%                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
19)^                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
20)&                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
21)*                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
22)(                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
23))                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
24)_                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
25)+                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
26)[                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
27)]                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
28);                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
29).                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
30),                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
31)<                        Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
32)!@##@$#%$%$^%#           Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
33)null                     Not accepted as is Null         Throws CS0037 error
34)abcdefg                  Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
35)3.14                     Accepted it is a decimal        Accepted
36)2.0                      Accepted it is a decimal        Accepted
37)" " (space)              Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
38)"" (empty input)         Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
39)😂                       Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999
40)你好                      Not accepted as is  NaN         NOT accepted Invalid input! Choose a number from 0-999999999   

(4) Y/N loop

1)yes                       Is Acceptted                    Is accepted
2)yeS                       Is Acceptted                    Is accepted
3)yEs                       Is Acceptted                    Is accepted
4)yES                       Is Acceptted                    Is accepted
5)Yes                       Is Acceptted                    Is accepted
6)YeS                       Is Acceptted                    Is accepted
7)YEs                       Is Acceptted                    Is accepted
8)YES                       Is Acceptted                    Is accepted
9)no                        Is Acceptted                    Is accepted
10)nO                       Is Acceptted                    Is accepted
11)No                       Is Acceptted                    Is accepted
12)NO                       Is Acceptted                    Is accepted
13) Y                       Is Acceptted                    Is accepted
14) N                       Is Acceptted                    Is accepted
15) n                       Is Acceptted                    Is accepted
16) y                       Is Acceptted                    Is accepted
17)!                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
18)@                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
19)#                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
20)$                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
21)%                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
22)^                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
23)&                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
24)*                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
25)(                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
26))                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
27)                         Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"_
28)+                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
29)=                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
30)[                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
31)]                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
32)|                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
33)/                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
34)\                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
35):                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
36>;                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
37)<                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
38>,                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
39>.                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
40)0                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
41)1                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
42)2                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
43)10                       Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
44)999                      Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
45)-1                       Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
46)-100                     Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
47)a                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
48)abc                      Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
49)nope                     Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
50)ye                       Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
51)yess                     Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
52)n0                       Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
53)""                       Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
54)" "                      Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
55)" "                      Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
56)😂                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
57)👍                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
58)你好                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
59)はい                        Won't be accepted               Isn't accepted "Invalid input! Enter Y/N"
60)да
61)null                       Won't be accepted             Endless looprejecting it


------NOTE-----
The above meethods are reused throughout the program so it is uneccasssary to
re-test them as they will be the same


(4) Text File creation
1) Create a text file with an applaince calleed "shower" 

Inputs
-----------------------------------------------------------------------
Shower, 22, 2,  2.5

Expected
-----------------------------------------------------------------------
 Creeates a text file with a shower appliance, and the reespectiive, calculated, values

 Output
 ----------------------------------------------------------------------
Shower
------------------
Daily usage (L): 44.00
Monthly usage (L): 1320.00
Yearly usage (L): 16060.00
Estimated Daily Cost (£): £0.11
Estimated Monthly Cost (£): £3.30
Estimated Yearly Cost (£): £40.15
------------------


2) Create a text file with an applaince calleed "Washinng Machine" 

Inputs
-----------------------------------------------------------------------
Washing Machine, 22, 2,  2.5

Expected
-----------------------------------------------------------------------
 Creates a text file with a Washing Machine appliance, and the respectiive, calculated, values

 Output
 ----------------------------------------------------------------------
Washing Machine
------------------
Daily usage (L): 44.00
Monthly usage (L): 1320.00
Yearly usage (L): 16060.00
Estimated Daily Cost (£): £0.11
Estimated Monthly Cost (£): £3.30
Estimated Yearly Cost (£): £40.15


3) Special characterrs Washing-Machine

Inputs
-----------------------------------------------------------------------
Washing-Machine, 22, 2,  2.5

Expected
-----------------------------------------------------------------------
 Creates a text file with a shower appliance, and the respectiive, calculated, values

Washing-machine
------------------
Daily usage (L): 44.00
Monthly usage (L): 1320.00
Yearly usage (L): 16060.00
Estimated Daily Cost (£): £0.11
Estimated Monthly Cost (£): £3.30
Estimated Yearly Cost (£): £40.15


4) Using large numbers as inputs


Inputts default name, 9999999999999

Expecteed: wont be acccepted
Result: Refuses nnumber - out of range

5) Empty name

Input: space
expected: rejecteed
resuult : rejected
---------------------------

(6) Behaviour tests for Water cost calculuaator

Input (all apps are called shower)

flowRate = 10, minutes = 5, price = 2

Expected: To work annd create reciept
Result: 

Shower
------------------
Daily usage (L): 50.00
Monthly usage (L): 1500.00
Yearly usage (L): 18250.00
Estimated Daily Cost (£): £0.10
Estimated Monthly Cost (£): £3.00
Estimated Yearly Cost (£): £36.50

Successfully creaated
---------------------------------------------

Inputs
flowRate = 0, minutes = 100, price = 1 
Expected: all values will be 0

Result:

SHower
------------------
Daily usage (L): 0.00
Monthly usage (L): 0.00
Yearly usage (L): 0.00
Estimated Daily Cost (£): £0.00
Estimated Monthly Cost (£): £0.00
Estimated Yearly Cost (£): £0.00


 Receipt has been created and saved to WaterUsageReceipt.txt


B) Cycle-Based Appliance Calculation Tests

Inputs: 
volume = 5, cycles = 3, price = 1
Expecteed: SHould work

Result:

shower
------------------
Daily usage (L): 15.00
Monthly usage (L): 450.00
Yearly usage (L): 5475.00
Estimated Daily Cost (£): £0.02
Estimated Monthly Cost (£): £0.45
Estimated Yearly Cost (£): £5.48

Input
volume = 0, cycles = 10, price = 1
Exppected: ALl vlaues 0
Resuult: As preedicted
shower
------------------
Daily usage (L): 0.00
Monthly usage (L): 0.00
Yearly usage (L): 0.00
Estimated Daily Cost (£): £0.00
Estimated Monthly Cost (£): £0.00
Estimated Yearly Cost (£): £0.00



(7)Test for JSON file loading and Library catalogue behaviour


1)JSON FIle missing

Input, will delete JSON file
Expected: Will not work, throws an error
Result: Just says no book in catalogue, so works without persistence

2) Corrupted JSON

Input: Put invalid data in the JSON - 'lorem ipsom' instead of the books
Expeected: An  error will be thrown
Result: Unhandled exception. System.Text.Json.JsonException: 'l' is an invalid start of a value. Path: $ | LineNumber: 0 | BytePositionInLine: 0.
 ---> System.Text.Json.JsonReaderException: 'l' is an invalid start of a value. LineNumber: 0 | BytePositionInLine: 0.
   at System.Text.Json.ThrowHelper.ThrowJsonReaderException(Utf8JsonReader& json, ExceptionResource resource, Byte nextByte, ReadOnlySpan`1 bytes)
   at System.Text.Json.Utf8JsonReader.ConsumeValue(Byte marker)
   at System.Text.Json.Utf8JsonReader.ReadFirstToken(Byte first)
   at System.Text.Json.Utf8JsonReader.ReadSingleSegment()
   at System.Text.Json.Utf8JsonReader.Read()
   at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, JsonSerializerOptions options, ReadStack& state)
   --- End of inner exception stack trace ---
   at System.Text.Json.ThrowHelper.ReThrowWithPath(ReadStack& state, JsonReaderException ex)
   at System.Text.Json.Serialization.JsonConverter`1.ReadCore(Utf8JsonReader& reader, JsonSerializerOptions options, ReadStack& state)
   at System.Text.Json.JsonSerializer.ReadFromSpan[TValue](ReadOnlySpan`1 utf8Json, JsonTypeInfo`1 jsonTypeInfo, Nullable`1 actualByteCount)
   at System.Text.Json.JsonSerializer.ReadFromSpan[TValue](ReadOnlySpan`1 json, JsonTypeInfo`1 jsonTypeInfo)
   at MyProject.Calculator.LibraryCatalogue.LoadCatalogue() in /home/kallam/PFC/PartA/Program.cs:line 546
   at MyProject.Calculator.LibraryCatalogue.LibMain() in /home/kallam/PFC/PartA/Program.cs:line 589
   at MyProject.Calculator.LibraryCatalogue.Program.Main(String[] args) in /home/kallam/PFC/PartA/Program.cs:line 790
Exception error

3) Add one book
Inputs:
Name - "How to get an expcetional 1st in computer science"
Author - Kallam Samad
Genre- Non fiction, autobiography

Expected result -  Will be do able


Result - Is a valid book and is added to JSON

    "Title": "How to get an Exceptional 1st in Computer Science",
    "Author": "Kallam Samad",
    "Genre": [
      "Autobiography"
    ],
    "IsFiction": false
  }
]

4) Remove a book

Input presss 2) remove book, called lord of the rings
Expected: boook will be remooved
result: Book 'lord of the rings' removed.

5) Filter by Genre
Inputs - choose fictiion>choose horor
Expected output - displays all horror books in fiction
Result - Displays Books in genre 'Horror':
- Dracula by Bram Stoker

6) List all books

Innput press 4)
Expected output - SHows all books
Output - All books in catalogue:
- Dracula by Bram Stoker (Horror) [Fiction]
- Dune by Frank Herbert (Science Fiction) [Fiction]
- The Girl with the Dragon Tattoo by Stieg Larsson (Crime) [Fiction]
- The Da Vinci Code by Dan Brown (Thriller) [Fiction]
- The Story of My Life by Helen Keller (Autobiography) [Non-Fiction]
- Sapiens: A Brief History of Humankind by Yuval Noah Harari (History) [Non-Fiction]
- A Brief History of Time by Stephen Hawking (Science) [Non-Fiction]
- Meditations by Marcus Aurelius (Philosophy) [Non-Fiction]
- Introduction to Algorithms by Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein (Science, Computer Science) [Non-Fiction]
- Clean Code: A Handbook of Agile Software Craftsmanship by Robert C. Martin (Science, Computer Science) [Non-Fiction]
- The Pragmatic Programmer by Andrew Hunt, David Thomas (Science, Computer Science) [Non-Fiction]
- Design Patterns: Elements of Reusable Object-Oriented Software by Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides (Science, Computer Science) [Non-Fiction]
- Structure and Interpretation of Computer Programs by Harold Abelson, Gerald Jay Sussman (Science, Computer Science) [Non-Fiction]
- 1984 by George Orwell (Science Fiction) [Fiction]
- How to get an Exceptional 1st in Computer Science by Kallam Samad (Autobiography) [Non-Fiction]
1) Add Book
 does as expected


(8) CSV files tests

1) CSV file present

Input -  A value that is invalid, using ! 
Expected - Program will read  the csv for any forvvbideenn symbols
Result - Input contains forbidden symbols. Please try again. It reads, since it rejects the oinput

2) CSV file missing

Input  - Will delete the csv and input !
Expected - willl still  be reejected but with caveats. The default list of
forbidden symmbols is  not complete, so some symbols will be accepted
result  - "Running Household Water Usage & Cost Calculat ForbiddenSymbols.csv not found. Using default list." so it works

3)  All values in CSV removed
Input - remove all content from CSVs, then input !
Expected - will accept the ! as  valid
Result - Accepts !

4) ForbidddenSymbols.csv - adding spaces to it
Input - space
Expected- Would still work beecause I use ..trim()
Result - It workss with spaaces

5) Hex file having less than 16 vallues

input - delete all numbers
expected - has a fallback list so will work still
result -  Running Household Water Usage & Cost Calculator

ForbiddenSymbols.csv not found. Using default list.
SO doesn't work if csv  is deleted



(9)Hex values

Input        Expected           Result
1) 15         F             Hexadecimal: 0xF
2) 1           1            0x1
3) 2           0x2          0x2
4)  100       0x64          Hexadecimal: 0x64
5)-1          invalid input Invalid input! Choose a number from 0-999999999
6)-1000           invalid input Invalid input! Choose a number from 0-999999999
7)!           invalid input Invalid input! Choose a number from 0-999999999
8)@           invalid input Invalid input! Choose a number from 0-999999999
9)#           invalid input Invalid input! Choose a number from 0-999999999
10)null        breaks program           CS0037 error
*/


using System;
using System.Text.Json;
using System.IO;
using System.Linq;
using System.Collections.Generic;



namespace MyProject
{
    
    class MenuHelper{/* Grouped helper methods into a class*/
        public static void Menu(List<string> options){
                        for (int x=0; x<options.Count;x++)
            {
                    Console.WriteLine($"{x+1}) {options[x]}");

            }                               /* This method creates the menu and has parameters with data type
            of a list, which is called Options*/
        }
        public static int ValidChoice(string prompt, int min, int max){

                /* This method is used to validate the input given by the end user and uses parameters of min and max.*/
            while(true){
                
                Console.WriteLine(prompt);
                string? choice = Console.ReadLine();
                bool isValidInput = int.TryParse(choice, out int SelectedOption);
                if (isValidInput && SelectedOption >= min && SelectedOption <= max)
                {
                    return SelectedOption;
                }

                else
                {   
                    Console.WriteLine($"Invalid input! Choose a number from {min}-{max}");
                }
                
            }

        }
            public static decimal ValidChoice(string prompt, decimal min, decimal max){

                /* This method is used to validate the input given by the end user and uses parameters of min and max.*/
            while(true){
                
                Console.WriteLine(prompt);
                string? choice = Console.ReadLine(); 
                bool isValidInput = decimal.TryParse(choice, out decimal SelectedOption);
                if (isValidInput && SelectedOption >= min && SelectedOption <= max)
                {
                    return SelectedOption;
                }

                else
                {   
                    Console.WriteLine($"Invalid input! Choose a number from {min}-{max}");
                }
                
            }

        }
    }
 
    class Calculator{
        static List<string> forbiddenSymbols = LibraryCatalogue.LoadForbiddenSymbols();

        public static void Calculations(string appliance, decimal dailyUsage, decimal waterPrice){
            decimal monthlyUsage=dailyUsage*30;
            decimal yearlyUsage=dailyUsage*365;
            decimal dailyCost=(dailyUsage/1000)*waterPrice;
            decimal monthlyCost=(monthlyUsage/1000)*waterPrice;
            decimal yearlyCost=(yearlyUsage/1000) * waterPrice;
            string receipt = $"{appliance}\n------------------\n" +
                     $"Daily usage (L): {dailyUsage:F2}\n" +
                     $"Monthly usage (L): {monthlyUsage:F2}\n" +
                     $"Yearly usage (L): {yearlyUsage:F2}\n" +
                     $"Estimated Daily Cost (£): £{dailyCost:F2}\n" +
                     $"Estimated Monthly Cost (£): £{monthlyCost:F2}\n" +
                     $"Estimated Yearly Cost (£): £{yearlyCost:F2}\n\n";
            Console.WriteLine(receipt);
            File.AppendAllText("WaterUsageReceipt.txt", receipt);
            Console.WriteLine(" Receipt has been created and saved to WaterUsageReceipt.txt\n");
        }
        public static void  CalcDailyUsage(string appliance, decimal flowRate, int minutes, decimal waterPrice){
            decimal dailyUsage=flowRate*minutes;
            Calculator.Calculations(appliance,dailyUsage,waterPrice);
        }
        public static void CalcDailyUsage(string appliance,decimal volume, decimal cycles, decimal waterPrice){
            decimal dailyUsage=volume*cycles;
            Calculator.Calculations(appliance,dailyUsage,waterPrice);
                }

       public static string GetValidInput(string prompt, List<string> forbiddenSymbols)
{
    string input = "";

    while (true)
    {
        Console.WriteLine(prompt);
        input = Console.ReadLine()?.Trim() ?? "";

      
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty. Please enter a valid value.");
            continue;
        }

    
        if (input.Any(ch => forbiddenSymbols.Contains(ch.ToString())))
        {
            Console.WriteLine("Input contains forbidden symbols. Please try again.");
            continue;
        }

         
        break;
    }

    return input;
}





    
    public static void RunCalculator(){
        var forbiddenSymbols = LibraryCatalogue.LoadForbiddenSymbols();

        string appName=GetValidInput("Enter Appliance Name:",forbiddenSymbols);
        int SelectedOption=MenuHelper.ValidChoice("\nPick 1 or 2:\n1) For Time-Based Appliances \n2) For Cycle based appliances \n",1,2);
        if (SelectedOption==1){
            decimal flowRate=MenuHelper.ValidChoice("Enter the flow rate (Litres/Minute)",0m,999999999m);
            int minutes=MenuHelper.ValidChoice("Enter minutes used per day",0,999999999);
            decimal waterPrice=MenuHelper.ValidChoice("Enter water price per 1000L",0m,999999999m);
            Calculator.CalcDailyUsage(appName,flowRate, minutes, waterPrice);
            }
        else if (SelectedOption==2){
            decimal volume=MenuHelper.ValidChoice("Enter the volume in (Litres/cycle)",0m,999999999m);
            decimal cycles=MenuHelper.ValidChoice("Enter cycles per day",0m,999999999m);
            decimal waterPrice=MenuHelper.ValidChoice("Enter water price per 1000L",0m,999999999m);
            Calculator.CalcDailyUsage(appName,volume,cycles,waterPrice);
        }
    }

    class Book{
    
        public string Title{get;set;

        }
        public string Author{get;set;

        }
        public List<string> Genre{get;set;
        }
        public bool IsFiction { get; set;
         }
        public Book()
        {
            Title = "";
            Author = "";
            Genre = new List<string>(); 
        }

        public Book(string title, string author, List<string> genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }
    class FictionBook : Book{

    }
    class NonFictionBook: Book{

    }
    class LibraryCatalogue{
    private static List<Book> books = new List<Book>();
    private static string filePath = "books.json";
    public static List<string> LoadForbiddenSymbols()
{
    string csvPath = Path.Combine(AppContext.BaseDirectory, "ForbiddenSymbols.csv");

    if (File.Exists(csvPath))
    {
        return File.ReadAllLines(csvPath)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim().Trim('"'))
                .ToList();
    }
    else
    {
        Console.WriteLine("ForbiddenSymbols.csv not found. Using default list.");
        return new List<string> { "<", ">", "|", "*", "\\", "/", "?", ":", "!", "\"" };
    }
}


    public static void SaveCatalogue()
    {
        string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
        Console.WriteLine("Catalogue saved to JSON.");
    }

    public static void LoadCatalogue()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
            Console.WriteLine("Catalogue loaded from JSON.");
        }
        else
        {
            books = new List<Book>();
        }
    }
      public static void  AddBook(Book b){
        books.Add(b);
        Console.WriteLine($"Book '{b.Title}' added.");
            
        }
        public static void RemoveBook(string title){
            var book=books.FirstOrDefault(b=>b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book!=null)
            {
                books.Remove(book);
                Console.WriteLine($"Book '{title}' removed.");
            }
            else{
                Console.WriteLine($"Book '{title}' not found");
            }
        }
        public static List<Book> FindByGenre(string genre, bool? isFiction = null)
        {
            return books.Where(b => b.Genre.Contains(genre) && 
                                    (isFiction == null || b.IsFiction == isFiction))
                        .ToList();
        }

      public static List<Book> ListOfAllBooks(){
        return books;
      }
private static List<string> FictionGenres = new List<string> 
{ "Horror", "Science Fiction", "Crime", "Thriller", "Adventure" };

private static List<string> NonFictionGenres = new List<string> 
{ "Autobiography", "History", "Science", "Philosophy" };

public static void LibMain()
{
    var forbiddenSymbols = LoadForbiddenSymbols();
    LoadCatalogue();
    bool back = false;

    while (!back)
    {
        List<string> options1 = new List<string>
        {
            "Add Book",
            "Remove Book",
            "Filter By Genre",
            "List of all Books",
            "Back to Main Menu"
        };

        MenuHelper.Menu(options1);
        int selectedOption = MenuHelper.ValidChoice("Choose 1-5:", 1, 5);

        switch (selectedOption)
        {
        case 1:{
        string title = GetValidInput("Enter Title:", forbiddenSymbols);
        string author = GetValidInput("Enter Author:", forbiddenSymbols);

        Console.WriteLine("Choose Category:");
        List<string> categories = new List<string> { "Fiction", "Non-Fiction" };
        MenuHelper.Menu(categories);
        int categoryChoice = MenuHelper.ValidChoice("Choose 1 for Fiction and 2 for Non fiction: ", 1, 2);
        bool isFiction = categoryChoice == 1;

        Console.WriteLine("Choose Genre:");
        var genreList = isFiction ? FictionGenres : NonFictionGenres;
        MenuHelper.Menu(genreList);
        int genreChoice = MenuHelper.ValidChoice("Choose 1-" + genreList.Count + ":", 1, genreList.Count);
        string genre = genreList[genreChoice - 1];

        Book newBook = new Book
        {
            Title = title,
            Author = author,
            Genre = new List<string> { genre },
            IsFiction = isFiction
        };

        AddBook(newBook);
        SaveCatalogue();
        break;
        }

            case 2:{
                string removeTitle = GetValidInput("Enter Title of book to remove:", forbiddenSymbols);
                RemoveBook(removeTitle);
                SaveCatalogue();
                break;
    }

            case 3:
            {
               Console.WriteLine("Choose Category:");
               List<string> filterCategories = new List<string> { "Fiction", "Non-Fiction" };
               int filterCategoryChoice = MenuHelper.ValidChoice("1) Choose Fiction 2) Choose Non-fiction:", 1, 2);
               bool isFictionFilter = filterCategoryChoice == 1;


                Console.WriteLine("Choose Genre:");
                var genreListFilter = isFictionFilter ? FictionGenres : NonFictionGenres;
                MenuHelper.Menu(genreListFilter);
                int filterChoice = MenuHelper.ValidChoice("Choose 1-" + genreListFilter.Count + ":", 1, genreListFilter.Count);
                string filterGenre = genreListFilter[filterChoice - 1];

                var results = FindByGenre(filterGenre, isFictionFilter);
                if (results.Count == 0)
                    Console.WriteLine($"No books found in genre '{filterGenre}'.");
                else
                {
                    Console.WriteLine($"Books in genre '{filterGenre}':");
                    foreach (var b in results)
                        Console.WriteLine($"- {b.Title} by {b.Author}");
                }
                break;
            }

                case 4:
                {
                    var allBooks = ListOfAllBooks();
                    if (allBooks.Count == 0)
                        Console.WriteLine("No books in catalogue.");
                    else
                    {
                        Console.WriteLine("All books in catalogue:");
                        foreach (var b in allBooks)
                            Console.WriteLine($"- {b.Title} by {b.Author} ({string.Join(", ", b.Genre)}) [{(b.IsFiction ? "Fiction" : "Non-Fiction")}]");
                    }
                    break;
                }


            case 5:
            {
                back = true;
                break;
            }
    }          

    }}


    class HexCalc {
    private static Dictionary<int, string> LoadHexMap()
    {
        string csvPath = Path.Combine(AppContext.BaseDirectory, "hexnumbers.csv");
        var hexMap = new Dictionary<int, string>();

        try
        {
            if (File.Exists(csvPath))
            {
                var lines = File.ReadAllLines(csvPath).Skip(1); // skip header
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int num))
                    {
                        hexMap[num] = parts[1].Trim();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        catch
        {
            // Default fallback if CSV not found or broken
            string[] defaultHex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            for (int i = 0; i < 16; i++)
                hexMap[i] = defaultHex[i];
            Console.WriteLine("hexnumbers.csv not found. Using default hex mapping.\n");
        }

        return hexMap;
    }

    public static void RunHexCalc()
    {
        var hexMap = LoadHexMap();
        int denary = MenuHelper.ValidChoice("Enter the base 10 number you want to convert to Hexadecimal:", 0, 999999999);

        if (denary == 0)
        {
            Console.WriteLine("0x0");
            return;
        }

        var remainder = new List<string>();
        while (denary > 0)
        {
            int digit = denary % 16;
            remainder.Add(hexMap[digit]);
            denary /= 16;
        }

        remainder.Reverse();
        Console.WriteLine($"Hexadecimal: 0x{string.Join("", remainder)}\n");
    }
}
    
    class Program
    {
        
        static void Main(string[] args)
        { /* The main defines the list and uses boolean logic to repeat the menu after eaach method
        for the options in the menu finish running I will also use new lines for readability*/
            List<string> options = new List<string> { "Household Water Usage & Cost Calculator", "Library Catalogue", "Hexadecimal Converter", "End the Program" };
            bool menuState=false;
            while (menuState==false){
                    MenuHelper.Menu(options);
                    int SelectedOption=MenuHelper.ValidChoice("Choose an option: \n",1,4);
                    switch(SelectedOption)
                    {
                    case 1:
                        Console.WriteLine($"\nRunning {options[SelectedOption-1]}\n");
                        string endCalc;
                        do
                        {
                            Calculator.RunCalculator();

                            while (true)
                            {
                                Console.WriteLine("Do you want to perform another calculation? Y/N");
                                endCalc = Console.ReadLine().Trim().ToUpper();
                                if (endCalc == "Y" || endCalc == "YES" || endCalc == "N" || endCalc == "NO")
                                    break; 
                                Console.WriteLine("Invalid input! Enter Y/N");
                            }

                        } while (endCalc == "Y" || endCalc == "YES");

                        break;
                        case 2:
                        Console.WriteLine($"\nRunning {options[SelectedOption-1]} \n");
                        LibraryCatalogue.LibMain();
                        break;
                        case 3:
                        Console.WriteLine($"\nRunning {options[SelectedOption-1]} \n");
                        HexCalc.RunHexCalc();
                        break;
                        case 4:
                        Console.WriteLine("\nTerminated the Program. \n ");
                        menuState=true;
                        break;
                        
                    }
            }

            }
        }
}}}