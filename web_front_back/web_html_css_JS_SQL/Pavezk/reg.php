<?php

$db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");

if($db->connect_error){
    die("Conection failed: " . $db->connect_error);
}else{
    echo 'Connected to database'.'<br>';
}

        $error = null;
        $username = null;
        $name = null;
        $surname = null;
        $email = null;
        $password = null;
        $repeatpassword = null;
        $adress = null;
        $phonenumber = null;
        $avatarIMG = null;


if ($_SERVER["REQUEST_METHOD"] == "POST"){
        $username = $_POST['username'];
        $name = $_POST['name'];
        $surname = $_POST['surname'];
        $email = $_POST['email'];
        $password = $_POST['password'];
        $repeatpassword = $_POST['repeatpassword'];
        $address = $_POST['address'];
        $phonenumber = $_POST['phonenumber'];
            $avatarIMG = addslashes(file_get_contents($_FILES['avatarIMG']['tmp_name']));
                
    if($password===$repeatpassword && $username!=null && $name!=null && $surname!=null && $email!=null && $password!=null && $phonenumber!=null && $address!=null){
        $sql = "INSERT INTO user_reg (Username,Name,Surname,Email,Password,Address,PhoneNumber,AvatarIMG,Active,Userlevel) VALUES ('$username','$name','$surname','$email','$password','$address','$phonenumber','{$avatarIMG}',1,1)";
            if ($db->query($sql) === TRUE) {
            echo "Registration successfully";
            header("location:index.php");
            } else {
            echo "Toks vartotojovardasjau yra";
            }
    }else{
        echo "Užpildykite visus registracijai reikalingus laukelius";
    }
               
    }

?>
