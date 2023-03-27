# _Factory_

#### By _**Michael Sol**_

#### _A MVC web application and database for a fictional factory exploring many to many relationships_

## Technologies Used

* _C#_
* _Dotnet 6_
* _SQL_

## Description

_Allows a fictional factory to organize engineers and their machines.  Engineers can work on many machines, and machines can have many engineers work on them_

## Setup/Installation Requirements

* _Navigate to the GitHub_
* _Clone the Repo_
* _Open the project using VS Code_
* _Open a new terminal_
* _In the terminal, navigate to 'newfactory.Solution/Factory'_ 
* _Create a appsettings.json file_
* _Include the following lines in it:_

{

    { 
        "ConnectionStrings": 
        {
            "DefaultConnection":"Server=localhost;Port=3306;database=michael_sol;uid=[YOUR-USER-HERE];pwd=[YOUR-PW-HERE];"
        }
    }
}

* _Run the migrations_
* _Run 'dotnet restore'_
* _Run 'dotnet build'_
* _Run 'dotnet start'_


## Known Bugs

*_None_

## License

_Contact Michael with any problems_

Copyright (c) _2/24/23_ _Michael Sol_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.