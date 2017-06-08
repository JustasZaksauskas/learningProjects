<?php
session_start();

$db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");

if($db->connect_error){
    die("Conection failed: " . $db->connect_error);
}else{
    echo 'Connected to database'.'<br>';
}
                $error = null;
                $loginusername = null;
                $loginpassword = null;
    
        if ($_SERVER["REQUEST_METHOD"] == "POST"){
                $loginusername = $_POST['loginusername'];
                $loginpassword = $_POST['loginpassword'];

            $sql = "SELECT ID, Userlevel FROM user_reg WHERE Username='$loginusername' and Password='$loginpassword'";
            
                $result = mysqli_query($db, $sql);
            
            if ($result->num_rows > 0) {
      
            while ($row = $result->fetch_assoc()) {
                $_SESSION["sendID"]=$row["ID"];
               echo $row["Userlevel"];
                    
                    if($row["Userlevel"]==1){
                        header("location:userPage.php");
                    }else{
                        header("location: adminPage.php");
                    }
                }
            } else {
                    if ($loginusername != null && $loginpassword != null) {
                    $error = "Your Login Name or Password is invalid";
                    }
		      echo ' '.$error;
	       }   
        }
?>
