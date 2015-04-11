@Code
    
End Code

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title></title>
    </head>
    <body>
        <h3>We suggest the following:</h3>
    <div>
        <h1>Task 2 Demo</h1>
        <p>The time is @DateTime.Now</p>

 @Code
 dim greeting = "Welcome to our site!" 
 dim weekDay = DateTime.Now.DayOfWeek 
 dim greetingMessage = greeting & " Today is: " & weekDay
 End Code 

 <p>The greeting is: @greetingMessage</p>


    </div>

    </body>
</html>
