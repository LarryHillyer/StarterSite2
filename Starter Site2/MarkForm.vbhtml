@Code
    
End Code

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title> Form Page</title>
    </head>
    <body>
@Code
    If IsPost Then
    Dim companyname As String = Request("companyname")
    Dim contactname As String = Request("companyname")
    @<p>
    You entered: <br /> 
    Company Name: @companyname <br />
    Contact Name: @contactname  <br />
    </p>
    Else
    @<form method="post" action="">
        Company Name:<br />
        <input type="text" name="CompanyName" value="" /><br />
        Contact Name:<br />
        <input type="text" name="ContactName" value="" /><br /><br />
        <input type="submit" value="Submit" class="submit" />
    </form>
    End If

End Code      
    </body>
</html>
