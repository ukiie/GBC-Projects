<!DOCTYPE html>
<html lang="en-us">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="author" content="Roman Garasymovych">
    <meta name="keywords" content="PHP, Form, input, tables">
    <title>Pre-lab 1</title>
    <style>
        td{
            border: 1px solid;
            border-color: <?php echo $_GET["color"]?>
        }
    </style>
</head>

<body>
    <form method="get">
        <input type="hidden" value="Roman" name="first_name">
        <input type="hidden" value="Garasymovych" name="last_name">
        <input type="hidden" value="100940045" name="student_id">
        <label>Rows: </label>
        <select name="rows">
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
            <option value="10">10</option>
        </select>
        <br>
        <label>Columns: </label>
        <select name="columns">
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
            <option value="10">10</option>
        </select>
        <br>
        <label>Color: </label>
        <input type="text" name="color">
        <br>
        <button type="submit">Submit</button>
    </form>
    <?php 
        echo "<h1>", $_GET["first_name"]," ",$_GET["last_name"]," : ",$_GET["student_id"],"</h1>";
        $row = (empty($_GET["rows"]) ? 0 : $_GET["rows"]);
        $column = (empty($_GET["columns"]) ? 0 : $_GET["columns"]);
        $f_n = (empty($_GET["first_name"]) ? 0 : $_GET["first_name"]);
        $l_n = (empty($_GET["last_name"]) ? 0 : $_GET["last_name"]);
    ?>
    <table>
        <?php
            for($r=0;$r<$row;$r++)
                {
                    echo "<tr>";
                    for($c=0;$c<$column;$c++)
                    {
                        if(($r%2)==0)
                        {
                            echo "<td>",$f_n,"</td>";
                        }else 
                        {
                            echo "<td>",$l_n,"</td>";
                        }
                    }
                    echo "</tr>";
                }
        ?>
    </table>
</body>
</html>
