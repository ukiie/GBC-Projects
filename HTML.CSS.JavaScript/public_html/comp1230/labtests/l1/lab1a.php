<!DOCTYPE html>
<html lang="">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="author" content="Roman Garasymovych">
    <meta name="description" content="Lab test 1 for COMP1230">
    <meta name="keywords" content="PHP, forms, POST">
    <title>Lab1a</title>
</head>

<body>
    <h1>Roman Garasymovych | 100940045</h1>
    
    <form method="post" name="form">
        <h3>Your Information</h3>
        <label>First Name:</label><br>
        <input type="text" name="first_name"><br>
        <label>Last Name:</label><br>
        <input type="text" name="last_name"><br>
        <label>Email:</label><br>
        <input type="text" name="email"><br>
        
        <button type="submit">Submit</button>
    </form>
    <?php
        echo "First Name: ", $_POST["first_name"], "<br>",
         "Last Name: ", $_POST["last_name"], "<br>",
         "Email: ", $_POST["email"];
        
    ?>
</body>
</html>
