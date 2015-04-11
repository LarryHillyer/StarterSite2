@Code
            Dim imagepath=""
            If Not(Request("Choice")=Nothing) Then
             imagepath="images/" + Request("Choice")
            End If

End Code

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>Traveling Rocks</title>
    </head>
    <body>
        <h1>Display Images</h1> 
        <form method="post" action=""> 
          I want to see: 
          <select name="Choice"> 
            <option value="IMG_0388.jpg">Photo 1</option> 
            <option value="IMG_0588.jpg">Photo 2</option> 
            <option value="IMG_1261.jpg">Photo 3</option> 
          </select> 
          <input type="submit" value="Submit" /> 
        </form>
        @Code
            If Not (imagepath=Nothing) Then
              @<p>
                 <img src="@imagePath" alt="Sample"  width="150px" height="100px"/>
               </p>
            End If
        End Code
    </body>
</html>
