<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en" dir="ltr" xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Pavežk</title>
    <link rel="stylesheet" href="styl/layout.css" type="text/css">
    <link rel="stylesheet" href="styl/profile.css" type="text/css">
    <link rel="icon" href="img/favicon.ico" type="image/ico">
    <script src="js/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="js/jssor.slider-23.0.0.mini.js" type="text/javascript"></script>
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
    <div class="wrapper row2">
        <div id="container" class="clear">

            <!-- Slider -->
            <section id="slider" class="clear" ;>
                <figure>
                    <div id="im" style="width: 600 px; height: 300 px; background-color: white; float:left;">
                        <script type="text/javascript">
                            jQuery(document).ready(function($) {

                                var jssor_1_SlideshowTransitions = [{
                                        $Duration: 1200,
                                        x: -0.3,
                                        $During: {
                                            $Left: [0.3, 0.7]
                                        },
                                        $Easing: {
                                            $Left: $Jease$.$InCubic,
                                            $Opacity: $Jease$.$Linear
                                        },
                                        $Opacity: 2
                                    },
                                    {
                                        $Duration: 1200,
                                        x: 0.3,
                                        $SlideOut: true,
                                        $Easing: {
                                            $Left: $Jease$.$InCubic,
                                            $Opacity: $Jease$.$Linear
                                        },
                                        $Opacity: 2
                                    }
                                ];

                                var jssor_1_options = {
                                    $AutoPlay: 1,
                                    $SlideshowOptions: {
                                        $Class: $JssorSlideshowRunner$,
                                        $Transitions: jssor_1_SlideshowTransitions,
                                        $TransitionsOrder: 1
                                    },
                                    $ArrowNavigatorOptions: {
                                        $Class: $JssorArrowNavigator$
                                    },
                                    $BulletNavigatorOptions: {
                                        $Class: $JssorBulletNavigator$
                                    },
                                    $ThumbnailNavigatorOptions: {
                                        $Class: $JssorThumbnailNavigator$,
                                        $Cols: 1,
                                        $Align: 0,
                                        $NoDrag: true
                                    }
                                };

                                var jssor_1_slider = new $JssorSlider$("jssor_1", jssor_1_options);

                                /*responsive code begin*/
                                /*remove responsive code if you don't want the slider scales while window resizing*/
                                function ScaleSlider() {
                                    var refSize = jssor_1_slider.$Elmt.parentNode.clientWidth;
                                    if (refSize) {
                                        refSize = Math.min(refSize, 600);
                                        jssor_1_slider.$ScaleWidth(refSize);
                                    } else {
                                        window.setTimeout(ScaleSlider, 30);
                                    }
                                }
                                ScaleSlider();
                                $(window).bind("load", ScaleSlider);
                                $(window).bind("resize", ScaleSlider);
                                $(window).bind("orientationchange", ScaleSlider);
                                /*responsive code end*/
                            });

                        </script>
                        <style>
                            /* jssor slider bullet navigator skin 01 css */
                            /*
        .jssorb01 div           (normal)
        .jssorb01 div:hover     (normal mouseover)
        .jssorb01 .av           (active)
        .jssorb01 .av:hover     (active mouseover)
        .jssorb01 .dn           (mousedown)
        */
                            
                            .jssorb01 {
                                position: absolute;
                            }
                            
                            .jssorb01 div,
                            .jssorb01 div:hover,
                            .jssorb01 .av {
                                position: absolute;
                                /* size of bullet elment */
                                width: 12px;
                                height: 12px;
                                filter: alpha(opacity=70);
                                opacity: .7;
                                overflow: hidden;
                                cursor: pointer;
                                border: #000 1px solid;
                            }
                            
                            .jssorb01 div {
                                background-color: gray;
                            }
                            
                            .jssorb01 div:hover,
                            .jssorb01 .av:hover {
                                background-color: #d3d3d3;
                            }
                            
                            .jssorb01 .av {
                                background-color: #fff;
                            }
                            
                            .jssorb01 .dn,
                            .jssorb01 .dn:hover {
                                background-color: #555555;
                            }
                            /* jssor slider arrow navigator skin 05 css */
                            /*
        .jssora05l                  (normal)
        .jssora05r                  (normal)
        .jssora05l:hover            (normal mouseover)
        .jssora05r:hover            (normal mouseover)
        .jssora05l.jssora05ldn      (mousedown)
        .jssora05r.jssora05rdn      (mousedown)
        .jssora05l.jssora05lds      (disabled)
        .jssora05r.jssora05rds      (disabled)
        */
                            
                            .jssora05l,
                            .jssora05r {
                                display: block;
                                position: absolute;
                                /* size of arrow element */
                                width: 40px;
                                height: 40px;
                                cursor: pointer;
                                background: url('img/a17.png') no-repeat;
                                overflow: hidden;
                            }
                            
                            .jssora05l {
                                background-position: -10px -40px;
                            }
                            
                            .jssora05r {
                                background-position: -70px -40px;
                            }
                            
                            .jssora05l:hover {
                                background-position: -130px -40px;
                            }
                            
                            .jssora05r:hover {
                                background-position: -190px -40px;
                            }
                            
                            .jssora05l.jssora05ldn {
                                background-position: -250px -40px;
                            }
                            
                            .jssora05r.jssora05rdn {
                                background-position: -310px -40px;
                            }
                            
                            .jssora05l.jssora05lds {
                                background-position: -10px -40px;
                                opacity: .3;
                                pointer-events: none;
                            }
                            
                            .jssora05r.jssora05rds {
                                background-position: -70px -40px;
                                opacity: .3;
                                pointer-events: none;
                            }
                            /* jssor slider thumbnail navigator skin 09 css */
                            
                            .jssort09-600-45 .p {
                                position: absolute;
                                top: 0;
                                left: 0;
                                width: 600px;
                                height: 45px;
                            }
                            
                            .jssort09-600-45 .t {
                                font-family: verdana;
                                font-weight: normal;
                                position: absolute;
                                width: 100%;
                                height: 100%;
                                top: 0;
                                left: 0;
                                color: #fff;
                                line-height: 45px;
                                font-size: 20px;
                                padding-left: 10px;
                            }

                        </style>
                        <div id="jssor_1" style="position:relative;margin:0 auto;top:0px;left:0px;width:600px;height:280px;overflow:hidden;visibility:hidden;">
                            <!-- Loading Screen -->
                            <div data-u="loading" style="position:absolute;top:0px;left:0px;background-color:rgba(0,0,0,0.7);">
                                <div style="filter: alpha(opacity=70); opacity: 0.7; position: absolute; display: block; top: 0px; left: 0px; width: 100%; height: 100%;"></div>
                                <div style="position:absolute;display:block;background:url('img/loading.gif') no-repeat center center;top:0px;left:0px;width:100%;height:100%;"></div>
                            </div>
                            <div data-u="slides" style="cursor:default;position:relative;top:0px;left:0px;width:600px;height:280px;overflow:hidden;">
                                <div>
                                    <img data-u="image" src="img/dog.jpeg" />
                                    <div data-u="thumb">Drauge keliauti linksmiau !</div>
                                </div>
                                <div>
                                    <img data-u="image" src="img/porsche.jpeg" />
                                    <div data-u="thumb">Važiuojam kartu!</div>
                                </div>
                                <div>
                                    <img data-u="image" src="img/emis.jpg" />
                                    <div data-u="thumb"> Po visą Lietuvą!</div>
                                </div>
                                <div>
                                    <img data-u="image" src="img/road.jpg" />
                                    <div data-u="thumb">Prisijunk prie mūsų!</div>

                                </div>
                            </div>
                            <!-- Thumbnail Navigator -->
                            <div data-u="thumbnavigator" class="jssort09-600-45" style="position:absolute;bottom:0px;left:0px;width:600px;height:45px;">
                                <div style="position:absolute;top:0;left:0;width:100%;height:100%;background-color:#000;filter:alpha(opacity=40.0);opacity:0.4;"></div>
                                <!-- Thumbnail Item Skin Begin -->
                                <div data-u="slides" style="cursor: default;">
                                    <div data-u="prototype" class="p">
                                        <div data-u="thumbnailtemplate" class="t"></div>
                                    </div>
                                </div>
                                <!-- Thumbnail Item Skin End -->
                            </div>
                            <!-- Bullet Navigator -->
                            <div data-u="navigator" class="jssorb01" style="bottom:16px;right:16px;">
                                <div data-u="prototype" style="width:12px;height:12px;"></div>
                            </div>
                            <!-- Arrow Navigator -->
                            <span data-u="arrowleft" class="jssora05l" style="top:0px;left:8px;width:40px;height:40px;" data-autocenter="2"></span>
                            <span data-u="arrowright" class="jssora05r" style="top:0px;right:8px;width:40px;height:40px;" data-autocenter="2"></span>
                        </div>
                    </div>




                    <figcaption style="height:240px;">
                        <h2>Norite įkelti skelbimą?</h2>
                        <p><button onclick="document.getElementById('profile').style.display='block'" style="width:auto;">Registruotis</button></p><br>
                        <p>Maršruto ieškoti gali visi, o jei norite pakviesti prisijungti į savo kelionę, prašome susikurti vartotojo profilį. </p>
                    </figcaption>
                </figure>
            </section>
            <!-- Content -->

            <div id="homepage">
                <!-- ########################################################################################## -->
                <section class="clear">
                    <article class="two_third">
                        <h2>Ieškoti maršruto</h2>

                        <form action="search.php" method="GET">
                            <p>
                                <?php 
    $db = mysqli_connect("klevas.serveriai.lt","top10hel_root","VilniusCoding","top10hel_TWork"); 
    mysqli_query($db,"SET NAMES 'utf8'");
    $result = mysqli_query($db,"select City from cities");
    
    //echo '<form action="search.php" method="GET">';
    echo 'Iš: <select name="cityfrom">';
    echo '<option value="%">-Pasirinkite-</option>';
    if ($result->num_rows > 0) {
     
        while ($row = $result->fetch_assoc()) {
            echo '<option value="'.$row['City'].'">'.$row['City'].'</option>';
		
        }
    } else {
            $error = "nothing to display";
		echo ' '.$error;
	}
    echo '</select>';// Close your drop down box
    
    $result2 = mysqli_query($db,"select City from cities"); 
    echo 'Į: <select name="cityto">';
    echo '<option value="%">-Pasirinkite-</option>';
    if ($result2->num_rows > 0) {
     
        while ($row = $result2->fetch_assoc()) {
            echo '<option value="'.$row['City'].'">'.$row['City'].'</option>';
        }
    } else {
            $error2 = "nothing to display";
		echo ' '.$error2;
	}
    echo '</select>';// Close your drop down box
    
    echo 'Data: <input name="tripdate" type="text" id="datepicker">';
    
    echo '<input type="submit" value="Ieškoti" />';
        //echo '</form>';
    
?>
                            </p>
                        </form>
                    </article>

                    <article class="one_third lastbox">

                        <p>Užsiregistravę vartotojai gali įkelti siūlomą kelionės maršrutą</p>
                    </article>
                </section>
            </div>
        </div>
    </div>

    <div id="profile" class="modal">

        <form class="modal-content animate" method="post" action="reg.php" enctype="multipart/form-data">
            <div class="imgcontainer">
                <span onclick="document.getElementById('profile').style.display='none'" class="close" title="Close Modal">&times;</span>
                <img src="img/favicon.ico" alt="Avatar" class="avatar">
            </div>

            <div class="container">


                <table class="registrationTable">
                    <tr>
                        <td>
                            <label for="username">Vartotojo vardas</label>
                            <input type="text" id="username" name="username" placeholder="Vartotojo vardas"><br>
                            <label for="name">Vardas</label>
                            <input type="text" id="name" name="name" placeholder="Vardas"><br>
                            <label for="surname">Pavardė</label>
                            <input type="text" id="surname" name="surname" placeholder="Pavardė"><br>
                            <label for="email">El. paštas</label>
                            <input type="text" id="email" name="email" placeholder="El. paštas"><br>
                            <label for="password" required>Slaptažodis</label>
                            <input type="password" id="password" name="password" placeholder="Slaptažodis"><br>
                            <label for="repeatpassword" required>Pakartoti slaptažodį</label>
                            <input type="password" id="repeatpassword" name="repeatpassword" placeholder="Pakartoti slaptažodį"><br>
                            <label for="address">Adresas</label>
                            <input type="text" id="address" name="address" placeholder="Adresas"><br>
                            <label for="phonenumber">Telefonas</label>
                            <input type="text" id="phonenumber" name="phonenumber" placeholder="Telefonas"><br>
                            <label for="avatarIMG">Avataras</label>
                            <input type="file" id="avatarIMG" name="avatarIMG" accept="image/JPEG"><br>
                            <input id="isItChecked" type="checkbox" name="checkbox" value="rules">
                            <a href="rules.html" target="_blank">Sutinku su taisyklėmis</a> <br><br>
                            <input class="cancelbtn" type="submit" name="submit" value="Registruotis" />
                        </td>
                    </tr>
                </table>
            </div>
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
