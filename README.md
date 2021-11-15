# areaCodeCSharp

This is my project for Code Louisville C# cohort. 
AreaCodeReader is a console application that takes in a user's input and tries to decide if what they have entered is an area code or a state. If it is a state, it returns all area codes associated with that state. If given an area code, it returns the state it belongs to.

Our project requirements ask for three (3) features from the "Feature List" on the syllabus. For consideration I have:
1) Created a master loop allowing for repeated entry of commands, as well as exiting out of the program: The while(true) loop in Program.cs should fulfill this.
2) Created a dictionary or list and use those values: I create multiple lists in my program. country in Program.cs is a list made up of lists.
3) Read data from an external source: Line 10 of Program.cs
4) LINQ query: In line 20 of State.cs I use LINQ to filter out blank list entries
