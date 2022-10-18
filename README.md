# UnitTest Demo

## Overview

Project uses `MSTest` V2 framework. There are other popular frameworks such as `xUnit` and `NUnit`. All are robust and have plenty of community support.

 **Helpful links**  
 - https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/  
 - https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest  
 - https://www.lambdatest.com/learning-hub/nunit-tutorial
 - https://xunit.net/  

 **Tutorials**   
 https://app.pluralsight.com/library/courses/basic-unit-testing-csharp-developers/table-of-contents

 
 ## Best Practices

 - Each Test Method should only have one assert, not multiple.
 - Don't be afraid to be verbose with Method names.  In fact, it's standard to be verbose and indicate exactly what it does. Ex: `GroupSalesOrderContainsGroupName()`.  The test names within this demo app are not prime examples of how to name your tests.
 - Remember "AAA" - Arrange, Act, & Assert
     - **Arrange** - Initialize variables. Create the variables and types we need
     - **Act** - Invoke method to test
     - **Assert** - Verify the Act



