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
    </head>

    <body>
        <div class="wrapper row1">

            <header id="header" class="clear" style="padding-bottom: 36px;">

                <nav>
                    <ul>
                        <li>Sveiki, esate prisijungęs su administratoriaus teisėmis</li>
                        <li><a href="index.php"> Atsijungti</a></li>
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
$error = null;

$sql = "SELECT * FROM user_reg";

$result = mysqli_query($db, $sql);

if ($result->num_rows > 0) {
echo '<table border="1"><tr>';
echo "<td><b>Vartotojo ID</b> </td>";
echo "<td><b>Vartotojo vardas</b> </td>";
echo "<td><b>Vardas</b> </td>";
echo "<td><b>Pavardė</b> </td>";
echo "<td><b>Telefono numeris</b> </td>";
echo "<td><b>Adresas</b> </td>";
echo "<td><b>Vartotojo statusas</b> </td>";
echo '</tr>';
while ($row = $result->fetch_assoc()) {

echo '<tr>';
echo "<td>" . $row["ID"]. "</td>";
echo "<td>" . $row["Username"]. "</td>";
echo "<td>" . $row["Name"]. "</td>";
echo "<td>" . $row["Surname"]. "</td>";
echo "<td>" . $row["PhoneNumber"]. "</td>";
echo "<td>" . $row["Address"]. "</td>";
echo "<td>" . $row["Userlevel"]. "</td>";
echo '</tr>';

}
} else {
$error = "vartotojai nepasiekiami";
echo ' '.$error;
}echo '</table>';
 
echo '<br> Deaktyvuoti vartotoją pagal ID';
            echo '<form method="POST" action="deleteUser.php" >';
            echo '<input type="text" name="deleteID">';
             echo '<input type="submit" value="Istrinti" >';
            echo '</form>';
            
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
