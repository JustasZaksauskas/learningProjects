<?php
session_start();
$db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");

$Name=null;
$Surname=null;

if($db->connect_error){
    die("Conection failed: " . $db->connect_error);
}
                
$sql = "SELECT Username, Name, Surname, Email, Password, Address, PhoneNumber, AvatarIMG, RegDate, Active FROM user_reg WHERE ID='{$_SESSION["sendID"]}'";
            
            
    $result = mysqli_query($db, $sql);

    if ($result->num_rows > 0) {

    while ($row = $result->fetch_assoc()) {
        $Name=$row["Name"];
        $Surname=$row["Surname"];
    }
    } else {
        if ($loginusername != null && $loginpassword != null) {
        $error = "Your Login Name or Password is invalid";
        }
      echo ' '.$error;
   }   

?>

    <!DOCTYPE html>
    <html lang="en" dir="ltr">

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
    <!-- a helper script for vaidating the form-->
    <script language="JavaScript" src="js/gen_validatorv31.js" type="text/javascript"></script>
    </head>

    <body>
        <div class="wrapper row1">
            <header id="header" class="clear" style="padding-bottom: 36px;">
                <nav>
                    <ul>
                        <li>
                            <?php echo 'Labas, '.$Name.' '.$Surname; ?>
                        </li>
                        <li><a href="userInfo.php"> Profilis</a></li>
                        <li><a href="logout.php"> Atsijungti</a></li>
                    </ul>
                </nav>

                <div id="hgroup">
                    <h1><a href="index.php">Pavežk mane</a></h1>
                    <h2>Pakeleivių ir vairuotojų svetainė</h2>
                </div>

                <div class="masina">
                    <img src="img/truck.png" alt="">
                </div>
            </header>
        </div>

        
        <div class="phpplace">
        <p>Jūsų kelionės:</p><br>
         <?php

$db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");

if ($db->connect_error) {
    die("Connection failed: " . $db->connect_error);
} 
$error = null;
 
	
    $sql = "SELECT trips.CityFrom, trips.CityTo, trips.TripDate, trips.TripTime, trips.Comments FROM trips INNER JOIN user_reg ON trips.UserID=user_reg.ID WHERE user_reg.ID='{$_SESSION["sendID"]}'";
    
    $result = mysqli_query($db, $sql);

    if ($result->num_rows > 0) {
      echo '<table border="1"><tr>';
            echo "<td><b>Iš kur</b> </td>";
            echo "<td><b>Į kur</b> </td>";
            echo "<td><b>Data</b> </td>";
            echo "<td><b>Laikas</b> </td>";
            echo "<td><b>Komentaras</b></td>";
            echo '</tr>';
        while ($row = $result->fetch_assoc()) {
           
		   echo '<tr>';
            echo "<td>" . $row["CityFrom"]. "</td>";
            echo "<td>" . $row["CityTo"]. "</td>";
            echo "<td>" . $row["TripDate"]. "</td>";
            echo "<td>" . $row["TripTime"]. "</td>";
            echo "<td>" . $row["Comments"]. "</td>";
            echo "</tr>";
        }
    } else {
            $error = "Deja, nėra kelionių pagal jūsų pasirinktus kriterijus";
		echo ' '.$error;
	}
     echo '</table>';
            
?>
       

            
                <p>Pridėti kelionę:</p><br>
                <?php 
$result = mysqli_query($db,"select City from cities"); 
   
    echo '<form action="" method="POST">';
    echo ' Iš: <select name="cityfrom">'; 
    if ($result->num_rows > 0) {
     
        while ($row = $result->fetch_assoc()) {
            echo '<option value="'.$row['City'].'">'.$row['City'].'</option>';
        }
    } else {
		echo ' '.$error;
	}
    echo '</select>';// Close your drop down box
    
    $result2 = mysqli_query($db,"select City from cities"); 
    echo ' Į: <select name="cityto">'; 
    if ($result2->num_rows > 0) {
     
        while ($row = $result2->fetch_assoc()) {
            echo '<option value="'.$row['City'].'">'.$row['City'].'</option>';
        }
    } else {
		echo ' '.$error2;
	}
    echo '</select>';// Close your drop down box
    
    echo ' Data: <input name="tripdate" type="text" id="datepicker">';
    
echo ' Laikas: <select name="triptime">';
echo '<option value="00:00:00">00:00</option>';
echo '<option value="00:30:00">00:30</option>';
echo '<option value="01:00:00">01:00</option>';
echo '<option value="01:30:00">01:30</option>';
echo '<option value="02:00:00">02:00</option>';
echo '<option value="02:30:00">02:30</option>';
echo '<option value="03:00:00">03:00</option>';
echo '<option value="03:30:00">03:30</option>';
echo '<option value="04:00:00">04:00</option>';
echo '<option value="04:30:00">04:30</option>';
echo '<option value="05:00:00">05:00</option>';
echo '<option value="05:30:00">05:30</option>';
echo '<option value="06:00:00">06:00</option>';
echo '<option value="06:30:00">06:30</option>';
echo '<option value="07:00:00">07:00</option>';
echo '<option value="07:30:00">07:30</option>';
echo '<option value="08:00:00">08:00</option>';
echo '<option value="08:30:00">08:30</option>';
echo '<option value="09:00:00">09:00</option>';
echo '<option value="09:30:00">09:30</option>';
echo '<option value="10:00:00">10:00</option>';
echo '<option value="10:30:00">10:30</option>';
echo '<option value="11:00:00">11:00</option>';
echo '<option value="11:30:00">11:30</option>';
echo '<option value="12:00:00">12:00</option>';
echo '<option value="12:30:00">12:30</option>';
echo '<option value="13:00:00">13:00</option>';
echo '<option value="13:30:00">13:30</option>';
echo '<option value="14:00:00">14:00</option>';
echo '<option value="14:30:00">14:30</option>';
echo '<option value="15:00:00">15:00</option>';
echo '<option value="15:30:00">15:30</option>';
echo '<option value="16:00:00">16:00</option>';
echo '<option value="16:30:00">16:30</option>';
echo '<option value="17:00:00">17:00</option>';
echo '<option value="17:30:00">17:30</option>';
echo '<option value="18:00:00">18:00</option>';
echo '<option value="18:30:00">18:30</option>';
echo '<option value="19:00:00">19:00</option>';
echo '<option value="19:30:00">19:30</option>';
echo '<option value="20:00:00">20:00</option>';
echo '<option value="20:30:00">20:30</option>';
echo '<option value="21:00:00">21:00</option>';
echo '<option value="21:30:00">21:30</option>';
echo '<option value="22:00:00">22:00</option>';
echo '<option value="22:30:00">22:30</option>';
echo '<option value="23:00:00">23:00</option>';
echo '<option value="23:30:00">23:30</option>';
echo '</select>';
    
    echo ' Comment: <input name="tripcomment" type="text">';

    echo '<input type="submit" value="Pridėti" />';
        echo '</form>';
    
                $error = null;
                $cityfrom = null;
                $cityto = null;
                $tripdate = null;
                $triptime = null;
                $tripcomment = null;
    
        if ($_SERVER["REQUEST_METHOD"] == "POST"){
                
                $cityfrom = $_POST['cityfrom'];
                $cityto = $_POST['cityto'];
                $tripdate = $_POST['tripdate'];
                $triptime = $_POST['triptime'];
                $tripcomment = $_POST['tripcomment'];
                
            $userID=$_SESSION["sendID"];
                $sql = "INSERT INTO trips (CityFrom,CityTo,TripDate,TripTime,UserID,Comments) VALUES ('$cityfrom','$cityto','$tripdate','$triptime','$userID','$tripcomment')";
                    if ($db->query($sql) === TRUE) {
                    echo "Kelionė pridėta";
                    } else {
                    echo "Error: " . $sql . "<br>" . mysqli_error($db);
                    }

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
