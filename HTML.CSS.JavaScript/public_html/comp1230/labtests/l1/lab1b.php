<!DOCTYPE html>
<html lang="">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="author" content="Roman Garasymovych">
    <meta name="description" content="Lab test 1 for COMP1230">
    <meta name="keywords" content="PHP, forms, POST">
    <title>Lab1b</title>
</head>

<body>
    <h1>Roman Garasymovych | 100940045</h1>
    
    <form method="get" name="form">
        <label>Num1: </label>
        <input type="text" name="num1">
        <label>Num2:</label>
        <input type="text" name="num2">
        <button type="submit">Submit</button>
    </form>
    <?php
        $num1 = $_GET["num1"];
        $num2 = $_GET["num2"];
        echo (
            "<table border= '1px'>
                <tr>
                    <td>".$num1."</td>
                    <td>"."   +   "."</td>
                    <td>".number_format($num2, 2)."</td>
                    <td>".number_format($num1 + $num2, 3)."</td>
                </tr>
                <tr>
                    <td>".$num1."</td>
                    <td>"."   -   "."</td>
                    <td>".number_format($num2, 2)."</td>
                    <td>".number_format($num1 - $num2, 3)."</td>
                </tr>
                <tr>
                    <td>".$num1."</td>
                    <td>"."   *   "."</td>
                    <td>".number_format($num2, 2)."</td>
                    <td>".number_format($num1 * $num2, 3)."</td>
                </tr>
                <tr>
                    <td>".$num1."</td>
                    <td>"."   /   "."</td>
                    <td>".number_format($num2, 2)."</td>
                    <td>".number_format($num1 / $num2, 3)."</td>
                </tr>
            </table>"
        );
    ?>
</body>
</html>
