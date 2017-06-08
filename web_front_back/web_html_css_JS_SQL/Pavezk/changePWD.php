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
        <div style="height=800px; background-color: white;">
            <?php

    $username= null;
    $oldpassword= null;
    $newpassword = null;
    $newrepeatpassword = null;
    $Password =null;
    
    if ($_SERVER["REQUEST_METHOD"] == "POST"){
            $oldpassword = $_POST['oldpassword'];
            $newpassword = $_POST['newpassword'];
            $newrepeatpassword = $_POST['newrepeatpassword'];
        
        $sql = "SELECT Password FROM user_reg WHERE ID='{$_SESSION['sendID']}'";
             $result = mysqli_query($db, $sql);
            
            if ($result->num_rows > 0) {
      
            while ($row = $result->fetch_assoc()) {
                $Password=$row["Password"];
                }   
            }
        
        if($oldpassword===$Password && $newpassword===$newrepeatpassword && $newpassword!=null){
            $sql = "UPDATE user_reg SET Password='$newpassword' WHERE ID='{$_SESSION['sendID']}'";
                if ($db->query($sql) === TRUE) {
                    echo 'Tavo slaptažodis sėkmingai pakeistas'.'<br>'.'<a href="userInfo.php" > Grįžti atgal</a>';
                } else {
                    echo "Slaptažodžio pakeisti nepavyko. Prašome patikrinti įvestus duomenis." . $db->error.'<br>'.'<a href="userInfo.php" > Grįžti atgal</a>';
                }
        }else{
            echo 'Please try again';
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
