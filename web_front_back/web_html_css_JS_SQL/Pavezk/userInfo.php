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
        <title>Pavežk</title>
        <meta http-equiv="content-type" content="text/html;charset=utf-8" />
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
                        <li>
                            <?php echo 'Labas, '.$Name.' '.$Surname; ?>
                        </li>
                        <li><a href="index.php"> Atsijungti</a></li>
                        <li><a href="userPage.php"> Vartotojo puslapis</a></li>
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
            <div style="font-size: 15px;">
                <ul type="square">

                    <?php 
$Username=null;
$Name=null;
$Surname=null;
$Email=null;
$Password=null;
$Address=null;
$AvatarIMG=null;
$Active=null;
$Phonenumber=null;
$Regdate=null;

$sql = "SELECT * FROM user_reg WHERE ID='{$_SESSION["sendID"]}'";
            
        $result = mysqli_query($db, $sql);

    if ($result->num_rows > 0) {

    while ($row = $result->fetch_assoc()) {
        $Username=$row["Username"];
        $Name=$row["Name"];
        $Surname=$row["Surname"];
        $Email=$row["Email"];
        $Password=$row["Password"];
        $Address=$row["Address"];
        $Phonenumber=$row["PhoneNumber"];
        $AvatarIMG=$row['AvatarIMG'];
        $Regdate=$row['RegDate'];
        $Active=$row["Active"];

    }
    } else {
            if ($loginusername != null && $loginpassword != null) {
            $error = "Your Login Name or Password is invalid";
            }
      echo ' '.$error;
   }   

        $avatar = '<img style="height:100px;  width: 100px;" src="data:image/jpeg;base64,'.base64_encode($AvatarIMG). ' " />';
        echo $avatar.'<br>'; 
        ?>
                    <li>
                        <?php echo 'Username: '.$Username; ?>
                    </li>
                    <li>
                        <?php echo 'Name: '.$Name; ?>
                    </li>
                    <li>
                        <?php echo 'Surname: '.$Surname; ?>
                    </li>
                    <li>
                        <?php echo 'Email: '.$Email; ?>
                    </li>
                    <li>
                        <?php echo 'Address: '.$Address; ?>
                    </li>
                    <li>
                        <?php echo 'Phone Number: '.$Phonenumber; ?>
                    </li>
                    <li>
                        <?php echo 'Registration date: '.$Regdate; ?>
                    </li>

                </ul>
            </div>

            <p>
                Slaptažodžio keitimas:
            </p>
            <form method="post" action="changePWD.php" class="" enctype="multipart/form-data">
                <label for="username">Vartotojo vardas</label>
                <input type="text" id="username" name="username" placeholder="Vartotojo vardas"><br>
                <label for="oldpassword">Esamas slaptažodis</label>
                <input type="password" id="oldpassword" name="oldpassword" placeholder="Esamas slaptažodis"><br>
                <label for="newpassword">Naujas slaptažodis</label>
                <input type="password" id="newpassword" name="newpassword" placeholder="Naujas slaptažodis"><br>
                <label for="newrepeatpassword">Pakartokite naują slaptažodį</label>
                <input type="password" id="newrepeatpassword" name="newrepeatpassword" placeholder="Pakartokite naują slaptažodį"><br>
                <input type="submit" name="submit" value="Keisti slaptažodį" />
            </form>
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
