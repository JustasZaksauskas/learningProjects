<?php
$db= mysqli_connect("localhost","root","842650mysql","projektas");

if($db->connect_error){
    die("Conection failed: " . $db->connect_error);
}else{
    echo 'success';
    
}

?>
<!DOCTYPE html>
    <html>

    <head>
        <link rel="shortcut icon" href="bike.ico" />
        <title>BEST BIKE SHOP</title>
        <meta http-equiv="content-type" content="text/html;charset=utf-8" />
        <link rel="stylesheet" href="style.css" type="text/css" />

    </head>

    <script>
        function check() {
            document.getElementById("myCheck").checked = true;
        }

        function registration() {
            var inputName = document.getElementById('name').value;
            var inputLName = document.getElementById('lname').value;
            var inputEmail = document.getElementById('email').value;
            var inputPassword = document.getElementById('password').value;
            var inputRepeatPassword = document.getElementById('repeatpassword').value;
            var isItChecked = document.getElementById('isItChecked').checked;

            if (inputPassword == inputRepeatPassword && inputPassword != "" && inputRepeatPassword != "" && isItChecked == true) {
                alert('REGISTRATION SUCCESSFULLY');
                

            } else {
                if (inputPassword != inputRepeatPassword && inputPassword != "" && inputRepeatPassword != "" && isItChecked == true) {
                    alert('REPEATED PASSWORD IS INCORRECT');
                    document.getElementById("password").style.border = '3px solid red';
                    document.getElementById("repeatpassword").style.border = '3px solid red';

                } else if (isItChecked == false) {
                    alert('PLEASE AGREE WITH RULES');

                } else {
                    alert('REPEATED PASSWORD IS INCORRECT AND PLEASE AGREE WITH RULES');
                    document.getElementById("password").style.border = '3px solid red';
                    document.getElementById("repeatpassword").style.border = '3px solid red';
                }
            }
        }

        function openPage() {
            window.open("MainPage.html", "_self")
        }

    </script>


    <body class="index_body">

            <?php
                $name = null;
                $surname = null;
                $email = null;
                $password = null;
                $repeatpassword = null;


            if(isset($_POST['submit'])){
                $name = $_POST['name'];
                $surname = $_POST['surname'];
                $email = $_POST['email'];
                $password = $_POST['password'];
                $repeatpassword = $_POST['repeatpassword'];
            }
        
        if ($_SERVER["REQUEST_METHOD"] == "POST")
        
            $myusername = $_POST['username'];
            $mypassword = $_POST['password'];
            
        $sql = "SELECT ID, Username FROM test WHERE Username='$myusername' and Password='$mypassword'"
            $result = mysqli_query($db, $sql);
        
        
        if($result->){
            while ($row = $result->fetch_assoc()){
                echo "id: " . $row["ID"]. "<br>";
                echo "Username: " . $row["Username"]. "";
            }
        }
        
        
        
        $sql = "INSERT INTO test WHERE Username='$myusername' and Password='$mypassword'"
            $result = mysqli_query($db, $sql);
        
        
        if($result->){
            while ($row = $result->fetch_assoc()){
                echo "id: " . $row["ID"]. "<br>";
                echo "Username: " . $row["Username"]. "";
            }
        }
        
        
        
        
        ?>




                        <div class="header">
                            <table>
                                <tr>
                                    <td>
                                        <img class="logo" src="pictures/logo.gif">
                                    </td>
                                    <td>
                                        <p class="typeTitle">//BEST BIKE SHOP//</p>
                                        <p class="typeTitle">REGISTRATION</p>
                                    </td>
                                </tr>
                            </table>
                        </div>


                        <table class="registrationTable">
                            <tr>
                                <td>
                                    <form method="post" action="" class="registratonInput">
                                        <label for="name">FIRST NAME</label>
                                        <input type="text" id="name" name="name" placeholder="Name"><br>
                                        <label for="surname">LAST NAME</label>
                                        <input type="text" id="lname" name="surname" placeholder="Last Name"><br>
                                        <label for="email">EMAIL</label>
                                        <input type="text" id="email" name="email" placeholder="Email"><br>
                                        <label for="password">PASSWORD</label>
                                        <input type="password" id="password" name="password" placeholder="Enter password"><br>
                                        <label for="repeatpassword">REPEAT PASSWORD</label>
                                        <input type="password" id="repeatpassword" name="repeatpassword" placeholder="Repeat password"><br>
                                        <input type="checkbox" name="checkbox" value="agree"> <a>SEND ME INFORMATION ABOUT NEW STUFF</a><br>
                                        <input id="isItChecked" type="checkbox" name="checkbox" value="rules">
                                        <a href="Rules.html">I AGREE WITH RULES </a> <br><br>
                                        
                                        <input type="submit" name="submit" value="SEND INFORMATION" />
                                                          
                                    </form>
                                     <?php 
                                    if($name!=null){
                                        echo ' name: '.$name.'<br> surname: '.$surname.'<br> email: '.$email.'<br> password: '.$password.' <br> repeatpassword: '.$repeatpassword;
                                    
                                    echo '<script type="text/javascript">','registration();','</script>';
                                        
                                    }
                                    
                                    ?>
                                    
                                </td>
                            </tr>
                        </table>



                        <div class="footer">
                            <table>
                                <tr>
                                    <td>
                                        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2306.443496081815!2d25.315243816118752!3d54.68422288028111!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x46dd942f73945d53%3A0x6f8e7c31a08fc73b!2sPeteli%C5%A1ki%C5%B3+g.+9%2C+Vilnius+01213!5e0!3m2!1slt!2slt!4v1490340716998" width="150" height="150" frameborder="2" style="border:2" allowfullscreen></iframe>
                                    </td>
                                    <td>
                                    </td>
                                    <td style="vertical-align: text-top;">
                                        <form class="contactinfo">
                                            <fieldset>
                                                <b>Peteliškių g. 9, <br> Tel.: +370 678 46035 <br> El. paštas: zaksauskas.justas@gmail.com <br> </b>
                                            </fieldset>
                                        </form>
                                    </td>
                                </tr>
                            </table>
                        </div>

    </body>

    </html>
