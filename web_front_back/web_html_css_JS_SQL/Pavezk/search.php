<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en" dir="ltr" xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta charset="utf-8">
    <title>Pavežk</title>
    <link rel="stylesheet" href="styl/layout.css" type="text/css">
    <link rel="stylesheet" href="styl/profile.css" type="text/css">
    <link rel="icon" href="img/favicon.ico" type="image/ico">
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script>
        $(function() {
            $("#header").load("header.html");
            $("#footer").load("footer.html");
        });

    </script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <link rel="stylesheet" href="/resources/demos/style.css">
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
        $(function() {
            $("#datepicker").datepicker({
                dateFormat: 'yy-mm-dd',
                dayNames: ['Sekmadienis', 'Pirmadienis', 'Antradienis', 'Trečiadienis', 'Ketvirtadienis', 'Penktadienis', 'Šeštadienis'],
                dayNamesMin: ['Sk', 'Pr', 'An', 'Tr', 'Kt', 'Pn', 'Št'],
                monthNames: ['Sausis', 'Vasaris', 'Kovas', 'Balandis', 'Gegužė', 'Birželis', 'Liepa', 'Rugpjūtis', 'Rugsėjis', 'Spalis', 'Lapkritis', 'Gruodis'],
                monthNamesShort: ['Sau', 'Vas', 'Kov', 'Bal', 'Geg', 'Bir', 'Lie', 'Rgp', 'Rgs', 'Spl', 'Lap', 'Grd']
            });
        });

    </script>

</head>

<body>
    <div class="wrapper row1">

        <header id="header" class="clear" style="padding-bottom: 36px;">

            <nav>
                <ul>
                    <form method="post" action="login.php" class="loginInput" enctype="multipart/form-data">

                        <li><input type="text" id="loginusername" name="loginusername" placeholder="Vartotojo vardas"></li>
                        <li><input type="password" id="loginpassword" name="loginpassword" placeholder="Slaptažodis"></li>
                        <li><input type="submit" name="submit" value="Prisijungti" style="width:272px"></li>
                    </form>
                </ul>
            </nav>
            <div id="hgroup">
                <h1><a href="#">Pavežk mane</a></h1>
                <h2>Pakeleivių ir vairuotojų svetainė</h2>
            </div>

            <div class="masina">
                <img src="img/truck.png" alt="">
            </div>
        </header>
    </div>

    <!-- content -->
    <div class="phpplace">
        <?php

$db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");

if ($db->connect_error) {
    die("Connection failed: " . $db->connect_error);
} 
$error = null;
 if ($_SERVER["REQUEST_METHOD"] == "GET") {
     
     
     
     if (isset($_GET['cityfrom'])) {
    $query = $_GET['cityfrom'];
    $query2 = $_GET['cityto'];
         $tripdate = $_GET['tripdate'];
}
 
     if ($tripdate == "") {
         $createDate = new DateTime();
         $tripdate2 = $createDate->format('Y-m-d');
         $sign = '>=';
     } else{
         $tripdate2 = date("Y-m-d", strtotime($tripdate));
         $sign = '=';
     }
	
    $sql = "SELECT trips.CityFrom, trips.CityTo, trips.TripDate, trips.TripTime, trips.Comments, user_reg.Username, user_reg.Name, user_reg.Surname, user_reg.Email, user_reg.PhoneNumber FROM trips INNER JOIN user_reg ON trips.UserID=user_reg.ID WHERE trips.CityFrom LIKE '$query' and trips.CityTo LIKE '$query2' and trips.TripDate $sign '$tripdate2' ORDER BY trips.TripDate";
    $result = mysqli_query($db, $sql);

    if ($result->num_rows > 0) {
      echo '<table border="1"><tr>';
            echo "<td>Iš kur </td>";
            echo "<td>Į kur </td>";
            echo "<td>Data </td>";
            echo "<td>Laikas </td>";
            echo "<td>Komentaras</td>";
            echo "<td>Vartotojo vardas </td>";
            echo "<td>Vardas </td>";
            echo "<td>Pavardė </td>";
            echo "<td>Telefono numeris </td>";
            echo '</tr>';
        while ($row = $result->fetch_assoc()) {
           
		   echo '<tr>';
            echo "<td>" . $row["CityFrom"]. "</td>";
            echo "<td>" . $row["CityTo"]. "</td>";
            echo "<td>" . $row["TripDate"]. "</td>";
            echo "<td>" . $row["TripTime"]. "</td>";
            echo "<td>" . $row["Comments"]. "</td>";
            echo "<td>" . $row["Username"]. "</td>";
            echo "<td>" . $row["Name"]. "</td>";
            echo "<td>" . $row["Surname"]. "</td>";
            echo "<td>" . $row["PhoneNumber"]. "</td>";
            echo "</tr>";
        }
    } else {
            $error = "Deja, nėra kelionių pagal jūsų pasirinktus kriterijus";
		echo ' '.$error;
	}
     echo '</table>';
            echo 'Jei norite ieškoti kitos kelionės spauskte '.'<br>'.'<a class="linkas" href="index.php" > Grįžti atgal</a>';
     
 }
?>
    </div>

    <!-- Footer -->
    <div class="wrapper row3">
        <div id="footer"></div>
    </div>

    <script>
        // Get the modal
        var modal = document.getElementById('profile');

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function(event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }

    </script>

</body>

</html>
