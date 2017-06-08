<?php
session_start();
$db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");

if($db->connect_error){
    die("Conection failed: " . $db->connect_error);
}
    $deleteUser= null;
    
    
    if ($_SERVER["REQUEST_METHOD"] == "POST"){
            $deleteUser = $_POST['deleteID'];
            
       
        
//        if(){
            $sql = "UPDATE user_reg SET Userlevel=2 WHERE ID='$deleteUser'";
                if ($db->query($sql) === TRUE) {
                    echo 'Vartotojas ištrintas'.'<br>'.'<a href="userInfo.php" > Grįžti atgal</a>';
                } else {
                    echo "Slaptažodžio pakeisti nepavyko. Prašome patikrinti įvestus duomenis." . $db->error.'<br>'.'<a href="userInfo.php" > Grįžti atgal</a>';
                }
//        }else{
//            echo 'Please try again';
//        }
    }
    ?>